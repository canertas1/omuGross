using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OmuGrossMarket
{
    public partial class Form2 : Form
    {

        public static Form2 instance;
        public Form2()
        {
            InitializeComponent();
            instance= this;
        }
        omuGrossDataBaseEntities1 db = new omuGrossDataBaseEntities1 ();

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void textPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void Btn_AddToDepot_Click(object sender, EventArgs e)
        {
            if (textSuppID.Text == "" || textAmount.Text == "" || textPrice.Text == "" || textProductID.Text == "")
            {
                dataGridView1.DataSource = db.irsaliye.ToList();
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Visible = false;
            }
            else {
                int Id = Convert.ToInt32(textProductID.Text);
                var product = db.urun.Find(Id);
                int Id2 = Convert.ToInt32(textSuppID.Text);
                var supplier = db.tedarikci.Find(Id2);
                irsaliye bill = new irsaliye();
                bill.tedarikciID = supplier.tedarikciID;
                bill.tedarikci = supplier;
                bill.urunGirdiMiktari = Convert.ToInt32(textAmount.Text);
                bill.urun = product;
                bill.urunFiyati = Convert.ToInt32(textPrice.Text);
                bill.urunID = product.urunID;
                bill.barkodNo = product.barkodNo;
                db.irsaliye.Add(bill);
                db.SaveChanges();
                var sorgu = from d1 in db.irsaliye
                            join d2 in db.tedarikci
                            on d1.tedarikciID equals d2.tedarikciID
                            join d3 in db.urun
                            on d1.urunID equals d3.urunID
                            select new
                            {
                                irsaliyeNo = d1.irsaliyeNo,
                                ürüngirdimiktarı = d1.urunGirdiMiktari,
                                ürünfiyatı = d1.urunFiyati,
                                tedarikciID = d2.ad,
                                urunID = d3.urunAd
                            };

                dataGridView1.DataSource = sorgu.ToList();
                //dataGridView1.Columns[6].Visible = false;
                //dataGridView1.Columns[7].Visible = false;
                db.SaveChanges();
            }
            
        }

        private void Btn_ProductList_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.urun.ToList();
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;

        }

        private void Btn_CostumerGetPayment_Click(object sender, EventArgs e)
        {
            if(textAmount.Text == "" || textCustomerID.Text == "")
            {
                dataGridView1.DataSource = db.musteriBorc.ToList();
            }
            else {
                int id = Convert.ToInt32(textCustomerID.Text);
                var customer = db.musteri.Find(id);
                musteriOdeme pay = new musteriOdeme();
                musteriBorc debt= new musteriBorc();
                pay.musteri = customer;
                pay.odemeMiktari = Convert.ToInt32(textAmount.Text);
                pay.odemeTarihi = DateTime.Now;
                debt.musteri = customer;
                debt.borcMiktari = debt.borcMiktari - Convert.ToInt32(textAmount.Text);
                db.musteriBorc.Add(debt);
                db.musteriOdeme.Add(pay);
                db.SaveChanges();
                dataGridView1.DataSource = db.musteriOdeme.ToList();
               
            }
        }

        List<urun> products = new List<urun>();
        private void Btn_AddToBox_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(textProductID.Text);
            var product = db.urun.Find(Id);
            products.Add(product);
            dataGridView1.DataSource= products.ToList();
        }

        private void Btn_RemoveFromBox_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.ShowDialog();
            int Id = Convert.ToInt32(textProductID.Text);
            var product = db.urun.Find(Id);
            products.Remove(product);
            dataGridView1.DataSource= products.ToList();
        }
    }
}
