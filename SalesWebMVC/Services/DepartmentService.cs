using SalesWebMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMVC.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMVCContext _context;

        public DepartmentService(SalesWebMVCContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync() //operação assincorona usando Task, mudamos FindAll para FindAllAsync
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync(); //ToList mudou para ToListAsync e incluimos await
        }
    }
}