using System;
using System.Collections.Generic;
using System.Text;

namespace Firm.Models.DTO
{
    /// <summary>
    /// EmployeeListDTO
    /// </summary>
    public class EmployeeListDTO
    {
        public int ID { get; set; }
        public string EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string Designation { get; set; }
        public DateTime DateOfJoin { get; set; }
        public string Status { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Photo { get; set; }
        public string EmailId { get; set; }
    }
}
