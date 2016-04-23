using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// radioButton1_CheckedChanged - Фирма 
/// radioButton2_CheckedChanged - Работника
/// </summary>

namespace WindowsFormsApplication3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public List<Candidate> candidates = new List<Candidate>();  
        public List<Firm> firms = new List<Firm>();

        private void radioButton1_CheckedChanged(object sender, EventArgs e)    //// Фирма
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

        private void radioButton2_CheckedChanged(object sender, EventArgs e)  //// Работник
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

        private void button1_Click(object sender, EventArgs e)    //// Наша кнопка
        {
            if  (radioButton1.Checked)
                firms.Add(new Firm(textBox1.Text));
            else if (radioButton2.Checked)
                candidates.Add(new Candidate(textBox2.Text));

            textBox1.Clear();
            textBox2.Clear();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            //if (((radioButton2.Checked == true) ||  ((radioButton1.Checked == true))))

            for (int i = progressBar1.Minimum; i < progressBar1.Maximum; i++)
            {
                progressBar1.Value = i;
                System.Threading.Thread.Sleep(10);
            }
        }
    }
}
