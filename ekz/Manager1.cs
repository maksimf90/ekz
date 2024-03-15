using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ekz
{
    public partial class Manager1 : Form
    {
        public Manager1()
        {
            InitializeComponent();

            fillDataGridView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }


        //кнопка внесения
        private void buttonOk_Click(object sender, EventArgs e)
        {// Проверяем, есть ли выделенная строка в DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Получаем выделенную строку
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Получаем значения из выделенной строки
                string write_up = richTextBoxWrite_up.Text;
                string master = textBoxMaster.Text;
                int id = Convert.ToInt32(selectedRow.Cells["id"].Value);

                string connectionString = "host=localhost; port=5432; username=postgres; password=11111; database=ekz";

                try
                {
                    using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                    {
                        connection.Open();

                        string commAdd = "UPDATE request SET master=@master, write_up=@write_up, status='В работе' WHERE id=@id";

                        using (NpgsqlCommand command = new NpgsqlCommand(commAdd, connection))
                        {
                            
                            command.Parameters.AddWithValue("@write_up", write_up);
                            command.Parameters.AddWithValue("@master", master);
                            command.Parameters.AddWithValue("@id", id);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Успешно");
        
                            }

                            else
                            {
                                MessageBox.Show("Ошибка: запись не обновлена");
                            }
                        }
                        connection.Close();
                        fillDataGridView();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Выберите строку для обновления");
            }

           

        }

        //для обновления датагрида
        private void fillDataGridView()
        {
            string connectionString = ("host=localhost; port=5432; username=postgres; password=11111; database=ekz");

            NpgsqlConnection connection;
            connection = new NpgsqlConnection(connectionString);
            connection.Open();

            string commGet = $"SELECT * FROM request";

            var command = new NpgsqlCommand(commGet, connection);
            NpgsqlDataReader reader = command.ExecuteReader();


            dataGridView1.Rows.Clear();

            while (reader.Read())
            {
                string writeUp;
                if (reader.IsDBNull(7))
                {
                    writeUp = string.Empty; // Если значение NULL, устанавливаем пустую строку
                }
                else
                {
                    writeUp = reader.GetString(7); // Иначе читаем значение столбца
                }

                string master;
                if (reader.IsDBNull(8))
                {
                    master = string.Empty; // Если значение NULL, устанавливаем пустую строку
                }
                else
                {
                    master = reader.GetString(8); // Иначе читаем значение столбца
                }


                dataGridView1.Rows.Add(reader.GetInt64(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetInt64(5), reader.GetString(6), writeUp, master);
            }

        }

        private void Manager1_Load(object sender, EventArgs e)
        {

        }
    }
}


