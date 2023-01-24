﻿using System.ComponentModel.DataAnnotations;

namespace CashCrusaders.Domain.Models
{
    public class Order
    {
        public int Id { get; set; }
        [Required]
        [StringLength(5)]
        public string Number { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public decimal? Tax { get; set; }
        [Required]
        public decimal GrandTotal { get; set; }
        [Required]
        [StringLength(20)]
        public string Code { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public List<OrderLine> Lines { get; set; }
    }
}
