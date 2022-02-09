using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace vosmerka
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();        
        }

        // 
        private void loginButton_Click(object sender, EventArgs e)
        {
            string connectionString = @"server=localhost;userid=root;password=root;database=vosmerka;charset=utf8";
            string sql = "SELECT * FROM users";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                MySqlCommand userCommand = new MySqlCommand(sql, connection);
                MySqlDataReader reader = userCommand.ExecuteReader();

                while (reader.Read())
                {
                    if ((reader[1].ToString() == loginField.Text) && (reader[2].ToString() == passwordField.Text))
                    {

                        //ProductForm form = new ProductForm();
                        //form.Show();
                        //form.Closed += (s, args) => this.Close(); 
                        //this.Hide();

                        this.Hide();
                        ProductForm form = new ProductForm();
                        form.ShowDialog();
                        this.Close();


                    }
                    else
                    {
                        MessageBox.Show("Неправильный логин или пароль!");
                    }
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Ошибка: , {0}", ex.Message));
            }
            //this.Close();
            connection.Close();
        }
    }
}
