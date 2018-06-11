using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services;
using System.IO;
using SendGrid;
using SendGrid.Helpers.Mail;
using OITJP2016.Models;
using System.Threading.Tasks;

namespace OITJP2016.Controllers
{
    public class HomeController : Controller
    {
        [Authorize]
        public ActionResult Index(int? GroupData, int? EventData)
        {
            WhiteElephantDBDataContext dc = new WhiteElephantDBDataContext();
            try
            {
                int selectedGroup = GroupData ?? 0;
                List<usp_GetGroupUsersResult> groupUsers = new List<usp_GetGroupUsersResult>();
                List<usp_GetEventUsersResult> eventUsers = new List<usp_GetEventUsersResult>();
                List<usp_GetEventGiftsResult> eventGifts = new List<usp_GetEventGiftsResult>();
                usp_GetEventsResult eventItem = new usp_GetEventsResult();
                var groups = (from gr in dc.usp_GetGroups(GetUser().Id)
                              orderby gr.GroupName
                              select new SelectListItem
                              {
                                  Value = gr.GroupId.ToString(),
                                  Text = gr.GroupName,
                                  Selected = (gr.GroupId == selectedGroup) ? true : false
                              }).ToList();
                if (!groups.Any())
                {
                    groups.Add(new SelectListItem() { Value = "-1", Text = "No groups exist", Selected = true });
                }
                else
                {
                    SelectListItem sli = groups.Where(x => x.Selected == true).FirstOrDefault();
                    if (sli == null)
                    {
                        groups[0].Selected = true;
                        GroupData = Convert.ToInt32(groups[0].Value);
                        sli = groups[0];
                    }
                    groupUsers = dc.usp_GetGroupUsers(Convert.ToInt32(sli.Value)).ToList();
                    ViewBag.GroupUsers = groupUsers;
                }
                int selectedEvent = EventData ?? 0;
                string id = GetUser().Id;
                var eventItems = dc.usp_GetEvents(GroupData, id).ToList();
                var events = (from ev in eventItems
                              orderby ev.EventName
                              select new SelectListItem
                              {
                                  Value = ev.EventId.ToString(),
                                  Text = ev.EventName,
                                  Selected = (ev.EventId == selectedEvent) ? true : false
                              }).ToList();
                if (!events.Any())
                {
                    events.Add(new SelectListItem() { Value = "-1", Text = "No events exist", Selected = true });
                }
                else
                {
                    SelectListItem sli = events.Where(x => x.Selected == true).FirstOrDefault();
                    if (sli == null)
                    {
                        sli = events[0];
                        events[0].Selected = true;
                    }
                    eventUsers = dc.usp_GetEventUsers(Convert.ToInt32(sli.Value)).ToList();
                    eventGifts = dc.usp_GetEventGifts(Convert.ToInt32(sli.Value)).ToList();
                    eventItem = eventItems.FirstOrDefault(eventData => eventData.EventId == Convert.ToInt32(sli.Value));
                    var test = eventItem.MaxPrice;                   
                }


                ViewBag.EventData = eventItem;

                ViewBag.Groups = groups;
                ViewBag.Events = events;
                ViewBag.EventUsers = eventUsers;
                ViewBag.EventGifts = eventGifts;
                ViewBag.PossEventUsers = PossibleEventUsers(dc, groupUsers, eventUsers);
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                dc.Dispose();
            }
            return View();
        }

        [Authorize]
        public ActionResult GroupSubmit(int? GroupData, int? EventData)
        {
            return RedirectToAction("Index", "Home", new { GroupData = GroupData, EventData = EventData });
        }

        [Authorize]
        public ActionResult DeleteGroup(int IdToDelete)
        {
            if (IsGroupAdmin(IdToDelete))
            {
                WhiteElephantDBDataContext dc = new WhiteElephantDBDataContext();
                try
                {
                    var grp = dc.GroupTables.Where(x => x.GroupId == IdToDelete).FirstOrDefault();
                    if (grp != null)
                    {
                        dc.usp_DeleteGroup(grp.GroupId);
                    }
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    dc.Dispose();
                }
            }
            return RedirectToAction("Index", "Home");
        }

