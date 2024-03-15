using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ekz
{
    public partial class RequestView : Form
    {
        public RequestView()
        {

            InitializeComponent();

            string connectionString = ("host=localhost; port=5432; username=postgres; password=11111; database=ekz");

            NpgsqlConnection connection;
            connection = new NpgsqlConnection(connectionString);
            connection.Open();

            string commGet = $"SELECT * FROM request";

            var command = new NpgsqlCommand(commGet, connection);
            NpgsqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
               

                dataGridView1.Rows.Add(reader.GetInt64(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetInt64(5), reader.GetString(6));
            }

            
        } 

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            User1 user1 = new User1();
            user1.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RequestView_Load(object sender, EventArgs e)
        {

        }
    }
}
