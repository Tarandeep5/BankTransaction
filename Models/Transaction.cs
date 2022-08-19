using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankTransaction.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }

        [Column(TypeName="nvarchar(12)")]
        public String AccountNumber { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public String BenificiaryName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public String BankName { get; set; }
        [Column(TypeName = "nvarchar(11)")]
        public String SwiftCode { get; set; }
        public int Amount { get; set; }

        public DateTime Date { get; set; }
    }
}
