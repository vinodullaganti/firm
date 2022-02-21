using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Firm.Service.Repository.Models
{
    /// <summary>
    /// Employee
    /// </summary>
    public class Employee
    {

        [Column("employee_id")]
        public int EmployeeID { get; set; }
        [Column("employee_code")]
        public string EmployeeCode { get; set; }
        [Column("first_name")]
        public string FirstName { get; set; }
        [Column("middle_Name")]
        public string MiddleName { get; set; }
        [Column("last_name")]
        public string LastName { get; set; }
        public string FullName { get => $"{FirstName} {MiddleName} {LastName}"; }
        [Column("designation")]
        public string Designation { get; set; }
        [Column("date_of_birth")]
        public DateTime? DateOfBirth { get; set; }
        [Column("image")]
        public string Image { get; set; }
        [Column("gender")]
        public string Gender { get; set; }
        [Column("date_of_joining")]
        public DateTime? DateOfJoin { get; set; }
        [Column("nationality")]
        public string Nationality { get; set; }
        [Column("marital_status")]
        public string MaritalStatus { get; set; }
        [Column("passport_number")]
        public string PassportNumber { get; set; }
        [Column("aadhaar")]
        public string AadharNumber { get; set; }
        [Column("pan")]
        public string PAN { get; set; }
        [Column("uan")]
        public string UAN { get; set; }
        [Column("ssn")]
        public string SSN { get; set; }
        [Column("driving_license_number")]
        public string DrivingLicense { get; set; }
        [Column("tier")]
        public string Tier { get; set; }
        [Column("permanent_location")]
        public string PermanentLocation { get; set; }
        [Column("employment_type")]
        public string EmploymentType { get; set; }
        [Column("status")]
        public string Status { get; set; }
        [Column("reporting_manager_code")]
        public string ReportingManagerCode { get; set; }
        [Column("is_onsite")]
        public string IsOnsite { get; set; }
        [Column("is_nearshore")]
        public string IsNearShore { get; set; }
        [Column("current_location")]
        public string CurrentLocation { get; set; }
        [Column("delivery_unit")]
        public string DeliveryUnit { get; set; }
        [Column("business_unit")]
        public string BusinessUnit { get; set; }
        [Column("personal_email")]
        public string PersonalEmailId { get; set; }
        [Column("email")]
        public string EmailId { get; set; }
        [Column("phone_1")]
        public string Phone1 { get; set; }
        [Column("phone_2")]
        public string Phone2 { get; set; }
        [Column("permanent_address1")]
        public string PermanentAddress1 { get; set; }
        [Column("permanent_address2")]
        public string PermanentAddress2 { get; set; }
        [Column("permanent_area")]
        public string PermanentArea { get; set; }
        [Column("permanent_city")]
        public string PermanentCity { get; set; }
        [Column("permanent_zipcode")]
        public string PermanentZipcode { get; set; }
        [Column("permanent_state")]
        public string PermanentState { get; set; }
        [Column("permanent_country")]
        public string PermanentCountry { get; set; }
        [Column("current_address_1")]
        public string CurrentAddess1 { get; set; }
        [Column("current_address_2")]
        public string CurrentAddess2 { get; set; }
        [Column("current_area")]
        public string CurrentArea { get; set; }
        [Column("current_city")]
        public string CurrentCity { get; set; }
        [Column("current_zipcode")]
        public string CurrentZipcode { get; set; }
        [Column("current_state")]
        public string CurrentState { get; set; }
        [Column("current_country")]
        public string CurrentCountry { get; set; }
        [Column("linkedIn")]
        public string LinkedIn { get; set; }
        [Column("blood_group")]
        public string BooldGroup { get; set; }
        [Column("category")]
        public string Category { get; set; }
        [Column("account_num")]
        public string AccountNumber { get; set; }
        [Column("bank")]
        public string Bank { get; set; }
        [Column("created_on")]
        public DateTime? CreatedOn { get; set; }
        [Column("created_by")]
        public string CreatedBy { get; set; }
        [Column("modified_on")]
        public DateTime? ModifiedOn { get; set; }
        [Column("modified_by")]
        public string ModifiedBy { get; set; }
    }
}
