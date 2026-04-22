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
    public partial class UForm : Form
    {
        int currentId = 1;
        public UForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UForm_Load(object sender, EventArgs e)
        {
           

        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtUserName.Text) && !string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
            {
                dgvUser.Rows.Add(currentId, txtUserName.Text, txtPhoneNumber.Text, "0");
                currentId++;
                txtUserName.Clear();
                txtPhoneNumber.Clear();
            }
            else
            {
                MessageBox.Show("Enter Name or Number");

            }
            
        }

        private void SearchUser_Click(object sender, EventArgs e)
        {
            dgvUser.ClearSelection();
            dgvUser.CurrentCell = null;
            foreach (DataGridViewRow row in dgvUser.Rows)
            {

                if (!row.IsNewRow)
                {
                    
                        string idValue = row.Cells[0].Value?.ToString() ?? "";
                        string nameValue = row.Cells[1].Value?.ToString() ?? "";

                        if (idValue.Contains(txtSearch.Text) || nameValue.Contains(txtSearch.Text))
                        {
                            row.Visible = true;
                            if (idValue== txtSearch.Text)
                            {
                                row.Selected = true;
                                dgvUser.FirstDisplayedScrollingRowIndex = row.Index;
                            }
                        }

                        else
                        {
                            row.Visible = false;
                        }
                    
                }
                txtSearch.Clear();

        }   }

        private void C_TextChanged(object sender, EventArgs e)
        {

        }

        private void DeletUser_Click(object sender, EventArgs e)
        {
            if (dgvUser.SelectedRows.Count > 0)
            {
                dgvUser.Rows.RemoveAt(dgvUser.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("   Select Row   ");
            }
        }

        private void EditUser_Click(object sender, EventArgs e)
        {
            if (dgvUser.SelectedRows.Count > 0)
            {
                if (string.IsNullOrWhiteSpace(txtUserName.Text))
                {
                    txtUserName.Text = dgvUser.SelectedRows[0].Cells[1].Value.ToString();
                    txtPhoneNumber.Text = dgvUser.SelectedRows[0].Cells[2].Value.ToString();
                }
                else
                {
                    dgvUser.SelectedRows[0].Cells[1].Value = txtUserName.Text;
                    dgvUser.SelectedRows[0].Cells[2].Value = txtPhoneNumber.Text;
                    txtUserName.Clear();
                    txtPhoneNumber.Clear();
                    MessageBox.Show("Done");
                }
                
            }
            else
            {
                MessageBox.Show("Select Row");
            }
        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
