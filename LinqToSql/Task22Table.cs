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
    public partial class Task22Table : Form
    {
        private SqlClient.SqlClient _client;

        private SqlClient.Repositories.CustomerRepository _customersRepository;
        private SqlClient.Repositories.DiscountRepository _discountsRepository;

        public Task22Table(SqlClient.SqlClient client)
        {
            InitializeComponent();

            this._client = client;

            this._customersRepository = new SqlClient.Repositories.CustomerRepository(this._client);
            this._discountsRepository = new SqlClient.Repositories.DiscountRepository(this._client);
        }

        private void Task22Table_Load(object sender, EventArgs e)
        {
            var data = new List<Task22Data>();

            var customers = this._customersRepository.GetCustomers();
            var discounts = this._discountsRepository.GetDiscounts();

            var shopTitles = discounts.Select(d => d.ShopTitle).Distinct();

            foreach (var shopTitle in shopTitles) 
            {
                var shopMaxDiscount = discounts.Where(d => d.ShopTitle == shopTitle).Max(d => d.DiscountValue);
                var targetCustomerCode = discounts.Where(d => d.DiscountValue == shopMaxDiscount).Min(d => d.CustomerCode);

                var row = new Task22Data();
                row.ShopTitle = shopTitle;
                row.CustomerCode = targetCustomerCode;
                row.BirthYear = customers.Where(c => c.CustomerCode == targetCustomerCode).First().BirthYear;
                row.MaxDiscount = shopMaxDiscount;

                data.Add(row);
            }

            dataGridView1.Rows.Clear();

            foreach (var row in data.OrderBy(d => d.ShopTitle)) 
            {
                dataGridView1.Rows.Add(row.ShopTitle, row.CustomerCode, row.BirthYear, row.MaxDiscount);
            }
        }
    }

    class Task22Data 
    {
        public string ShopTitle;
        public string CustomerCode;
        public int BirthYear;
        public int MaxDiscount;
    }
}
