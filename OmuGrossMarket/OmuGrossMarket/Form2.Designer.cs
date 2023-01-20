namespace OmuGrossMarket
{
    partial class Form2
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
            this.textProductID = new System.Windows.Forms.TextBox();
            this.textAmount = new System.Windows.Forms.TextBox();
            this.Btn_CostumerDebtList = new System.Windows.Forms.Button();
            this.textSuppID = new System.Windows.Forms.TextBox();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_RemoveFromBox = new System.Windows.Forms.Button();
            this.Btn_AddToBox = new System.Windows.Forms.Button();
            this.Btn_CostumerGetPayment = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Btn_AddToDepot = new System.Windows.Forms.Button();
            this.Btn_RemoveFromDepot = new System.Windows.Forms.Button();
            this.Btn_SupplierDebtList = new System.Windows.Forms.Button();
            this.Btn_SupplierGetPayment = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_ProductList = new System.Windows.Forms.Button();
            this.textCustomerID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(307, 1);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 206);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textProductID
            // 
            this.textProductID.Location = new System.Drawing.Point(137, 82);
            this.textProductID.Margin = new System.Windows.Forms.Padding(2);
            this.textProductID.Name = "textProductID";
            this.textProductID.Size = new System.Drawing.Size(115, 20);
            this.textProductID.TabIndex = 14;
            // 
            // textAmount
            // 
            this.textAmount.Location = new System.Drawing.Point(137, 131);
            this.textAmount.Margin = new System.Windows.Forms.Padding(2);
            this.textAmount.Name = "textAmount";
            this.textAmount.Size = new System.Drawing.Size(115, 20);
            this.textAmount.TabIndex = 16;
            // 
            // Btn_CostumerDebtList
            // 
            this.Btn_CostumerDebtList.Location = new System.Drawing.Point(61, 184);
            this.Btn_CostumerDebtList.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_CostumerDebtList.Name = "Btn_CostumerDebtList";
            this.Btn_CostumerDebtList.Size = new System.Drawing.Size(97, 30);
            this.Btn_CostumerDebtList.TabIndex = 17;
            this.Btn_CostumerDebtList.Text = "Borç Göster";
            this.Btn_CostumerDebtList.UseVisualStyleBackColor = true;
            // 
            // textSuppID
            // 
            this.textSuppID.Location = new System.Drawing.Point(137, 229);
            this.textSuppID.Margin = new System.Windows.Forms.Padding(2);
            this.textSuppID.Name = "textSuppID";
            this.textSuppID.Size = new System.Drawing.Size(115, 20);
            this.textSuppID.TabIndex = 19;
            // 
            // textPrice
            // 
            this.textPrice.Location = new System.Drawing.Point(137, 180);
            this.textPrice.Margin = new System.Windows.Forms.Padding(2);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(115, 20);
            this.textPrice.TabIndex = 20;
            this.textPrice.TextChanged += new System.EventHandler(this.textPrice_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_RemoveFromBox);
            this.groupBox1.Controls.Add(this.Btn_AddToBox);
            this.groupBox1.Controls.Add(this.Btn_CostumerDebtList);
            this.groupBox1.Controls.Add(this.Btn_CostumerGetPayment);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Location = new System.Drawing.Point(406, 221);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(218, 233);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri";
            // 
            // Btn_RemoveFromBox
            // 
            this.Btn_RemoveFromBox.Location = new System.Drawing.Point(61, 34);
            this.Btn_RemoveFromBox.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_RemoveFromBox.Name = "Btn_RemoveFromBox";
            this.Btn_RemoveFromBox.Size = new System.Drawing.Size(97, 30);
            this.Btn_RemoveFromBox.TabIndex = 27;
            this.Btn_RemoveFromBox.Text = "Sepetten Çıkar";
            this.Btn_RemoveFromBox.UseVisualStyleBackColor = true;
            this.Btn_RemoveFromBox.Click += new System.EventHandler(this.Btn_RemoveFromBox_Click);
            // 
            // Btn_AddToBox
            // 
            this.Btn_AddToBox.Location = new System.Drawing.Point(61, 84);
            this.Btn_AddToBox.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_AddToBox.Name = "Btn_AddToBox";
            this.Btn_AddToBox.Size = new System.Drawing.Size(97, 30);
            this.Btn_AddToBox.TabIndex = 26;
            this.Btn_AddToBox.Text = "Sepete Ekle";
            this.Btn_AddToBox.UseVisualStyleBackColor = true;
            this.Btn_AddToBox.Click += new System.EventHandler(this.Btn_AddToBox_Click);
            // 
            // Btn_CostumerGetPayment
            // 
            this.Btn_CostumerGetPayment.Location = new System.Drawing.Point(61, 134);
            this.Btn_CostumerGetPayment.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_CostumerGetPayment.Name = "Btn_CostumerGetPayment";
            this.Btn_CostumerGetPayment.Size = new System.Drawing.Size(97, 30);
            this.Btn_CostumerGetPayment.TabIndex = 25;
            this.Btn_CostumerGetPayment.Text = "Ödeme Al";
            this.Btn_CostumerGetPayment.UseVisualStyleBackColor = true;
            this.Btn_CostumerGetPayment.Click += new System.EventHandler(this.Btn_CostumerGetPayment_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox2.Controls.Add(this.Btn_AddToDepot);
            this.groupBox2.Controls.Add(this.Btn_RemoveFromDepot);
            this.groupBox2.Controls.Add(this.Btn_SupplierDebtList);
            this.groupBox2.Controls.Add(this.Btn_SupplierGetPayment);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Location = new System.Drawing.Point(736, 221);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(218, 233);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tedarikçi";
            // 
            // Btn_AddToDepot
            // 
            this.Btn_AddToDepot.Location = new System.Drawing.Point(64, 34);
            this.Btn_AddToDepot.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_AddToDepot.Name = "Btn_AddToDepot";
            this.Btn_AddToDepot.Size = new System.Drawing.Size(97, 30);
            this.Btn_AddToDepot.TabIndex = 31;
            this.Btn_AddToDepot.Text = "Depoya Ekle";
            this.Btn_AddToDepot.UseVisualStyleBackColor = true;
            this.Btn_AddToDepot.Click += new System.EventHandler(this.Btn_AddToDepot_Click);
            // 
            // Btn_RemoveFromDepot
            // 
            this.Btn_RemoveFromDepot.Location = new System.Drawing.Point(64, 84);
            this.Btn_RemoveFromDepot.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_RemoveFromDepot.Name = "Btn_RemoveFromDepot";
            this.Btn_RemoveFromDepot.Size = new System.Drawing.Size(97, 30);
            this.Btn_RemoveFromDepot.TabIndex = 30;
            this.Btn_RemoveFromDepot.Text = "Depodan Çıkar";
            this.Btn_RemoveFromDepot.UseVisualStyleBackColor = true;
            // 
            // Btn_SupplierDebtList
            // 
            this.Btn_SupplierDebtList.Location = new System.Drawing.Point(64, 184);
            this.Btn_SupplierDebtList.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_SupplierDebtList.Name = "Btn_SupplierDebtList";
            this.Btn_SupplierDebtList.Size = new System.Drawing.Size(97, 30);
            this.Btn_SupplierDebtList.TabIndex = 28;
            this.Btn_SupplierDebtList.Text = "Borç Göster";
            this.Btn_SupplierDebtList.UseVisualStyleBackColor = true;
            // 
            // Btn_SupplierGetPayment
            // 
            this.Btn_SupplierGetPayment.Location = new System.Drawing.Point(64, 134);
            this.Btn_SupplierGetPayment.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_SupplierGetPayment.Name = "Btn_SupplierGetPayment";
            this.Btn_SupplierGetPayment.Size = new System.Drawing.Size(97, 30);
            this.Btn_SupplierGetPayment.TabIndex = 29;
            this.Btn_SupplierGetPayment.Text = "Ödeme Al";
            this.Btn_SupplierGetPayment.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(33, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "Ürün ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(46, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Miktar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(0, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = "Tedarikçi ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(55, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 25);
            this.label4.TabIndex = 27;
            this.label4.Text = "Tutar:";
            // 
            // Btn_ProductList
            // 
            this.Btn_ProductList.Location = new System.Drawing.Point(1010, 211);
            this.Btn_ProductList.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_ProductList.Name = "Btn_ProductList";
            this.Btn_ProductList.Size = new System.Drawing.Size(97, 30);
            this.Btn_ProductList.TabIndex = 32;
            this.Btn_ProductList.Text = "Ürün Listesi";
            this.Btn_ProductList.UseVisualStyleBackColor = true;
            this.Btn_ProductList.Click += new System.EventHandler(this.Btn_ProductList_Click);
            // 
            // textCustomerID
            // 
            this.textCustomerID.Location = new System.Drawing.Point(137, 278);
            this.textCustomerID.Margin = new System.Windows.Forms.Padding(2);
            this.textCustomerID.Name = "textCustomerID";
            this.textCustomerID.Size = new System.Drawing.Size(115, 20);
            this.textCustomerID.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(8, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 25);
            this.label5.TabIndex = 34;
            this.label5.Text = "Müşteri ID:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1112, 464);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textCustomerID);
            this.Controls.Add(this.Btn_ProductList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textPrice);
            this.Controls.Add(this.textSuppID);
            this.Controls.Add(this.textAmount);
            this.Controls.Add(this.textProductID);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textProductID;
        private System.Windows.Forms.TextBox textAmount;
        private System.Windows.Forms.Button Btn_CostumerDebtList;
        private System.Windows.Forms.TextBox textSuppID;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Btn_RemoveFromBox;
        private System.Windows.Forms.Button Btn_AddToBox;
        private System.Windows.Forms.Button Btn_CostumerGetPayment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_AddToDepot;
        private System.Windows.Forms.Button Btn_RemoveFromDepot;
        private System.Windows.Forms.Button Btn_SupplierDebtList;
        private System.Windows.Forms.Button Btn_SupplierGetPayment;
        private System.Windows.Forms.Button Btn_ProductList;
        private System.Windows.Forms.TextBox textCustomerID;
        private System.Windows.Forms.Label label5;
    }
}