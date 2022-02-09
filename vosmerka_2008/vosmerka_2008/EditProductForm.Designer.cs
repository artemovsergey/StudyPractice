namespace WindowsFormsApplication1
{
    partial class EditProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProductForm));
            this.idField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.titleField = new System.Windows.Forms.TextBox();
            this.articleField = new System.Windows.Forms.TextBox();
            this.countPersonField = new System.Windows.Forms.TextBox();
            this.numberWorkshopField = new System.Windows.Forms.TextBox();
            this.minCostForAgentField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numberWorkshopLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.typeproductcomboBox = new System.Windows.Forms.ComboBox();
            this.descriptionField = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.backProductButton = new System.Windows.Forms.Button();
            this.forwardProductButton = new System.Windows.Forms.Button();
            this.dataGridViewMaterial = new System.Windows.Forms.DataGridView();
            this.comboBoxMaterial = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.countField = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.addMaterialButton = new System.Windows.Forms.Button();
            this.delMaterialButton = new System.Windows.Forms.Button();
            this.searchMaterialButton = new System.Windows.Forms.Button();
            this.addProductButton = new System.Windows.Forms.Button();
            this.saveProductButton = new System.Windows.Forms.Button();
            this.imageFieldPictureBox = new System.Windows.Forms.PictureBox();
            this.addImageButton = new System.Windows.Forms.Button();
            this.delProductButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageFieldPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // idField
            // 
            this.idField.Location = new System.Drawing.Point(29, 113);
            this.idField.Name = "idField";
            this.idField.Size = new System.Drawing.Size(249, 20);
            this.idField.TabIndex = 0;
            this.idField.TextChanged += new System.EventHandler(this.idField_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "id";
            // 
            // titleField
            // 
            this.titleField.Location = new System.Drawing.Point(29, 153);
            this.titleField.Name = "titleField";
            this.titleField.Size = new System.Drawing.Size(249, 20);
            this.titleField.TabIndex = 2;
            // 
            // articleField
            // 
            this.articleField.Location = new System.Drawing.Point(29, 193);
            this.articleField.Name = "articleField";
            this.articleField.Size = new System.Drawing.Size(249, 20);
            this.articleField.TabIndex = 3;
            // 
            // countPersonField
            // 
            this.countPersonField.Location = new System.Drawing.Point(29, 275);
            this.countPersonField.Name = "countPersonField";
            this.countPersonField.Size = new System.Drawing.Size(249, 20);
            this.countPersonField.TabIndex = 5;
            // 
            // numberWorkshopField
            // 
            this.numberWorkshopField.Location = new System.Drawing.Point(29, 315);
            this.numberWorkshopField.Name = "numberWorkshopField";
            this.numberWorkshopField.Size = new System.Drawing.Size(249, 20);
            this.numberWorkshopField.TabIndex = 6;
            // 
            // minCostForAgentField
            // 
            this.minCostForAgentField.Location = new System.Drawing.Point(29, 355);
            this.minCostForAgentField.Name = "minCostForAgentField";
            this.minCostForAgentField.Size = new System.Drawing.Size(249, 20);
            this.minCostForAgentField.TabIndex = 7;
            this.minCostForAgentField.Validating += new System.ComponentModel.CancelEventHandler(this.minCostForAgentField_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 14);
            this.label2.TabIndex = 8;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 14);
            this.label3.TabIndex = 9;
            this.label3.Text = "Артикул";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 14);
            this.label4.TabIndex = 10;
            this.label4.Text = "Тип продукта";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(252, 14);
            this.label5.TabIndex = 11;
            this.label5.Text = "Количество человек для производства";
            // 
            // numberWorkshopLabel
            // 
            this.numberWorkshopLabel.AutoSize = true;
            this.numberWorkshopLabel.Location = new System.Drawing.Point(26, 298);
            this.numberWorkshopLabel.Name = "numberWorkshopLabel";
            this.numberWorkshopLabel.Size = new System.Drawing.Size(203, 14);
            this.numberWorkshopLabel.TabIndex = 12;
            this.numberWorkshopLabel.Text = "Номер производственного цеха";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(231, 14);
            this.label7.TabIndex = 13;
            this.label7.Text = "Минимальная стоимость для агента";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // typeproductcomboBox
            // 
            this.typeproductcomboBox.FormattingEnabled = true;
            this.typeproductcomboBox.Location = new System.Drawing.Point(29, 233);
            this.typeproductcomboBox.Name = "typeproductcomboBox";
            this.typeproductcomboBox.Size = new System.Drawing.Size(249, 22);
            this.typeproductcomboBox.TabIndex = 15;
            // 
            // descriptionField
            // 
            this.descriptionField.Location = new System.Drawing.Point(29, 397);
            this.descriptionField.Name = "descriptionField";
            this.descriptionField.Size = new System.Drawing.Size(249, 96);
            this.descriptionField.TabIndex = 16;
            this.descriptionField.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 14);
            this.label6.TabIndex = 17;
            this.label6.Text = "Описание";
            // 
            // backProductButton
            // 
            this.backProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(99)))), ((int)(((byte)(245)))));
            this.backProductButton.Location = new System.Drawing.Point(55, 499);
            this.backProductButton.Name = "backProductButton";
            this.backProductButton.Size = new System.Drawing.Size(94, 35);
            this.backProductButton.TabIndex = 18;
            this.backProductButton.Text = "Назад";
            this.backProductButton.UseVisualStyleBackColor = false;
            this.backProductButton.Click += new System.EventHandler(this.backProductButton_Click);
            // 
            // forwardProductButton
            // 
            this.forwardProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(99)))), ((int)(((byte)(245)))));
            this.forwardProductButton.Location = new System.Drawing.Point(168, 499);
            this.forwardProductButton.Name = "forwardProductButton";
            this.forwardProductButton.Size = new System.Drawing.Size(97, 35);
            this.forwardProductButton.TabIndex = 19;
            this.forwardProductButton.Text = "Вперед";
            this.forwardProductButton.UseVisualStyleBackColor = false;
            this.forwardProductButton.Click += new System.EventHandler(this.forwardProductButton_Click);
            // 
            // dataGridViewMaterial
            // 
            this.dataGridViewMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMaterial.Location = new System.Drawing.Point(315, 269);
            this.dataGridViewMaterial.Name = "dataGridViewMaterial";
            this.dataGridViewMaterial.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewMaterial.TabIndex = 20;
            // 
            // comboBoxMaterial
            // 
            this.comboBoxMaterial.FormattingEnabled = true;
            this.comboBoxMaterial.Location = new System.Drawing.Point(315, 113);
            this.comboBoxMaterial.Name = "comboBoxMaterial";
            this.comboBoxMaterial.Size = new System.Drawing.Size(240, 22);
            this.comboBoxMaterial.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(312, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 14);
            this.label8.TabIndex = 22;
            this.label8.Text = "Материалы";
            // 
            // countField
            // 
            this.countField.Location = new System.Drawing.Point(315, 227);
            this.countField.Name = "countField";
            this.countField.Size = new System.Drawing.Size(240, 20);
            this.countField.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(312, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 14);
            this.label9.TabIndex = 24;
            this.label9.Text = "Количество";
            // 
            // addMaterialButton
            // 
            this.addMaterialButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(99)))), ((int)(((byte)(245)))));
            this.addMaterialButton.Location = new System.Drawing.Point(350, 431);
            this.addMaterialButton.Name = "addMaterialButton";
            this.addMaterialButton.Size = new System.Drawing.Size(84, 39);
            this.addMaterialButton.TabIndex = 25;
            this.addMaterialButton.Text = "Добавить";
            this.addMaterialButton.UseVisualStyleBackColor = false;
            this.addMaterialButton.Click += new System.EventHandler(this.addMaterialButton_Click);
            // 
            // delMaterialButton
            // 
            this.delMaterialButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(99)))), ((int)(((byte)(245)))));
            this.delMaterialButton.Location = new System.Drawing.Point(440, 431);
            this.delMaterialButton.Name = "delMaterialButton";
            this.delMaterialButton.Size = new System.Drawing.Size(81, 39);
            this.delMaterialButton.TabIndex = 26;
            this.delMaterialButton.Text = "Удалить";
            this.delMaterialButton.UseVisualStyleBackColor = false;
            // 
            // searchMaterialButton
            // 
            this.searchMaterialButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(99)))), ((int)(((byte)(245)))));
            this.searchMaterialButton.Location = new System.Drawing.Point(315, 154);
            this.searchMaterialButton.Name = "searchMaterialButton";
            this.searchMaterialButton.Size = new System.Drawing.Size(98, 36);
            this.searchMaterialButton.TabIndex = 27;
            this.searchMaterialButton.Text = "Найти";
            this.searchMaterialButton.UseVisualStyleBackColor = false;
            this.searchMaterialButton.Click += new System.EventHandler(this.searchMaterialButton_Click);
            // 
            // addProductButton
            // 
            this.addProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(99)))), ((int)(((byte)(245)))));
            this.addProductButton.Location = new System.Drawing.Point(306, 499);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(119, 36);
            this.addProductButton.TabIndex = 28;
            this.addProductButton.Text = "Новый продукт";
            this.addProductButton.UseVisualStyleBackColor = false;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // saveProductButton
            // 
            this.saveProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(99)))), ((int)(((byte)(245)))));
            this.saveProductButton.Location = new System.Drawing.Point(436, 499);
            this.saveProductButton.Name = "saveProductButton";
            this.saveProductButton.Size = new System.Drawing.Size(119, 35);
            this.saveProductButton.TabIndex = 29;
            this.saveProductButton.Text = "Сохранить";
            this.saveProductButton.UseVisualStyleBackColor = false;
            this.saveProductButton.Click += new System.EventHandler(this.saveProductButton_Click);
            // 
            // imageFieldPictureBox
            // 
            this.imageFieldPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageFieldPictureBox.Location = new System.Drawing.Point(582, 12);
            this.imageFieldPictureBox.Name = "imageFieldPictureBox";
            this.imageFieldPictureBox.Size = new System.Drawing.Size(693, 494);
            this.imageFieldPictureBox.TabIndex = 30;
            this.imageFieldPictureBox.TabStop = false;
            this.imageFieldPictureBox.Click += new System.EventHandler(this.imageFieldPictureBox_Click);
            // 
            // addImageButton
            // 
            this.addImageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(99)))), ((int)(((byte)(245)))));
            this.addImageButton.Location = new System.Drawing.Point(582, 512);
            this.addImageButton.Name = "addImageButton";
            this.addImageButton.Size = new System.Drawing.Size(191, 38);
            this.addImageButton.TabIndex = 31;
            this.addImageButton.Text = "Добавить изображение";
            this.addImageButton.UseVisualStyleBackColor = false;
            this.addImageButton.Click += new System.EventHandler(this.addImageButton_Click);
            // 
            // delProductButton
            // 
            this.delProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(99)))), ((int)(((byte)(245)))));
            this.delProductButton.Location = new System.Drawing.Point(306, 541);
            this.delProductButton.Name = "delProductButton";
            this.delProductButton.Size = new System.Drawing.Size(119, 32);
            this.delProductButton.TabIndex = 32;
            this.delProductButton.Text = "Удалить";
            this.delProductButton.UseVisualStyleBackColor = false;
            this.delProductButton.Click += new System.EventHandler(this.delProductButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(99)))), ((int)(((byte)(245)))));
            this.backButton.Location = new System.Drawing.Point(1181, 512);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(94, 38);
            this.backButton.TabIndex = 33;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // EditProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1287, 576);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.delProductButton);
            this.Controls.Add(this.addImageButton);
            this.Controls.Add(this.imageFieldPictureBox);
            this.Controls.Add(this.saveProductButton);
            this.Controls.Add(this.addProductButton);
            this.Controls.Add(this.searchMaterialButton);
            this.Controls.Add(this.delMaterialButton);
            this.Controls.Add(this.addMaterialButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.countField);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxMaterial);
            this.Controls.Add(this.dataGridViewMaterial);
            this.Controls.Add(this.forwardProductButton);
            this.Controls.Add(this.backProductButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.descriptionField);
            this.Controls.Add(this.typeproductcomboBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numberWorkshopLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.minCostForAgentField);
            this.Controls.Add(this.numberWorkshopField);
            this.Controls.Add(this.countPersonField);
            this.Controls.Add(this.articleField);
            this.Controls.Add(this.titleField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idField);
            this.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditProductForm";
            this.Text = "Редактирование";
            this.Load += new System.EventHandler(this.EditProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageFieldPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox titleField;
        private System.Windows.Forms.TextBox articleField;
        private System.Windows.Forms.TextBox countPersonField;
        private System.Windows.Forms.TextBox numberWorkshopField;
        private System.Windows.Forms.TextBox minCostForAgentField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label numberWorkshopLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox typeproductcomboBox;
        private System.Windows.Forms.RichTextBox descriptionField;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button backProductButton;
        private System.Windows.Forms.Button forwardProductButton;
        private System.Windows.Forms.DataGridView dataGridViewMaterial;
        private System.Windows.Forms.ComboBox comboBoxMaterial;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox countField;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button addMaterialButton;
        private System.Windows.Forms.Button delMaterialButton;
        private System.Windows.Forms.Button searchMaterialButton;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Button saveProductButton;
        private System.Windows.Forms.PictureBox imageFieldPictureBox;
        private System.Windows.Forms.Button addImageButton;
        private System.Windows.Forms.Button delProductButton;
        private System.Windows.Forms.Button backButton;
    }
}