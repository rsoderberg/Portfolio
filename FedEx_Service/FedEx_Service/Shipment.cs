using System.Collections.Generic;
using System.Globalization;

namespace FedEx_Service
{
    public class Shipment
    {
        public string Weight { get; set; }
        public string Length { get; set; }
        public string Width { get; set; }
        public string Height { get; set; }

        public Dictionary<string, int> ShipRates = new Dictionary<string, int>();
        public BillToAddress Address { get; set; }
    }

    public class BillToAddress
    {
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }

        public string ConvertThreeLetterCountryCodeToTwoLetters(string countryCode)
        {
            if (countryCode.Length != 3)
            {
                return "";
            }

            countryCode = countryCode.ToUpper();

            CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
            foreach (CultureInfo culture in cultures)
            {
                RegionInfo region = new RegionInfo(culture.LCID);
                if (region.ThreeLetterISORegionName.ToUpper() == countryCode)
                {
                    return region.TwoLetterISORegionName;
                }
            }

            return "";
        }
    }
}