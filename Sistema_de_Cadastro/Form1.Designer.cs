﻿namespace Sistema_de_Cadastro
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
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(40, 12);
            button1.Name = "button1";
            button1.Size = new Size(254, 130);
            button1.TabIndex = 0;
            button1.Text = "Cadastrar Contato";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(43, 174);
            button2.Name = "button2";
            button2.Size = new Size(254, 130);
            button2.TabIndex = 1;
            button2.Text = "Exibir Lista";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 332);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Cadastrar";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
    }
}