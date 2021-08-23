using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có chắc muốn thoát không?",
                "Error", MessageBoxButtons.YesNoCancel);
            Application.Exit();
        }

        private void btnTieptuc_Click(object sender, EventArgs e)
        {
            txtDayvn.ResetText();
            txtNhapso.ResetText();
            txtTongchan.ResetText();
            txtTongle.ResetText();
            txtTongpt.ResetText();
         

          
            //{
            //    string x = "";
            //    int Tongchan = 0;
            //    int Tongday = 0;
            //    int Tongle = 0;
            //}

        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtNhapso.Text);
            txtDayvn.Text += x.ToString().Trim() + " ";
            int Tongday = 0;
            Tongday += x;
            txtTongpt.Text = Tongday.ToString();
            if( x%2==0)

            {
                int Tongchan = 0;
                Tongchan += x;
                txtTongchan.Text = Tongchan.ToString();

            }
            else
            {
                int Tongle = 0;
                Tongle += x;
                txtTongle.Text = Tongle.ToString();

            }    
        }
    }
}