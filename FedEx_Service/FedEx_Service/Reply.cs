using FedEx_Service.RateService_v28;
using System;

namespace FedEx_Service
{
    public class Reply
    {
        string ServiceType { get; set; }
        decimal TotalNetCharge { get; set; }

        public void ShowRateReply(RateReply reply, Shipment shipment)
        {
            Logger logger = new Logger();

            string rateReplyLog = "RateReply details: ";
            for (int i = 0; i < reply.RateReplyDetails.Length; i++)
            {
                RateReplyDetail rateReplyDetail = reply.RateReplyDetails[i];
                rateReplyLog += $"Rate Reply Detail for Service {i + 1}: ";

                ServiceType = rateReplyDetail.ServiceType;
                rateReplyLog += $"ServiceType: {ServiceType}, ";
                rateReplyLog += $"ServiceType: {rateReplyDetail.PackagingType} // ";

                for (int j = 0; j < rateReplyDetail.RatedShipmentDetails.Length; j++)
                {
                    RatedShipmentDetail shipmentDetail = rateReplyDetail.RatedShipmentDetails[j];
                    rateReplyLog += $"---Rated Shipment Detail for Rate Type {j + 1}---";

                    logger.LogValue(rateReplyLog);

                    ShowShipmentRateDetails(shipmentDetail, shipment);
                    ShowPackageRateDetails(shipmentDetail.RatedPackages);
                }
                ShowDeliveryDetails(rateReplyDetail);
            }
        }

        private void ShowShipmentRateDetails(RatedShipmentDetail shipmentDetail, Shipment shipment)
        {
            Logger logger = new Logger();

            if (shipmentDetail == null) return;
            if (shipmentDetail.ShipmentRateDetail == null) return;
            ShipmentRateDetail shipRateDetail = shipmentDetail.ShipmentRateDetail;
            string shipDetailLog = "Shipment Rate Detail: ";
            
            shipDetailLog += $"RateType: {shipRateDetail.RateType}, ";
            if (shipRateDetail.TotalBillingWeight != null)
                shipDetailLog += $"Total Billing Weight: {shipRateDetail.TotalBillingWeight.Value} {shipmentDetail.ShipmentRateDetail.TotalBillingWeight.Units} // ";
            if (shipRateDetail.TotalBaseCharge != null)
                shipDetailLog += $"Total Base Charge: {shipRateDetail.TotalBaseCharge.Amount} {shipRateDetail.TotalBaseCharge.Currency} // ";
            if (shipRateDetail.TotalFreightDiscounts != null)
                shipDetailLog += $"Total Freight Discounts: {shipRateDetail.TotalFreightDiscounts.Amount} {shipRateDetail.TotalFreightDiscounts.Currency} // ";
            if (shipRateDetail.TotalSurcharges != null)
                shipDetailLog += $"Total Surcharges: {shipRateDetail.TotalSurcharges.Amount} {shipRateDetail.TotalSurcharges.Currency} // ";
            if (shipRateDetail.Surcharges != null)
            {
                // Individual surcharge for each package
                foreach (Surcharge surcharge in shipRateDetail.Surcharges)
                    shipDetailLog += $" {surcharge.SurchargeType} surcharge {surcharge.Amount.Amount} {surcharge.Amount.Currency} // ";
            }
            if (shipRateDetail.TotalNetCharge != null)
            {
                TotalNetCharge = shipRateDetail.TotalNetCharge.Amount;
                shipDetailLog += $"Total Net Charge: {TotalNetCharge} {shipRateDetail.TotalNetCharge.Currency}";

                shipment.ShipRates.Add(ServiceType, Convert.ToInt32(TotalNetCharge));
            }

            logger.LogValue(shipDetailLog);
        }

        private static void ShowPackageRateDetails(RatedPackageDetail[] ratedPackages)
        {
            Logger logger = new Logger();

            if (ratedPackages == null) return;
            string packageRateLog = "Rated Package Detail: ";
            for (int i = 0; i < ratedPackages.Length; i++)
            {
                RatedPackageDetail ratedPackage = ratedPackages[i];
                packageRateLog += $"Package {i + 1}: ";
                if (ratedPackage.PackageRateDetail != null)
                {
                    packageRateLog += $"Billing weight {ratedPackage.PackageRateDetail.BillingWeight.Value} {ratedPackage.PackageRateDetail.BillingWeight.Units} // ";
                    packageRateLog += $"Base charge {ratedPackage.PackageRateDetail.BaseCharge.Amount} {ratedPackage.PackageRateDetail.BaseCharge.Currency} // ";
                    if (ratedPackage.PackageRateDetail.TotalSurcharges != null)
                        packageRateLog += $"Total Surcharges: {ratedPackage.PackageRateDetail.TotalSurcharges.Amount} {ratedPackage.PackageRateDetail.TotalSurcharges.Currency} // ";
                    if (ratedPackage.PackageRateDetail.Surcharges != null)
                    {
                        foreach (Surcharge surcharge in ratedPackage.PackageRateDetail.Surcharges)
                        {
                            packageRateLog += $"{surcharge.SurchargeType} surcharge {surcharge.Amount.Amount} {surcharge.Amount.Currency} // ";
                        }
                    }
                    packageRateLog += $"Net charge {ratedPackage.PackageRateDetail.NetCharge.Amount} {ratedPackage.PackageRateDetail.NetCharge.Currency} --- ";
                }
            }

            logger.LogValue(packageRateLog);
        }

        private static void ShowDeliveryDetails(RateReplyDetail rateReplyDetail)
        {
            Logger logger = new Logger();

            string deliveryLog = "";
            if (rateReplyDetail.DeliveryTimestampSpecified)
                deliveryLog = $"Delivery timestamp: {rateReplyDetail.DeliveryTimestamp.ToString()}";
            if (rateReplyDetail.TransitTimeSpecified)
                deliveryLog += $"Transit time: {rateReplyDetail.TransitTime}";

            logger.LogValue(deliveryLog);
        }
    }
}