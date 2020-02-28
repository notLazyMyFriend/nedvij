namespace nedvij
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NameComplex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count_houses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cities = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filter_apply = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.city_filter = new System.Windows.Forms.ComboBox();
            this.filter_clear = new System.Windows.Forms.Button();
            this.row_delete = new System.Windows.Forms.Button();
            this.row_edit = new System.Windows.Forms.Button();
            this.row_add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameComplex,
            this.status,
            this.count_houses,
            this.cities});
            this.dataGridView1.Location = new System.Drawing.Point(54, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(609, 223);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            this.dataGridView1.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_UserDeletedRow);
            // 
            // NameComplex
            // 
            this.NameComplex.HeaderText = "Название ЖК";
            this.NameComplex.Name = "NameComplex";
            // 
            // status
            // 
            this.status.HeaderText = "Статус";
            this.status.Name = "status";
            // 
            // count_houses
            // 
            this.count_houses.HeaderText = "КоличествоДомов";
            this.count_houses.Name = "count_houses";
            // 
            // cities
            // 
            this.cities.HeaderText = "Города";
            this.cities.Name = "cities";
            // 
            // filter_apply
            // 
            this.filter_apply.Location = new System.Drawing.Point(504, 36);
            this.filter_apply.Name = "filter_apply";
            this.filter_apply.Size = new System.Drawing.Size(77, 26);
            this.filter_apply.TabIndex = 2;
            this.filter_apply.Text = "Применить";
            this.filter_apply.UseVisualStyleBackColor = true;
            this.filter_apply.Click += new System.EventHandler(this.filter_apply_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(392, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Фильтр:";
            // 
            // city_filter
            // 
            this.city_filter.FormattingEnabled = true;
            this.city_filter.Location = new System.Drawing.Point(395, 39);
            this.city_filter.Name = "city_filter";
            this.city_filter.Size = new System.Drawing.Size(103, 21);
            this.city_filter.TabIndex = 4;
            // 
            // filter_clear
            // 
            this.filter_clear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.filter_clear.Location = new System.Drawing.Point(587, 36);
            this.filter_clear.Name = "filter_clear";
            this.filter_clear.Size = new System.Drawing.Size(76, 26);
            this.filter_clear.TabIndex = 5;
            this.filter_clear.Text = "Сбросить";
            this.filter_clear.UseVisualStyleBackColor = true;
            this.filter_clear.Click += new System.EventHandler(this.filter_clear_Click);
            // 
            // row_delete
            // 
            this.row_delete.Location = new System.Drawing.Point(411, 309);
            this.row_delete.Name = "row_delete";
            this.row_delete.Size = new System.Drawing.Size(95, 27);
            this.row_delete.TabIndex = 6;
            this.row_delete.Text = "Удалить";
            this.row_delete.UseVisualStyleBackColor = true;
            this.row_delete.Click += new System.EventHandler(this.row_delete_click);
            // 
            // row_edit
            // 
            this.row_edit.Location = new System.Drawing.Point(310, 309);
            this.row_edit.Name = "row_edit";
            this.row_edit.Size = new System.Drawing.Size(95, 27);
            this.row_edit.TabIndex = 7;
            this.row_edit.Text = "Изменить";
            this.row_edit.UseVisualStyleBackColor = true;
            this.row_edit.Click += new System.EventHandler(this.row_edit_Click);
            // 
            // row_add
            // 
            this.row_add.Location = new System.Drawing.Point(209, 309);
            this.row_add.Name = "row_add";
            this.row_add.Size = new System.Drawing.Size(95, 27);
            this.row_add.TabIndex = 8;
            this.row_add.Text = "Добавить";
            this.row_add.UseVisualStyleBackColor = true;
            this.row_add.Click += new System.EventHandler(this.row_add_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 450);
            this.Controls.Add(this.row_add);
            this.Controls.Add(this.row_edit);
            this.Controls.Add(this.row_delete);
            this.Controls.Add(this.filter_clear);
            this.Controls.Add(this.city_filter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filter_apply);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameComplex;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn count_houses;
        private System.Windows.Forms.DataGridViewTextBoxColumn cities;
        private System.Windows.Forms.Button filter_apply;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox city_filter;
        private System.Windows.Forms.Button filter_clear;
        private System.Windows.Forms.Button row_delete;
        private System.Windows.Forms.Button row_edit;
        private System.Windows.Forms.Button row_add;
    }
}

