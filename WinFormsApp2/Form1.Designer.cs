﻿namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(127, 31);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(127, 69);
            label2.Name = "label2";
            label2.Size = new Size(149, 23);
            label2.TabIndex = 1;
            label2.Text = "hola, mundo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Romantic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(170, 181);
            label3.Name = "label3";
            label3.Size = new Size(142, 19);
            label3.TabIndex = 2;
            label3.Text = "Cual es tu nombre?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Romantic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(170, 265);
            label4.Name = "label4";
            label4.Size = new Size(179, 19);
            label4.TabIndex = 3;
            label4.Text = "HELLO, alguien especial";
            // 
            // button1
            // 
            button1.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Image = Properties.Resources.images;
            button1.Location = new Point(355, 205);
            button1.Name = "button1";
            button1.Size = new Size(90, 42);
            button1.TabIndex = 4;
            button1.Text = "Diga \"Hello\"";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(170, 215);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(143, 23);
            textBox1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private TextBox textBox1;
    }
}