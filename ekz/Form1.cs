using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ekz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;

            string connectionString = ("host=localhost; port=5432; username=postgres; password=11111; database=ekz");

            using(NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT role FROM users WHERE Login=@login AND Password=@password";

                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("Login", login);
                    command.Parameters.AddWithValue("Password", password);

                    string role = (string)command.ExecuteScalar();

                    if(role == null)
                    {
                        MessageBox.Show("Пользователь не найден");
                        return;
                    }

                    if(role == "admin")
                    {
                        //создать форму Админ
                        Admin1 admin1 = new Admin1();
                        admin1.Show();
                        this.Hide();
                    }

                    if(role == "manager")
                    {
                        //создать форму менеджера
                        Manager1 manager1 = new Manager1();
                        manager1.Show();
                        this.Hide();
                    }

                    else if (role == "user")
                    {
                        //создать форму юзера
                        User1 user1 = new User1();
                        user1.Show();
                        this.Hide();
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
