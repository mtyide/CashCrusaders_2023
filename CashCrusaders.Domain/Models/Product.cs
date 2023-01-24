using System.ComponentModel.DataAnnotations;

namespace CashCrusaders.Domain.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string ProductCode { get; set; }
        [Required]
        [MaxLength(150)]
        public string Description { get; set; }
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        public int? SupplierID { get; set; }
    }
}
