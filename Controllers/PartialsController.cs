﻿using Neighborly.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Neighborly.Controllers
{
    [ChildActionOnly]
    public class PartialsController : Controller
    {
        public ActionResult Navigation()
        {
           


            return PartialView("_Navigation");
        }


       

        private string getConnString()
        {
            string connString = "Server = tcp:xxxx.database.windows.net,1433; Initial Catalog = Clients; Persist Security Info = False; User ID = xxx; Password = xxx; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = True; Connection Timeout = 30";
            return connString;
        }
    }
}