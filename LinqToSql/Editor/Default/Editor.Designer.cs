
namespace LinqToSql.Editor
{
    partial class Editor
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Select = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Insert = new System.Windows.Forms.TabPage();
            this.Update = new System.Windows.Forms.TabPage();
            this.Delete = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.InsertBtn = new System.Windows.Forms.Button();
            this.GetByIdBtn = new System.Windows.Forms.Button();
            this.AcceptBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.DeleteByIdBtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Select.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Insert.SuspendLayout();
            this.Update.SuspendLayout();
            this.Delete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Select);
            this.tabControl1.Controls.Add(this.Insert);
            this.tabControl1.Controls.Add(this.Update);
            this.tabControl1.Controls.Add(this.Delete);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(961, 576);
            this.tabControl1.TabIndex = 0;
            // 
            // Select
            // 
            this.Select.Controls.Add(this.dataGridView1);
            this.Select.Location = new System.Drawing.Point(4, 25);
            this.Select.Name = "Select";
            this.Select.Padding = new System.Windows.Forms.Padding(3);
            this.Select.Size = new System.Drawing.Size(953, 547);
            this.Select.TabIndex = 0;
            this.Select.Text = "Выборка";
            this.Select.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(953, 547);
            this.dataGridView1.TabIndex = 0;
            // 
            // Insert
            // 
            this.Insert.Controls.Add(this.InsertBtn);
            this.Insert.Controls.Add(this.dataGridView2);
            this.Insert.Location = new System.Drawing.Point(4, 25);
            this.Insert.Name = "Insert";
            this.Insert.Padding = new System.Windows.Forms.Padding(3);
            this.Insert.Size = new System.Drawing.Size(953, 547);
            this.Insert.TabIndex = 1;
            this.Insert.Text = "Вставка";
            this.Insert.UseVisualStyleBackColor = true;
            // 
            // Update
            // 
            this.Update.Controls.Add(this.dataGridView3);
            this.Update.Controls.Add(this.textBox1);
            this.Update.Controls.Add(this.AcceptBtn);
            this.Update.Controls.Add(this.GetByIdBtn);
            this.Update.Location = new System.Drawing.Point(4, 25);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(953, 547);
            this.Update.TabIndex = 2;
            this.Update.Text = "Редактирование";
            this.Update.UseVisualStyleBackColor = true;
            // 
            // Delete
            // 
            this.Delete.Controls.Add(this.DeleteByIdBtn);
            this.Delete.Controls.Add(this.textBox2);
            this.Delete.Location = new System.Drawing.Point(4, 25);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(953, 547);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "Удаление";
            this.Delete.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(953, 511);
            this.dataGridView2.TabIndex = 0;
            // 
            // InsertBtn
            // 
            this.InsertBtn.Location = new System.Drawing.Point(3, 517);
            this.InsertBtn.Name = "InsertBtn";
            this.InsertBtn.Size = new System.Drawing.Size(84, 27);
            this.InsertBtn.TabIndex = 1;
            this.InsertBtn.Text = "Вставить";
            this.InsertBtn.UseVisualStyleBackColor = true;
            // 
            // GetByIdBtn
            // 
            this.GetByIdBtn.Location = new System.Drawing.Point(3, 517);
            this.GetByIdBtn.Name = "GetByIdBtn";
            this.GetByIdBtn.Size = new System.Drawing.Size(149, 27);
            this.GetByIdBtn.TabIndex = 0;
            this.GetByIdBtn.Text = "Извлечь по ИД";
            this.GetByIdBtn.UseVisualStyleBackColor = true;
            // 
            // AcceptBtn
            // 
            this.AcceptBtn.Location = new System.Drawing.Point(872, 516);
            this.AcceptBtn.Name = "AcceptBtn";
            this.AcceptBtn.Size = new System.Drawing.Size(78, 28);
            this.AcceptBtn.TabIndex = 1;
            this.AcceptBtn.Text = "Принять";
            this.AcceptBtn.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(168, 519);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 2;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(0, 0);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(953, 510);
            this.dataGridView3.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(513, 268);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 0;
            // 
            // DeleteByIdBtn
            // 
            this.DeleteByIdBtn.Location = new System.Drawing.Point(378, 266);
            this.DeleteByIdBtn.Name = "DeleteByIdBtn";
            this.DeleteByIdBtn.Size = new System.Drawing.Size(129, 27);
            this.DeleteByIdBtn.TabIndex = 1;
            this.DeleteByIdBtn.Text = "Удалить по ИД";
            this.DeleteByIdBtn.UseVisualStyleBackColor = true;
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 600);
            this.Controls.Add(this.tabControl1);
            this.Name = "Editor";
            this.Text = "Редактор таблиц";
            this.tabControl1.ResumeLayout(false);
            this.Select.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Insert.ResumeLayout(false);
            this.Update.ResumeLayout(false);
            this.Update.PerformLayout();
            this.Delete.ResumeLayout(false);
            this.Delete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Select;
        private System.Windows.Forms.TabPage Insert;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage Update;
        private System.Windows.Forms.TabPage Delete;
        private System.Windows.Forms.Button InsertBtn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button AcceptBtn;
        private System.Windows.Forms.Button GetByIdBtn;
        private System.Windows.Forms.Button DeleteByIdBtn;
        private System.Windows.Forms.TextBox textBox2;
    }
}