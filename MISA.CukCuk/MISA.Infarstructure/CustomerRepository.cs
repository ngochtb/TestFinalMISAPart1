using Dapper;
using Microsoft.Extensions.Configuration;
using MISA.ApplicationCore.Entities;
using MISA.ApplicationCore.Interfaces;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;

namespace MISA.Infarstructure
{
    public class CustomerRepository:BaseRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(IConfiguration configuration):base(configuration)
        {

        }
        public Customer GetCustomerByCode(string customerCode)
        {
            var customerDuplicate = _dbConnection.Query<Customer>($"SELECT * FROM Customer WHERE CustomerCode = '{customerCode}'", commandType: CommandType.Text).FirstOrDefault();
            return customerDuplicate;
        }
    }
}
