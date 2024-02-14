using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UyariMesaji1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUyariMesaji_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba,Hoşgeldin,Güle Güle","Bilgilendirme",MessageBoxButtons.RetryCancel,MessageBoxIcon.Information);
        }
    }
}
