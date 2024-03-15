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
    public partial class Admin1 : Form
    {
        public Admin1()
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
                dataGridView1.Rows.Add(reader.GetInt64(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetInt64(5), reader.GetString(6), reader.GetString(7), reader.GetString(8));
            }
        }

        

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                string connectionString = ("host=localhost; port=5432; username=postgres; password=11111; database=ekz");

                NpgsqlConnection connection;
                connection = new NpgsqlConnection(connectionString);
                connection.Open();

                e.SuppressKeyPress = true;
                contextMenuStrip1.Close();
                int id = (int)dataGridView1.CurrentRow.Cells["id"].Value;

                NpgsqlCommand cmd = new NpgsqlCommand($"UPDATE ekz SET {dataGridView1.CurrentCell.OwningColumn.HeaderText} = '{toolStripTextBox1.Text}'" +
                    $"WHERE id = {id}");
                cmd.ExecuteNonQuery();
                toolStripTextBox1.Clear();
            }
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
           
                if (e.Button == MouseButtons.Right)
                {
                    dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    contextMenuStrip1.Show(Cursor.Position);
                }
            
        }
    }
}
