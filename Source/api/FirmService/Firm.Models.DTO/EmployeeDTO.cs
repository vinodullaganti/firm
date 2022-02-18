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
        public int ID { get; set; }
        public string EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Designation { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Photo { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfJoin { get; set; }
        public string Citizenship { get; set; }
        public string MaritalStatus { get; set; }
        public string PassportNumber { get; set; }
        public string AadharNumber { get; set; }
        public string PAN { get; set; }
        public string UAN { get; set; }
        public string SSN { get; set; }
        public string DrivingLicense { get; set; }
        public DateTime MarriageDate { get; set; }
        public string Tier { get; set; }
        public string PermanentLocation { get; set; }
        public string EmploymentType { get; set; }
        public string Status { get; set; }
        public string WorkLocationType { get; set; }
        public string CurrentLocation { get; set; }
        public string GEO { get; set; }
        public string DeliveryUnit { get; set; }
        public string BU { get; set; }
        public string Practice { get; set; }
        public string SkillCategory { get; set; }
        public string VisaStatus { get; set; }
        public string VisaDetails { get; set; }
        public string EmailId { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string PermanentAddress1 { get; set; }
        public string PermanentAddress2 { get; set; }
        public string PermanentLocality { get; set; }
        public string PermanentArea { get; set; }
        public string PermanentCity { get; set; }
        public string PermanentPincode { get; set; }
        public string PermanentState { get; set; }
        public string PermanentCountry { get; set; }
        public string CompanyAddess1 { get; set; }
        public string CompanyAddess2 { get; set; }
        public string CompanyLocality { get; set; }
        public string CompanyArea { get; set; }
        public string CompanyCity { get; set; }
        public string CompanyPincode { get; set; }
        public string CompanyState { get; set; }
        public string CompanyCountry { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastModified { get; set; }
    }
}
