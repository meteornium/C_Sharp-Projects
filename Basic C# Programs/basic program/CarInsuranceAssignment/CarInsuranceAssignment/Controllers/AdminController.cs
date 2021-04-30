using CarInsuranceAssignment.Models;
using CarInsuranceAssignment.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsuranceAssignment.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (InsuranceEntities db = new InsuranceEntities())
            {
                // setting up access to database list
                var insurees = db.Tables.ToList();

                // empty list to add all info into later and then return to vies
                var insureeVms = new List<InsureeVm>();

                // for each loop
                foreach (var insuree in insurees)
                {
                    insuree.Quote = 50;
                    var insureeVm = new InsureeVm();

                    // checking insuree age. if 18 or below, goes through first if, if 19-25, goes through else if, all others goes through final else
                    var insureeAge = (insuree.DateOfBirth - DateTime.Now).TotalDays / 365;
                    if (insureeAge < 19)
                    {
                        insuree.Quote += 100;
                    }
                    else if (insureeAge >= 19 && insureeAge < 26)
                    {
                        insuree.Quote += 50;
                    }
                    else
                    {
                        insuree.Quote += 25;
                    }

                    // checks if car year is below 200 or above 2015
                    if (insuree.CarYear < 2000 || insuree.CarYear > 2015)
                    {
                        insuree.Quote += 25;
                    }

                    //checks car make and model for porsche and carerra
                    if (insuree.CarMake == "Porsche" && insuree.CarModel == "911 Carerra")
                    {
                        insuree.Quote += 50;
                    }
                    else if (insuree.CarMake == "Porsche")
                    {
                        insuree.Quote += 25;
                    }

                    // checks if speedingtickets are greater than zero, then adds 10 times how many tickets to the quote total
                    if (insuree.SpeedingTickets > 0)
                    {
                        insuree.Quote += 10 * insuree.SpeedingTickets;
                    }

                    //if user had DUI, multiplies quote value and sets it to that
                    if (insuree.DUI == true)
                    {
                        insuree.Quote *= (Decimal)1.25;
                    }

                    // if user selects full coverage, adds 50% to total
                    if (insuree.CoverageType == true)
                    {
                        insuree.Quote *= (Decimal)1.5;
                    }

                    insureeVm.FirstName = insuree.FirstName;
                    insureeVm.LastName = insuree.LastName;
                    insureeVm.EmailAddress = insuree.EmailAddress;
                    insureeVm.Quote = insuree.Quote;
                    insureeVms.Add(insureeVm);
                }
                return View(insureeVms);
            }           
        }
    }
}