using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace ekz
{
    public partial class User1 : Form
    {
        public User1()
        {
            InitializeComponent();

        }

        private void User1_Load(object sender, EventArgs e)
        {

        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            string user_name = textBoxFullName.Text;
            string device_type = textBoxType.Text;
            string device_name = textBoxDevName.Text;
            string problem = richTextBoxProblem.Text;
            string phone_number = textBoxPhoneNumber.Text;
           // string status = textBoxStatus.Text;

            string connectionString = ("host=localhost; port=5432; username=postgres; password=11111; database=ekz");

            try
            {

                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    string commAdd = $"INSERT INTO request (user_name, device_type, device_name, problem, phone_number, status) VALUES('{user_name}', '{device_type}', '{device_name}', '{problem}', '{phone_number}', 'В обработке')";

                    using (NpgsqlCommand command = new NpgsqlCommand(commAdd, connection))
                    {
                        command.Parameters.AddWithValue("user_name", user_name);
                        command.Parameters.AddWithValue("device_type", device_type);
                        command.Parameters.AddWithValue("device_name", device_name);
                        command.Parameters.AddWithValue("problem", problem);
                        command.Parameters.AddWithValue("phone_number", phone_number);
                        command.Parameters.AddWithValue("status", "В обработке");

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Успешно");
                        }
                        else
                        {
                            MessageBox.Show("Ошибка");
                        }
                    }
                } 
            }

            catch 
            {
                MessageBox.Show("Ошибка!@");
            }
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            RequestView requestView = new RequestView();
            requestView.Show();
            this.Hide();
        }
    }
}
