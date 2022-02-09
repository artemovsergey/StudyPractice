namespace vosmerka
{
    partial class ProductForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
            this.productLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewProduct = new System.Windows.Forms.DataGridView();
            this.forwardPageButton = new System.Windows.Forms.Button();
            this.backPageButton = new System.Windows.Forms.Button();
            this.previosPageButton = new System.Windows.Forms.Button();
            this.endPageButton = new System.Windows.Forms.Button();
            this.page2Button = new System.Windows.Forms.Button();
            this.page3Button = new System.Windows.Forms.Button();
            this.page4Button = new System.Windows.Forms.Button();
            this.page1Button = new System.Windows.Forms.Button();
            this.page5Button = new System.Windows.Forms.Button();
            this.comboBoxSort = new System.Windows.Forms.ComboBox();
            this.labelSort = new System.Windows.Forms.Label();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.filterLabel = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.buttonParamsClear = new System.Windows.Forms.Button();
            this.changeCostButton = new System.Windows.Forms.Button();
            this.editProductButton = new System.Windows.Forms.Button();
            this.addProductButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // productLabel
            // 
            this.productLabel.AutoSize = true;
            this.productLabel.Location = new System.Drawing.Point(48, 138);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(63, 14);
            this.productLabel.TabIndex = 1;
            this.productLabel.Text = "Продукты";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::vosmerka.Properties.Resources.Восьмерка;
            this.pictureBox1.Location = new System.Drawing.Point(12, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridViewProduct
            // 
            this.dataGridViewProduct.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridViewProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduct.Location = new System.Drawing.Point(182, 67);
            this.dataGridViewProduct.Name = "dataGridViewProduct";
            this.dataGridViewProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProduct.Size = new System.Drawing.Size(1107, 539);
            this.dataGridViewProduct.TabIndex = 2;
            this.dataGridViewProduct.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewProduct_CellMouseDoubleClick);
            this.dataGridViewProduct.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewProduct_CellMouseUp);
            // 
            // forwardPageButton
            // 
            this.forwardPageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(99)))), ((int)(((byte)(245)))));
            this.forwardPageButton.Location = new System.Drawing.Point(929, 636);
            this.forwardPageButton.Name = "forwardPageButton";
            this.forwardPageButton.Size = new System.Drawing.Size(108, 45);
            this.forwardPageButton.TabIndex = 3;
            this.forwardPageButton.Text = "Вперед";
            this.forwardPageButton.UseVisualStyleBackColor = false;
            this.forwardPageButton.Click += new System.EventHandler(this.forwardPageButton_Click);
            // 
            // backPageButton
            // 
            this.backPageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(99)))), ((int)(((byte)(245)))));
            this.backPageButton.Location = new System.Drawing.Point(506, 636);
            this.backPageButton.Name = "backPageButton";
            this.backPageButton.Size = new System.Drawing.Size(109, 45);
            this.backPageButton.TabIndex = 4;
            this.backPageButton.Text = "Назад";
            this.backPageButton.UseVisualStyleBackColor = false;
            this.backPageButton.Click += new System.EventHandler(this.backPageButton_Click);
            // 
            // previosPageButton
            // 
            this.previosPageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(99)))), ((int)(((byte)(245)))));
            this.previosPageButton.Location = new System.Drawing.Point(382, 636);
            this.previosPageButton.Name = "previosPageButton";
            this.previosPageButton.Size = new System.Drawing.Size(109, 45);
            this.previosPageButton.TabIndex = 5;
            this.previosPageButton.Text = "Первые";
            this.previosPageButton.UseVisualStyleBackColor = false;
            this.previosPageButton.Click += new System.EventHandler(this.previosPageButton_Click);
            // 
            // endPageButton
            // 
            this.endPageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(99)))), ((int)(((byte)(245)))));
            this.endPageButton.Location = new System.Drawing.Point(1052, 636);
            this.endPageButton.Name = "endPageButton";
            this.endPageButton.Size = new System.Drawing.Size(108, 45);
            this.endPageButton.TabIndex = 6;
            this.endPageButton.Text = "Последние";
            this.endPageButton.UseVisualStyleBackColor = false;
            this.endPageButton.Click += new System.EventHandler(this.endPageButton_Click);
            // 
            // page2Button
            // 
            this.page2Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(99)))), ((int)(((byte)(245)))));
            this.page2Button.Location = new System.Drawing.Point(688, 636);
            this.page2Button.Name = "page2Button";
            this.page2Button.Size = new System.Drawing.Size(41, 45);
            this.page2Button.TabIndex = 7;
            this.page2Button.Text = "2";
            this.page2Button.UseVisualStyleBackColor = false;
            this.page2Button.Click += new System.EventHandler(this.page2Button_Click);
            // 
            // page3Button
            // 
            this.page3Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(99)))), ((int)(((byte)(245)))));
            this.page3Button.Location = new System.Drawing.Point(750, 636);
            this.page3Button.Name = "page3Button";
            this.page3Button.Size = new System.Drawing.Size(41, 45);
            this.page3Button.TabIndex = 8;
            this.page3Button.Text = "3";
            this.page3Button.UseVisualStyleBackColor = false;
            this.page3Button.Click += new System.EventHandler(this.page3Button_Click);
            // 
            // page4Button
            // 
            this.page4Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(99)))), ((int)(((byte)(245)))));
            this.page4Button.Location = new System.Drawing.Point(807, 636);
            this.page4Button.Name = "page4Button";
            this.page4Button.Size = new System.Drawing.Size(41, 45);
            this.page4Button.TabIndex = 9;
            this.page4Button.Text = "4";
            this.page4Button.UseVisualStyleBackColor = false;
            this.page4Button.Click += new System.EventHandler(this.page4Button_Click);
            // 
            // page1Button
            // 
            this.page1Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(99)))), ((int)(((byte)(245)))));
            this.page1Button.Location = new System.Drawing.Point(632, 636);
            this.page1Button.Name = "page1Button";
            this.page1Button.Size = new System.Drawing.Size(41, 45);
            this.page1Button.TabIndex = 10;
            this.page1Button.Text = "1";
            this.page1Button.UseVisualStyleBackColor = false;
            this.page1Button.Click += new System.EventHandler(this.page1Button_Click);
            // 
            // page5Button
            // 
            this.page5Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(99)))), ((int)(((byte)(245)))));
            this.page5Button.Location = new System.Drawing.Point(866, 636);
            this.page5Button.Name = "page5Button";
            this.page5Button.Size = new System.Drawing.Size(41, 45);
            this.page5Button.TabIndex = 11;
            this.page5Button.Text = "5";
            this.page5Button.UseVisualStyleBackColor = false;
            this.page5Button.Click += new System.EventHandler(this.page5Button_Click);
            // 
            // comboBoxSort
            // 
            this.comboBoxSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSort.FormattingEnabled = true;
            this.comboBoxSort.Location = new System.Drawing.Point(988, 27);
            this.comboBoxSort.Name = "comboBoxSort";
            this.comboBoxSort.Size = new System.Drawing.Size(301, 22);
            this.comboBoxSort.TabIndex = 12;
            this.comboBoxSort.SelectionChangeCommitted += new System.EventHandler(this.comboBoxSort_SelectionChangeCommitted);
            // 
            // labelSort
            // 
            this.labelSort.AutoSize = true;
            this.labelSort.Location = new System.Drawing.Point(905, 30);
            this.labelSort.Name = "labelSort";
            this.labelSort.Size = new System.Drawing.Size(77, 14);
            this.labelSort.TabIndex = 13;
            this.labelSort.Text = "Сортировка";
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Location = new System.Drawing.Point(778, 27);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(121, 22);
            this.comboBoxFilter.TabIndex = 14;
            this.comboBoxFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilter_SelectedIndexChanged);
            // 
            // filterLabel
            // 
            this.filterLabel.AutoSize = true;
            this.filterLabel.Location = new System.Drawing.Point(695, 30);
            this.filterLabel.Name = "filterLabel";
            this.filterLabel.Size = new System.Drawing.Size(77, 14);
            this.filterLabel.TabIndex = 15;
            this.filterLabel.Text = "Фильтрация";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(589, 27);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearch.TabIndex = 16;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(541, 30);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(42, 14);
            this.labelSearch.TabIndex = 17;
            this.labelSearch.Text = "Поиск";
            // 
            // buttonParamsClear
            // 
            this.buttonParamsClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(99)))), ((int)(((byte)(245)))));
            this.buttonParamsClear.Location = new System.Drawing.Point(182, 21);
            this.buttonParamsClear.Name = "buttonParamsClear";
            this.buttonParamsClear.Size = new System.Drawing.Size(144, 35);
            this.buttonParamsClear.TabIndex = 18;
            this.buttonParamsClear.Text = "Очистить параметры";
            this.buttonParamsClear.UseVisualStyleBackColor = false;
            this.buttonParamsClear.Click += new System.EventHandler(this.buttonParamsClear_Click);
            // 
            // changeCostButton
            // 
            this.changeCostButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(99)))), ((int)(((byte)(245)))));
            this.changeCostButton.Location = new System.Drawing.Point(12, 282);
            this.changeCostButton.Name = "changeCostButton";
            this.changeCostButton.Size = new System.Drawing.Size(141, 38);
            this.changeCostButton.TabIndex = 19;
            this.changeCostButton.Text = "Изменить стоимость";
            this.changeCostButton.UseVisualStyleBackColor = false;
            this.changeCostButton.Click += new System.EventHandler(this.changeCostButton_Click);
            // 
            // editProductButton
            // 
            this.editProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(99)))), ((int)(((byte)(245)))));
            this.editProductButton.Location = new System.Drawing.Point(12, 229);
            this.editProductButton.Name = "editProductButton";
            this.editProductButton.Size = new System.Drawing.Size(141, 38);
            this.editProductButton.TabIndex = 20;
            this.editProductButton.Text = "Редактироание";
            this.editProductButton.UseVisualStyleBackColor = false;
            this.editProductButton.Click += new System.EventHandler(this.editProductButton_Click);
            // 
            // addProductButton
            // 
            this.addProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(99)))), ((int)(((byte)(245)))));
            this.addProductButton.Location = new System.Drawing.Point(12, 171);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(141, 38);
            this.addProductButton.TabIndex = 21;
            this.addProductButton.Text = "Добавление";
            this.addProductButton.UseVisualStyleBackColor = false;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.addProductButton);
            this.Controls.Add(this.editProductButton);
            this.Controls.Add(this.changeCostButton);
            this.Controls.Add(this.buttonParamsClear);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.filterLabel);
            this.Controls.Add(this.comboBoxFilter);
            this.Controls.Add(this.labelSort);
            this.Controls.Add(this.comboBoxSort);
            this.Controls.Add(this.page5Button);
            this.Controls.Add(this.page1Button);
            this.Controls.Add(this.page4Button);
            this.Controls.Add(this.page3Button);
            this.Controls.Add(this.page2Button);
            this.Controls.Add(this.endPageButton);
            this.Controls.Add(this.previosPageButton);
            this.Controls.Add(this.backPageButton);
            this.Controls.Add(this.forwardPageButton);
            this.Controls.Add(this.dataGridViewProduct);
            this.Controls.Add(this.productLabel);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ProductForm";
            this.Text = "Продукты";
            this.Activated += new System.EventHandler(this.ProductForm_Activated);
            this.Load += new System.EventHandler(this.ProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.DataGridView dataGridViewProduct;
        private System.Windows.Forms.Button forwardPageButton;
        private System.Windows.Forms.Button backPageButton;
        private System.Windows.Forms.Button previosPageButton;
        private System.Windows.Forms.Button endPageButton;
        private System.Windows.Forms.Button page2Button;
        private System.Windows.Forms.Button page3Button;
        private System.Windows.Forms.Button page4Button;
        private System.Windows.Forms.Button page1Button;
        private System.Windows.Forms.Button page5Button;
        private System.Windows.Forms.ComboBox comboBoxSort;
        private System.Windows.Forms.Label labelSort;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.Label filterLabel;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Button buttonParamsClear;
        private System.Windows.Forms.Button changeCostButton;
        private System.Windows.Forms.Button editProductButton;
        private System.Windows.Forms.Button addProductButton;
    }
}

