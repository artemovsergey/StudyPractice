namespace WindowsFormsApplication1
{
    partial class ProductForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewProduct = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.forwardButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.page1Button = new System.Windows.Forms.Button();
            this.page2Button = new System.Windows.Forms.Button();
            this.page3Button = new System.Windows.Forms.Button();
            this.page4Button = new System.Windows.Forms.Button();
            this.page5Button = new System.Windows.Forms.Button();
            this.firstPageButton = new System.Windows.Forms.Button();
            this.lastPageButton = new System.Windows.Forms.Button();
            this.comboBoxSort = new System.Windows.Forms.ComboBox();
            this.sortLabel = new System.Windows.Forms.Label();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.comboBoxLLabel = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.clearParamsButton = new System.Windows.Forms.Button();
            this.changeCostButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Продукты";
            // 
            // dataGridViewProduct
            // 
            this.dataGridViewProduct.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduct.Location = new System.Drawing.Point(152, 62);
            this.dataGridViewProduct.Name = "dataGridViewProduct";
            this.dataGridViewProduct.Size = new System.Drawing.Size(1098, 366);
            this.dataGridViewProduct.TabIndex = 2;
            this.dataGridViewProduct.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewProduct_CellMouseUp);
            this.dataGridViewProduct.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewProduct_CellMouseDoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // forwardButton
            // 
            this.forwardButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(99)))), ((int)(((byte)(245)))));
            this.forwardButton.Location = new System.Drawing.Point(815, 444);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(93, 31);
            this.forwardButton.TabIndex = 3;
            this.forwardButton.Text = "Вперед";
            this.forwardButton.UseVisualStyleBackColor = false;
            this.forwardButton.Click += new System.EventHandler(this.forwardButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(99)))), ((int)(((byte)(245)))));
            this.backButton.Location = new System.Drawing.Point(461, 444);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(98, 31);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // page1Button
            // 
            this.page1Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(99)))), ((int)(((byte)(245)))));
            this.page1Button.Location = new System.Drawing.Point(565, 444);
            this.page1Button.Name = "page1Button";
            this.page1Button.Size = new System.Drawing.Size(44, 31);
            this.page1Button.TabIndex = 4;
            this.page1Button.Text = "1";
            this.page1Button.UseMnemonic = false;
            this.page1Button.UseVisualStyleBackColor = false;
            this.page1Button.Click += new System.EventHandler(this.page1Button_Click);
            // 
            // page2Button
            // 
            this.page2Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(99)))), ((int)(((byte)(245)))));
            this.page2Button.Location = new System.Drawing.Point(615, 444);
            this.page2Button.Name = "page2Button";
            this.page2Button.Size = new System.Drawing.Size(44, 31);
            this.page2Button.TabIndex = 4;
            this.page2Button.Text = "2";
            this.page2Button.UseMnemonic = false;
            this.page2Button.UseVisualStyleBackColor = false;
            this.page2Button.Click += new System.EventHandler(this.page2Button_Click);
            // 
            // page3Button
            // 
            this.page3Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(99)))), ((int)(((byte)(245)))));
            this.page3Button.Location = new System.Drawing.Point(665, 444);
            this.page3Button.Name = "page3Button";
            this.page3Button.Size = new System.Drawing.Size(44, 31);
            this.page3Button.TabIndex = 4;
            this.page3Button.Text = "3";
            this.page3Button.UseMnemonic = false;
            this.page3Button.UseVisualStyleBackColor = false;
            this.page3Button.Click += new System.EventHandler(this.page3Button_Click);
            // 
            // page4Button
            // 
            this.page4Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(99)))), ((int)(((byte)(245)))));
            this.page4Button.Location = new System.Drawing.Point(715, 444);
            this.page4Button.Name = "page4Button";
            this.page4Button.Size = new System.Drawing.Size(44, 31);
            this.page4Button.TabIndex = 4;
            this.page4Button.Text = "4";
            this.page4Button.UseMnemonic = false;
            this.page4Button.UseVisualStyleBackColor = false;
            this.page4Button.Click += new System.EventHandler(this.page4Button_Click);
            // 
            // page5Button
            // 
            this.page5Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(99)))), ((int)(((byte)(245)))));
            this.page5Button.Location = new System.Drawing.Point(765, 444);
            this.page5Button.Name = "page5Button";
            this.page5Button.Size = new System.Drawing.Size(44, 31);
            this.page5Button.TabIndex = 4;
            this.page5Button.Text = "5";
            this.page5Button.UseMnemonic = false;
            this.page5Button.UseVisualStyleBackColor = false;
            this.page5Button.Click += new System.EventHandler(this.page5Button_Click);
            // 
            // firstPageButton
            // 
            this.firstPageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(99)))), ((int)(((byte)(245)))));
            this.firstPageButton.Location = new System.Drawing.Point(357, 444);
            this.firstPageButton.Name = "firstPageButton";
            this.firstPageButton.Size = new System.Drawing.Size(98, 31);
            this.firstPageButton.TabIndex = 4;
            this.firstPageButton.Text = "Первая";
            this.firstPageButton.UseVisualStyleBackColor = false;
            this.firstPageButton.Click += new System.EventHandler(this.firstPageButton_Click);
            // 
            // lastPageButton
            // 
            this.lastPageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(99)))), ((int)(((byte)(245)))));
            this.lastPageButton.Location = new System.Drawing.Point(914, 444);
            this.lastPageButton.Name = "lastPageButton";
            this.lastPageButton.Size = new System.Drawing.Size(93, 31);
            this.lastPageButton.TabIndex = 3;
            this.lastPageButton.Text = "Последняя";
            this.lastPageButton.UseVisualStyleBackColor = false;
            this.lastPageButton.Click += new System.EventHandler(this.lastPageButton_Click);
            // 
            // comboBoxSort
            // 
            this.comboBoxSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSort.FormattingEnabled = true;
            this.comboBoxSort.Location = new System.Drawing.Point(957, 21);
            this.comboBoxSort.Name = "comboBoxSort";
            this.comboBoxSort.Size = new System.Drawing.Size(293, 22);
            this.comboBoxSort.TabIndex = 5;
            this.comboBoxSort.SelectedIndexChanged += new System.EventHandler(this.comboBoxSort_SelectedIndexChanged);
            // 
            // sortLabel
            // 
            this.sortLabel.AutoSize = true;
            this.sortLabel.Location = new System.Drawing.Point(874, 24);
            this.sortLabel.Name = "sortLabel";
            this.sortLabel.Size = new System.Drawing.Size(77, 14);
            this.sortLabel.TabIndex = 6;
            this.sortLabel.Text = "Сортировка";
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Location = new System.Drawing.Point(747, 21);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(121, 22);
            this.comboBoxFilter.TabIndex = 7;
            this.comboBoxFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilter_SelectedIndexChanged);
            // 
            // comboBoxLLabel
            // 
            this.comboBoxLLabel.AutoSize = true;
            this.comboBoxLLabel.Location = new System.Drawing.Point(665, 24);
            this.comboBoxLLabel.Name = "comboBoxLLabel";
            this.comboBoxLLabel.Size = new System.Drawing.Size(77, 14);
            this.comboBoxLLabel.TabIndex = 8;
            this.comboBoxLLabel.Text = "Фильтрация";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(559, 23);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearch.TabIndex = 9;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(511, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 14);
            this.label3.TabIndex = 11;
            this.label3.Text = "Поиск";
            // 
            // clearParamsButton
            // 
            this.clearParamsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(99)))), ((int)(((byte)(245)))));
            this.clearParamsButton.Location = new System.Drawing.Point(152, 21);
            this.clearParamsButton.Name = "clearParamsButton";
            this.clearParamsButton.Size = new System.Drawing.Size(152, 33);
            this.clearParamsButton.TabIndex = 12;
            this.clearParamsButton.Text = "Очистить параметры";
            this.clearParamsButton.UseVisualStyleBackColor = false;
            this.clearParamsButton.Click += new System.EventHandler(this.clearParamsButton_Click);
            // 
            // changeCostButton
            // 
            this.changeCostButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(99)))), ((int)(((byte)(245)))));
            this.changeCostButton.Location = new System.Drawing.Point(12, 133);
            this.changeCostButton.Name = "changeCostButton";
            this.changeCostButton.Size = new System.Drawing.Size(117, 44);
            this.changeCostButton.TabIndex = 13;
            this.changeCostButton.Text = "Изменить стоимость";
            this.changeCostButton.UseVisualStyleBackColor = false;
            this.changeCostButton.Click += new System.EventHandler(this.changeCostButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(99)))), ((int)(((byte)(245)))));
            this.addButton.Location = new System.Drawing.Point(12, 203);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(117, 37);
            this.addButton.TabIndex = 14;
            this.addButton.Text = "Добавление";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(99)))), ((int)(((byte)(245)))));
            this.editButton.Location = new System.Drawing.Point(12, 258);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(117, 38);
            this.editButton.TabIndex = 14;
            this.editButton.Text = "Редактирование";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1277, 503);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.changeCostButton);
            this.Controls.Add(this.clearParamsButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.comboBoxLLabel);
            this.Controls.Add(this.comboBoxFilter);
            this.Controls.Add(this.sortLabel);
            this.Controls.Add(this.comboBoxSort);
            this.Controls.Add(this.page5Button);
            this.Controls.Add(this.page4Button);
            this.Controls.Add(this.page3Button);
            this.Controls.Add(this.page2Button);
            this.Controls.Add(this.page1Button);
            this.Controls.Add(this.firstPageButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.lastPageButton);
            this.Controls.Add(this.forwardButton);
            this.Controls.Add(this.dataGridViewProduct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProductForm";
            this.Text = "Продукты";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.Activated += new System.EventHandler(this.ProductForm_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProductForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewProduct;
        private System.Windows.Forms.Button forwardButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button page1Button;
        private System.Windows.Forms.Button page2Button;
        private System.Windows.Forms.Button page3Button;
        private System.Windows.Forms.Button page4Button;
        private System.Windows.Forms.Button page5Button;
        private System.Windows.Forms.Button firstPageButton;
        private System.Windows.Forms.Button lastPageButton;
        private System.Windows.Forms.ComboBox comboBoxSort;
        private System.Windows.Forms.Label sortLabel;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.Label comboBoxLLabel;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button clearParamsButton;
        private System.Windows.Forms.Button changeCostButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
    }
}

