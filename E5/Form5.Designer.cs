﻿namespace E5
{
    partial class Form5
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
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.DateTime = new System.Windows.Forms.TextBox();
            this.FIO = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(258, 184);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(285, 44);
            this.button2.TabIndex = 13;
            this.button2.Text = "Обновить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Введите ФИО:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Введите значение в формате: ГГГГ-MM-ДД ЧЧ:ММ:СС.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(258, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(285, 44);
            this.button1.TabIndex = 10;
            this.button1.Text = "Добавить запись";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DateTime
            // 
            this.DateTime.Location = new System.Drawing.Point(258, 108);
            this.DateTime.Name = "DateTime";
            this.DateTime.Size = new System.Drawing.Size(284, 20);
            this.DateTime.TabIndex = 9;
            // 
            // FIO
            // 
            this.FIO.Location = new System.Drawing.Point(258, 69);
            this.FIO.Name = "FIO";
            this.FIO.Size = new System.Drawing.Size(285, 20);
            this.FIO.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 241);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(741, 193);
            this.dataGridView1.TabIndex = 7;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DateTime);
            this.Controls.Add(this.FIO);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form5";
            this.Text = "5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox DateTime;
        private System.Windows.Forms.TextBox FIO;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

