using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton1.Checked == true)
            {
                label1.Show();
                textBox1.Show();
            }
            else {
                label1.Hide();
                textBox1.Hide();
            }
            }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                label2.Show();
                textBox2.Show();
            }
            else {
                label2.Hide();
                textBox2.Hide();
            }
            }
    }
}
