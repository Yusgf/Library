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
    public partial class BorrowForm : Form
    {
        int borrowId = 1;
        public BorrowForm()
        {
            InitializeComponent();
        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string autoDate = DateTime.Now.ToShortDateString();
            UForm userForm = (UForm)Application.OpenForms["UForm"];
            if (userForm != null)
            {
                bool userFound = false;
                foreach (DataGridViewRow row in userForm.dgvUser.Rows)
                {
                    if (row.Cells[0].Value !=null && row.Cells[0].Value.ToString()==txtUserId.Text)
                    {
                        userFound = true;
                        int CurrentBorrow = Convert.ToInt32(row.Cells[3].Value);
                        row.Cells[3].Value = CurrentBorrow++;dgvBorrow.Rows.Add(borrowId,txtBookName.Text,txtUserId.Text,autoDate);
                        borrowId++;
                        MessageBox.Show("  Done  ");

                    }
                }
                if (!userFound)
                {
                    MessageBox.Show(" Not Found ID ");
                }
            }
            

        }
    }
}
