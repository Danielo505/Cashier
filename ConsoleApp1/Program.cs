using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cashier.Data;
using Cashier.Data.Context;
using Cashier.Data.Repositories;
using Cashier.Data.Services;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            UnitOfWork db = new UnitOfWork();

            var List=db.CustomerRepository.GetAllCustomers();

            db.Dispose();
        }
    }
}
