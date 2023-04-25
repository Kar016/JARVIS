namespace Problema__8
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
            lblMensaje = new Label();
            lblComentario = new Label();
            SuspendLayout();
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblMensaje.Location = new Point(12, 21);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(46, 17);
            lblMensaje.TabIndex = 0;
            lblMensaje.Text = "label1";
            // 
            // lblComentario
            // 
            lblComentario.AutoSize = true;
            lblComentario.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblComentario.Location = new Point(12, 49);
            lblComentario.Name = "lblComentario";
            lblComentario.Size = new Size(50, 18);
            lblComentario.TabIndex = 1;
            lblComentario.Text = "label1";
            lblComentario.Click += label1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(295, 103);
            Controls.Add(lblComentario);
            Controls.Add(lblMensaje);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMensaje;
        private Label lblComentario;
    }
}