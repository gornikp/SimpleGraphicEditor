﻿namespace GrafikaKomputerowa.Zad5
{
    partial class Kuwahara
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.int32TextBox1 = new GrafikaKomputerowa.Zad4.Int32TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Podaj wielkość maski";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // int32TextBox1
            // 
            this.int32TextBox1.Location = new System.Drawing.Point(15, 36);
            this.int32TextBox1.Name = "int32TextBox1";
            this.int32TextBox1.Size = new System.Drawing.Size(100, 20);
            this.int32TextBox1.TabIndex = 3;
            // 
            // Kuwahara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(133, 96);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.int32TextBox1);
            this.Name = "Kuwahara";
            this.Text = "Kuwahara";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Kuwahara_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        public Zad4.Int32TextBox int32TextBox1;
    }
}