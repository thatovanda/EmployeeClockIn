using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EmployeeClockIn.Models
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }
        public string Title { get; set; }

        [DisplayName("Firstname")]
        [Required(ErrorMessage = "Kindly enter your name")]
        public string FirstName { get; set; }
        [DisplayName("LastName")]
        [Required(ErrorMessage = "Kindly enter your surname")]
        public string LastName { get; set; }
        [DisplayName("Gender")]
        [Required(ErrorMessage = "Kindly choose your gender")]
        public string Gender { get; set; }
        [DisplayName("Physical Address")]
        [Required(ErrorMessage = "Kindly enter your physical address")]
        public string PhysicalAd { get; set; }
        [DisplayName("Phone Number")]
        [Required(ErrorMessage = "Kindly enter your phone number")]
        public string PhoneNo { get; set; }
        [DisplayName("Email Adresss")]
        [Required(ErrorMessage = "Kindly enter your email address")]
        public string Email { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
        [DisplayName("Employee Status")]
        [Required(ErrorMessage = "Kindly Enter the status of the Employee")]
        public bool EmployeeStat { get; set; }

        public ApplicationUser User { get; set; }
        public string ApplicationUserId { get; set; }

        public double hrsWorked { get; set; }

        public List<Schedule> Schedule { get; set; }
    }
}