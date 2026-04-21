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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void btnBook_Click(object sender, EventArgs e)
        {
            BookForm book = new BookForm();
            book.TopLevel = false;
            book.FormBorderStyle = FormBorderStyle.None;
            book.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(book);
            book.Show();

        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
          "Are you sure you want to logout?",
          "Confirm Logout",
          MessageBoxButtons.YesNo,
          MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                this.Close();
            }
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            UserForm Ueser = new UserForm();
            Ueser.TopLevel = false;
            Ueser.FormBorderStyle = FormBorderStyle.None;
            Ueser.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(Ueser);
            Ueser.Show();
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            BorrowForm Borrow = new BorrowForm();
            Borrow.TopLevel = false;
            Borrow.FormBorderStyle = FormBorderStyle.None;
            Borrow.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(Borrow);
            Borrow.Show();
        }
    }
}
