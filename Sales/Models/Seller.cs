using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Sales.Models
{
    public class Seller
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} Required!")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "E-mail")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Birth date")]
        [DataType(DataType.Date)]
        public DateTime BirthDate{ get; set; }

        [Required]
        [Range(100.00, 50000.00, ErrorMessage = "{0} must be from {1} to {2}")]
        [Display(Name = "Base salary")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public double BaseSalary { get; set; }

        [Display(Name ="Department")]
        public Department Department { get; set; }

        [Display(Name ="Department")]
        public int DepartmentId { get; set; }

        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller() { }

        public Seller(string name, string email, DateTime birthDate, double baseSalary, Department department)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddSales(SalesRecord sr)
        {
            Sales.Add(sr);
        }

        public void RemoveSales(SalesRecord sr)
        {
            Sales.Remove(sr);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sales.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount);
        }
    }
}
