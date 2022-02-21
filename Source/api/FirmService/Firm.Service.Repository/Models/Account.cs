using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Firm.Service.Repository.Models
{
    //[Table("account")]
    //public class Account
    //{
    //    [Key]
    //    [Column("ID")]
    //    public int Id { get; set; }
    //    [Column("Account_ID")]
    //    public string AccountId { get; set; }
    //    [Column("Name")]
    //    public string AccountName { get; set; }
    //    [Column("Description")]
    //    public string Description { get; set; }

    //}

    [Table("account")]
    public class Account
    {
        [Key]
        [Column("account_id")]
        public int AccountId { get; set; }
        [Column("account_name")]
        public string AccountName { get; set; }
        [Column("account_prefix")]
        public string AccountPrefix { get; set; }
        [Column("description")]
        public string Description { get; set; }
        [Column("account_revenue")]
        public decimal AccountRevenue { get; set; }
        [Column("domain_id")]
        public int DomainId { get; set; }
        [Column("planned_start_date")]
        public DateTime PlannedStartDate { get; set; }
        [Column("planned_end_date")]
        public DateTime PlannedEndDate { get; set; }
        [Column("account_start_date")]
        public DateTime AccountStartDate { get; set; }
        [Column("account_end_date")]
        public DateTime AccountEndDate { get; set; }
        [Column("address1")]
        public string Address1 { get; set; }
        [Column("address2")]
        public string Address2 { get; set; }
        [Column("city")]
        public string City { get; set; }
        [Column("state")]
        public string State { get; set; }
        [Column("zipcode")]
        public string ZipCode { get; set; }
        [Column("country")]
        public string Country { get; set; }
        [Column("contact_email1")]
        public string ContactEmail1 { get; set; }
        [Column("contact_email2")]
        public string ContactEmail2 { get; set; }
        [Column("contact_num1")]
        public string ContactNumumer1 { get; set; }
        [Column("contact_num2")]
        public string ContactNumber2 { get; set; }
        [Column("is_red")]
        public bool IsRed { get; set; }
        [Column("account_logo")]
        public string AccountLogo { get; set; }
        [Column("account_url")]
        public string AccountUrl { get; set; }
        [Column("created_on")]
        public DateTime CreatedOn { get; set; }
        [Column("created_by")]
        public string CreatedBy { get; set; }
        [Column("modified_on")]
        public DateTime ModifiedOn { get; set; }
        [Column("modified_by")]
        public string ModifiedBy { get; set; }
        [Column("account_phase")]
        public string AccountPhase { get; set; }
        [Column("is_active")]
        public bool IsActive { get; set; }
    }
}
