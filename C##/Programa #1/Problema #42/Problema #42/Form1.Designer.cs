namespace Problema__42
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
            this.btnInvalidate = new System.Windows.Forms.Button();
            this.btnDibuja = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInvalidate
            // 
            this.btnInvalidate.Location = new System.Drawing.Point(624, 28);
            this.btnInvalidate.Name = "btnInvalidate";
            this.btnInvalidate.Size = new System.Drawing.Size(75, 23);
            this.btnInvalidate.TabIndex = 0;
            this.btnInvalidate.Text = "Invalidate";
            this.btnInvalidate.UseVisualStyleBackColor = true;
            this.btnInvalidate.Click += new System.EventHandler(this.btnInvalidate_Click);
            // 
            // btnDibuja
            // 
            this.btnDibuja.Location = new System.Drawing.Point(624, 57);
            this.btnDibuja.Name = "btnDibuja";
            this.btnDibuja.Size = new System.Drawing.Size(75, 23);
            this.btnDibuja.TabIndex = 1;
            this.btnDibuja.Text = "Dibuja";
            this.btnDibuja.UseVisualStyleBackColor = true;
            this.btnDibuja.Click += new System.EventHandler(this.btnDibuja_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 262);
            this.Controls.Add(this.btnDibuja);
            this.Controls.Add(this.btnInvalidate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInvalidate;
        private System.Windows.Forms.Button btnDibuja;
    }
}

