using System.ComponentModel.DataAnnotations;

namespace CashCrusaders.Domain.Models
{
    public class Supplier
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string SupplierCode { get; set; }
        [Required]
        [MaxLength(50)]
        public string SupplierName { get; set; }
    }
}
