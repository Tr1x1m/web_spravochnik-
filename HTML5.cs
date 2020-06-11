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
    public partial class HTML5 : Form
    {
        public HTML5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HTML5 newForm1 = new HTML5();
            newForm1.Close();
            Form1 newForm = new Form1();
            newForm.Show();
        }
    }
}
