﻿using LinqToSql.SqlClient.Repositories;
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
    public partial class PurchasesEditor : Form
    {
        private PurchasesRepository _repository;

        public PurchasesEditor(PurchasesRepository repository)
        {
            InitializeComponent();

            this._repository = repository;

            dataGridView2.Rows.Add("Код потребителя");
            dataGridView2.Rows.Add("Артикул товара");
            dataGridView2.Rows.Add("Название магазина");

            dataGridView3.Rows.Add("Код потребителя");
            dataGridView3.Rows.Add("Артикул товара");
            dataGridView3.Rows.Add("Название магазина");
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            var data = _repository.GetPurchases();

            dataGridView1.Rows.Clear();

            foreach (var element in data) 
            {
                dataGridView1.Rows.Add(element.ID, element.CustomerCode, element.ProductArticleNumber, element.ShopTitle);
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

            var entity = new SqlClient.Entities.Purchase(
                    -1,
                    data[0],
                    data[1],
                    data[2]
                );

            this._repository.AddPurchase(entity);

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

            var purchase = this._repository.GetPurchaseById(id);

            if (purchase == null) 
            {
                MessageBox.Show("Пользователь не найден");
                return;
            }

            GetByIdBtn.Enabled = false;
            textBox1.Enabled = false;
            AcceptBtn.Enabled = true;

            dataGridView3.Rows[0].Cells["EditedValue"].Value = purchase.CustomerCode;
            dataGridView3.Rows[1].Cells["EditedValue"].Value = purchase.ProductArticleNumber;
            dataGridView3.Rows[2].Cells["EditedValue"].Value = purchase.ShopTitle;
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

            var entity = new SqlClient.Entities.Purchase(
                    Convert.ToInt32(textBox1.Text),
                    data[0],
                    data[1],
                    data[2]
                );

            this._repository.UpdatePurchase(entity);

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
            this._repository.DeletePurchase(id);
            textBox2.Text = "";
        }
    }
}
