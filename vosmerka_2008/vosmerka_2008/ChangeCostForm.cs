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

namespace WindowsFormsApplication1
{
    public partial class ChangeCostForm : Form
    {
        public ChangeCostForm()
        {
            InitializeComponent();
        }



        private void ChangeCostForm_Load(object sender, EventArgs e)
        {
            string connectionString = @"server=localhost;userid=root;password=root;database=vosmerka1;charset=utf8";

            string sql = "select round(avg(MinCostForAgent),2) from product";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand sCommand = new MySqlCommand(sql, connection);
            string result = sCommand.ExecuteScalar().ToString();
            textBoxChangeCost.Text = result.Replace(",", ".");
            connection.Close();
        }


        // Изменить стоимость

        private void changeCostButton_Click(object sender, EventArgs e)
        {
             string connectionString = @"server=localhost;userid=root;password=root;database=vosmerka1;charset=utf8";
            string sql = "select * from product";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            // Поиск старой цены

            string[] array = new string[Info.SelectedRowsArray.Length];
            int i = 0;
            foreach (string id1 in Info.SelectedRowsArray)
            {

                MySqlCommand oldCostCommand = new MySqlCommand(string.Format("select MinCostForAgent from product where id = {0}",id1), connection);
                MySqlDataAdapter oldCostadapter = new MySqlDataAdapter(oldCostCommand);
                string oldCostresult = oldCostCommand.ExecuteScalar().ToString();
                array[i] = oldCostresult;
                i = i + 1;
            }

            // Обновление цены в продуктах
            MySqlCommand sCommand = new MySqlCommand(sql, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(sCommand);

            foreach (string id in Info.SelectedRowsArray)
            {
                adapter.UpdateCommand = new MySqlCommand(string.Format("update product set MinCostForAgent = MinCostForAgent + '{0}' where id = '{1}'",textBoxChangeCost.Text.Replace(",", "."),id), connection);
                adapter.UpdateCommand.ExecuteNonQuery();
            }


            //

            MySqlCommand changeCostCommand = new MySqlCommand("select * from productchangecosthistory", connection);
            MySqlDataAdapter changeCostadapter = new MySqlDataAdapter(changeCostCommand);
            i = 0;

            foreach (string id in Info.SelectedRowsArray)
            {
                var newCost = Convert.ToDecimal(array[i].Replace(".", ",")) + Convert.ToDecimal(textBoxChangeCost.Text.Replace(".", ","));

                adapter.InsertCommand = new MySqlCommand(string.Format("insert into productchangecosthistory(product_id,old_cost,new_cost) values('{0}','{1}','{2}')", id, array[i].Replace(",", "."), newCost.ToString().Replace(",", ".")), connection);
                adapter.InsertCommand.ExecuteNonQuery();
                i = i + 1;
            }


            MessageBox.Show("Цена для агента обновлена в базе данных. История изменения записана!");
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
