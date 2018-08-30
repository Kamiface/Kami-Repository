using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCProject.Models
{
    public class QuoteLogic : Quote
    {
        Quote carquote = new Quote();
        public int age;
        
        public QuoteLogic(string FirstName, string LastName, string EmailAddress, DateTime DateOfBirth, int CarModelYear, string CarMake, string CarModel, int SpeedingTickets, string DUICheck, string CoverageType)
        {
            
            age = DateTime.Now.Year - DateOfBirth.Year;
            if (DateTime.Now.Month < DateOfBirth.Month || (DateTime.Now.Month == DateOfBirth.Month && DateTime.Now.Day < DateOfBirth.Day))

                age--;
            Total = 50;
            if (CarModelYear > 2015) Total += 25;
            if (CarModelYear < 2000) Total += 25;
            if (age > 100) Total += 100;
            if (age < 25) Total += 25;
            if (age < 18) Total += 75;  // Already adds $25 from being under 25yrs old - added another 75 to equal $100

            if (CarMake == "Porsche") Total += 25;
            if (CarMake == "Porsche" && CarModel == "911 Carrera") Total += 25;
            if (SpeedingTickets > 0) Total += (SpeedingTickets * 10);
            if (DUICheck == "True") Total += (Total / 4);
            if (CoverageType == "True") Total += (Total / 2);
        }
        public void DBLogic(string FirstName, string LastName, string EmailAddress, DateTime DateOfBirth, int CarModelYear, string CarMake, string CarModel, int SpeedingTickets, string DUICheck, string CoverageType)
        { 
            using (InsuranceEntities2 db = new InsuranceEntities2())
            {
                
                carquote.Total = Total;
                carquote.FirstName = FirstName;
                carquote.LastName = LastName;
                carquote.EmailAddress = EmailAddress;
                carquote.DateOfBirth = DateOfBirth;
                carquote.CarModelYear = CarModelYear;
                carquote.CarMake = CarMake;
                carquote.CarModel = CarModel;
                carquote.SpeedingTickets = SpeedingTickets;
                carquote.DUICheck = DUICheck;
                carquote.CoverageType = CoverageType;
                db.Quotes.Add(carquote);
                db.SaveChanges();
            }
        }
    }
}