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
        public int ID { get; set; }

        [Column("EMP_ID")]
        public string EmployeeID { get; set; }
        [Column("EMP_First_Name")]
        public string FirstName { get; set; }
        [Column("EMP_Middle_Name")]
        public string MiddleName { get; set; }
        [Column("EMP_Last_Name")]
        public string LastName { get; set; }
        [Column("EMP_Designation")]
        public string Designation { get; set; }
        [Column("Date_of_Birth")]
        public DateTime DateOfBirth { get; set; }
        [Column("EMP_photo")]
        public string Photo { get; set; }
        [Column("Gender")]
        public string Gender { get; set; }
        [Column("Date_of_Join")]
        public DateTime DateOfJoin { get; set; }
        [Column("Citizenship")]
        public string Citizenship { get; set; }
        [Column("Marital_Status")]
        public string MaritalStatus { get; set; }
        [Column("Passport_Number")]
        public string PassportNumber { get; set; }
        [Column("Aadhaar_Number")]
        public string AadharNumber { get; set; }
        [Column("PAN")]
        public string PAN { get; set; }
        [Column("UAN")]
        public string UAN { get; set; }
        [Column("SSN")]
        public string SSN { get; set; }
        [Column("Driving_License")]
        public string DrivingLicense { get; set; }
        [Column("Marriage_Date")]
        public DateTime MarriageDate { get; set; }
        [Column("Tier")]
        public string Tier { get; set; }
        [Column("Permanent_Location")]
        public string PermanentLocation { get; set; }
        [Column("Employment_Type")]
        public string EmploymentType { get; set; }
        [Column("Employee_Status")]
        public string Status { get; set; }
        [Column("Onsite_Offshore")]
        public string WorkLocationType { get; set; }
        [Column("Current_Location")]
        public string CurrentLocation { get; set; }
        [Column("GEO")]
        public string GEO { get; set; }
        [Column("Delivery_Unit")]
        public string DeliveryUnit { get; set; }
        [Column("BU")]
        public string BU { get; set; }
        [Column("Practice")]
        public string Practice { get; set; }
        [Column("Skill_category")]
        public string SkillCategory { get; set; }
        [Column("Visa_Status")]
        public string VisaStatus { get; set; }
        [Column("Visa_Details")]
        public string VisaDetails { get; set; }
        [Column("Email_Id")]
        public string EmailId { get; set; }
        [Column("Phone_1")]
        public string Phone1 { get; set; }
        [Column("Phone_2")]
        public string Phone2 { get; set; }
        [Column("P_Address_1")]
        public string PermanentAddress1 { get; set; }
        [Column("P_Address_2")]
        public string PermanentAddress2 { get; set; }
        [Column("P_Locality")]
        public string PermanentLocality { get; set; }
        [Column("P_Area")]
        public string PermanentArea { get; set; }
        [Column("P_City")]
        public string PermanentCity { get; set; }
        [Column("P_Pincode")]
        public string PermanentPincode { get; set; }
        [Column("P_State")]
        public string PermanentState { get; set; }
        [Column("P_Country")]
        public string PermanentCountry { get; set; }
        [Column("C_Address_1")]
        public string CompanyAddess1 { get; set; }
        [Column("C_Address_2")]
        public string CompanyAddess2 { get; set; }
        [Column("C_Locality")]
        public string CompanyLocality { get; set; }
        [Column("C_Area")]
        public string CompanyArea { get; set; }
        [Column("C_City")]
        public string CompanyCity { get; set; }
        [Column("C_Pincode")]
        public string CompanyPincode { get; set; }
        [Column("C_State")]
        public string CompanyState { get; set; }
        [Column("C_Country")]
        public string CompanyCountry { get; set; }
        [Column("created")]
        public DateTime Created { get; set; }
        [Column("last_modified")]
        public DateTime LastModified { get; set; }
    }
}
