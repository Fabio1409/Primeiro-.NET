using PrimeiroDOTNET.Models.Enums;

namespace PrimeiroDOTNET.Models
{
    public class SellerRecord
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SellerStatus Status { get; set; }
        public Seller Seller { get; set; }

        public SellerRecord()
        { 
        }

        public SellerRecord(int iD, DateTime date, double amount, SellerStatus status, Seller seller)
        {
            ID = iD;
            Date = date;
            Amount = amount;
            Status = status;
            Seller = seller;
        }
    }
}
