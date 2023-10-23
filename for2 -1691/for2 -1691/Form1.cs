using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace for2__1691
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string sayilar = txtSayilar.Text;

            for (int i = 24; i < 76; i++)
            {
                lbSayilar.Items.Add(i);
            }
               
        }
    }
}
