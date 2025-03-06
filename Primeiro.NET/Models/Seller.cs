using System.ComponentModel.DataAnnotations;

namespace PrimeiroDOTNET.Models
{
    public class Seller
    {
        
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} required")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "{0} size should be between {2} and {1} characters")]
        public string Name { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "{0} required")]
        [EmailAddress(ErrorMessage = "Enter a valid email")]
        public string Email { get; set; }

        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Required(ErrorMessage = "{0} required")]
        public DateTime BirthDate { get; set; }
        [Display(Name = "Base Salary")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        [Required(ErrorMessage = "{0} required")]
        [Range(100.0, 50000.0, ErrorMessage = "{0} must be from {1} to {2}")]
        public double BaseSalary { get; set; }
        public Departament Departament { get; set; }
        public int DepartamentId { get; set; }
        public ICollection<SellerRecord> Sales { get; set; } = new List<SellerRecord>();

        public Seller()
        {
        }

        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary, Departament departament)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Departament = departament;

        }
        public void AddSales(SellerRecord salesRecord)
        {
            Sales.Add(salesRecord);
        }

        public void RemoveSales(SellerRecord salesRecord)
        
            {
                Sales.Remove(salesRecord);
            }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sales.Where(salesRecord => salesRecord.Date >= initial && salesRecord.Date <= final).
                Sum(salesRecord => salesRecord.Amount);
        }
    }
}
