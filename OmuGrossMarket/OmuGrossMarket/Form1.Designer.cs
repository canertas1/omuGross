namespace OmuGrossMarket
{
    partial class Form1
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
            this.Btn_AddCustomer = new System.Windows.Forms.Button();
            this.Btn_DeleteCustomer = new System.Windows.Forms.Button();
            this.Btn_ListCustomer = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Btn_ListProduct = new System.Windows.Forms.Button();
            this.Btn_UpdateProduct = new System.Windows.Forms.Button();
            this.Btn_DeleteProduct = new System.Windows.Forms.Button();
            this.Btn_AddProduct = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Btn_AddSupplier = new System.Windows.Forms.Button();
            this.Btn_ListSuplier = new System.Windows.Forms.Button();
            this.Btn_UpdateSuplier = new System.Windows.Forms.Button();
            this.Btn_DeleteSuplier = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.textSurname = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Btn_UpdateCustomer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(355, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1084, 242);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Btn_AddCustomer
            // 
            this.Btn_AddCustomer.Location = new System.Drawing.Point(29, 19);
            this.Btn_AddCustomer.Name = "Btn_AddCustomer";
            this.Btn_AddCustomer.Size = new System.Drawing.Size(133, 36);
            this.Btn_AddCustomer.TabIndex = 1;
            this.Btn_AddCustomer.Text = "Add";
            this.Btn_AddCustomer.UseVisualStyleBackColor = true;
            this.Btn_AddCustomer.Click += new System.EventHandler(this.Btn_AddCustomer_Click);
            // 
            // Btn_DeleteCustomer
            // 
            this.Btn_DeleteCustomer.Location = new System.Drawing.Point(29, 69);
            this.Btn_DeleteCustomer.Name = "Btn_DeleteCustomer";
            this.Btn_DeleteCustomer.Size = new System.Drawing.Size(133, 36);
            this.Btn_DeleteCustomer.TabIndex = 2;
            this.Btn_DeleteCustomer.Text = "Delete";
            this.Btn_DeleteCustomer.UseVisualStyleBackColor = true;
            this.Btn_DeleteCustomer.Click += new System.EventHandler(this.Btn_DeleteCustomer_Click);
            // 
            // Btn_ListCustomer
            // 
            this.Btn_ListCustomer.Location = new System.Drawing.Point(29, 169);
            this.Btn_ListCustomer.Name = "Btn_ListCustomer";
            this.Btn_ListCustomer.Size = new System.Drawing.Size(133, 36);
            this.Btn_ListCustomer.TabIndex = 4;
            this.Btn_ListCustomer.Text = "List";
            this.Btn_ListCustomer.UseVisualStyleBackColor = true;
            this.Btn_ListCustomer.Click += new System.EventHandler(this.Btn_ListCustomer_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_UpdateCustomer);
            this.groupBox1.Controls.Add(this.Btn_ListCustomer);
            this.groupBox1.Controls.Add(this.Btn_DeleteCustomer);
            this.groupBox1.Controls.Add(this.Btn_AddCustomer);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Location = new System.Drawing.Point(355, 268);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 211);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Costumer";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Btn_ListProduct);
            this.groupBox2.Controls.Add(this.Btn_UpdateProduct);
            this.groupBox2.Controls.Add(this.Btn_DeleteProduct);
            this.groupBox2.Controls.Add(this.Btn_AddProduct);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Location = new System.Drawing.Point(917, 268);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(190, 211);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product";
            // 
            // Btn_ListProduct
            // 
            this.Btn_ListProduct.Location = new System.Drawing.Point(28, 169);
            this.Btn_ListProduct.Name = "Btn_ListProduct";
            this.Btn_ListProduct.Size = new System.Drawing.Size(133, 36);
            this.Btn_ListProduct.TabIndex = 8;
            this.Btn_ListProduct.Text = "List";
            this.Btn_ListProduct.UseVisualStyleBackColor = true;
            this.Btn_ListProduct.Click += new System.EventHandler(this.Btn_ListProduct_Click);
            // 
            // Btn_UpdateProduct
            // 
            this.Btn_UpdateProduct.Location = new System.Drawing.Point(28, 119);
            this.Btn_UpdateProduct.Name = "Btn_UpdateProduct";
            this.Btn_UpdateProduct.Size = new System.Drawing.Size(133, 36);
            this.Btn_UpdateProduct.TabIndex = 7;
            this.Btn_UpdateProduct.Text = "Update";
            this.Btn_UpdateProduct.UseVisualStyleBackColor = true;
            this.Btn_UpdateProduct.Click += new System.EventHandler(this.Btn_UpdateProduct_Click);
            // 
            // Btn_DeleteProduct
            // 
            this.Btn_DeleteProduct.Location = new System.Drawing.Point(28, 69);
            this.Btn_DeleteProduct.Name = "Btn_DeleteProduct";
            this.Btn_DeleteProduct.Size = new System.Drawing.Size(133, 36);
            this.Btn_DeleteProduct.TabIndex = 6;
            this.Btn_DeleteProduct.Text = "Delete";
            this.Btn_DeleteProduct.UseVisualStyleBackColor = true;
            this.Btn_DeleteProduct.Click += new System.EventHandler(this.Btn_DeleteProduct_Click);
            // 
            // Btn_AddProduct
            // 
            this.Btn_AddProduct.Location = new System.Drawing.Point(28, 19);
            this.Btn_AddProduct.Name = "Btn_AddProduct";
            this.Btn_AddProduct.Size = new System.Drawing.Size(133, 36);
            this.Btn_AddProduct.TabIndex = 5;
            this.Btn_AddProduct.Text = "Add";
            this.Btn_AddProduct.UseVisualStyleBackColor = true;
            this.Btn_AddProduct.Click += new System.EventHandler(this.Btn_AddProduct_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Btn_AddSupplier);
            this.groupBox3.Controls.Add(this.Btn_ListSuplier);
            this.groupBox3.Controls.Add(this.Btn_UpdateSuplier);
            this.groupBox3.Controls.Add(this.Btn_DeleteSuplier);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Location = new System.Drawing.Point(636, 268);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(190, 211);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Suplier";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // Btn_AddSupplier
            // 
            this.Btn_AddSupplier.Location = new System.Drawing.Point(29, 19);
            this.Btn_AddSupplier.Name = "Btn_AddSupplier";
            this.Btn_AddSupplier.Size = new System.Drawing.Size(133, 36);
            this.Btn_AddSupplier.TabIndex = 26;
            this.Btn_AddSupplier.Text = "Add";
            this.Btn_AddSupplier.UseVisualStyleBackColor = true;
            this.Btn_AddSupplier.Click += new System.EventHandler(this.Btn_AddSupplier_Click_1);
            // 
            // Btn_ListSuplier
            // 
            this.Btn_ListSuplier.Location = new System.Drawing.Point(29, 169);
            this.Btn_ListSuplier.Name = "Btn_ListSuplier";
            this.Btn_ListSuplier.Size = new System.Drawing.Size(133, 36);
            this.Btn_ListSuplier.TabIndex = 8;
            this.Btn_ListSuplier.Text = "List";
            this.Btn_ListSuplier.UseVisualStyleBackColor = true;
            this.Btn_ListSuplier.Click += new System.EventHandler(this.Btn_ListSuplier_Click);
            // 
            // Btn_UpdateSuplier
            // 
            this.Btn_UpdateSuplier.Location = new System.Drawing.Point(29, 119);
            this.Btn_UpdateSuplier.Name = "Btn_UpdateSuplier";
            this.Btn_UpdateSuplier.Size = new System.Drawing.Size(133, 36);
            this.Btn_UpdateSuplier.TabIndex = 7;
            this.Btn_UpdateSuplier.Text = "Update";
            this.Btn_UpdateSuplier.UseVisualStyleBackColor = true;
            this.Btn_UpdateSuplier.Click += new System.EventHandler(this.Btn_UpdateSuplier_Click);
            // 
            // Btn_DeleteSuplier
            // 
            this.Btn_DeleteSuplier.Location = new System.Drawing.Point(29, 69);
            this.Btn_DeleteSuplier.Name = "Btn_DeleteSuplier";
            this.Btn_DeleteSuplier.Size = new System.Drawing.Size(133, 36);
            this.Btn_DeleteSuplier.TabIndex = 6;
            this.Btn_DeleteSuplier.Text = "Delete";
            this.Btn_DeleteSuplier.UseVisualStyleBackColor = true;
            this.Btn_DeleteSuplier.Click += new System.EventHandler(this.Btn_DeleteSuplier_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(86, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(50, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(12, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(20, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Surname:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(130, 14);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(100, 20);
            this.textID.TabIndex = 16;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(130, 52);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(100, 20);
            this.textName.TabIndex = 17;
            // 
            // textSurname
            // 
            this.textSurname.Location = new System.Drawing.Point(130, 90);
            this.textSurname.Name = "textSurname";
            this.textSurname.Size = new System.Drawing.Size(100, 20);
            this.textSurname.TabIndex = 18;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(130, 203);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 21;
            // 
            // textPrice
            // 
            this.textPrice.Location = new System.Drawing.Point(130, 165);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(100, 20);
            this.textPrice.TabIndex = 20;
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(130, 127);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(100, 20);
            this.textPassword.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(57, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "Price:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(60, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 25);
            this.label6.TabIndex = 23;
            this.label6.Text = "label:";
            // 
            // Btn_UpdateCustomer
            // 
            this.Btn_UpdateCustomer.Location = new System.Drawing.Point(29, 119);
            this.Btn_UpdateCustomer.Name = "Btn_UpdateCustomer";
            this.Btn_UpdateCustomer.Size = new System.Drawing.Size(133, 36);
            this.Btn_UpdateCustomer.TabIndex = 25;
            this.Btn_UpdateCustomer.Text = "Update";
            this.Btn_UpdateCustomer.UseVisualStyleBackColor = true;
            this.Btn_UpdateCustomer.Click += new System.EventHandler(this.Btn_UpdateCustomer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1484, 561);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textPrice);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textSurname);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "OmuGross Market";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Btn_AddCustomer;
        private System.Windows.Forms.Button Btn_DeleteCustomer;
        private System.Windows.Forms.Button Btn_ListCustomer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Btn_ListProduct;
        private System.Windows.Forms.Button Btn_UpdateProduct;
        private System.Windows.Forms.Button Btn_DeleteProduct;
        private System.Windows.Forms.Button Btn_AddProduct;
        private System.Windows.Forms.Button Btn_ListSuplier;
        private System.Windows.Forms.Button Btn_UpdateSuplier;
        private System.Windows.Forms.Button Btn_DeleteSuplier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textSurname;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Btn_AddSupplier;
        private System.Windows.Forms.Button Btn_UpdateCustomer;
    }
}

