using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Firm.Service.Repository.Models
{
    public class HolidayMaster
    {
        public int ID { get; set; }

        [Column("Holiday Date")]
        public DateTime HolidayDate { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        [Column("created")]
        public DateTime Created { get; set; }
        [Column("last_modified")]
        public DateTime LastModified { get; set; }

    }
}
