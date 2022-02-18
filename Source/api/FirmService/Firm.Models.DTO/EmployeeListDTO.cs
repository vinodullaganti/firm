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
        public string Designation { get; set; }
        public DateTime DateOfJoin { get; set; }
        public string Status { get; set; }
    }
}
