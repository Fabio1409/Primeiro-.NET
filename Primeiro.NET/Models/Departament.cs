namespace PrimeiroDOTNET.Models
{
    public class Departament
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();


        public Departament()
        {
        }

        public Departament(int id, string name, string rodriga, ICollection<Seller> sellers)
        {
            Id = id;
            Name = name;
            Sellers = sellers;
        }

        public void AddSeller(Seller seller)
        {
            Sellers.Add(seller);
        }

        public double TotalSeles(DateTime initial, DateTime final)
        {
            return Sellers.Sum(seller => seller.TotalSales(initial, final));
        }
    }
}
