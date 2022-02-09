namespace vosmerka
{
    partial class EditProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProductForm));
            this.titleField = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.idField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.descriptionField = new System.Windows.Forms.RichTextBox();
            this.minCostField = new System.Windows.Forms.TextBox();
            this.numberWorkshopField = new System.Windows.Forms.TextBox();
            this.countPersonField = new System.Windows.Forms.TextBox();
            this.articleField = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.typeProductcomboBox = new System.Windows.Forms.ComboBox();
            this.backButton = new System.Windows.Forms.Button();
            this.moveButton = new System.Windows.Forms.Button();
            this.dataGridViewMaterial = new System.Windows.Forms.DataGridView();
            this.materialcomboBox = new System.Windows.Forms.ComboBox();
            this.countMaterialField = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.addMaterialButton = new System.Windows.Forms.Button();
            this.delMaterialButton = new System.Windows.Forms.Button();
            this.findMaterialButton = new System.Windows.Forms.Button();
            this.addProductButton = new System.Windows.Forms.Button();
            this.saveProductButton = new System.Windows.Forms.Button();
            this.imageFieldPictureBox = new System.Windows.Forms.PictureBox();
            this.addImageButton = new System.Windows.Forms.Button();
            this.delProductButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageFieldPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // titleField
            // 
            this.titleField.Location = new System.Drawing.Point(24, 171);
            this.titleField.Name = "titleField";
            this.titleField.Size = new System.Drawing.Size(250, 20);
            this.titleField.TabIndex = 65;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 14);
            this.label9.TabIndex = 64;
            this.label9.Text = "Имя";
            // 
            // idField
            // 
            this.idField.Location = new System.Drawing.Point(24, 131);
            this.idField.Name = "idField";
            this.idField.Size = new System.Drawing.Size(250, 20);
            this.idField.TabIndex = 60;
            this.idField.TextChanged += new System.EventHandler(this.idField_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 14);
            this.label3.TabIndex = 59;
            this.label3.Text = "id";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::vosmerka.Properties.Resources.Восьмерка;
            this.pictureBox2.Location = new System.Drawing.Point(24, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(73, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 55;
            this.pictureBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 394);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 14);
            this.label7.TabIndex = 48;
            this.label7.Text = "Описание";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 354);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(231, 14);
            this.label6.TabIndex = 47;
            this.label6.Text = "Минимальная стоимость для агента";
            // 
            // descriptionField
            // 
            this.descriptionField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descriptionField.Location = new System.Drawing.Point(24, 411);
            this.descriptionField.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.descriptionField.Name = "descriptionField";
            this.descriptionField.Size = new System.Drawing.Size(250, 85);
            this.descriptionField.TabIndex = 46;
            this.descriptionField.Text = "";
            // 
            // minCostField
            // 
            this.minCostField.Location = new System.Drawing.Point(24, 371);
            this.minCostField.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.minCostField.Name = "minCostField";
            this.minCostField.Size = new System.Drawing.Size(250, 20);
            this.minCostField.TabIndex = 44;
            this.minCostField.Text = " ";
            this.minCostField.Validating += new System.ComponentModel.CancelEventHandler(this.minCostField_Validating);
            // 
            // numberWorkshopField
            // 
            this.numberWorkshopField.Location = new System.Drawing.Point(24, 331);
            this.numberWorkshopField.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numberWorkshopField.Name = "numberWorkshopField";
            this.numberWorkshopField.Size = new System.Drawing.Size(250, 20);
            this.numberWorkshopField.TabIndex = 43;
            // 
            // countPersonField
            // 
            this.countPersonField.Location = new System.Drawing.Point(24, 291);
            this.countPersonField.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.countPersonField.Name = "countPersonField";
            this.countPersonField.Size = new System.Drawing.Size(250, 20);
            this.countPersonField.TabIndex = 42;
            // 
            // articleField
            // 
            this.articleField.Location = new System.Drawing.Point(24, 211);
            this.articleField.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.articleField.Name = "articleField";
            this.articleField.Size = new System.Drawing.Size(250, 20);
            this.articleField.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 314);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 14);
            this.label5.TabIndex = 40;
            this.label5.Text = "Номер производственного цеха";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 274);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(252, 14);
            this.label4.TabIndex = 39;
            this.label4.Text = "Количество человек для производства";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 234);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 14);
            this.label2.TabIndex = 38;
            this.label2.Text = "Тип продукта";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 194);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 14);
            this.label1.TabIndex = 37;
            this.label1.Text = "Артикул";
            // 
            // typeProductcomboBox
            // 
            this.typeProductcomboBox.FormattingEnabled = true;
            this.typeProductcomboBox.Location = new System.Drawing.Point(24, 251);
            this.typeProductcomboBox.Name = "typeProductcomboBox";
            this.typeProductcomboBox.Size = new System.Drawing.Size(250, 22);
            this.typeProductcomboBox.TabIndex = 66;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(99)))), ((int)(((byte)(245)))));
            this.backButton.Location = new System.Drawing.Point(24, 502);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(106, 38);
            this.backButton.TabIndex = 67;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // moveButton
            // 
            this.moveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(99)))), ((int)(((byte)(245)))));
            this.moveButton.Location = new System.Drawing.Point(168, 502);
            this.moveButton.Name = "moveButton";
            this.moveButton.Size = new System.Drawing.Size(106, 38);
            this.moveButton.TabIndex = 68;
            this.moveButton.Text = "Вперед";
            this.moveButton.UseVisualStyleBackColor = false;
            this.moveButton.Click += new System.EventHandler(this.moveButton_Click);
            // 
            // dataGridViewMaterial
            // 
            this.dataGridViewMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMaterial.Location = new System.Drawing.Point(300, 131);
            this.dataGridViewMaterial.Name = "dataGridViewMaterial";
            this.dataGridViewMaterial.Size = new System.Drawing.Size(332, 150);
            this.dataGridViewMaterial.TabIndex = 69;
            this.dataGridViewMaterial.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMaterial_RowEnter);
            // 
            // materialcomboBox
            // 
            this.materialcomboBox.FormattingEnabled = true;
            this.materialcomboBox.Location = new System.Drawing.Point(300, 309);
            this.materialcomboBox.Name = "materialcomboBox";
            this.materialcomboBox.Size = new System.Drawing.Size(241, 22);
            this.materialcomboBox.TabIndex = 70;
            // 
            // countMaterialField
            // 
            this.countMaterialField.Location = new System.Drawing.Point(300, 354);
            this.countMaterialField.Name = "countMaterialField";
            this.countMaterialField.Size = new System.Drawing.Size(332, 20);
            this.countMaterialField.TabIndex = 71;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(297, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 14);
            this.label8.TabIndex = 72;
            this.label8.Text = "Материалы";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(297, 337);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 14);
            this.label10.TabIndex = 73;
            this.label10.Text = "Количество";
            // 
            // addMaterialButton
            // 
            this.addMaterialButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(99)))), ((int)(((byte)(245)))));
            this.addMaterialButton.Location = new System.Drawing.Point(300, 384);
            this.addMaterialButton.Name = "addMaterialButton";
            this.addMaterialButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addMaterialButton.Size = new System.Drawing.Size(92, 33);
            this.addMaterialButton.TabIndex = 74;
            this.addMaterialButton.Text = "Добавить";
            this.addMaterialButton.UseVisualStyleBackColor = false;
            this.addMaterialButton.Click += new System.EventHandler(this.addMaterialButton_Click);
            // 
            // delMaterialButton
            // 
            this.delMaterialButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(99)))), ((int)(((byte)(245)))));
            this.delMaterialButton.Location = new System.Drawing.Point(398, 384);
            this.delMaterialButton.Name = "delMaterialButton";
            this.delMaterialButton.Size = new System.Drawing.Size(141, 33);
            this.delMaterialButton.TabIndex = 75;
            this.delMaterialButton.Text = "Удалить материал";
            this.delMaterialButton.UseVisualStyleBackColor = false;
            this.delMaterialButton.Click += new System.EventHandler(this.delMaterialButton_Click);
            // 
            // findMaterialButton
            // 
            this.findMaterialButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(99)))), ((int)(((byte)(245)))));
            this.findMaterialButton.Location = new System.Drawing.Point(547, 308);
            this.findMaterialButton.Name = "findMaterialButton";
            this.findMaterialButton.Size = new System.Drawing.Size(85, 23);
            this.findMaterialButton.TabIndex = 76;
            this.findMaterialButton.Text = "Найти";
            this.findMaterialButton.UseVisualStyleBackColor = false;
            this.findMaterialButton.Click += new System.EventHandler(this.findMaterialButton_Click);
            // 
            // addProductButton
            // 
            this.addProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(99)))), ((int)(((byte)(245)))));
            this.addProductButton.Location = new System.Drawing.Point(27, 546);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(103, 35);
            this.addProductButton.TabIndex = 77;
            this.addProductButton.Text = "Добавить";
            this.addProductButton.UseVisualStyleBackColor = false;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // saveProductButton
            // 
            this.saveProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(99)))), ((int)(((byte)(245)))));
            this.saveProductButton.Location = new System.Drawing.Point(168, 546);
            this.saveProductButton.Name = "saveProductButton";
            this.saveProductButton.Size = new System.Drawing.Size(106, 35);
            this.saveProductButton.TabIndex = 78;
            this.saveProductButton.Text = "Сохранить";
            this.saveProductButton.UseVisualStyleBackColor = false;
            this.saveProductButton.Click += new System.EventHandler(this.saveProductButton_Click);
            // 
            // imageFieldPictureBox
            // 
            this.imageFieldPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageFieldPictureBox.Location = new System.Drawing.Point(663, 23);
            this.imageFieldPictureBox.Name = "imageFieldPictureBox";
            this.imageFieldPictureBox.Size = new System.Drawing.Size(620, 558);
            this.imageFieldPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageFieldPictureBox.TabIndex = 79;
            this.imageFieldPictureBox.TabStop = false;
            // 
            // addImageButton
            // 
            this.addImageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(99)))), ((int)(((byte)(245)))));
            this.addImageButton.Location = new System.Drawing.Point(663, 597);
            this.addImageButton.Name = "addImageButton";
            this.addImageButton.Size = new System.Drawing.Size(120, 38);
            this.addImageButton.TabIndex = 80;
            this.addImageButton.Text = "Добавить";
            this.addImageButton.UseVisualStyleBackColor = false;
            this.addImageButton.Click += new System.EventHandler(this.addImageButton_Click);
            // 
            // delProductButton
            // 
            this.delProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(99)))), ((int)(((byte)(245)))));
            this.delProductButton.Location = new System.Drawing.Point(313, 472);
            this.delProductButton.Name = "delProductButton";
            this.delProductButton.Size = new System.Drawing.Size(108, 39);
            this.delProductButton.TabIndex = 81;
            this.delProductButton.Text = "Удалить";
            this.delProductButton.UseVisualStyleBackColor = false;
            this.delProductButton.Click += new System.EventHandler(this.delProductButton_Click);
            // 
            // EditProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1307, 672);
            this.Controls.Add(this.delProductButton);
            this.Controls.Add(this.addImageButton);
            this.Controls.Add(this.imageFieldPictureBox);
            this.Controls.Add(this.saveProductButton);
            this.Controls.Add(this.addProductButton);
            this.Controls.Add(this.findMaterialButton);
            this.Controls.Add(this.delMaterialButton);
            this.Controls.Add(this.addMaterialButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.countMaterialField);
            this.Controls.Add(this.materialcomboBox);
            this.Controls.Add(this.dataGridViewMaterial);
            this.Controls.Add(this.moveButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.typeProductcomboBox);
            this.Controls.Add(this.titleField);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.idField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.descriptionField);
            this.Controls.Add(this.minCostField);
            this.Controls.Add(this.numberWorkshopField);
            this.Controls.Add(this.countPersonField);
            this.Controls.Add(this.articleField);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "EditProductForm";
            this.Text = "Редактирование";
            this.Load += new System.EventHandler(this.EditProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageFieldPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox titleField;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox idField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox descriptionField;
        private System.Windows.Forms.TextBox minCostField;
        private System.Windows.Forms.TextBox numberWorkshopField;
        private System.Windows.Forms.TextBox countPersonField;
        private System.Windows.Forms.TextBox articleField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox typeProductcomboBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button moveButton;
        private System.Windows.Forms.DataGridView dataGridViewMaterial;
        private System.Windows.Forms.ComboBox materialcomboBox;
        private System.Windows.Forms.TextBox countMaterialField;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button addMaterialButton;
        private System.Windows.Forms.Button delMaterialButton;
        private System.Windows.Forms.Button findMaterialButton;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Button saveProductButton;
        private System.Windows.Forms.PictureBox imageFieldPictureBox;
        private System.Windows.Forms.Button addImageButton;
        private System.Windows.Forms.Button delProductButton;
    }
}