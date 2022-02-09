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
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class EditProductForm : Form
    {

        static string connection = @"server=localhost;userid=root;password=root;database=vosmerka1;charset=utf8";
        MySqlConnection connect = new MySqlConnection(connection);
        BindingSource productBindingSourse = new BindingSource();
        DataTable productTable = new DataTable();
        DataTable materialTable = new DataTable();

        //
        string idmaterial;


        public EditProductForm()
        {
            InitializeComponent();
        }

        private void EditProductForm_Load(object sender, EventArgs e)
        {
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

            // Настройка связывания для элементов:

            titleField.DataBindings.Add("Text", productBindingSourse, "Title");
            idField.DataBindings.Add("Text", productBindingSourse, "ID");
            typeproductcomboBox.DataBindings.Add("Text", productBindingSourse, "ProductTypeID"); // переделать
            articleField.DataBindings.Add("Text", productBindingSourse, "ArticleNumber");
            countPersonField.DataBindings.Add("Text", productBindingSourse, "ProductionPersonCount");
            numberWorkshopField.DataBindings.Add("Text", productBindingSourse, "ProductionWorkshopNumber");
            minCostForAgentField.DataBindings.Add("Text", productBindingSourse, "MinCostForAgent");
            descriptionField.DataBindings.Add("Text", productBindingSourse, "Description");

            imageFieldPictureBox.DataBindings.Add(new Binding("Image", productBindingSourse, "ImagePic", true));
            imageFieldPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            //


            // добавление всех материалов в выпадающий список
            MySqlCommand cmdMaterial = connect.CreateCommand();
            cmdMaterial.CommandText = "select title from material";
            MySqlDataReader myReader = cmdMaterial.ExecuteReader();
            while (myReader.Read())
            {
                comboBoxMaterial.Items.Add(myReader[0]);
            }
            connect.Close();

            //

            // Логика поведения данных при dobleclick по строке DataGridView

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
                typeproductcomboBox.Text = Info.ProductTypeID;
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
                minCostForAgentField.Text = Info.MinCostForAgent;
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



        }


        












        private void backProductButton_Click(object sender, EventArgs e)
        {
          productBindingSourse.MovePrevious();
        }

        private void forwardProductButton_Click(object sender, EventArgs e)
        {
            productBindingSourse.MoveNext();
        }

        private void idField_TextChanged(object sender, EventArgs e)
        {
            // Выбираем название и количество материалов для производства продукта

            if(idField.Text != ""){

            MySqlCommand cmdJoinProductMaterial = connect.CreateCommand();
            cmdJoinProductMaterial.CommandText = string.Format("select title,count from productmaterial inner join material on materialID = id where productid = '{0}'", idField.Text);

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

        private void addMaterialButton_Click(object sender, EventArgs e)
        {
            string newmaterial = comboBoxMaterial.SelectedItem.ToString();
            string newmaterialcount = countField.Text.ToString();
            materialTable.Rows.Add(newmaterial, newmaterialcount);

            // найти id материала

            string mysql = @"server=localhost;userid=root;password=root;database=vosmerka1;Character Set=utf8";
            MySqlConnection connect1 = new MySqlConnection(mysql);
            connect1.Open();

            try
            {

                MySqlCommand cmd = new MySqlCommand(string.Format("select id from material where Title = '{0}'",newmaterial), connect1);
                MySqlDataReader result1 = cmd.ExecuteReader();


                while (result1.Read())
                {
                   idmaterial = result1[0].ToString();
                }
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Ошибка: {0}",ex));
            }
            connect1.Close();

            // добавление записи в связующую таблицу productmaterial

            connect1.Open();
            MySqlCommand insertProductMaterial = connect1.CreateCommand();
            MySqlDataAdapter insertProductMaterialadapter = new MySqlDataAdapter(insertProductMaterial);

            try
            {
                insertProductMaterialadapter.InsertCommand = new MySqlCommand(string.Format("insert into productmaterial(ProductID,MaterialID,Count) values('{0}','{1}','{2}')",idField.Text,idmaterial,newmaterialcount), connect1);
                insertProductMaterialadapter.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Запись добавлена!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Ошибка: {0}",ex));
            }

            connect1.Close();
            dataGridViewMaterial.DataSource = materialTable;
        }

        private void searchMaterialButton_Click(object sender, EventArgs e)
        {
            int index = comboBoxMaterial.FindString(comboBoxMaterial.Text);
            comboBoxMaterial.SelectedIndex = index;
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            idField.Clear();
            titleField.Clear();
            articleField.Clear();
            numberWorkshopField.Clear();
            countField.Clear();
            countPersonField.Clear();
            minCostForAgentField.Clear();
            descriptionField.Clear();
            imageFieldPictureBox.Image = null;
            dataGridViewMaterial.DataSource = null;
            typeproductcomboBox.Text = "";
        }

        private void saveProductButton_Click(object sender, EventArgs e)
        {
              MySqlConnection connect = new MySqlConnection(connection);
            connect.Open();

            MySqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = "select * from product";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

            // Поиск по id
            //MySqlCommand searchCurrentArticle = connect.CreateCommand();
            //searchCurrentArticle.CommandText = string.Format("select count(*) from product where Title = '{titleField.Text}' and ArticleNumber = '{articleField.Text}' and MinCostForAgent = '{minCostField.Text.Replace(",", ".")}' and ProductionPersonCount = '{countPersonField.Text}' and ProductionWorkshopNumber = '{numberWorkshopField.Text}' and ProductTypeID = '{typeProductcomboBox.Text}' and Description = '{descriptionField.Text}'",   );
            

            if (idField.Text == "")
            {
                try
                {
                    adapter.InsertCommand = new MySqlCommand(string.Format("insert into product(Title,ArticleNumber,MinCostForAgent,ProductionPersonCount,ProductionWorkshopNumber,ProductTypeID) values('{0}','{1}','{2}','{3}','{4}','{5}')",titleField.Text,articleField.Text,minCostForAgentField.Text.Replace(",", "."),countPersonField.Text,numberWorkshopField.Text,typeproductcomboBox.Text), connect);
                    adapter.InsertCommand.ExecuteNonQuery();
                    LoadProductForm();
                    MessageBox.Show("Продукт сохранен в базу данных");
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    MessageBox.Show(string.Format("Ошибка MySQL сохранения: {0}",ex.Message));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("Ошибка сохранения: {0}",ex.Message));
                }
            }
            else
            {
                try
                {
                    adapter.UpdateCommand = new MySqlCommand(string.Format("update product set Title = '{0}', ArticleNumber = '{1}', MinCostForAgent = '{2}',ProductionPersonCount = '{3}',ProductionWorkshopNumber = '{4}',ProductTypeID = '{5}',Description = '{6}' where ID = '{7}'",titleField.Text,articleField.Text,minCostForAgentField.Text.Replace(",", "."),countPersonField.Text,numberWorkshopField.Text,typeproductcomboBox.Text,descriptionField.Text,idField.Text), connect);
                    adapter.UpdateCommand.ExecuteNonQuery();
                    MessageBox.Show("Продукт обновлен в базе данных");
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    MessageBox.Show(string.Format("Ошибка MySQL обновления: {0}"),ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("Ошибка обновления: {0}"),ex.Message);
                }
            }
            connect.Close();

            productBindingSourse.DataSource = productTable;

        }

        private void minCostForAgentField_Validating(object sender, CancelEventArgs e)
        {
            if (minCostForAgentField.Text == " ")
            {
                e.Cancel = false;
                MessageBox.Show("Цена не может быть пустой");

            }

            else
            {
                try
                {
                    double.Parse(minCostForAgentField.Text);
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
                if (double.Parse(minCostForAgentField.Text) < 0)
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

                    string mysql = @"server=localhost;userid=root;password=root;database=vosmerka1;Character Set=utf8";
                    MySqlConnection connect = new MySqlConnection(mysql);
                    connect.Open();
                    MySqlCommand findIdProduct = connect.CreateCommand();
                    MySqlDataAdapter findIdProductadapter = new MySqlDataAdapter(findIdProduct);
                    MySqlCommandBuilder sBuilder = new MySqlCommandBuilder(findIdProductadapter);

                    findIdProductadapter.UpdateCommand = new MySqlCommand(string.Format("update product set Image = 'products/{0}' where id = '{1}'",dlg.SafeFileName,idField.Text), connect);
                    findIdProductadapter.UpdateCommand.ExecuteNonQuery();
                    MessageBox.Show("Изображение обновлено в базе данных");
                    
                    findIdProductadapter.Update(productTable);
                    LoadProductForm();
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

            MySqlCommand detectSaleProductCmd = new MySqlCommand(string.Format("select * from productsale where ProductID = '{0}' limit 1",idField.Text), connect1);
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

                    adapter.DeleteCommand = new MySqlCommand(string.Format("delete from product where ID = {0}", idField.Text), connect1);
                    adapter.DeleteCommand.ExecuteNonQuery();

                    MessageBox.Show("Продукт удален из базы данных");

                    this.Hide();  // система переходи к списку продукции
                }
            }
        }


        public void LoadProductForm()
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

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void imageFieldPictureBox_Click(object sender, EventArgs e)
        {

        }




    }





}
