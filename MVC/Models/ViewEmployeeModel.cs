using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class ViewEmployeeModel
    {
        [Display(Name="Employee ID")]
        public int EmployeeID { get; set; }

        [Display(Name = "First Name")]
        [Required (ErrorMessage ="This field is compulsory")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "This field is compulsory")]
        public string LastName { get; set; }

        [Display(Name = "Position")]
        [Required(ErrorMessage = "This field is compulsory")]
        public string Position { get; set; }

        [Required(ErrorMessage = "This field is compulsory")]
        public Nullable<int> Age { get; set; }

        [Required(ErrorMessage = "This field is compulsory")]
        public Nullable<int> Salary { get; set; }
    }
}