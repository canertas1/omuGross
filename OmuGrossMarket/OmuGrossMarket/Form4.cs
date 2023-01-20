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
    public partial class Form4 : Form
    {
        public static Form4 instance;
        public Form4()
        {
            InitializeComponent();
            instance= this;
        }

        private void textUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Enter_Click(object sender, EventArgs e)
        {
            if ((textUserName.Text == "admin") && (textPassword.Text == "1234"))
            {
                instance.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!!");
            }
        }
    }
}
