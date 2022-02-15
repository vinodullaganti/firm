using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FirmApi.Models
{
    [Table("AccountMaster")]
    public class Accounts
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("Account_ID")]
        public string AccountId { get; set; }
        [Column("Name")]
        public string AccountName { get; set; }
        [Column("Description")]
        public string Description { get; set; }
    }
}
