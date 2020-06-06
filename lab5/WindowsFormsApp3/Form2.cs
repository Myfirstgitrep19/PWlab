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
    public partial class Dodaj : Form
    {
        public Dodaj()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=komis;";
            string query = "INSERT INTO samochod(marka,model,pojemnosc,kolor,cena) VALUES (?marka,?model,?pojemnosc,?kolor,?cena);";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
           // MySqlDataReader reader;

            try
            {
                databaseConnection.Open();

                //reader = commandDatabase.ExecuteReader();
                commandDatabase.Parameters.Add("?marka", MySqlDbType.VarChar).Value = textBox1.Text;
                commandDatabase.Parameters.Add("?model", MySqlDbType.VarChar).Value = textBox2.Text;
                commandDatabase.Parameters.Add("?pojemnosc", MySqlDbType.Int32).Value = Convert.ToInt32(textBox3.Text);
                commandDatabase.Parameters.Add("?kolor", MySqlDbType.VarChar).Value = textBox4.Text;
                commandDatabase.Parameters.Add("?cena", MySqlDbType.Int32).Value = Convert.ToInt32(textBox5.Text);
                commandDatabase.ExecuteNonQuery();

                MessageBox.Show("Dodano rekord : " + textBox1.Text+" " + textBox2.Text);

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
