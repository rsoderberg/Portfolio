using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OITJP2016.Models
{
    public class GiftModel
    {
        public int GiftID { get; set; }
        public string GiftName { get; set; }
        public double GiftPrice { get; set; }
        public int GiftOwnerUserID { get; set; }
        public int GiftPurchaserUserID { get; set; }
    }
}