using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace PESEL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                int[] a = new int[] { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3, 7, 9 };
                bool sprawdz = true;
                string wejscie = textBox1.Text;
                int dlugoscPesel = wejscie.Length;

                int razem = 0, wart = 0;
                for (int i = 0; i < dlugoscPesel; i++)
                {
                    wart = wart + (int.Parse(wejscie[i].ToString()) * a[i]);

                }

                int prawidlowy = wart % 10;

                if (prawidlowy == int.Parse(wejscie[wejscie.Length - 1].ToString())) sprawdz = true;
                else sprawdz = false;


                if (sprawdz)
                {
                    label2.ForeColor = Color.Green;
                    label2.Text = "Pesel prawidłowy";
                }
                else
                {
                    label2.ForeColor = Color.Red;
                    label2.Text = "Pesel nieprawidłowy";
                }
            }
            else
            {
                label2.ForeColor = Color.Red;
                label2.Text = "Brak danych";

            }

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            textBox1.Text = "";
        }
    }
}