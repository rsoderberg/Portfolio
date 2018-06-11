using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OITJP2016.Models
{
    public class UserModel
    {
        public int UserID { get; set; }
        public int GroupID { get; set; }
        public string GroupName { get; set; }
        public int EventID { get; set; }
        public string EventName { get; set; }
        public DateTime EventDate { get; set; }
        public double EventMaxGiftPrice { get; set; }
        public List<GiftModel> Gifts { get; set; }

        public UserModel()
        {
            Gifts = new List<GiftModel>();
        }
    }
}