using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text != "") && (textBox2.Text != "") && (textBox2.Text != ""))
            {
                label6.ForeColor = Color.Black;
                double waga = Convert.ToDouble(textBox1.Text);
                double wzrost = Convert.ToDouble(textBox2.Text);
                int wiek = Convert.ToInt16(textBox3.Text);
                double bmr = (waga * 9.99) + (6.25 * wzrost) - (4.92 * wiek);

                if (radioButton1.Checked == true)
                {
                    bmr = bmr + 5;
                }
                if (radioButton2.Checked == true)
                {
                    bmr = bmr - 161;
                }
                label6.Text = bmr.ToString();

            }
            else
            {
                label6.ForeColor = Color.Red;
                label6.Text = "Brak danych";
            }

        }

        public void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox1.Text ="";
            textBox3.Text = "";
            label6.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }
    }

}