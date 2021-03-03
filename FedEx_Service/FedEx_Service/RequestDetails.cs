using System;
using System.Collections.Specialized;
using System.Configuration;

namespace FedEx_Service
{
    public class RequestDetails
    {
        public string FedExKey { get; set; }
        public string FedExPassword { get; set; }
        public string FedExAccountNumber { get; set; }
        public string FedExMeterNumber { get; set; }

        public string ShipperFreightAccountNumber { get; set; }
        public string ShipperAddressLine1 { get; set; }
        public string ShipperAddressLine2 { get; set; }
        public string ShipperCity { get; set; }
        public string ShipperState { get; set; }
        public string ShipperZip { get; set; }
        public string ShipperCountry { get; set; }

        public string BillToAccountNumber { get; set; }
        public string BillToAddressLine1 { get; set; }
        public string BillToAddressLine2 { get; set; }
        public string BillToCity { get; set; }
        public string BillToState { get; set; }
        public string BillToZip { get; set; }
        public string BillToCountry { get; set; }

        internal readonly NameValueCollection _appSettings = ConfigurationManager.AppSettings;

        public void SetRequestDetails(bool isProduction, Shipment shipment)
        {
            if (isProduction)
            {
                FedExKey = _appSettings["Production:FedExKey"];
                FedExPassword = _appSettings["Production:FedExPassword"];
                FedExAccountNumber = _appSettings["Production:FedExAccoutNumber"];
                FedExMeterNumber = _appSettings["Production:FedExMeterNumber"];

                ShipperAddressLine1 = _appSettings["Production:ShipperAddressLine1"];
                ShipperAddressLine2 = _appSettings["Production:ShipperAddressLine2"];
                ShipperCity = _appSettings["Production:ShipperCity"];
                ShipperState = _appSettings["Production:ShipperState"];
                ShipperZip = _appSettings["Production:ShipperZip"];
                ShipperCountry = _appSettings["Production:ShipperCountry"];

                if (shipment.Address != null)
                {
                    BillToAddressLine1 = shipment.Address.AddressLine1;
                    BillToAddressLine2 = shipment.Address.AddressLine2;
                    BillToCity = shipment.Address.City;
                    BillToState = shipment.Address.State;
                    BillToZip = shipment.Address.Zip;

                    if (shipment.Address.Country.Length > 2)
                        BillToCountry = shipment.Address.ConvertThreeLetterCountryCodeToTwoLetters(shipment.Address.Country);
                    else
                        BillToCountry = shipment.Address.Country;
                }
                else
                {
                    // Use test bill to address when an address isn't passed in, allowing
                    // for a valid (but not necessarily accurate) rate being returned
                    // instead of returning nothing.
                    BillToAddressLine1 = _appSettings["Development:BillToAddressLine1"];
                    BillToAddressLine2 = _appSettings["Development:BillToAddressLine2"];
                    BillToCity = _appSettings["Development:BillToCity"];
                    BillToState = _appSettings["Development:BillToState"];
                    BillToZip = _appSettings["Development:BillToZip"];
                    BillToCountry = _appSettings["Development:BillToCountry"];
                }
            }
            else
            {
                FedExKey = _appSettings["Development:FedExKey"];
                FedExPassword = _appSettings["Development:FedExPassword"];
                FedExAccountNumber = _appSettings["Development:FedExAccoutNumber"];
                FedExMeterNumber = _appSettings["Development:FedExMeterNumber"];

                ShipperFreightAccountNumber = _appSettings["Development:ShipperFreightAccountNumber"];
                ShipperAddressLine1 = _appSettings["Development:ShipperAddressLine1"];
                ShipperAddressLine2 = _appSettings["Development:ShipperAddressLine2"];
                ShipperCity = _appSettings["Development:ShipperCity"];
                ShipperState = _appSettings["Development:ShipperState"];
                ShipperZip = _appSettings["Development:ShipperZip"];
                ShipperCountry = _appSettings["Development:ShipperCountry"];

                BillToAccountNumber = _appSettings["Development:BillToAccountNumber"];
                BillToAddressLine1 = _appSettings["Development:BillToAddressLine1"];
                BillToAddressLine2 = _appSettings["Development:BillToAddressLine2"];
                BillToCity = _appSettings["Development:BillToCity"];
                BillToState = _appSettings["Development:BillToState"];
                BillToZip = _appSettings["Development:BillToZip"];
                BillToCountry = _appSettings["Development:BillToCountry"];
            }
        }
    }
}