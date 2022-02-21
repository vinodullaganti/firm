using System;
using System.Collections.Generic;
using System.Text;

namespace Firm.Models.DTO
{
    public class HolidayDTO
    {
        public int HolidayId { get; set; }
        public DateTime HolidayDate { get; set; }
        public string HolidayDay { get; set; }
        public string HolidayName { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
    }
}
