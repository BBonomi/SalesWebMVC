using SalesWebMVC.Models.Enums;
using System;

namespace SalesWebMVC.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SaleStatus Status { get; set; }
        public Seller Seller { get; set; } //associação SalesRecord para Seller (* para 1)

        public SalesRecord() // construtor vazio
        {
        }

        public SalesRecord(int id, DateTime date, double amount, SaleStatus status, Seller seller) // construtor do SalesRecord
        {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
            Seller = seller;
        }
    }
}