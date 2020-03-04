using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC.Services.Exceptions
{
    public class IntegrityExcetpion : ApplicationException
    {
        public IntegrityExcetpion(string message) : base(message)
        {
        }
    }
}