using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace RSoderbergAppAPI
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            AppDomain.CurrentDomain.SetData("DataDirectory", @"C:\Users\Rachel\Google Drive\CST356Repo\RachelSoderberg_Week9Lab\RachelSoderberg_Lab2\App_Data");
        }
    }
}
