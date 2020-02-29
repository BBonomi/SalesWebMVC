using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMVC.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>(); //associação do departamento com o vendedores(seller)

        public Department() //construtor sem argumento para utilização do framework
        {
        }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        //adicionar um vendedor
        public void AddSeller(Seller seller)
        {
            Sellers.Add(seller);
        }

        //Total de Vendas do Departamento
        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sellers.Sum(seller => seller.TotalSales(initial, final)); //faz a soma de todos os vendedores no periodo - sendo a venda de cada vendedor calculada no periodo e depois somada
        }
    }
}