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
    public partial class Task5Table : Form
    {
        private SqlClient.SqlClient _client;

        private SqlClient.Repositories.ProductRepository _productRepository;
        private SqlClient.Repositories.PurchasesRepository _purchasesRepository;
        private SqlClient.Repositories.PriceRepository _priceRepository;

        public Task5Table(SqlClient.SqlClient client)
        {
            InitializeComponent();

            this._client = client;
            this._productRepository = new SqlClient.Repositories.ProductRepository(this._client);
            this._purchasesRepository = new SqlClient.Repositories.PurchasesRepository(this._client);
            this._priceRepository = new SqlClient.Repositories.PriceRepository(this._client);
        }

        private void Task5Table_Load(object sender, EventArgs e)
        {
            var data = new List<Task5Data>();

            var products = this._productRepository.GetProducts();
            var purchases = this._purchasesRepository.GetPurchases();
            var prices = this._priceRepository.GetPrices();

            foreach (var product in products) 
            {
                var row = new Task5Data();

                var sells = purchases.Where(p => p.ProductArticleNumber == product.ProductArticleNumber).Count();
                var price = prices.Where(p => p.ProductArticleNumber == product.ProductArticleNumber).First().PriceValue;

                row.ShopTitle = prices.Where(p => p.ProductArticleNumber == product.ProductArticleNumber).First().ShopTitle;
                row.ProductArticleNumber = product.ProductArticleNumber;
                row.Summary = sells * price;

                data.Add(row);
            }

            dataGridView1.Rows.Clear();

            foreach(var row in data.OrderBy(d => d.ShopTitle).ThenBy(d => d.ProductArticleNumber))
            {
                dataGridView1.Rows.Add(row.ShopTitle, row.ProductArticleNumber, row.Summary);
            }
        }
    }

    class Task5Data 
    {
        public string ShopTitle;
        public string ProductArticleNumber;
        public int Summary;
    }
}
