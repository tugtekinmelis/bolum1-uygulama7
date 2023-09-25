using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bolum1_uygulama7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            lboxMeyveler.Items.Add(txtMeyve.Text);
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            lboxMeyveler.Items.Clear();
        }
    }
}
