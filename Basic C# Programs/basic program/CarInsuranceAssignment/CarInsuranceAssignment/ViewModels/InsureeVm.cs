using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarInsuranceAssignment.ViewModels
{
    public class InsureeVm // using a view model because there are a few select things we want to return to the admin page
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public decimal Quote { get; set; }
    }
}