        [Authorize]
        public ActionResult DeleteGroupUser(int GroupId, string UserToDelete)
        {
            if (IsGroupAdmin(GroupId))
            {
                WhiteElephantDBDataContext dc = new WhiteElephantDBDataContext();
                try
                {
                    dc.usp_DeleteUserFromGroup(UserToDelete, GroupId);
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    dc.Dispose();
                }
            }
            return RedirectToAction("Index", "Home", new { GroupData = GroupId });
        }

        [Authorize]
        public ActionResult DeleteEventUser(int GroupId, int EventId, string UserToDelete)
        {
            if (IsEventAdmin(EventId))
            {
                WhiteElephantDBDataContext dc = new WhiteElephantDBDataContext();
                try
                {
                    dc.usp_DeleteUserFromEvent(UserToDelete, EventId);
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    dc.Dispose();
                }
            }
            return RedirectToAction("Index", "Home", new { GroupData = GroupId, EventData = EventId });
        }

        [Authorize]
        public ActionResult AddGroup(int? GroupData, string GroupName)
        {
            int groupId = GroupData ?? 0;
            if (GroupName != "")
            {
                WhiteElephantDBDataContext dc = new WhiteElephantDBDataContext();
                try
                {
                    groupId = dc.usp_AddNewGroup(GroupName, GetUser().Id);
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    dc.Dispose();
                }
            }
            return RedirectToAction("Index", "Home", new { GroupData = groupId });
        }

        [Authorize]
        public ActionResult AddEvent(int? GroupID, int? EventData, string EventName, string EventGiftPrice, DateTime EventDate)
        {
            int eventId = EventData ?? 0;
            if (EventName != "" && EventGiftPrice != "")
            {
                WhiteElephantDBDataContext dc = new WhiteElephantDBDataContext();
                try
                {
                    eventId = dc.usp_AddEvent(EventName, EventDate, Convert.ToDecimal(EventGiftPrice), GroupID, GetUser().Id);
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    dc.Dispose();
                }
            }
            return RedirectToAction("Index", "Home", new { GroupData = GroupID, EventData = eventId });
        }

        [Authorize]
        public ActionResult EditEvent(int? GroupID, int? EventID, string EventName, decimal? EventGiftPrice, DateTime EventDate )
        {
            if (EventID!= null && EventDate != null && EventName != "" && EventGiftPrice != null)
            {
                WhiteElephantDBDataContext dc = new WhiteElephantDBDataContext();
                try
                {
                    dc.usp_EditEvent(EventName, EventDate, EventGiftPrice, EventID);
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    dc.Dispose();
                }
            }
            return RedirectToAction("Index", "Home", new { GroupData = GroupID, EventData = EventID });
        }

        [Authorize]
         public ActionResult DeleteEvent(int IdToDelete)
         {
             if (IsEventAdmin(IdToDelete))
             {
                 WhiteElephantDBDataContext dc = new WhiteElephantDBDataContext();
                 try
                 {
                     var evt = dc.EventTables.Where(x => x.EventId == IdToDelete).FirstOrDefault();
                     if (evt != null)
                     {
                         dc.usp_DeleteEvent(evt.EventId);
                     }
                 }
                 catch (Exception)
                 {
                     throw;
                 }
                 finally
                 {
                     dc.Dispose();
                 }
            }
             return RedirectToAction("Index", "Home");
         }

