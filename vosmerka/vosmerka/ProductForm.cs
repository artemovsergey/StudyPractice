using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using MinCostLibrary;

namespace vosmerka
{
    public partial class ProductForm : Form
    {

        MySqlCommand productCommand;
        MySqlDataAdapter productAdapter;
        DataSet productDataset;
        DataTable productTable;
        int scrollVal;
        DataView productDataView;
        string connectionString = @"server=localhost;userid=root;password=root;database=vosmerka;charset=utf8";

        public ProductForm()
        {
            InitializeComponent();
            scrollVal = 0;
            this.dataGridViewProduct.AllowUserToAddRows = false;
            this.dataGridViewProduct.RowTemplate.Height = 100;
            changeCostButton.Visible = false;
            Info.ProductForm = this;
        }


        // Загрузка формы
        private void ProductForm_Load(object sender, EventArgs e)
        {

            string connectionString = @"server=localhost;userid=root;password=root;database=vosmerka;charset=utf8";
            string sql = "SELECT * FROM product";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                productCommand = new MySqlCommand(sql, connection);
                productAdapter = new MySqlDataAdapter(productCommand);
                productDataset = new DataSet();
                productAdapter.Fill(productDataset,scrollVal,20, "product");
                scrollVal = 20;
                productTable = productDataset.Tables["product"];

                productTable.Columns.Add("ImagePic", Type.GetType("System.Byte[]"));
                productTable.Columns.Add("Materials");
                productTable.Columns.Add("Cost");


                foreach (DataRow row in productTable.Rows)
                {
                    row["ImagePic"] = File.ReadAllBytes(row["Image"].ToString());
                }

                dataGridViewProduct.DataSource = productTable;
                //MessageBox.Show("Успешное соединение с базой данных!");
                connection.Close();
            }
            catch
            {
                MessageBox.Show("Нет соединения с базой данных!");
            }

            // Название столбцов в DataGridView

            dataGridViewProduct.Columns[0].HeaderText = "id";
            dataGridViewProduct.Columns[1].HeaderText = "Название";
            dataGridViewProduct.Columns[2].HeaderText = "Тип продукта";
            dataGridViewProduct.Columns[3].HeaderText = "Артикль";
            dataGridViewProduct.Columns[4].HeaderText = "Описание";
            dataGridViewProduct.Columns[5].HeaderText = "Путь к изображению";
            dataGridViewProduct.Columns[6].HeaderText = "Количество человек для производства";
            dataGridViewProduct.Columns[7].HeaderText = "Номер производственного цеха";
            dataGridViewProduct.Columns[8].HeaderText = "Минимальная стоимость для агента";
            dataGridViewProduct.Columns[9].HeaderText = "Изображение";
            dataGridViewProduct.Columns[10].HeaderText = "Материалы";
            dataGridViewProduct.Columns[11].HeaderText = "Стоимость";

            dataGridViewProduct.ReadOnly = true;

            // Изменение отображения картинке в столбце
            
            DataGridViewColumn column = dataGridViewProduct.Columns[9];
            ((DataGridViewImageColumn)dataGridViewProduct.Columns[9]).ImageLayout = DataGridViewImageCellLayout.Zoom;

            // Находим материалы и считаем стоимость

            dataGridViewProduct.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            foreach (DataRow row in productTable.Rows)
            {

                MySqlConnection connect = new MySqlConnection(connectionString);
                connect.Open();
                MySqlCommand cmdFindMaterials = connect.CreateCommand();
                cmdFindMaterials.CommandText = $"select material.title,productmaterial.count,material.cost from productmaterial join material on productmaterial.materialid = material.id where ProductID = {row["ID"]}";
                MySqlDataReader MaterialsReader = cmdFindMaterials.ExecuteReader();

                decimal sum = 0;
                while (MaterialsReader.Read())
                {
                    row["Materials"] = row["Materials"] + MaterialsReader[0].ToString() + Environment.NewLine;
                    row["Cost"] = sum + (Convert.ToDecimal(MaterialsReader[1]) * Convert.ToDecimal(MaterialsReader[2]));
                    sum = (Convert.ToDecimal(MaterialsReader[1]) * Convert.ToDecimal(MaterialsReader[2]));
                }

                connect.Close();
            }

