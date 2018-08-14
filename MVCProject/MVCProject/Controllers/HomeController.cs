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
        public ActionResult Quote(string firstName, string lastName, string emailAddress, DateTime dateOfBirth, int carModelYear, string carMake, string carModel, int speedingTickets, string duiCheck, string coverageType)
        {

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {

                            int age;
                            int total = 50;

                     
                            age = DateTime.Now.Year - dateOfBirth.Year;
                            if (DateTime.Now.Month < dateOfBirth.Month || (DateTime.Now.Month == dateOfBirth.Month && DateTime.Now.Day < dateOfBirth.Day))
                                age--;

                            if (carModelYear > 2015) total += 25;
                            if (carModelYear < 2000) total += 25;

                            if (age > 100) total += 100;
                            if (age < 25) total += 25;
                            if (age < 18) total += 75;  // Already adds $25 from being under 25yrs old - added another 75 to equal $100

                            if (carMake == "Porsche") total += 25;
                            if (carMake == "Porsche" && carModel == "911 Carrera") total += 25;

                            if (speedingTickets > 0) total += (speedingTickets * 10);

                            if (duiCheck == "True") total += (total / 4);

                            if (coverageType == "True") total += (total / 2);



                using (InsuranceEntities2 db = new InsuranceEntities2())
                        {
                    
                            var carquote = new Quote();
                            carquote.Total = total;
                            carquote.FirstName = firstName;
                            carquote.LastName = lastName;
                            carquote.EmailAddress = emailAddress;
                            carquote.DateOfBirth = dateOfBirth;
                            carquote.CarModelYear = carModelYear;
                            carquote.CarMake = carMake;
                            carquote.CarModel = carModel;
                            carquote.SpeedingTickets = speedingTickets;
                            carquote.DUICheck = duiCheck;
                            carquote.CoverageType = coverageType;
                            db.Quotes.Add(carquote);
                            db.SaveChanges();

                    int yourQuote = carquote.Total;

                    
                    return RedirectToAction(Success(firstName, lastName, emailAddress, total));
                    //Please help, why doesn't this work??? I've tried just return result(Success()); and a number of other things, like making a viewmodel, but nothing seems to work

                }



            }

        }


        public ActionResult Success(string firstName, string lastName, string emailAddress, int total)
        {



            ViewBag.FirstName = firstName;
            ViewBag.LastName = lastName;
            ViewBag.Email = emailAddress;
            ViewBag.Total = total;
            return View();


        }
    }
}