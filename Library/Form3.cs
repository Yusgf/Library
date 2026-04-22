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
    public partial class BookForm : Form
    {
        public BookForm()
        {
            InitializeComponent();
        }

        private void BookForm_Load(object sender, EventArgs e)
        {

        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {if(txtName.Text.Any(Char.IsDigit)) {
                MessageBox.Show("The book's title cannot contain numbers ");
                return;   }
            if (txtAuthor.Text.Any(char.IsDigit))
            {
                MessageBox.Show("The author's title cannot contain numbers");
                return;
                
            }
           dataGridView1.Rows.Add(txtName.Text, txtAuthor.Text, comboCategory.Text, numCopies.Text);

        }

        private void Edit_Click(object sender, EventArgs e)
        {
            dataGridView1 = new DataGridView();
        }

        private void txtRemove_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtAuthor.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                        comboCategory.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                                    numCopies.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

        }

        private void comboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboCategory.DropDownStyle = ComboBoxStyle.DropDownList;

            
        }
    }
}
