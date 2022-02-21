using System;
using System.Collections.Generic;
using System.Text;

namespace Firm.Models.DTO
{
    public class AccountDTO
    {
        public int AccountId { get; set; }
        public string AccountName { get; set; }
        public string AccountPrefix { get; set; }
        public string Description { get; set; }
        public decimal AccountRevenue { get; set; }
        public int DomainId { get; set; }
        public DateTime PlannedStartDate { get; set; }
        public DateTime PlannedEndDate { get; set; }
        public DateTime AccountStartDate { get; set; }
        public DateTime AccountEndDate { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public string ContactEmail1 { get; set; }
        public string ContactEmail2 { get; set; }
        public string ContactNumumer1 { get; set; }
        public string ContactNumber2 { get; set; }
        public bool IsRed { get; set; }
        public string AccountLogo { get; set; }
        public string AccountUrl { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
        public string AccountPhase { get; set; }
        public bool IsActive { get; set; }
    }
}
