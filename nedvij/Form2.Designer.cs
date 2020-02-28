namespace nedvij
{
    partial class Form2
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
            this.complex_name = new System.Windows.Forms.TextBox();
            this.complex_addcost = new System.Windows.Forms.TextBox();
            this.complex_cost = new System.Windows.Forms.TextBox();
            this.complex_city = new System.Windows.Forms.TextBox();
            this.complex_add = new System.Windows.Forms.Button();
            this.complex_status = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // complex_name
            // 
            this.complex_name.Location = new System.Drawing.Point(187, 83);
            this.complex_name.Name = "complex_name";
            this.complex_name.Size = new System.Drawing.Size(181, 20);
            this.complex_name.TabIndex = 0;
            // 
            // complex_addcost
            // 
            this.complex_addcost.Location = new System.Drawing.Point(187, 109);
            this.complex_addcost.Name = "complex_addcost";
            this.complex_addcost.Size = new System.Drawing.Size(181, 20);
            this.complex_addcost.TabIndex = 1;
            // 
            // complex_cost
            // 
            this.complex_cost.Location = new System.Drawing.Point(187, 161);
            this.complex_cost.Name = "complex_cost";
            this.complex_cost.Size = new System.Drawing.Size(181, 20);
            this.complex_cost.TabIndex = 3;
            // 
            // complex_city
            // 
            this.complex_city.Location = new System.Drawing.Point(187, 187);
            this.complex_city.Name = "complex_city";
            this.complex_city.Size = new System.Drawing.Size(181, 20);
            this.complex_city.TabIndex = 4;
            // 
            // complex_add
            // 
            this.complex_add.Location = new System.Drawing.Point(230, 227);
            this.complex_add.Name = "complex_add";
            this.complex_add.Size = new System.Drawing.Size(87, 28);
            this.complex_add.TabIndex = 5;
            this.complex_add.Text = "Добавить";
            this.complex_add.UseVisualStyleBackColor = true;
            this.complex_add.Click += new System.EventHandler(this.complex_add_Click);
            // 
            // complex_status
            // 
            this.complex_status.FormattingEnabled = true;
            this.complex_status.Items.AddRange(new object[] {
            "План",
            "Строительство",
            "Реализация"});
            this.complex_status.Location = new System.Drawing.Point(187, 134);
            this.complex_status.Name = "complex_status";
            this.complex_status.Size = new System.Drawing.Size(181, 21);
            this.complex_status.TabIndex = 6;
            this.complex_status.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Название ЖК";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Добавочная стоимость";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Статус";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Затраты на строительство";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Город";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 314);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.complex_status);
            this.Controls.Add(this.complex_add);
            this.Controls.Add(this.complex_city);
            this.Controls.Add(this.complex_cost);
            this.Controls.Add(this.complex_addcost);
            this.Controls.Add(this.complex_name);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox complex_name;
        private System.Windows.Forms.TextBox complex_addcost;
        private System.Windows.Forms.TextBox complex_cost;
        private System.Windows.Forms.TextBox complex_city;
        private System.Windows.Forms.Button complex_add;
        private System.Windows.Forms.ComboBox complex_status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}