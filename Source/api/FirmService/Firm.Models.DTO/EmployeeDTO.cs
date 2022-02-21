using System;
using System.Collections.Generic;
using System.Text;

namespace Firm.Models.DTO
{
    /// <summary>
    /// EmployeeDTO
    /// </summary>
    public class EmployeeDTO
    {
        public int EmployeeID { get; set; }
        public string EmployeeCode { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string Designation { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Image { get; set; }
        public string Gender { get; set; }
        public DateTime? DateOfJoin { get; set; }
        public string Nationality { get; set; }
        public string MaritalStatus { get; set; }
        public string PassportNumber { get; set; }
        public string AadharNumber { get; set; }
        public string PAN { get; set; }
        public string UAN { get; set; }
        public string SSN { get; set; }
        public string DrivingLicense { get; set; }
        public string Tier { get; set; }
        public string PermanentLocation { get; set; }
        public string EmploymentType { get; set; }
        public string Status { get; set; }
        public string ReportingManagerCode { get; set; }
        public string IsOnsite { get; set; }
        public string IsNearShore { get; set; }
        public string CurrentLocation { get; set; }
        public string DeliveryUnit { get; set; }
        public string BusinessUnit { get; set; }
        public string PersonalEmailId { get; set; }
        public string EmailId { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string PermanentAddress1 { get; set; }
        public string PermanentAddress2 { get; set; }
        public string PermanentArea { get; set; }
        public string PermanentCity { get; set; }
        public string PermanentZipcode { get; set; }
        public string PermanentState { get; set; }
        public string PermanentCountry { get; set; }
        public string CurrentAddess1 { get; set; }
        public string CurrentAddess2 { get; set; }
        public string CurrentArea { get; set; }
        public string CurrentCity { get; set; }
        public string CurrentZipcode { get; set; }
        public string CurrentState { get; set; }
        public string CurrentCountry { get; set; }
        public string LinkedIn { get; set; }
        public string BooldGroup { get; set; }
        public string Category { get; set; }
        public string AccountNumber { get; set; }
        public string Bank { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
    }
}
