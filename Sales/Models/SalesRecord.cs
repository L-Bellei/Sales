using System;
using System.ComponentModel.DataAnnotations;
using Sales.Models.Enums;

namespace Sales.Models
{
    public class SalesRecord
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }

        [Required]
        [Display(Name = "Amount")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public double Amount { get; set; }

        [Required]
        [Display(Name = "Sale status")]
        public SaleStatus Status { get; set; }

        public Seller Seller { get; set; }

        public SalesRecord() { }

        public SalesRecord(DateTime date, double amount, SaleStatus status, Seller seller)
        {
            Date = date;
            Amount = amount;
            Status = status;
            Seller = seller;
        }
    }
}
