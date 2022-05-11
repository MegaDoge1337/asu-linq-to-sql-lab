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
    public partial class Task61Table : Form
    {
        private SqlClient.SqlClient _client;
        private SqlClient.Repositories.ProductRepository _productRepository;
        private SqlClient.Repositories.PriceRepository _priceRepository;
        private SqlClient.Repositories.PurchasesRepository _purchasesRepository;

        public Task61Table(SqlClient.SqlClient client)
        {
            InitializeComponent();

            this._client = client;
            this._productRepository = new SqlClient.Repositories.ProductRepository(this._client);
            this._purchasesRepository = new SqlClient.Repositories.PurchasesRepository(this._client);
            this._priceRepository = new SqlClient.Repositories.PriceRepository(this._client);
        }

        private void Task61Table_Load(object sender, EventArgs e)
        {
            var products = this._productRepository.GetProducts();
            var prices = this._priceRepository.GetPrices();
            var purchases = this._purchasesRepository.GetPurchases();

            var pairs = new List<string>();

            foreach (var product in products) 
            {
                pairs.Add(prices.Where(p => p.ProductArticleNumber == product.ProductArticleNumber).First().ShopTitle + "@" + product.MadeInCountry);
            }

            foreach (var pair in pairs) 
            {
                var productsInCountry = products.Where(p => p.MadeInCountry == pair.Split('@')[1]);

            }
        }
    }

    class Task61Data 
    {
        public string ShopTitle;
        public string MadeInCountry;
        public int Summary;
    }
}
