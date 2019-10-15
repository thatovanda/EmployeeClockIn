using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EmployeeClockIn.Models
{
    public class ClockOut
    {
        [Key]
        public string ClockOutID { get; set; }

        [Required]
        [Display(Name = "Start Time")]
        [DataType(DataType.Time)]
        public TimeSpan EndTime { get; set; }

        public int EmpId { get; set; }
        public Employee Employee { get; set; }

    }
}