using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiProject.Models;

namespace WebApiProject.Controllers.Api
{
    public class SnapshotController : ApiController
    {
        public snapshot get_snapshot()
        {
            snapshot s = new snapshot();
            s.nid = 1787;
            s.uuid = "18ede399-b6a2-4cc4-b0b6-021041a82ad5";
            s.vid = 1787;
            s.type = "snapshot";

            return s;
        }
    }
}
