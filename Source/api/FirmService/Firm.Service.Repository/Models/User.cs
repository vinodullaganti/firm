using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Firm.Service.Repository.Models
{
    public class User
    {
        [Column("user_id")]
        public long UserID { get; set; }
        [Column("first_name")]
        public string FirstName { get; set; }
        [Column("last_name")]
        public string LastName { get; set; }
        [Column("user_email")]
        public string EmailId { get; set; }
        [Column("is_internal")]
        public bool IsInternal { get; set; }
        [Column("created_on")]
        public DateTime CreatedOn { get; set; }
        [Column("created_by")]
        public string CreatedBy { get; set; }
        [Column("modified_on")]
        public DateTime ModifiedOn { get; set; }
        [Column("modified_by")]
        public string ModifiedBy { get; set; }
    }
}
