﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OrgPortalServer.Controllers
{
  public class OrgPortalController : ApiController
  {
    // GET api/orgportal
    public IEnumerable<string> Get()
    {
      return new string[] { "Marimer LLC", "http://www.lhotka.net" };
    }
  }
}
