using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace web_spravochnik
{
    public partial class BD : Form
    {
        public BD()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            BD newForm1 = new BD();
            newForm.Show();
            newForm1.Hide();
        }
    }
}