        [Authorize]
        public ActionResult AddGroupAdmin(string Email, string Status, int GroupId)
        {
            if (IsGroupAdmin(GroupId))
            {
                WhiteElephantDBDataContext dc = new WhiteElephantDBDataContext();
                try
                {
                    dc.usp_AddUserToGroup(Email, GroupId, Status);
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    dc.Dispose();
                }
            }
            return RedirectToAction("Index", "Home", new { GroupData = GroupId });
        }
        [Authorize]
        public ActionResult AddEventAdmin(string Email, string Status, int GroupId, int EventId)
        {
            if (IsEventAdmin(EventId))
            {
                WhiteElephantDBDataContext dc = new WhiteElephantDBDataContext();
                try
                {
                    dc.usp_AddUserToEvent(Email, EventId, Status);
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    dc.Dispose();
                }
            }
            return RedirectToAction("Index", "Home", new { GroupData = GroupId, EventData = EventId });
        }
        [Authorize]
        public async Task<ActionResult> AddUserToGroup(string Email, string Status, int GroupId)
        {

            if (IsGroupAdmin(GroupId))
            {
                WhiteElephantDBDataContext dc = new WhiteElephantDBDataContext();
                try
                {
                    dc.usp_AddUserToGroup(Email, GroupId, Status);

                    string messageBody = System.IO.File.ReadAllText(Server.MapPath("~/Static/GroupAddEmail.html"));
                    await SendEmail(Email, "A group invite", messageBody);
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    dc.Dispose();
                }
            }

            return RedirectToAction("Index", "Home", new { GroupData = GroupId });
        }


        [Authorize]
        public ActionResult AddUserToEvent(string Email, string Status, int GroupId, int EventId)
        {
            if (IsEventAdmin(EventId))
            {
                WhiteElephantDBDataContext dc = new WhiteElephantDBDataContext();
                try
                {
                    dc.usp_AddUserToEvent(Email, EventId, Status);
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    dc.Dispose();
                }
            }
            return RedirectToAction("Index", "Home", new { GroupData = GroupId, EventData = EventId });
        }

        /*
         * AddGiftToEvent: Method for user to add gift to event
         * Author: Patrick J Carlson
         */
        [Authorize]
        public ActionResult AddGiftToEvent(int GroupID, int EventID, int? GiftData, string GiftTitle, string GiftDescription, string GiftPrice, string GiftURL)
        {
            int giftId = GiftData ?? 0;
            WhiteElephantDBDataContext dc = new WhiteElephantDBDataContext();

            // Convert price to decimal and round to 2 places
            var GiftDecPrice = Convert.ToDecimal(GiftPrice);    

            decimal.Round(GiftDecPrice, 2, MidpointRounding.AwayFromZero);   
            
            try
            {
                giftId = dc.usp_AddGiftToEvent(GetUser().Id, EventID, GiftTitle, GiftDescription, GiftDecPrice, GiftURL);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                dc.Dispose();
            }
            return RedirectToAction("Index", "Home", new { GroupData = GroupID, EventData = EventID }); 
        }

        [Authorize]
        public ActionResult EditGift(int GroupID, int EventID, int? GiftId, string GiftTitle, string GiftDescription, decimal? GiftPrice, string GiftURL)
        {
            if (GiftId != null && GiftTitle.Trim() != "" && GiftPrice != null)
            {
                WhiteElephantDBDataContext dc = new WhiteElephantDBDataContext();
                GiftPrice = decimal.Round((decimal)GiftPrice, 2, MidpointRounding.AwayFromZero);

                try
                {
                    dc.usp_EditGift(GiftId, GiftTitle, GiftDescription, GiftPrice, GiftURL);
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    dc.Dispose();
                }
            }
            return RedirectToAction("Index", "Home", new { GroupData = GroupID, EventData = EventID });
        }

