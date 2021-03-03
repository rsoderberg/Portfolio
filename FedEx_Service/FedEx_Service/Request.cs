using FedEx_Service.RateService_v28;
using System;

namespace FedEx_Service
{
    public class Request
    {
        public RateRequest CreateRateRequest(bool isProduction, Shipment shipment)
        {
            RequestDetails requestDetails = new RequestDetails();
            requestDetails.SetRequestDetails(isProduction, shipment);

            RateRequest request = new RateRequest();
            request.WebAuthenticationDetail = new WebAuthenticationDetail();
            request.WebAuthenticationDetail.UserCredential = new WebAuthenticationCredential();
            request.WebAuthenticationDetail.UserCredential.Key = requestDetails.FedExKey;
            request.WebAuthenticationDetail.UserCredential.Password = requestDetails.FedExPassword;
            request.WebAuthenticationDetail.ParentCredential = new WebAuthenticationCredential();
            request.WebAuthenticationDetail.ParentCredential.Key = requestDetails.FedExKey;
            request.WebAuthenticationDetail.ParentCredential.Password = requestDetails.FedExPassword;

            request.ClientDetail = new ClientDetail();
            request.ClientDetail.AccountNumber = requestDetails.FedExAccountNumber; // Client's account number
            request.ClientDetail.MeterNumber = requestDetails.FedExMeterNumber; // Client's meter number

            request.TransactionDetail = new TransactionDetail();
            request.TransactionDetail.CustomerTransactionId = "***Rate Available Services Request using VC#***"; // This is a reference field for the customer.  Any value can be used and will be provided in the response.

            request.Version = new VersionId();

            request.ReturnTransitAndCommit = true;
            request.ReturnTransitAndCommitSpecified = true;

            SetShipmentDetails(request, requestDetails, shipment);

            return request;
        }

        private void SetShipmentDetails(RateRequest request, RequestDetails requestDetails, Shipment shipment)
        {
            request.RequestedShipment = new RequestedShipment();
            request.RequestedShipment.ShipTimestamp = DateTime.Now; // Shipping date and time
            request.RequestedShipment.ShipTimestampSpecified = true;
            request.RequestedShipment.DropoffType = DropoffType.REGULAR_PICKUP; //Drop off types are BUSINESS_SERVICE_CENTER, DROP_BOX, REGULAR_PICKUP, REQUEST_COURIER, STATION
            request.RequestedShipment.PackagingType = "YOUR_PACKAGING"; // Packaging type FEDEX_BOX, FEDEX_PAK, FEDEX_TUBE, YOUR_PACKAGING, ...
            //  request.RequestedShipment.PackagingTypeSpecified = true;

            SetOrigin(request, requestDetails);
            SetDestination(request, requestDetails);

            SetPackageLineItems(request, shipment);

            request.RequestedShipment.PackageCount = "1";
        }

        private void SetOrigin(RateRequest request, RequestDetails requestDetails)
        {
            request.RequestedShipment.Shipper = new Party();
            request.RequestedShipment.Shipper.Address = new Address();
            request.RequestedShipment.Shipper.Address.StreetLines = new string[2] { $"{requestDetails.ShipperAddressLine1}", $"{requestDetails.ShipperAddressLine2}" };
            request.RequestedShipment.Shipper.Address.City = $"{requestDetails.ShipperCity}";
            request.RequestedShipment.Shipper.Address.StateOrProvinceCode = $"{requestDetails.ShipperState}";
            request.RequestedShipment.Shipper.Address.PostalCode = $"{requestDetails.ShipperZip}";
            request.RequestedShipment.Shipper.Address.CountryCode = $"{requestDetails.ShipperCountry}";
        }

        private void SetDestination(RateRequest request, RequestDetails requestDetails)
        {
            request.RequestedShipment.Recipient = new Party();
            request.RequestedShipment.Recipient.Address = new Address();
            request.RequestedShipment.Recipient.Address.StreetLines = new string[2] { $"{requestDetails.BillToAddressLine1}", $"{requestDetails.BillToAddressLine2}" };
            request.RequestedShipment.Recipient.Address.City = $"{requestDetails.BillToCity}";
            request.RequestedShipment.Recipient.Address.StateOrProvinceCode = $"{requestDetails.BillToState}";
            request.RequestedShipment.Recipient.Address.PostalCode = $"{requestDetails.BillToZip}";
            request.RequestedShipment.Recipient.Address.CountryCode = $"{requestDetails.BillToCountry}";
        }

        private void SetPackageLineItems(RateRequest request, Shipment shipment)
        {
            request.RequestedShipment.RequestedPackageLineItems = new RequestedPackageLineItem[1];
            request.RequestedShipment.RequestedPackageLineItems[0] = new RequestedPackageLineItem();
            request.RequestedShipment.RequestedPackageLineItems[0].SequenceNumber = "1";
            request.RequestedShipment.RequestedPackageLineItems[0].GroupPackageCount = "1";
            // Package weight
            request.RequestedShipment.RequestedPackageLineItems[0].Weight = new Weight();
            request.RequestedShipment.RequestedPackageLineItems[0].Weight.Units = WeightUnits.LB;
            request.RequestedShipment.RequestedPackageLineItems[0].Weight.UnitsSpecified = true;
            request.RequestedShipment.RequestedPackageLineItems[0].Weight.Value = Convert.ToDecimal(shipment.Weight);
            request.RequestedShipment.RequestedPackageLineItems[0].Weight.ValueSpecified = true;
            // Package dimensions
            request.RequestedShipment.RequestedPackageLineItems[0].Dimensions = new Dimensions();
            request.RequestedShipment.RequestedPackageLineItems[0].Dimensions.Length = shipment.Length;
            request.RequestedShipment.RequestedPackageLineItems[0].Dimensions.Width = shipment.Width;
            request.RequestedShipment.RequestedPackageLineItems[0].Dimensions.Height = shipment.Height;
            request.RequestedShipment.RequestedPackageLineItems[0].Dimensions.Units = LinearUnits.IN;
            request.RequestedShipment.RequestedPackageLineItems[0].Dimensions.UnitsSpecified = true;
        }
    }
}