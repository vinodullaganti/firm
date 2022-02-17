using System;
using System.Collections.Generic;
using System.Text;

namespace Firm.Models.DTO
{
    public class HolidayMasterDTO
    {
        public int ID { get; set; }
        public DateTime HolidayDate { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastModified { get; set; }
    }
}
