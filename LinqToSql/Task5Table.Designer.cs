
namespace LinqToSql
{
    partial class Task5Table
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ShopTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductArticleNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Summary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ShopTitle,
            this.ProductArticleNumber,
            this.Summary});
            this.dataGridView1.Location = new System.Drawing.Point(1, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(798, 449);
            this.dataGridView1.TabIndex = 0;
            // 
            // ShopTitle
            // 
            this.ShopTitle.HeaderText = "Название магазина";
            this.ShopTitle.MinimumWidth = 6;
            this.ShopTitle.Name = "ShopTitle";
            this.ShopTitle.ReadOnly = true;
            // 
            // ProductArticleNumber
            // 
            this.ProductArticleNumber.HeaderText = "Артикул товара";
            this.ProductArticleNumber.MinimumWidth = 6;
            this.ProductArticleNumber.Name = "ProductArticleNumber";
            this.ProductArticleNumber.ReadOnly = true;
            // 
            // Summary
            // 
            this.Summary.HeaderText = "Суммарная стоимость продаж";
            this.Summary.MinimumWidth = 6;
            this.Summary.Name = "Summary";
            this.Summary.ReadOnly = true;
            // 
            // Task5Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Task5Table";
            this.Text = "Задание 5";
            this.Load += new System.EventHandler(this.Task5Table_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShopTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductArticleNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Summary;
    }
}