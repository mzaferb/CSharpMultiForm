using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiFormSaitOrhan
{
    public partial class Form1 : Form
    {
        public int Id { get; set; }

        public Form1()
        {
            InitializeComponent();
            Id = 1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Transaction transactionAdd = new Transaction();
            DialogResult result = transactionAdd.ShowDialog();
            if (result == DialogResult.OK)
            {
                dataGridView1.Rows.Add(Id++, transactionAdd.Nm, transactionAdd.Srnm);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return;
            }

            DataGridViewRow row = dataGridView1.SelectedRows[0];

            Transaction transactionUpdate = new Transaction();
            transactionUpdate.Id = Convert.ToInt32(row.Cells[0].Value);
            transactionUpdate.Nm = row.Cells[1].Value.ToString();
            transactionUpdate.Srnm = row.Cells[2].Value.ToString();

            DialogResult result = transactionUpdate.ShowDialog();
            
            if (result != DialogResult.OK)
            {
                return;
            }

            row.Cells[1].Value = transactionUpdate.Nm;
            row.Cells[2].Value = transactionUpdate.Srnm;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }
            dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        //Form1/Properties/KeyPreview must be "True"
        {
            if (e.Control && e.KeyCode == Keys.D)
            {
                btnAdd_Click(null, null);
            }
            else if (e.Control && e.KeyCode == Keys.U)
            {
                btnUpdate_Click(null, null);
            }
            else if (e.Control && e.KeyCode == Keys.Delete)
            {
                btnDelete_Click(null, null);
            }
        }
    }
}
