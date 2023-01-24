using System.ComponentModel.DataAnnotations;

namespace CashCrusaders.Domain.Models
{
    public class OrderLine
    {
        public int Id { get; set; }
        [Required]
        public int Qty { get; set; }
        [Required]
        public decimal SubTotal { get; set; }
        [Required]
        [MaxLength(150)]
        public string Description { get; set; }
        [Required]
        [MaxLength(20)]
        public string Code { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        public int? OrderID { get; set; }
    }
}
