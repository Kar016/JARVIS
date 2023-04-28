namespace Problema__29
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.textMensaje = new System.Windows.Forms.TextBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // btnMostrar
            // 
            this.helpProvider1.SetHelpString(this.btnMostrar, "Este boton permite mostrar el mensaje");
            this.btnMostrar.Location = new System.Drawing.Point(214, 48);
            this.btnMostrar.Name = "btnMostrar";
            this.helpProvider1.SetShowHelp(this.btnMostrar, true);
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 0;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(40, 146);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(35, 13);
            this.lblMensaje.TabIndex = 1;
            this.lblMensaje.Text = "label1";
            // 
            // textMensaje
            // 
            this.helpProvider1.SetHelpString(this.textMensaje, "Coloca aqui el mensaje");
            this.textMensaje.Location = new System.Drawing.Point(12, 50);
            this.textMensaje.Multiline = true;
            this.textMensaje.Name = "textMensaje";
            this.helpProvider1.SetShowHelp(this.textMensaje, true);
            this.textMensaje.Size = new System.Drawing.Size(145, 23);
            this.textMensaje.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 212);
            this.Controls.Add(this.textMensaje);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnMostrar);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.TextBox textMensaje;
    }
}

