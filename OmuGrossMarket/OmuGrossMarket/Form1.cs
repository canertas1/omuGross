using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OmuGrossMarket
{
    public partial class Form1 : Form
    {

        public static Form1 instance;
        
        public Form1()
        {
            InitializeComponent();
            instance= this;
          
        }

        public void refreshPage(DataGridView dataSource)
        {
            dataSource.Update();
            dataSource.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        omuGrossDataBaseEntities1 db = new omuGrossDataBaseEntities1();
        private void Btn_ListCustomer_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.musteri.ToList();
            
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;

        }

        private void Btn_AddCustomer_Click(object sender, EventArgs e)
        {
            musteri Customer = new musteri();
            Customer.ad = textName.Text;
            Customer.soyad = textSurname.Text;
            Customer.sifre = textPassword.Text;
            db.musteri.Add(Customer);
            db.SaveChanges();
            MessageBox.Show("Müşteri Eklenmiştir");
            refreshPage(dataGridView1);
        }

        private void Btn_DeleteCustomer_Click(object sender, EventArgs e)
        {  
            int id = Convert.ToInt32(textID.Text);
            var x = db.musteri.Find(id);
            db.musteri.Remove(x);
            db.SaveChanges();
            MessageBox.Show("Müşteri Silindi");
            refreshPage(dataGridView1);
        }

        private void Btn_UpdateCustomer_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textID.Text);
            var x = db.musteri.Find(id);
            x.ad = textName.Text;
            x.sifre = textPassword.Text;
            x.soyad = textSurname.Text;
            db.SaveChanges();
            MessageBox.Show("Müşteri Güncellendi");
            refreshPage(dataGridView1);
        }

        private void Btn_AddProduct_Click(object sender, EventArgs e)
        {
            urun Product= new urun();
            Product.urunAd = textName.Text;
            Product.urunFiyat = Convert.ToInt32(textPrice.Text);
            db.urun.Add(Product);
            db.SaveChanges();
            MessageBox.Show("Ürün eklenmiştir");
            String temp = Product.urunID.ToString();
            Product.barkodNo = Convert.ToInt32(String.Concat(temp, temp, temp));
            db.urun.AddOrUpdate(Product);
            db.SaveChanges();
            refreshPage(dataGridView1);
        }
        private void Btn_ListProduct_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource= db.urun.ToList();
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
        }

        private void Btn_DeleteProduct_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textID.Text);
            var x = db.urun.Find(id);
            db.urun.Remove(x);
            db.SaveChanges();
            MessageBox.Show("Ürün Silindi");
            refreshPage(dataGridView1);
        }

        private void Btn_UpdateProduct_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textID.Text);
            var x = db.urun.Find(id);
            x.urunAd = textName.Text;
            x.urunFiyat = Convert.ToInt32(textPrice.Text);
            db.SaveChanges();
            MessageBox.Show("Ürün Güncellendi");
            refreshPage(dataGridView1);
        }

        private void Btn_ListSuplier_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.tedarikci.ToList();
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[5].Visible = false;
        }

        private void Btn_AddSupplier_Click_1(object sender, EventArgs e)
        {
            tedarikci Supplier = new tedarikci();
            Supplier.ad = textName.Text;
            db.tedarikci.Add(Supplier);
            db.SaveChanges();
            MessageBox.Show("Tedarikçi kaydedildi");
            Btn_ListSuplier_Click(sender, e);
            refreshPage(dataGridView1);
        }

        private void Btn_DeleteSuplier_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textID.Text);
            var x = db.musteri.Find(id);
            db.musteri.Remove(x);
            db.SaveChanges();
            MessageBox.Show("Tedarikçi Silindi");
            refreshPage(dataGridView1);
        }

        private void Btn_UpdateSuplier_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textID.Text);
            var x = db.tedarikci.Find(id);
            x.ad = textName.Text;
            db.SaveChanges();
            MessageBox.Show("Tedarikçi Güncellendi");
            refreshPage(dataGridView1);
        }

        private void btn_Satış_Yap_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            
            form.ShowDialog();
            

        }
    }
}
