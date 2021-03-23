using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace ASPCore_Session.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            var user = HttpContext.Session.GetString("sessionUser");
            var userinfo = JsonConvert.DeserializeObject<userInfo>(HttpContext.Session.GetString("sessionUser"));
            return View(userinfo);
        }
    }
}
