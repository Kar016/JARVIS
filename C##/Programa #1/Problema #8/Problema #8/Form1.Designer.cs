﻿namespace Problema__8
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
            btnEnviar = new Button();
            textMensaje = new TextBox();
            SuspendLayout();
            // 
            // btnEnviar
            // 
            btnEnviar.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEnviar.Location = new Point(222, 26);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(75, 23);
            btnEnviar.TabIndex = 3;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // textMensaje
            // 
            textMensaje.Location = new Point(12, 26);
            textMensaje.Name = "textMensaje";
            textMensaje.Size = new Size(129, 23);
            textMensaje.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(309, 92);
            Controls.Add(btnEnviar);
            Controls.Add(textMensaje);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEnviar;
        private TextBox textMensaje;
    }
}