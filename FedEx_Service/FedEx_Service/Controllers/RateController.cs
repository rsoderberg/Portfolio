using FedEx_Service.RateService_v28;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Web.Http;
using System.Web.Services.Protocols;

namespace FedEx_Service.Controllers
{
    public class RateController : ApiController
    {
        // 400 - BadRequest: "Don't know, don't care" response. Use when you've tried everything and still can't find what's wrong with the request
        // 404 - NotFound: Use when a find query returns null

        private bool IsProduction { get; set; }
        public string FedExUrl { get; set; }

        internal readonly NameValueCollection _appSettings = ConfigurationManager.AppSettings;

        // https://localhost:44352/api/Rate/GetShippingRate
        [HttpPost]
        public IHttpActionResult GetShippingRate([FromBody] Shipment shipment)
        {
            Logger logger = new Logger();

            // Note: When referencing FedEx API examples, use RateAvailableServiceWebServiceClient
            SetEnvironmentStatus();

            Request request = new Request();
            RateRequest rateRequest = request.CreateRateRequest(IsProduction, shipment);

            RateService service = new RateService();
            service.Url = SetServiceUrl(IsProduction);

            try
            {
                RateReply rateReply = service.getRates(rateRequest);

                if (rateReply.HighestSeverity == NotificationSeverityType.SUCCESS || rateReply.HighestSeverity == NotificationSeverityType.NOTE)
                {
                    Reply reply = new Reply();
                    reply.ShowRateReply(rateReply, shipment);
                }
                else
                {
                    Logger.LogNotifications(rateReply);
                    return BadRequest($"{rateReply.HighestSeverity} No Rates Returned");
                }
            }
            catch (SoapException ex)
            {
                logger.ExceptionOutput(ex.Detail.InnerText);
            }
            catch (Exception ex)
            {
                logger.ExceptionOutput(ex.Message);
            }

            return Ok(shipment.ShipRates);
        }

        private void SetEnvironmentStatus()
        {
            if (_appSettings["IsProduction"] == "TRUE")
                IsProduction = true;
            else
                IsProduction = false;
        }

        public string SetServiceUrl(bool isProduction)
        {
            FedExUrl = isProduction ? _appSettings["Production:FedExEndpoint"] : _appSettings["Development:FedExEndpoint"];

            return FedExUrl;
        }
    }
}