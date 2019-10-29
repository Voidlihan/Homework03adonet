using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace hw3
{
    partial class Form1 : Form
    {
        private System.ComponentModel.IContainer components = null;
        private static string connectionString;
        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        public Button but = new Button();
        public Form1()
        {
            Console.WriteLine("Добро пожаловать, напишите снизу строку подключения базы данных");
            connectionString = Console.ReadLine();
            but.Text = "Подключиться";
            but.Size = new Size(60, 20);
            but.Location = new Point(10, 10);           
            but.Click += new EventHandler(but_Click);
            this.Controls.Add(but);
        }
        private void but_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы подключились к серверу!");
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Form1";
            this.Text = "SqlConnect";
            this.ResumeLayout(false);

        }

        #endregion
    }
}
