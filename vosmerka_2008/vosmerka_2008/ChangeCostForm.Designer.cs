namespace WindowsFormsApplication1
{
    partial class ChangeCostForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeCostForm));
            this.textBoxChangeCost = new System.Windows.Forms.TextBox();
            this.changeCostButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxChangeCost
            // 
            this.textBoxChangeCost.Location = new System.Drawing.Point(112, 98);
            this.textBoxChangeCost.Name = "textBoxChangeCost";
            this.textBoxChangeCost.Size = new System.Drawing.Size(100, 20);
            this.textBoxChangeCost.TabIndex = 0;
            // 
            // changeCostButton
            // 
            this.changeCostButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(99)))), ((int)(((byte)(245)))));
            this.changeCostButton.Location = new System.Drawing.Point(112, 136);
            this.changeCostButton.Name = "changeCostButton";
            this.changeCostButton.Size = new System.Drawing.Size(100, 30);
            this.changeCostButton.TabIndex = 1;
            this.changeCostButton.Text = "Изменить";
            this.changeCostButton.UseVisualStyleBackColor = false;
            this.changeCostButton.Click += new System.EventHandler(this.changeCostButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(99)))), ((int)(((byte)(245)))));
            this.backButton.Location = new System.Drawing.Point(112, 185);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(100, 31);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // ChangeCostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(331, 281);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.changeCostButton);
            this.Controls.Add(this.textBoxChangeCost);
            this.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangeCostForm";
            this.Text = "Изменение стоимости";
            this.Load += new System.EventHandler(this.ChangeCostForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxChangeCost;
        private System.Windows.Forms.Button changeCostButton;
        private System.Windows.Forms.Button backButton;
    }
}