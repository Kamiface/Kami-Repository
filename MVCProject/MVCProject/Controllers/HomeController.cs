using MVCProject.Models;
using MVCProject.ViewModels;
using System;
using System.Web.Mvc;

namespace MVCProject.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
            
        }


        [HttpPost]
        public ActionResult Quote(string FirstName, string LastName, string EmailAddress, DateTime DateOfBirth, int CarModelYear, string CarMake, string CarModel, int SpeedingTickets, string DUICheck, string CoverageType)
        {

            if (string.IsNullOrEmpty(FirstName) || string.IsNullOrEmpty(LastName) || string.IsNullOrEmpty(EmailAddress))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            
            
                QuoteLogic quoteLogic = new QuoteLogic(FirstName, LastName, EmailAddress, DateOfBirth, CarModelYear, CarMake, CarModel, SpeedingTickets, DUICheck, CoverageType);
                quoteLogic.DBLogic(FirstName, LastName, EmailAddress, DateOfBirth, CarModelYear, CarMake, CarModel, SpeedingTickets, DUICheck, CoverageType);

                

                

            return Success(FirstName, LastName, quoteLogic.Total);

        }


        public ActionResult Success(string FirstName, string LastName, int Total)
        {

            
            ViewBag.fName = FirstName;
            ViewBag.lName = LastName;
            ViewBag.total = Total;

            return View("Success");                       


        }






    }



    
}