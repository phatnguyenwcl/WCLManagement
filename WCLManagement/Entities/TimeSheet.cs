﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WCLManagement.Entities
{
    [Table("TimeSheets")]
    public class TimeSheet
    {
        [Key]
        public int ID { get; set; }

        public int EmployeeID { get; set; }

        [ForeignKey("EmployeeID")]
        public virtual Employee Employee { get; set; }

        [Required]
        public DateTime StartWorking { get; set; }
        
        [Required]
        public DateTime EndWorking { get; set; }

        public DateTime BreakStart { get; set; }

        public DateTime BreakEnd { get; set; }
        
        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }
    }
}