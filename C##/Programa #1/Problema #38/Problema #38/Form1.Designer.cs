namespace Problema__38
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
            this.textMensaje = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbManzana = new System.Windows.Forms.RadioButton();
            this.rbPera = new System.Windows.Forms.RadioButton();
            this.rbCereza = new System.Windows.Forms.RadioButton();
            this.ckbImportado = new System.Windows.Forms.CheckBox();
            this.ckbOrganico = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textMensaje
            // 
            this.textMensaje.Location = new System.Drawing.Point(12, 12);
            this.textMensaje.Name = "textMensaje";
            this.textMensaje.Size = new System.Drawing.Size(100, 20);
            this.textMensaje.TabIndex = 0;
            this.textMensaje.TextChanged += new System.EventHandler(this.textMensaje_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbCereza);
            this.groupBox1.Controls.Add(this.rbPera);
            this.groupBox1.Controls.Add(this.rbManzana);
            this.groupBox1.Location = new System.Drawing.Point(12, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(135, 124);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rbManzana
            // 
            this.rbManzana.AutoSize = true;
            this.rbManzana.Location = new System.Drawing.Point(6, 29);
            this.rbManzana.Name = "rbManzana";
            this.rbManzana.Size = new System.Drawing.Size(69, 17);
            this.rbManzana.TabIndex = 2;
            this.rbManzana.Text = "Manzana";
            this.rbManzana.UseVisualStyleBackColor = true;
            this.rbManzana.CheckedChanged += new System.EventHandler(this.rbManzana_CheckedChanged);
            // 
            // rbPera
            // 
            this.rbPera.AutoSize = true;
            this.rbPera.Location = new System.Drawing.Point(6, 52);
            this.rbPera.Name = "rbPera";
            this.rbPera.Size = new System.Drawing.Size(47, 17);
            this.rbPera.TabIndex = 3;
            this.rbPera.Text = "Pera";
            this.rbPera.UseVisualStyleBackColor = true;
            this.rbPera.CheckedChanged += new System.EventHandler(this.rbPera_CheckedChanged);
            // 
            // rbCereza
            // 
            this.rbCereza.AutoSize = true;
            this.rbCereza.Checked = true;
            this.rbCereza.Location = new System.Drawing.Point(6, 75);
            this.rbCereza.Name = "rbCereza";
            this.rbCereza.Size = new System.Drawing.Size(58, 17);
            this.rbCereza.TabIndex = 4;
            this.rbCereza.TabStop = true;
            this.rbCereza.Text = "Cereza";
            this.rbCereza.UseVisualStyleBackColor = true;
            this.rbCereza.CheckedChanged += new System.EventHandler(this.rbCereza_CheckedChanged);
            // 
            // ckbImportado
            // 
            this.ckbImportado.AutoSize = true;
            this.ckbImportado.Location = new System.Drawing.Point(177, 116);
            this.ckbImportado.Name = "ckbImportado";
            this.ckbImportado.Size = new System.Drawing.Size(73, 17);
            this.ckbImportado.TabIndex = 2;
            this.ckbImportado.Text = "Importado";
            this.ckbImportado.UseVisualStyleBackColor = true;
            this.ckbImportado.CheckStateChanged += new System.EventHandler(this.ckbImportado_CheckStateChanged);
            // 
            // ckbOrganico
            // 
            this.ckbOrganico.AutoSize = true;
            this.ckbOrganico.Location = new System.Drawing.Point(181, 139);
            this.ckbOrganico.Name = "ckbOrganico";
            this.ckbOrganico.Size = new System.Drawing.Size(69, 17);
            this.ckbOrganico.TabIndex = 3;
            this.ckbOrganico.Text = "Organico";
            this.ckbOrganico.UseVisualStyleBackColor = true;
            this.ckbOrganico.CheckStateChanged += new System.EventHandler(this.ckbOrganico_CheckStateChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ckbOrganico);
            this.Controls.Add(this.ckbImportado);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textMensaje);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textMensaje;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbCereza;
        private System.Windows.Forms.RadioButton rbPera;
        private System.Windows.Forms.RadioButton rbManzana;
        private System.Windows.Forms.CheckBox ckbImportado;
        private System.Windows.Forms.CheckBox ckbOrganico;
    }
}

