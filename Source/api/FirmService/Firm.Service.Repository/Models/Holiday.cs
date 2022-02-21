using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Firm.Service.Repository.Models
{
    public class Holiday
    {
        [Key]
        [Column("holiday_id")]
        public int ID { get; set; }
        [Column("holiday_date")]
        public DateTime HolidayDate { get; set; }
        [Column("holiday_day")]
        public string HolidayDay { get; set; }
        [Column("holiday_name")]
        public string HolidayName { get; set; }
        [Column("description")]
        public string Description { get; set; }
        [Column("location")]
        public string Location { get; set; }
        [Column("created_on")]
        public DateTime Created { get; set; }
        [Column("created_by")]
        public string CreatedBy { get; set; }
        [Column("modified_on")]
        public DateTime ModifiedOn { get; set; }
        [Column("modified_by")]
        public string ModifiedBy { get; set; }
    }
}
