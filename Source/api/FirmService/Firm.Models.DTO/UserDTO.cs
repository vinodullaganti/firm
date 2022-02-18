using System;
using System.Collections.Generic;
using System.Text;

namespace Firm.Models.DTO
{
    /// <summary>
    /// UserDTO
    /// </summary>
    public class UserDTO
    {
        public long UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailId { get; set; }
        public bool IsInternal { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
    }
}
