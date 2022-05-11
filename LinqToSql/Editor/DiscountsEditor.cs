using LinqToSql.SqlClient.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqToSql.Editor
{
    public partial class DiscountsEditor : Form
    {
        private DiscountRepository _repository;

        public DiscountsEditor(DiscountRepository repository)
        {
            InitializeComponent();

            this._repository = repository;

            dataGridView2.Rows.Add("Скидка (%)");
            dataGridView2.Rows.Add("Код потребителя");
            dataGridView2.Rows.Add("Название магазина");

            dataGridView3.Rows.Add("Скидка (%)");
            dataGridView3.Rows.Add("Код потребителя");
            dataGridView3.Rows.Add("Название магазина");

        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            var data = _repository.GetDiscounts();

            dataGridView1.Rows.Clear();

            foreach (var element in data) 
            {
                dataGridView1.Rows.Add(element.ID, element.DiscountValue, element.CustomerCode, element.ShopTitle);
            }
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            var data = new List<string>();

            foreach (DataGridViewRow row in dataGridView2.Rows) 
            {
                var value = row.Cells["Value"].Value.ToString();

                if (string.IsNullOrWhiteSpace(value)) 
                {
                    MessageBox.Show("Поля не должны быть пустыми");
                    return;
                }

                data.Add(value);
            }

            var entity = new SqlClient.Entities.Discount(
                    -1,
                    Convert.ToInt32(data[0]),
                    data[1],
                    data[2]
                );

            this._repository.AddDiscount(entity);

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                row.Cells["Value"].Value = null;
            }
        }

        private void GetByIdBtn_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(textBox1.Text);

            if (id < 0) 
            {
                MessageBox.Show("ИД не может быть отрицательным");
                return;
            }

            var discount = this._repository.GetDiscountById(id);

            if (discount == null) 
            {
                MessageBox.Show("Запись не найдена");
                return;
            }

            GetByIdBtn.Enabled = false;
            textBox1.Enabled = false;
            AcceptBtn.Enabled = true;

            dataGridView3.Rows[0].Cells["EditedValue"].Value = discount.DiscountValue.ToString();
            dataGridView3.Rows[1].Cells["EditedValue"].Value = discount.CustomerCode;
            dataGridView3.Rows[2].Cells["EditedValue"].Value = discount.ShopTitle;
        }

        private void AcceptBtn_Click(object sender, EventArgs e)
        {
            var data = new List<string>();

            foreach (DataGridViewRow row in dataGridView3.Rows)
            {
                var value = row.Cells["EditedValue"].Value.ToString();

                if (string.IsNullOrWhiteSpace(value))
                {
                    MessageBox.Show("Поля не должны быть пустыми");
                    return;
                }

                data.Add(value);
            }

            var entity = new SqlClient.Entities.Discount(
                    Convert.ToInt32(textBox1.Text),
                    Convert.ToInt32(data[0]),
                    data[1],
                    data[2]
                );

            this._repository.UpdateDiscount(entity);

            foreach (DataGridViewRow row in dataGridView3.Rows)
            {
                row.Cells["EditedValue"].Value = null;
            }

            AcceptBtn.Enabled = false;
            textBox1.Enabled = true;
            textBox1.Text = "";
            GetByIdBtn.Enabled = true;
        }

        private void DeleteByIdBtn_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(textBox2.Text);
            this._repository.DeleteDiscount(id);
            textBox2.Text = "";
        }
    }
}
