using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winbai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int tong;
            Console.WriteLine(txtA.Text);
            Console.WriteLine(txtB.Text);
            tong = int.Parse(txtA.Text)+ int.Parse(txtB.Text);
            lblKetQua.Text = tong + ""; 
        }

        private void btnHieu_Click(object sender, EventArgs e)
        {
            int tong;
            Console.WriteLine(txtA.Text);
            Console.WriteLine(txtB.Text);
            tong = int.Parse(txtA.Text) - int.Parse(txtB.Text);
            lblKetQua.Text = tong + "";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblKetQua.Text = " ";
            txtA.Text = "";
            txtB.Text = "";
        }
    }
}
