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
            dataGridView1.Rows.Add("Harry Potter", "J.K. Rowling", "Fantasy", 10);
            dataGridView1.Rows.Add("Atomic Habits", "James Clear", "Self Development", 5);
            dataGridView1.Rows.Add("The Hobbit", "J.R.R. Tolkien", "Fantasy", 7);
            dataGridView1.Rows.Add("Clean Code", "Robert C. Martin", "Programming", 3);
            dataGridView1.Rows.Add("ارض الزيكولا", " عمرو عبد الحميد", "Fiction", 15);
            dataGridView1.Rows.Add("فن اللامبلاه", "Mark Manson", "psychology", 9);
            dataGridView1.Rows.Add(" Cosmos", "Carl Sagan", "Science", 18);
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
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var row = dataGridView1.SelectedRows[0];

                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    txtName.Text = row.Cells[0].Value?.ToString();
                    txtAuthor.Text = row.Cells[1].Value?.ToString();
                    comboCategory.Text = row.Cells[2].Value?.ToString();
                    numCopies.Text = row.Cells[3].Value?.ToString();
                }
                else
                {
                    row.Cells[0].Value = txtName.Text;
                    row.Cells[1].Value = txtAuthor.Text;
                    row.Cells[2].Value = comboCategory.Text;
                    row.Cells[3].Value = numCopies.Text;


                    txtName.Clear();
                    txtAuthor.Clear();
                    comboCategory.SelectedIndex = -1;
                    numCopies.ClearSelected();
                    MessageBox.Show("Done");
                }
            }
            else
            {
                MessageBox.Show("Select Row");
            }
        }

        private void txtRemove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("   Select Row   ");
            }
        }

        private void comboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboCategory.DropDownStyle = ComboBoxStyle.DropDownList;

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
