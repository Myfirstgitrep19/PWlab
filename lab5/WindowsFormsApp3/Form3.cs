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
    public partial class Usun : Form
    {
        public Usun()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=komis;";
            string query = "DELETE FROM samochod WHERE id=?id;";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            // MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                commandDatabase.Parameters.Add("?id", MySqlDbType.Int32).Value = Convert.ToInt32(textBox1.Text);
                commandDatabase.ExecuteNonQuery();

                MessageBox.Show("Usunięto "+ textBox1.Text+" rekord");

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Close();
        }
    }
}
