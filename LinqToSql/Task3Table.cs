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
    public partial class Task3Table : Form
    {
        private SqlClient.SqlClient _client;

        private SqlClient.Repositories.CustomerRepository _customerRepository;
        private SqlClient.Repositories.DiscountRepository _discountRepository;
        private SqlClient.Repositories.ProductRepository _productRepository;
        private SqlClient.Repositories.PurchasesRepository _purchasesRepository;

        public Task3Table(SqlClient.SqlClient client)
        {
            InitializeComponent();

            this._client = client;

            this._customerRepository = new SqlClient.Repositories.CustomerRepository(this._client);
            this._discountRepository = new SqlClient.Repositories.DiscountRepository(this._client);
            this._productRepository = new SqlClient.Repositories.ProductRepository(this._client);
            this._purchasesRepository = new SqlClient.Repositories.PurchasesRepository(this._client);
        }

        private void Task3Table_Load(object sender, EventArgs e)
        {
            var data = new List<Task3Data>();

            var customers = this._customerRepository.GetCustomers();
            var discuounts = this._discountRepository.GetDiscounts();
            var products = this._productRepository.GetProducts();
            var purchases = this._purchasesRepository.GetPurchases();

            foreach (var purchase in purchases)
            {
                var targetCustomer = customers.Where(c => c.CustomerCode == purchase.CustomerCode).First();
                var targetProduct = products.Where(p => p.ProductArticleNumber == purchase.ProductArticleNumber).First();
                var targetShop = purchase.ShopTitle;

                var row = new Task3Data();
                row.MadeInCountry = targetProduct.MadeInCountry;
                row.Street = targetCustomer.Street;

                var targetDiscounts = discuounts.Where(d => d.ShopTitle == targetShop).Where(d => d.CustomerCode == targetCustomer.CustomerCode);

                if (targetDiscounts.Count() == 0)
                {
                    row.Discount = 0;
                }
                else 
                {
                    row.Discount = targetDiscounts.Max(d => d.DiscountValue);
                }

                data.Add(row);
            }

            
            var pairs = new List<string>();
            foreach (var row in data) 
            {
                pairs.Add(row.MadeInCountry + "|" + row.Street);
            }

            dataGridView1.Rows.Clear();

            foreach (var pair in pairs.Distinct()) 
            {
                var targetCountry = pair.Split('|')[0];
                var targetStreet = pair.Split('|')[1];
                var targetDicount = data.Where(d => d.MadeInCountry == targetCountry).Where(d => d.Street == targetStreet).Max(d => d.Discount);

                dataGridView1.Rows.Add(targetCountry, targetStreet, targetDicount);
            }
            
            /*
            foreach (var row in data.OrderBy(d => d.MadeInCountry).ThenBy(d => d.Street)) 
            {
                dataGridView1.Rows.Add(row.MadeInCountry, row.Street, row.Discount);
            }
            */
        }
    }

    class Task3Data 
    {
        public string MadeInCountry;
        public string Street;
        public int Discount;
    }
}
