using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "admin" && txtpassword.Text == "123")
            {
                this.Hide();
                MainForm main = new MainForm() ;
                main.Show();
            }
            else 
            {
                MessageBox.Show("you can enter password");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        { 
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {
            
        }
        

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
