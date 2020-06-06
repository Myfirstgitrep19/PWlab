using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=;password=;database=komis;";
            string query = "SELECT * FROM samochod";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();

                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    MessageBox.Show("Wczytano");
                    listBox1.Items.Clear();
                    listBox1.Items.Add("id; cena; kolor; marka; model; pojemnosc; rocznik");
                    listBox1.Items.Add(" ");
                    while (reader.Read())
                    {
                        
                        string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7) };
                        listBox1.Items.Add(row[0] + " " + row[1] + " " + row[2] + " " + row[3] + " " + row[4] + " " + row[5] +" " + row[6] + " " + row[7]);
                    }
                }
                else
                {
                    MessageBox.Show("Brak rekordów!");
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=komis;";
            string query = "SELECT * FROM samochod order by cena";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();

                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    MessageBox.Show("Wczytano");
                    listBox1.Items.Clear();
                    listBox1.Items.Add("id; cena; kolor; marka; model; pojemnosc; rocznik");
                    listBox1.Items.Add(" ");
                    while (reader.Read())
                    {
                        
                        string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7) };
                        listBox1.Items.Add(row[0] + " " + row[1] + " " + row[2] + " " + row[3] + " " + row[4] + " " + row[5] + " " + row[6] + " " + row[7]);
                    }
                }
                else
                {
                    MessageBox.Show("Brak rekordów!");
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dodaj okienko1 = new Dodaj();
            okienko1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Usun okienko2 = new Usun();
            okienko2.Show();
        }
    }
}
