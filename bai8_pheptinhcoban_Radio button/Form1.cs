using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai8_pheptinhcoban_Radio_button
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double so1 = double .Parse(txtso1.Text);
            double so2 = double.Parse(txtso2.Text);
             
            if (rdbcong.Checked)
                {
                txtkq.Text = (so1 + so2).ToString();
            }
            if (rdbtru.Checked)
            {
                txtkq.Text = (so1 - so2).ToString();
            }
            if (rdbnhan.Checked)
            {
                txtkq.Text = (so1 * so2).ToString();
            }
            if (rdbchia.Checked)
                if (so2 == 0)
                {
                    txtkq.Text = "loi chia o";
                }
                else
                {
                    txtkq.Text = (so1 / so2).ToString();
                }
        }
    }
}
