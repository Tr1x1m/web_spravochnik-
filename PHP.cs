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
    public partial class PHP : Form
    {
        public PHP()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PHP newForm1 = new PHP();
            newForm1.Close();
            Form1 newForm = new Form1();
            newForm.Show();
            
        }
    }
}
