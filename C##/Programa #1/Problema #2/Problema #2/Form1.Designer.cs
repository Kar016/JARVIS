namespace Problema__2
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
            lblNombre = new Label();
            textNombre = new TextBox();
            lblMensaje = new Label();
            btnSaludo = new Button();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(13, 54);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(59, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "NOMBRE:";
            lblNombre.Click += label1_Click;
            // 
            // textNombre
            // 
            textNombre.Location = new Point(78, 46);
            textNombre.Multiline = true;
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(168, 30);
            textNombre.TabIndex = 1;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(22, 106);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(38, 15);
            lblMensaje.TabIndex = 2;
            lblMensaje.Text = "label1";
            // 
            // btnSaludo
            // 
            btnSaludo.Location = new Point(286, 46);
            btnSaludo.Name = "btnSaludo";
            btnSaludo.Size = new Size(75, 30);
            btnSaludo.TabIndex = 3;
            btnSaludo.Text = "Saludo";
            btnSaludo.UseVisualStyleBackColor = true;
            btnSaludo.Click += btnSaludo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 147);
            Controls.Add(btnSaludo);
            Controls.Add(lblMensaje);
            Controls.Add(textNombre);
            Controls.Add(lblNombre);
            Name = "Form1";
            Text = "Problema #2";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private TextBox textNombre;
        private Label lblMensaje;
        private Button btnSaludo;
    }
}