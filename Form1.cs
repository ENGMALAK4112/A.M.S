using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace الآلة_الحاسبة2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void n0_TextChanged(object sender, EventArgs e)
        {
              n0.Text= display.Text;
            n0.Text="0";
            display.Text = n0.Text;
        }

        private void n9_TextChanged(object sender, EventArgs e)
        {
            display.Text = n9.Text;
            double n = Convert.ToDouble(n9.Text);
            n9.Text = (9).ToString();

        }

        private void point_TextChanged(object sender, EventArgs e)
        {

        }

        private void n1_TextChanged(object sender, EventArgs e)
        {

        }

        private void delete_TextChanged(object sender, EventArgs e)
        {
            display.Text = delete.Text;
            display.Clear();
        }

        private void n8_TextChanged(object sender, EventArgs e)
        {

        }

        private void n4_TextChanged(object sender, EventArgs e)
        {

        }

        private void sup_TextChanged(object sender, EventArgs e)
        {

        }

        private void n5_TextChanged(object sender, EventArgs e)
        {

        }

        private void n2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dive_TextChanged(object sender, EventArgs e)
        {

        }

        private void n7_TextChanged(object sender, EventArgs e)
        {

        }

        private void n6_TextChanged(object sender, EventArgs e)
        {

        }

        private void ac_TextChanged(object sender, EventArgs e)
        {
            display.Text = ac.Text;
            display.Hide();
        }

        private void n3_TextChanged(object sender, EventArgs e)
        {

        }

        private void sum_TextChanged(object sender, EventArgs e)
        {

        }

        private void multy_TextChanged(object sender, EventArgs e)
        {

        }

        private void equl_Click(object sender, EventArgs e)
        {

        }
    }
}
