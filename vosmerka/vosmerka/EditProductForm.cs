using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace vosmerka
{
    public partial class EditProductForm : Form
    {

        static string connection = @"server=localhost;userid=root;password=root;database=vosmerka;charset=utf8";
        MySqlConnection connect = new MySqlConnection(connection);
        BindingSource productBindingSourse = new BindingSource();
        DataTable productTable = new DataTable();
        DataTable materialTable = new DataTable();

        string idmaterial;
        int CurrentRow;

        public EditProductForm()
        {
            InitializeComponent();
        }

        // Обработчик загрузки формы редактирования
        private void EditProductForm_Load(object sender, EventArgs e)
        {
            // Состояния

            idField.Enabled = false;

            //

            connect.Open();
            MySqlCommand cmd = connect.CreateCommand();

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            cmd.CommandText = "select * from product order by id desc";
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);

            // Добавляем столбец с изображением
            productTable = dataset.Tables[0];
            productTable.Columns.Add("ImagePic", Type.GetType("System.Byte[]"));

            foreach (DataRow row in productTable.Rows)
            {
                row["ImagePic"] = File.ReadAllBytes(row["Image"].ToString());
            }

            productBindingSourse.DataSource = productTable;



            // Настройка связывания для элементов TextBox:

            titleField.DataBindings.Add("Text", productBindingSourse, "Title");
            idField.DataBindings.Add("Text", productBindingSourse, "ID");
            typeProductcomboBox.DataBindings.Add("Text", productBindingSourse, "ProductTypeID"); // переделать
            articleField.DataBindings.Add("Text", productBindingSourse, "ArticleNumber");
            countPersonField.DataBindings.Add("Text", productBindingSourse, "ProductionPersonCount");
            numberWorkshopField.DataBindings.Add("Text", productBindingSourse, "ProductionWorkshopNumber");
            minCostField.DataBindings.Add("Text", productBindingSourse, "MinCostForAgent");
            descriptionField.DataBindings.Add("Text", productBindingSourse, "Description");


            imageFieldPictureBox.DataBindings.Add(new Binding("Image", productBindingSourse, "ImagePic", true));
            imageFieldPictureBox.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;


            // Логика поведения данных при doubleleclick по строке DataGridView

            if (Info.Title == null)
            {
                productBindingSourse.DataSource = productTable;
            }
            else
            {
                titleField.Text = Info.Title;
            };


            if (Info.ID != null)
            {
                idField.Text = Info.ID;
            }
            else
            {
                productBindingSourse.DataSource = productTable;
            };


            if (Info.ProductTypeID != null)
            {
                typeProductcomboBox.Text = Info.ProductTypeID;
            }
            else
            {
                productBindingSourse.DataSource = productTable;
            };


            if (Info.ArticleNumber != null)
            {
                articleField.Text = Info.ArticleNumber;
            }
            else
            {
                productBindingSourse.DataSource = productTable;
            };

            if (Info.ProductionWorkshopNumber != null)
            {
                numberWorkshopField.Text = Info.ProductionWorkshopNumber;
            }
            else
            {
                productBindingSourse.DataSource = productTable;
            };

            if (Info.ProductionPersonCount != null)

            {
               countPersonField.Text = Info.ProductionPersonCount;
            }
            else
            {
                productBindingSourse.DataSource = productTable;
            };

            if (Info.MinCostForAgent != null)
            {
                minCostField.Text = Info.MinCostForAgent;
            }
            else
            {
                productBindingSourse.DataSource = productTable;
            };

            if (Info.Description != null)
            {
                descriptionField.Text = Info.Description;
            }
            else
            {
                productBindingSourse.DataSource = productTable;
            }

            // добавление всех материалов в выпадающий список
            MySqlCommand cmdMaterial = connect.CreateCommand();
            cmdMaterial.CommandText = "select title from material";
            MySqlDataReader myReader = cmdMaterial.ExecuteReader();
            while (myReader.Read())
            {
                materialcomboBox.Items.Add(myReader[0]);
            }
            
            connect.Close();
        }

        // Load DataBinding
        public void LoadEditForm()
        {

            // Состояния

            idField.Enabled = false;

            //

            connect.Open();
            MySqlCommand cmd = connect.CreateCommand();

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            cmd.CommandText = "select * from product order by id desc";
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);

            // Добавляем столбец с изображением
            productTable = dataset.Tables[0];
            productTable.Columns.Add("ImagePic", Type.GetType("System.Byte[]"));

            foreach (DataRow row in productTable.Rows)
            {
                row["ImagePic"] = File.ReadAllBytes(row["Image"].ToString());
            }

            productBindingSourse.DataSource = productTable;
            imageFieldPictureBox.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;

            connect.Close();

        }

        // Назад
        private void backButton_Click(object sender, EventArgs e)
        {
            productBindingSourse.MovePrevious();
        }

        // Вперед
        private void moveButton_Click(object sender, EventArgs e)
        {
            productBindingSourse.MoveNext();
        }

        // Событие по изменению id в поле
        private void idField_TextChanged(object sender, EventArgs e)
        {

            if (idField.Text != "")
            {

            // Выбираем название и количество материалов для производства продукта

            MySqlCommand cmdJoinProductMaterial = connect.CreateCommand();
            cmdJoinProductMaterial.CommandText = $"select title,count from productmaterial inner join material on materialID = id where productid = {idField.Text}";

            MySqlDataAdapter material_adapter = new MySqlDataAdapter(cmdJoinProductMaterial);
            DataSet material_dataset = new DataSet();
            material_adapter.Fill(material_dataset);

            materialTable = material_dataset.Tables[0];
            dataGridViewMaterial.DataSource = materialTable;
            dataGridViewMaterial.Columns[0].HeaderText = "Материал";
            dataGridViewMaterial.Columns[0].Width = 200;
            dataGridViewMaterial.Columns[1].HeaderText = "Количество";

            }
        }

        // Добавление нового материала
        private void addMaterialButton_Click(object sender, EventArgs e)
        {
           
            string newmaterial = materialcomboBox.SelectedItem.ToString();
            string newmaterialcount = countMaterialField.Text.ToString();
            materialTable.Rows.Add(newmaterial, newmaterialcount);

            // найти id материала

            try
            {
                string mysql = @"server=localhost;userid=root;password=root;database=vosmerka;Character Set=utf8";
                MySqlConnection connect = new MySqlConnection(mysql);
                connect.Open();
                MySqlCommand cmd = new MySqlCommand($"select id from material where Title = '{newmaterial}'", connect);
                MySqlDataReader result1 = cmd.ExecuteReader();


                while (result1.Read())
                {
                   idmaterial = result1[0].ToString();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex}");
            }
            connect.Close();

            // добавление записи в связующую таблицу productmaterial

            connect.Open();
            MySqlCommand insertProductMaterial = connect.CreateCommand();
            MySqlDataAdapter insertProductMaterialadapter = new MySqlDataAdapter(insertProductMaterial);

            try
            {
                insertProductMaterialadapter.InsertCommand = new MySqlCommand($"insert into productmaterial(ProductID,MaterialID,Count) values('{idField.Text}','{idmaterial}','{newmaterialcount}')", connect);
                insertProductMaterialadapter.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Запись добавлена!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex}");
            }

            connect.Close();
            dataGridViewMaterial.DataSource = materialTable;

        }

        // Удаление материала 
        private void delMaterialButton_Click(object sender, EventArgs e)
        {

            try
            {
                if (MessageBox.Show("Вы действительно хотите удалить продукт?", "Удалить", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    string currentMaterial = materialTable.Rows[CurrentRow].ItemArray.GetValue(0).ToString();
                    materialTable.Rows[CurrentRow].Delete();

                    string mysql = @"server=localhost;userid=root;password=root;database=vosmerka;Character Set=utf8";
                    MySqlConnection connect = new MySqlConnection(mysql);
                    connect.Open();
                    MySqlCommand findIdMaterial = connect.CreateCommand();
                    MySqlDataAdapter findIdMaterialadapter = new MySqlDataAdapter(findIdMaterial);
                    MySqlCommandBuilder sBuilder = new MySqlCommandBuilder(findIdMaterialadapter);

                    MySqlCommand cmd = new MySqlCommand($"select id from material where Title = '{currentMaterial}'", connect);
                    string idmaterial = cmd.ExecuteScalar().ToString();


                    //
                    MySqlCommand delCommand = connect.CreateCommand();
                    MySqlDataAdapter deladapter = new MySqlDataAdapter(delCommand);
                    MySqlCommandBuilder delBuilder = new MySqlCommandBuilder(deladapter);

                    deladapter.DeleteCommand = new MySqlCommand($"delete from productmaterial where ProductID = '{idField.Text}' and MaterialID = '{idmaterial}'", connect);
                    deladapter.DeleteCommand.ExecuteNonQuery();
                    MessageBox.Show("Материал удален из состава продукта ");

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex}");
            }

        }

        // Действие по выбору строки в таблице материалов
        private void dataGridViewMaterial_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            CurrentRow = e.RowIndex;
        }

        // Поиск материала в списке материалов
        private void findMaterialButton_Click(object sender, EventArgs e)
        {
            int index = materialcomboBox.FindString(materialcomboBox.Text);
            materialcomboBox.SelectedIndex = index;
        }

        // Очистка полей для добавления
        private void addProductButton_Click(object sender, EventArgs e)
        {

            idField.Clear();
            titleField.Clear();
            articleField.Clear();
            numberWorkshopField.Clear();
            countMaterialField.Clear();
            countPersonField.Clear();
            minCostField.Clear();
            typeProductcomboBox.Text = " ";
            descriptionField.Clear();
            imageFieldPictureBox.Image = null;
            dataGridViewMaterial.DataSource = null;
        }

        // Сохранение и обновление продукта
        private void saveProductButton_Click(object sender, EventArgs e)
        {
            MySqlConnection connect = new MySqlConnection(connection);
            connect.Open();

            MySqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = "select * from product";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

            // Поиск по id
            MySqlCommand searchCurrentArticle = connect.CreateCommand();
            searchCurrentArticle.CommandText = $"select count(*) from product where Title = '{titleField.Text}' and ArticleNumber = '{articleField.Text}' and MinCostForAgent = '{minCostField.Text.Replace(",", ".")}' and ProductionPersonCount = '{countPersonField.Text}' and ProductionWorkshopNumber = '{numberWorkshopField.Text}' and ProductTypeID = '{typeProductcomboBox.Text}' and Description = '{descriptionField.Text}'";
            

            if (idField.Text == "")
            {
                try
                {
                    adapter.InsertCommand = new MySqlCommand($"insert into product(Title,ArticleNumber,MinCostForAgent,ProductionPersonCount,ProductionWorkshopNumber,ProductTypeID) values('{titleField.Text}',{articleField.Text},{minCostField.Text.Replace(",", ".")},{countPersonField.Text},{numberWorkshopField.Text},{typeProductcomboBox.Text})", connect);
                    adapter.InsertCommand.ExecuteNonQuery();
                    MessageBox.Show("Продукт сохранен в базу данных");
                    LoadEditForm();
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    MessageBox.Show($"Ошибка MySQL сохранения: {ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка сохранения: {ex.Message}");
                }
            }
            else
            {
                try
                {
                    adapter.UpdateCommand = new MySqlCommand($"update product set Title = '{titleField.Text}', ArticleNumber = '{articleField.Text}', MinCostForAgent = '{minCostField.Text.Replace(",", ".")}',ProductionPersonCount = '{countPersonField.Text}',ProductionWorkshopNumber = '{numberWorkshopField.Text}',ProductTypeID = '{typeProductcomboBox.Text}',Description = '{descriptionField.Text}' where ID = '{idField.Text}'", connect);
                    adapter.UpdateCommand.ExecuteNonQuery();
                    MessageBox.Show("Продукт обновлен в базе данных");
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    MessageBox.Show($"Ошибка MySQL обновления: {ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка обновления: {ex}");
                }
            }
            connect.Close();

            productBindingSourse.DataSource = productTable;
        }

        // Проверка поля стоимость
        private void minCostField_Validating(object sender, CancelEventArgs e)
        {
            if (minCostField.Text == " ")
            {
                e.Cancel = false;
                MessageBox.Show("Цена не может быть пустой");

            }

            else
            {
                try
                {
                    double.Parse(minCostField.Text);
                    e.Cancel = false;
                }
                catch
                {
                    e.Cancel = true;
                    MessageBox.Show("Поле не может содержать буквы");
                    e.Cancel = false;
                }
            };

            try
            {
                if (double.Parse(minCostField.Text) < 0)
                {
                    e.Cancel = true;
                    MessageBox.Show("Цена не может быть отрицательной");
                }
            }
            catch
            {
                MessageBox.Show("Цена должна состоять из цифр");
            }
        }

        // Добавление изображения
        private void addImageButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "png files (*.jpg)|*.jpg";
                dlg.InitialDirectory = "./";
                //dlg.FileName.Replace(@"\",@"/");
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    PictureBox PictureBox1 = new PictureBox();

                    // Create a new Bitmap object from the picture file on disk,
                    // and assign that to the PictureBox.Image property
                    PictureBox1.Image = new Bitmap(dlg.FileName);

                    string mysql = @"server=localhost;userid=root;password=root;database=vosmerka;Character Set=utf8";
                    MySqlConnection connect = new MySqlConnection(mysql);
                    connect.Open();
                    MySqlCommand findIdProduct = connect.CreateCommand();
                    MySqlDataAdapter findIdProductadapter = new MySqlDataAdapter(findIdProduct);
                    MySqlCommandBuilder sBuilder = new MySqlCommandBuilder(findIdProductadapter);

                    findIdProductadapter.UpdateCommand = new MySqlCommand($"update product set Image = 'products/{dlg.SafeFileName}' where id = '{idField.Text}'", connect);
                    findIdProductadapter.UpdateCommand.ExecuteNonQuery();
                    MessageBox.Show("Изображение обновлено в базе данных");
                    findIdProductadapter.Update(productTable);
                    LoadEditForm();
                }
            }
        }

        // Удаление продукта
        private void delProductButton_Click(object sender, EventArgs e)
        {

            MySqlConnection connect1 = new MySqlConnection(connection);
            connect1.Open();

            MySqlCommand cmd = connect1.CreateCommand();
            cmd.CommandText = "select * from product";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

            // Проверка возможности удаления продукта

            MySqlCommand detectSaleProductCmd = new MySqlCommand($"select * from productsale where ProductID = '{idField.Text}' limit 1", connect1);
            MySqlDataReader result1 = detectSaleProductCmd.ExecuteReader();

            if (result1.Read())
            {

                MessageBox.Show("Удаление запрещено! Есть данные о продажах продукта!");
                result1.Close();
                this.Hide();
            }
            else
            {
                result1.Close();
                if (MessageBox.Show("Вы действительно хотите удалить продукт?", "Удалить", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    adapter.DeleteCommand = new MySqlCommand($"delete from product where ID = {idField.Text}", connect1);
                    adapter.DeleteCommand.ExecuteNonQuery();

                    MessageBox.Show("Продукт удален из базы данных");

                    this.Hide();  // система переходит к списку продукции
                }
            }
        }

    }
}