            dataGridViewProduct.DataSource = productTable;


            // Показывать кнопки навигации, если в базе данных более 20 продуктов

            MySqlConnection connectCount = new MySqlConnection(connectionString);
            connectCount.Open();
            MySqlCommand CountCmd = new MySqlCommand("SELECT count(*) FROM product", connectCount);
            int count = Convert.ToInt32(CountCmd.ExecuteScalar());
            
            if (count < 20)
            {
                previosPageButton.Visible = forwardPageButton.Visible = backPageButton.Visible = endPageButton.Visible = false;
                page1Button.Visible = page2Button.Visible = page3Button.Visible = page4Button.Visible = page5Button.Visible = false;
            }
            connectCount.Close();
            
            dataGridViewProduct.Refresh();

            // Добавление элементов в выпадающий список

            comboBoxSort.Items.Add("Название (по возрастанию)");
            comboBoxSort.Items.Add("Название (по убыванию)");
            comboBoxSort.Items.Add("Номер цеха (по возрастанию)");
            comboBoxSort.Items.Add("Номер цеха (по убыванию)");
            comboBoxSort.Items.Add("Мин. стоимость для агента (по возрастанию)");
            comboBoxSort.Items.Add("Мин. стоимость для агента (по убыванию)");

            // Добавление элементов в выпадающий список для фильтрации

            comboBoxFilter.Items.Add("Все типы");
            comboBoxFilter.Items.Add("Колесо");
            comboBoxFilter.Items.Add("Шина");
            comboBoxFilter.Items.Add("Запаска");
            comboBoxFilter.Items.Add("Диск");

            // Подсветить продукты, которые не продавались в течении месяца

            var listOfStrings = new List<string>();

            connection.Open();
            MySqlCommand cmdFindProductSale = connection.CreateCommand();
            cmdFindProductSale.CommandText = "select ProductId from productsale where SaleDate not between DATE_ADD(current_date(), INTERVAL -2 MONTH) and current_date()";
            MySqlDataReader myReader = cmdFindProductSale.ExecuteReader();

            int i = 0;
            while (myReader.Read())
            {
                listOfStrings.Add(myReader[0].ToString());
                i = i + 1;
            }

            //

            foreach (DataGridViewRow row in dataGridViewProduct.Rows)
            {
                if (listOfStrings.Contains(row.Cells[0].Value.ToString()))
                {
                    dataGridViewProduct.Rows[row.Index].DefaultCellStyle.BackColor = Color.PaleVioletRed;
                };
            }
            connection.Close();


            //

            maxMinCostLabel.Text = $"Максимальная цена: {MinCost.MaxCostProduct().ToString()}";




        }

        // Выводит по pageCount страниц, начиная с pageStart по направлению stream или без направления
        public void ShowPage(int pageStart, int pageCount, string stream = " ")

        {

            if (stream == "+")
            {
                scrollVal = scrollVal + pageCount;
                if (scrollVal > 100)
                {
                    scrollVal = 100;
                }
            }

            if (stream == "-")
            {
                scrollVal = scrollVal - pageCount;
                if (scrollVal <= 0)
                {
                    scrollVal = 0;
                }
            }

            
            DataSet productSet = new DataSet();

            productAdapter.Fill(productSet, pageStart, pageCount, "product");
            

            productTable = productSet.Tables["product"];
            
            productTable.Columns[0].ColumnName = "id";
            productTable.Columns[1].ColumnName = "Title";
            productTable.Columns[2].ColumnName = "ProductTypeID";
            productTable.Columns[3].ColumnName = "ArticleNumber";
            productTable.Columns[4].ColumnName = "Description";
            productTable.Columns[5].ColumnName = "Image";
            productTable.Columns[6].ColumnName = "ProductionPersonCount";
            productTable.Columns[7].ColumnName = "ProductionWorkshopNumber";
            productTable.Columns[8].ColumnName = "MinCostForAgent";

            dataGridViewProduct.DataSource = productTable;

          
        }