        [Authorize]
        public ActionResult SetGiftClaim(int GiftID, int EventID, int GroupID)
        {
          
            WhiteElephantDBDataContext dc = new WhiteElephantDBDataContext();

            try
            {
                dc.usp_SetGiftClaimStatus(GiftID, GetUser().Id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                dc.Dispose();
            }


            return RedirectToAction("Index", "Home", new { GroupData = GroupID, EventData = EventID });
        }

        [Authorize]
        public ActionResult DeleteGift(int GiftID, int EventID, int GroupID)
        {
            WhiteElephantDBDataContext dc = new WhiteElephantDBDataContext();

            try
            {
                dc.usp_DeleteGiftFromEvent(GiftID);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                dc.Dispose();
            }

            return RedirectToAction("Index", "Home", new { GroupData = GroupID, EventData = EventID });
        }
 //           
        public ActionResult About()
        {
            //ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        private List<SelectListItem> PossibleEventUsers(WhiteElephantDBDataContext DC, List<usp_GetGroupUsersResult> GroupUsers, List<usp_GetEventUsersResult> EventUsers)
        {
            List<SelectListItem> possEventUsers = new List<SelectListItem>();
            if (!EventUsers.Any())
            {
                possEventUsers.Add(new SelectListItem { Value = "-1", Text = "No events exist" });
            }
            else
            {
                List<usp_GetGroupUsersResult> possEventUserList = GroupUsers.Where(x => !EventUsers.Any(y => y.Email == x.Email) && x.Email != null).ToList();
                if (!possEventUserList.Any())
                {
                    possEventUsers.Add(new SelectListItem { Value = "-1", Text = "All group members are in the event" });
                }
                else
                {
                    foreach (usp_GetGroupUsersResult user in possEventUserList)
                    {
                        possEventUsers.Add(new SelectListItem { Value = user.Email, Text = user.UserName });
                    }
                }
            }
            return possEventUsers;
        }

        private bool IsGroupAdmin(int GroupId)
        {
            var userEmail = GetUser().Email;
            bool isUser = false;
            WhiteElephantDBDataContext dc = new WhiteElephantDBDataContext();
            try
            {
                usp_IsGroupAdminResult status = dc.usp_IsGroupAdmin(GroupId, userEmail).FirstOrDefault();
                if (status != null && status.Status == "Admin")
                {
                    isUser = true;
                }
                return isUser;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                dc.Dispose();
            }
        }

        private bool IsEventAdmin(int EventId)
        {
            var userEmail = GetUser().Email;
            bool isUser = false;
            WhiteElephantDBDataContext dc = new WhiteElephantDBDataContext();
            try
            {
                usp_IsEventAdminResult status = dc.usp_IsEventAdmin(EventId, userEmail).FirstOrDefault();
                if (status != null && status.Status == "Admin")
                {
                    isUser = true;
                }
                return isUser;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                dc.Dispose();
            }
        }

        private AspNetUser GetUser()
        {
            AspNetUser user = null;
            WhiteElephantDBDataContext dc = new WhiteElephantDBDataContext();
            try
            {
                user = dc.AspNetUsers.Where(x => x.UserName == HttpContext.User.Identity.Name).FirstOrDefault();
                if (user == null)
                {
                    throw new Exception(String.Format("User {0} not found in the database.", HttpContext.User.Identity.Name));
                }
            }
            catch (Exception x)
            {
                throw;
            }
            finally
            {
                dc.Dispose();
            }
            return user;
        }

        /*
         * SendEmail: Utilizes SendGrid to send email. Requires an address to send to
         *              a subject line, and a message. 
         * 
         * In process of being redacted. Remove if no longer called.(PJC: 02/14/2017)
         * 
         * Author: Patrick J Carlson
         */
        public static async Task SendEmail(String toAddress, String toSubject, String toMessage) //Opportunity to add name to email, name would be stored in db
        {
            var client = new SendGridClient("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");
            var SGmessage = new SendGridMessage();

            SGmessage.From = new EmailAddress("oitjp2016@outlook.com", "White Elephant Gift Exchange");
            SGmessage.AddTo(new EmailAddress(toAddress));
            SGmessage.Subject = toSubject;
            SGmessage.HtmlContent = toMessage;
            try
            {
                var response = await client.SendEmailAsync(SGmessage);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error in application " + ex);
            }

            await Task.FromResult(0);
        }
    }
}