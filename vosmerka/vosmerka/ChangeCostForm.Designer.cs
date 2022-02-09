namespace vosmerka
{
    partial class ChangeCostForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeCostForm));
            this.changeCostButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxChangeCost = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // changeCostButton
            // 
            this.changeCostButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(99)))), ((int)(((byte)(245)))));
            this.changeCostButton.Location = new System.Drawing.Point(90, 104);
            this.changeCostButton.Name = "changeCostButton";
            this.changeCostButton.Size = new System.Drawing.Size(100, 35);
            this.changeCostButton.TabIndex = 0;
            this.changeCostButton.Text = "Изменить";
            this.changeCostButton.UseVisualStyleBackColor = false;
            this.changeCostButton.Click += new System.EventHandler(this.changeCostButton_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(99)))), ((int)(((byte)(245)))));
            this.button2.Location = new System.Drawing.Point(90, 145);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 38);
            this.button2.TabIndex = 2;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // textBoxChangeCost
            // 
            this.textBoxChangeCost.Location = new System.Drawing.Point(90, 69);
            this.textBoxChangeCost.Name = "textBoxChangeCost";
            this.textBoxChangeCost.Size = new System.Drawing.Size(100, 20);
            this.textBoxChangeCost.TabIndex = 3;
            // 
            // ChangeCostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.textBoxChangeCost);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.changeCostButton);
            this.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ChangeCostForm";
            this.Text = "Изменение стоимости";
            this.Load += new System.EventHandler(this.ChangeCostForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button changeCostButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxChangeCost;
    }
}