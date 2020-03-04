using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMVC.Models;

namespace SalesWebMVC.Services
{
    public class SellerService
    {
        private readonly SalesWebMVCContext _context;

        public SellerService(SalesWebMVCContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll() //retorna todos os vendedores
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj) //inserindo novo vendedor no banco de dados
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public Seller FindById(int id) //buscar vendedor por Id
        {
            return _context.Seller.FirstOrDefault(obj => obj.Id == id);
        }

        public void Remove(int id) //remove vendedor
        {
            var obj = _context.Seller.Find(id);
            _context.Seller.Remove(obj); //remove do dbset
            _context.SaveChanges();
        }
    }
}