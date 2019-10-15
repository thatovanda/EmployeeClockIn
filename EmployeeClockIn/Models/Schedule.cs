using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EmployeeClockIn.Models
{
    public class Schedule
    {
        [Key]
        public int SchdId { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Date")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
        [Required]
        [DisplayName("Employee name")]
        public int EmpId { get; set; }
        public Employee Employee { get; set; }
        [Required]
        [DisplayName("Shift name")]
        public int ShiftId { get; set; }
        public Shift Shift { get; set; }
    }
}