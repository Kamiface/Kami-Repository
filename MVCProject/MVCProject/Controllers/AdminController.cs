using MVCProject.Models;
using MVCProject.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace MVCProject.Controllers
{
    public class AdminController : Controller
    {
       
        public ActionResult Index()
        {

            
            using (InsuranceEntities2 db = new InsuranceEntities2())
            {
                var quotes = db.Quotes;
                var quoteVms = new List<QuoteVm>();
                foreach (var vquote in quotes)
                {
                    var quoteVm = new QuoteVm();
                    quoteVm.Id = vquote.Id;
                    quoteVm.Total = vquote.Total;
                    quoteVm.FirstName = vquote.FirstName;
                    quoteVm.LastName = vquote.LastName;
                    quoteVm.EmailAddress = vquote.EmailAddress;
                    quoteVms.Add(quoteVm);
                }


                return View(quoteVms);
            }
        }

    }
}