using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSql.SqlClient.Entities
{
    public class Customer
    {
        public int ID;
        public string CustomerCode;
        public string Street;
        public int BirthYear;

        public Customer(int id, string customerCode, string street, int birthYear) 
        {
            this.ID = id;
            this.CustomerCode = customerCode;
            this.Street = street;
            this.BirthYear = birthYear;
        }
    }
}