        // Вперед
        private void forwardPageButton_Click(object sender, EventArgs e)
        {
            ShowPage(scrollVal, 20, "+");
        }

        // Назад
        private void backPageButton_Click(object sender, EventArgs e)
        {
            ShowPage(scrollVal, 20, "-");
        }

        // Первые
        private void previosPageButton_Click(object sender, EventArgs e)
        {
            ShowPage(0, 20);
        }

        // Последние
        private void endPageButton_Click(object sender, EventArgs e)
        {
            ShowPage(80, 20);
        }

        // 1
        private void page1Button_Click(object sender, EventArgs e)
        {
            ShowPage(0, 20);
        }

        // 2
        private void page2Button_Click(object sender, EventArgs e)
        {
            ShowPage(20, 20);
        }

        // 3
        private void page3Button_Click(object sender, EventArgs e)
        {
            ShowPage(40, 20);
        }

        // 4
        private void page4Button_Click(object sender, EventArgs e)
        {
            ShowPage(60, 20);
        }

        // 5
        private void page5Button_Click(object sender, EventArgs e)
        {
            ShowPage(80, 20);
        }

        // Сортировка
        private void comboBoxSort_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBoxSort.Text == "Название (по возрастанию)")
            {
                productDataView = new DataView(productTable, "", "Title asc", DataViewRowState.CurrentRows);
            }

            if (comboBoxSort.Text == "Название (по убыванию)")
            {
                productDataView = new DataView(productTable, "", "Title Desc", DataViewRowState.CurrentRows);
            }

            if (comboBoxSort.Text == "Номер цеха (по возрастанию)")
            {
                productDataView = new DataView(productTable, "", "ProductionWorkshopNumber", DataViewRowState.CurrentRows);
            }

            if (comboBoxSort.Text == "Номер цеха (по убыванию)")
            {
                productDataView = new DataView(productTable, "", "ProductionWorkshopNumber Desc", DataViewRowState.CurrentRows);
            }

            if (comboBoxSort.Text == "Мин. стоимость для агента (по возрастанию)")
            {
                productDataView = new DataView(productTable, "", "MinCostForAgent", DataViewRowState.CurrentRows);
            }

            if (comboBoxSort.Text == "Мин. стоимость для агента (по убыванию)")
            {
                productDataView = new DataView(productTable, "", "MinCostForAgent Desc", DataViewRowState.CurrentRows);
            }

            productTable = productDataView.ToTable();
            dataGridViewProduct.DataSource = productTable;

        }

        // Фильтрация
        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
                if (comboBoxFilter.Text == "Все типы")
                {
                    DataView productDataView1 = new DataView(productTable, "", "", DataViewRowState.CurrentRows);
                productTable = productDataView1.ToTable();
                    dataGridViewProduct.DataSource = productTable;
                }

                if (comboBoxFilter.Text == "Колесо")
                {

                    DataView productDataView1 = new DataView(productTable, $"ProductTypeID = 1", "", DataViewRowState.CurrentRows);
                    productTable = productDataView1.ToTable();
                    dataGridViewProduct.DataSource = productTable;
                    comboBoxFilter.Enabled = false;
                }

                if (comboBoxFilter.Text == "Запаска")
                {
                    DataView productDataView1 = new DataView(productTable, $"ProductTypeID = 2", "", DataViewRowState.CurrentRows);
                    productTable = productDataView1.ToTable();
                    dataGridViewProduct.DataSource = productTable;
                    comboBoxFilter.Enabled = false;
                }

                if (comboBoxFilter.Text == "Шина")
                {
                    DataView productDataView1 = new DataView(productTable, $"ProductTypeID = 3", "", DataViewRowState.CurrentRows);
                    productTable = productDataView1.ToTable();
                    dataGridViewProduct.DataSource = productTable;
                    comboBoxFilter.Enabled = false;
                }

                if (comboBoxFilter.Text == "Диск")
                {
                    DataView productDataView1 = new DataView(productTable, $"ProductTypeID = 4", "", DataViewRowState.CurrentRows);
                    productTable = productDataView1.ToTable();
                    dataGridViewProduct.DataSource = productTable;
                    comboBoxFilter.Enabled = false;
                }
        }

        // Поиск
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            DataView productDataView = new DataView(productTable, "", "", DataViewRowState.CurrentRows);
            productDataView.RowFilter = "(Title like '%' + '" + textBoxSearch.Text + "' + '%') or (Description like '%' + '" + textBoxSearch.Text + "' + '%') ";
            //productDataView.Sort = $"{comboBoxSort.Text}";
            if (productDataView.Count == 0)
            {
                MessageBox.Show("Отсутствуют реультаты поиска");
            }

            dataGridViewProduct.DataSource = productDataView;

        }

        // Очистка параметров сортировки, фильтрации
        private void buttonParamsClear_Click(object sender, EventArgs e)
        {
            //productTable = sTableSave;
            
            comboBoxFilter.Text = "Все типы";
            comboBoxSort.Text = " ";
            textBoxSearch.Text = " ";

            comboBoxFilter.Enabled = true;

            MessageBox.Show("Параметры очищены");
            dataGridViewProduct.DataSource = productTable;
        }

        // Выбор ячеек в DataGridView
        private void dataGridViewProduct_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {

            changeCostButton.Visible = true;

            string[] array = new string[dataGridViewProduct.SelectedRows.Count];

            int i = 0;
            foreach (DataGridViewRow row in dataGridViewProduct.SelectedRows)
            {
                array[i] = row.Cells[0].Value.ToString();
                i = i + 1;
            }

            if (e.RowIndex >= 0)
            {

                Info.SelectedRowsArray = array;
                dataGridViewProduct.Rows[e.RowIndex].Selected = true;

                Info.MinCostForAgent = dataGridViewProduct.Rows[e.RowIndex].Cells["MinCostForAgent"].Value.ToString();
                Info.Title = dataGridViewProduct.Rows[e.RowIndex].Cells["Title"].Value.ToString();
                Info.ID = dataGridViewProduct.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                Info.ProductTypeID = dataGridViewProduct.Rows[e.RowIndex].Cells["ProductTypeID"].Value.ToString();
                Info.ArticleNumber = dataGridViewProduct.Rows[e.RowIndex].Cells["ArticleNumber"].Value.ToString();
                Info.Image = dataGridViewProduct.Rows[e.RowIndex].Cells["Image"].Value.ToString();
                Info.ProductionPersonCount = dataGridViewProduct.Rows[e.RowIndex].Cells["ProductionPersonCount"].Value.ToString();
                Info.ProductionWorkshopNumber = dataGridViewProduct.Rows[e.RowIndex].Cells["ProductionWorkshopNumber"].Value.ToString();
                Info.Description = dataGridViewProduct.Rows[e.RowIndex].Cells["Description"].Value.ToString();

            }
        }

        // Изменить стоимость
        private void changeCostButton_Click(object sender, EventArgs e)
        {
            ChangeCostForm form = new ChangeCostForm();
            form.ShowDialog();
        }

        // Переход на форму добавления
        private void addProductButton_Click(object sender, EventArgs e)
        {
            EditProductForm form = new EditProductForm();
            form.ShowDialog();
        }

        // Переход на форму редактирования
        private void editProductButton_Click(object sender, EventArgs e)
        {
            EditProductForm form = new EditProductForm();
            form.Show();
        }

        // Переход на форму редактирования по double-click
        private void dataGridViewProduct_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            EditProductForm form = new EditProductForm();
            form.ShowDialog();
        }

        // Load
        public void LoadProduct()
        {

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            productCommand = new MySqlCommand("SELECT * FROM product", connection);
            productAdapter = new MySqlDataAdapter(productCommand);


            productDataset = new DataSet();

            productAdapter.Fill(productDataset, "product");

            productTable = productDataset.Tables["product"];

            productTable.Columns.Add("ImagePic", Type.GetType("System.Byte[]"));
            productTable.Columns.Add("Materials");
            productTable.Columns.Add("Cost");

            foreach (DataRow row in productTable.Rows)
            {
                row["ImagePic"] = File.ReadAllBytes(row["Image"].ToString());
            }

            // Находим материалы и считаем стоимость

            dataGridViewProduct.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            foreach (DataRow row in productTable.Rows)
            {

                MySqlConnection connect = new MySqlConnection(connectionString);
                connect.Open();
                MySqlCommand cmdFindMaterials = connect.CreateCommand();
                cmdFindMaterials.CommandText = $"select material.title,productmaterial.count,material.cost from productmaterial join material on productmaterial.materialid = material.id where ProductID = {row["ID"]}";
                MySqlDataReader MaterialsReader = cmdFindMaterials.ExecuteReader();

                decimal sum = 0;
                row["Materials"] = row["Cost"] = "";
                while (MaterialsReader.Read())
                {
                    //MessageBox.Show(MaterialsReader[0].ToString());

                    row["Materials"] = row["Materials"] + MaterialsReader[0].ToString() + Environment.NewLine;
                    row["Cost"] = sum + (Convert.ToDecimal(MaterialsReader[1]) * Convert.ToDecimal(MaterialsReader[2]));
                    sum = (Convert.ToDecimal(MaterialsReader[1]) * Convert.ToDecimal(MaterialsReader[2]));
                }

                connect.Close();
            }

            dataGridViewProduct.DataSource = productTable;

            DataGridViewColumn column = dataGridViewProduct.Columns[9];
            ((DataGridViewImageColumn)dataGridViewProduct.Columns[9]).ImageLayout = DataGridViewImageCellLayout.Zoom;

            dataGridViewProduct.RowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dataGridViewProduct.RowsDefaultCellStyle.SelectionBackColor = Color.MediumPurple;


            // Подсветить продукты, которые не продавались в течении месяца

            var listOfStrings = new List<string>();

            MySqlCommand cmdFindProductSale = connection.CreateCommand();
            cmdFindProductSale.CommandText = "select ProductId from productsale where SaleDate not between DATE_ADD(current_date(), INTERVAL -2 MONTH) and current_date()";
            MySqlDataReader myReader = cmdFindProductSale.ExecuteReader();

            int i = 0;
            while (myReader.Read())
            {
                listOfStrings.Add(myReader[0].ToString());
                i = i + 1;
            }

            //

            foreach (DataGridViewRow row in dataGridViewProduct.Rows)
            {
                if (listOfStrings.Contains(row.Cells[0].Value.ToString()))
                {
                    dataGridViewProduct.Rows[row.Index].DefaultCellStyle.BackColor = Color.PaleVioletRed;
                };
            }
            connection.Close();
            

        }

        // Обновление данных в DataGridView при активации формы
        private void ProductForm_Activated(object sender, EventArgs e)
        {
            LoadProduct();  
        }
    }


    // Класс связи
    public static class Info
    {
        public static string ID { get; set; }
        public static string Title { get; set; }
        public static string ProductTypeID { get; set; }
        public static string ArticleNumber { get; set; }
        public static string Description { get; set; }
        public static string Image { get; set; }
        public static string ProductionPersonCount { get; set; }
        public static string ProductionWorkshopNumber { get; set; }
        public static string MinCostForAgent { get; set; }
        public static string StateButton { get; set; }
        public static string[] SelectedRowsArray { get; set; }

        public static ProductForm ProductForm { get; set; }

    }

}
