using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JayStudyGroupProfiles.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult List()
        {
            List<Models.PersonModel> members = new List<Models.PersonModel>();

            members.Add(new Models.PersonModel { stuNum = "u20467207", fName = "Raelene", lName = "Dookkoo", email = "raelene.d@tuks.co.za", myLink = "../HTML/raePage.html"});
            members.Add(new Models.PersonModel { stuNum = "u23854830", fName = "Dakalo", lName = "Nemamilwe", email = "u23854830@tuks.co.za", myLink = "../HTML/duckyPage.html" });
            members.Add(new Models.PersonModel { stuNum = "u23959094", fName = "Jessica", lName = "Turner", email = "u23959094@tuks.co.za", myLink = "../HTML/jessPage.html" });
            members.Add(new Models.PersonModel { stuNum = "u22500333", fName = "Jay", lName = "Mashele", email = "njl.mashele@tuks.co.za", myLink = "../HTML/jayPage.html" });
            members.Add(new Models.PersonModel { stuNum = "u24596385", fName = "Ryan", lName = "van Wyk", email = "r.vanwyk@tuks.co.za", myLink = "../HTML/ryanPage.html" });

            return View(members);
        }
    }
}