using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace training.netcorenvc.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }

        [Column(TypeName ="nvarchar(12)")]
        [Required]
        public string AccountNumber { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [Required]
        public string BeneficiaryName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [Required]
        public string BankName { get; set; }

        [Column(TypeName = "nvarchar(11)")]
        [Required]
        public string SWIFTcode { get; set; }

        [Required]
        public int Amount { get; set; }
        public DateTime Date { get; set; }
    }   
}
