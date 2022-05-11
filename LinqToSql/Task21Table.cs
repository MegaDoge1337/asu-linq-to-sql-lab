using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqToSql
{
    public partial class Task21Table : Form
    {
        private SqlClient.SqlClient _client;
        private SqlClient.Repositories.CustomerRepository _customersRepository;
        private SqlClient.Repositories.DiscountRepository _discountsRepository;

        public Task21Table(SqlClient.SqlClient client)
        {
            InitializeComponent();

            this._client = client;

            this._customersRepository = new SqlClient.Repositories.CustomerRepository(this._client);
            this._discountsRepository = new SqlClient.Repositories.DiscountRepository(this._client);
        }

        private void Task21Table_Load(object sender, EventArgs e)
        {
            var data = new List<Task21Data>();

            var customers = this._customersRepository.GetCustomers();
            var discounts = this._discountsRepository.GetDiscounts();

            foreach (var customer in customers) 
            {
                var row = new Task21Data();

                row.CusomerCode = customer.CustomerCode;
                row.Street = customer.Street;

                row.ShopsCount = discounts.Where(d => d.CustomerCode == customer.CustomerCode).Select(d => d.ShopTitle).Distinct().Count();

                data.Add(row);
            }

            dataGridView1.Rows.Clear();

            foreach (var row in data.OrderBy(d => d.ShopsCount).ThenBy(d => d.CusomerCode)) 
            {
                dataGridView1.Rows.Add(row.ShopsCount, row.CusomerCode, row.Street);
            }
        }
    }

    class Task21Data 
    {
        public int ShopsCount;
        public string CusomerCode;
        public string Street;
    }
}
