﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using Cashier.Data.Repositories;
using Cashier.Data.Services;

namespace Cashier.Data.Context
{
    public class UnitOfWork : IDisposable
    {
        Cashier_DBEntities db = new Cashier_DBEntities();

        private ICustomerRepository _customerRepository;

        public ICustomerRepository CustomerRepository
        {
            get
            {
                if (_customerRepository == null)
                {
                    _customerRepository = new CustomerRepository(db);
                }
                return _customerRepository;
            }
        }


        private GenericRepository<Accounting> _accountingRepository;
        public GenericRepository<Accounting> AccountingRepository
        { 
         get
            {
                if(_accountingRepository == null)
                {
                    _accountingRepository=new GenericRepository<Accounting>(db);
                }
                return _accountingRepository ;
            }
        }

        private GenericRepository<Login> _loginRepository;
        public GenericRepository<Login> LoginRepository
        {
           get
            {
                if(_loginRepository == null)
                {
                    _loginRepository=new GenericRepository<Login>(db);
                }
                return _loginRepository;
            }
        }
        public void Save()
        {
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}
