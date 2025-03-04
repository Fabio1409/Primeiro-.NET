namespace PrimeiroDOTNET.Models
{
    public class Seller
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public double BaseSalary { get; set; }
        public Departament Departament { get; set; }
        public ICollection<SellerRecord> Sales { get; set; } = new List<SellerRecord>();

        public Seller()
        {
        }

        public Seller(int iD, string name, string email, DateTime birthDate, double baseSalary, Departament departament)
        {
            ID = iD;
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
