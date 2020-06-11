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
    public partial class CSS : Form
    {
        public CSS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CSS newForm1 = new CSS();
            newForm1.Close();
            Form1 newForm = new Form1();
            newForm.Show();
        }
    }
}
