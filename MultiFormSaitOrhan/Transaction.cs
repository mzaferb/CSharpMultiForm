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
    public partial class Transaction : Form
    {
        public int Id { get; set; }

        public string Nm
        {
            get { return textBoxName.Text; }
            set { textBoxName.Text = value; }
        }

        public string Srnm
        {
            get { return textBoxSurname.Text; }
            set { textBoxSurname.Text = value; }
        }

        public Transaction()
        {
            InitializeComponent();
        }
    }
}
