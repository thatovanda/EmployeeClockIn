using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeClockIn.Models
{
    public class Shift
    {
        [Key]
        public int ShiftId { get; set; }

        [Required]
        [Display(Name = "Shift name")]
        public string shiftName { get; set; }

        [Required]
        [DisplayName("Start Time")]
        [DataType(DataType.Time)]
        public TimeSpan startTime { get; set; }


        [Required]
        [DisplayName("End Time")]
        [DataType(DataType.Time)]
        public TimeSpan endTime { get; set; }

        public List<Schedule> Schedule { get; set; }
    }
}