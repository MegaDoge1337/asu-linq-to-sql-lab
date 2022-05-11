
namespace LinqToSql
{
    partial class Menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.DbConnectionIndicartor = new System.Windows.Forms.Button();
            this.TablesBtns = new System.Windows.Forms.GroupBox();
            this.OpenPricesTableBtn = new System.Windows.Forms.Button();
            this.OpenPurchasesTableBtn = new System.Windows.Forms.Button();
            this.OpenProductsTableBtn = new System.Windows.Forms.Button();
            this.OpenDiscountsTableBtn = new System.Windows.Forms.Button();
            this.OpenCustomersTableBtn = new System.Windows.Forms.Button();
            this.OpenStudentsMarksTableBtn = new System.Windows.Forms.Button();
            this.Task1Btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Task5Btn = new System.Windows.Forms.Button();
            this.Task3Btn = new System.Windows.Forms.Button();
            this.Task22Btn = new System.Windows.Forms.Button();
            this.Task21Btn = new System.Windows.Forms.Button();
            this.TablesBtns.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DbConnectionIndicartor
            // 
            this.DbConnectionIndicartor.Enabled = false;
            this.DbConnectionIndicartor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DbConnectionIndicartor.ForeColor = System.Drawing.SystemColors.Window;
            this.DbConnectionIndicartor.Location = new System.Drawing.Point(12, 12);
            this.DbConnectionIndicartor.Name = "DbConnectionIndicartor";
            this.DbConnectionIndicartor.Size = new System.Drawing.Size(776, 39);
            this.DbConnectionIndicartor.TabIndex = 0;
            this.DbConnectionIndicartor.UseVisualStyleBackColor = true;
            // 
            // TablesBtns
            // 
            this.TablesBtns.Controls.Add(this.OpenPricesTableBtn);
            this.TablesBtns.Controls.Add(this.OpenPurchasesTableBtn);
            this.TablesBtns.Controls.Add(this.OpenProductsTableBtn);
            this.TablesBtns.Controls.Add(this.OpenDiscountsTableBtn);
            this.TablesBtns.Controls.Add(this.OpenCustomersTableBtn);
            this.TablesBtns.Controls.Add(this.OpenStudentsMarksTableBtn);
            this.TablesBtns.Location = new System.Drawing.Point(12, 57);
            this.TablesBtns.Name = "TablesBtns";
            this.TablesBtns.Size = new System.Drawing.Size(200, 381);
            this.TablesBtns.TabIndex = 1;
            this.TablesBtns.TabStop = false;
            this.TablesBtns.Text = "Таблицы";
            // 
            // OpenPricesTableBtn
            // 
            this.OpenPricesTableBtn.Location = new System.Drawing.Point(6, 201);
            this.OpenPricesTableBtn.Name = "OpenPricesTableBtn";
            this.OpenPricesTableBtn.Size = new System.Drawing.Size(188, 30);
            this.OpenPricesTableBtn.TabIndex = 7;
            this.OpenPricesTableBtn.Text = "Цены";
            this.OpenPricesTableBtn.UseVisualStyleBackColor = true;
            this.OpenPricesTableBtn.Click += new System.EventHandler(this.OpenPricesTableBtn_Click);
            // 
            // OpenPurchasesTableBtn
            // 
            this.OpenPurchasesTableBtn.Location = new System.Drawing.Point(6, 165);
            this.OpenPurchasesTableBtn.Name = "OpenPurchasesTableBtn";
            this.OpenPurchasesTableBtn.Size = new System.Drawing.Size(188, 30);
            this.OpenPurchasesTableBtn.TabIndex = 6;
            this.OpenPurchasesTableBtn.Text = "Покупки";
            this.OpenPurchasesTableBtn.UseVisualStyleBackColor = true;
            this.OpenPurchasesTableBtn.Click += new System.EventHandler(this.OpenPurchasesTableBtn_Click);
            // 
            // OpenProductsTableBtn
            // 
            this.OpenProductsTableBtn.Location = new System.Drawing.Point(6, 129);
            this.OpenProductsTableBtn.Name = "OpenProductsTableBtn";
            this.OpenProductsTableBtn.Size = new System.Drawing.Size(188, 30);
            this.OpenProductsTableBtn.TabIndex = 5;
            this.OpenProductsTableBtn.Text = "Товары";
            this.OpenProductsTableBtn.UseVisualStyleBackColor = true;
            this.OpenProductsTableBtn.Click += new System.EventHandler(this.OpenProductsTableBtn_Click);
            // 
            // OpenDiscountsTableBtn
            // 
            this.OpenDiscountsTableBtn.Location = new System.Drawing.Point(6, 93);
            this.OpenDiscountsTableBtn.Name = "OpenDiscountsTableBtn";
            this.OpenDiscountsTableBtn.Size = new System.Drawing.Size(188, 30);
            this.OpenDiscountsTableBtn.TabIndex = 4;
            this.OpenDiscountsTableBtn.Text = "Скидки";
            this.OpenDiscountsTableBtn.UseVisualStyleBackColor = true;
            this.OpenDiscountsTableBtn.Click += new System.EventHandler(this.OpenDiscountsTableBtn_Click);
            // 
            // OpenCustomersTableBtn
            // 
            this.OpenCustomersTableBtn.Location = new System.Drawing.Point(6, 57);
            this.OpenCustomersTableBtn.Name = "OpenCustomersTableBtn";
            this.OpenCustomersTableBtn.Size = new System.Drawing.Size(188, 30);
            this.OpenCustomersTableBtn.TabIndex = 3;
            this.OpenCustomersTableBtn.Text = "Покупатели";
            this.OpenCustomersTableBtn.UseVisualStyleBackColor = true;
            this.OpenCustomersTableBtn.Click += new System.EventHandler(this.OpenCustomersTableBtn_Click);
            // 
            // OpenStudentsMarksTableBtn
            // 
            this.OpenStudentsMarksTableBtn.Location = new System.Drawing.Point(6, 21);
            this.OpenStudentsMarksTableBtn.Name = "OpenStudentsMarksTableBtn";
            this.OpenStudentsMarksTableBtn.Size = new System.Drawing.Size(188, 30);
            this.OpenStudentsMarksTableBtn.TabIndex = 2;
            this.OpenStudentsMarksTableBtn.Text = "Оценки учащихся";
            this.OpenStudentsMarksTableBtn.UseVisualStyleBackColor = true;
            this.OpenStudentsMarksTableBtn.Click += new System.EventHandler(this.OpenStudentsMarksTableBtn_Click);
            // 
            // Task1Btn
            // 
            this.Task1Btn.Location = new System.Drawing.Point(6, 20);
            this.Task1Btn.Name = "Task1Btn";
            this.Task1Btn.Size = new System.Drawing.Size(87, 31);
            this.Task1Btn.TabIndex = 2;
            this.Task1Btn.Text = "1";
            this.Task1Btn.UseVisualStyleBackColor = true;
            this.Task1Btn.Click += new System.EventHandler(this.Task1Btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Task5Btn);
            this.groupBox1.Controls.Add(this.Task3Btn);
            this.groupBox1.Controls.Add(this.Task22Btn);
            this.groupBox1.Controls.Add(this.Task21Btn);
            this.groupBox1.Controls.Add(this.Task1Btn);
            this.groupBox1.Location = new System.Drawing.Point(218, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(570, 381);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Задания";
            // 
            // Task5Btn
            // 
            this.Task5Btn.Location = new System.Drawing.Point(6, 131);
            this.Task5Btn.Name = "Task5Btn";
            this.Task5Btn.Size = new System.Drawing.Size(87, 31);
            this.Task5Btn.TabIndex = 6;
            this.Task5Btn.Text = "5";
            this.Task5Btn.UseVisualStyleBackColor = true;
            this.Task5Btn.Click += new System.EventHandler(this.Task5Btn_Click);
            // 
            // Task3Btn
            // 
            this.Task3Btn.Location = new System.Drawing.Point(6, 94);
            this.Task3Btn.Name = "Task3Btn";
            this.Task3Btn.Size = new System.Drawing.Size(87, 31);
            this.Task3Btn.TabIndex = 5;
            this.Task3Btn.Text = "3";
            this.Task3Btn.UseVisualStyleBackColor = true;
            this.Task3Btn.Click += new System.EventHandler(this.Task3Btn_Click);
            // 
            // Task22Btn
            // 
            this.Task22Btn.Location = new System.Drawing.Point(99, 57);
            this.Task22Btn.Name = "Task22Btn";
            this.Task22Btn.Size = new System.Drawing.Size(87, 31);
            this.Task22Btn.TabIndex = 4;
            this.Task22Btn.Text = "2.2";
            this.Task22Btn.UseVisualStyleBackColor = true;
            this.Task22Btn.Click += new System.EventHandler(this.Task22Btn_Click);
            // 
            // Task21Btn
            // 
            this.Task21Btn.Location = new System.Drawing.Point(6, 57);
            this.Task21Btn.Name = "Task21Btn";
            this.Task21Btn.Size = new System.Drawing.Size(87, 31);
            this.Task21Btn.TabIndex = 3;
            this.Task21Btn.Text = "2.1";
            this.Task21Btn.UseVisualStyleBackColor = true;
            this.Task21Btn.Click += new System.EventHandler(this.Task21Btn_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TablesBtns);
            this.Controls.Add(this.DbConnectionIndicartor);
            this.Name = "Menu";
            this.Text = "Меню";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TablesBtns.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DbConnectionIndicartor;
        private System.Windows.Forms.GroupBox TablesBtns;
        private System.Windows.Forms.Button OpenStudentsMarksTableBtn;
        private System.Windows.Forms.Button Task1Btn;
        private System.Windows.Forms.Button OpenCustomersTableBtn;
        private System.Windows.Forms.Button OpenDiscountsTableBtn;
        private System.Windows.Forms.Button OpenProductsTableBtn;
        private System.Windows.Forms.Button OpenPurchasesTableBtn;
        private System.Windows.Forms.Button OpenPricesTableBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Task21Btn;
        private System.Windows.Forms.Button Task22Btn;
        private System.Windows.Forms.Button Task5Btn;
        private System.Windows.Forms.Button Task3Btn;
    }
}

