namespace Problema__9
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.Grupo1 = new System.Windows.Forms.GroupBox();
            this.rbBasico = new System.Windows.Forms.RadioButton();
            this.rbTerceros = new System.Windows.Forms.RadioButton();
            this.rbTotal = new System.Windows.Forms.RadioButton();
            this.lblSeguro = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblEquipo = new System.Windows.Forms.Label();
            this.chkAire = new System.Windows.Forms.CheckBox();
            this.chkAudio = new System.Windows.Forms.CheckBox();
            this.lblCosto = new System.Windows.Forms.Label();
            this.textConteo = new System.Windows.Forms.TextBox();
            this.btnCotizar = new System.Windows.Forms.Button();
            this.textCotizacion = new System.Windows.Forms.TextBox();
            this.Grupo1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(12, 9);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(68, 18);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // textNombre
            // 
            this.textNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombre.Location = new System.Drawing.Point(86, 9);
            this.textNombre.Multiline = true;
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(139, 23);
            this.textNombre.TabIndex = 1;
            // 
            // Grupo1
            // 
            this.Grupo1.Controls.Add(this.lblSeguro);
            this.Grupo1.Controls.Add(this.rbTotal);
            this.Grupo1.Controls.Add(this.rbTerceros);
            this.Grupo1.Controls.Add(this.rbBasico);
            this.Grupo1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grupo1.Location = new System.Drawing.Point(15, 47);
            this.Grupo1.Name = "Grupo1";
            this.Grupo1.Size = new System.Drawing.Size(237, 129);
            this.Grupo1.TabIndex = 2;
            this.Grupo1.TabStop = false;
            this.Grupo1.Text = "Seguro a seleccionar:";
            // 
            // rbBasico
            // 
            this.rbBasico.AutoSize = true;
            this.rbBasico.Checked = true;
            this.rbBasico.Location = new System.Drawing.Point(80, 30);
            this.rbBasico.Name = "rbBasico";
            this.rbBasico.Size = new System.Drawing.Size(71, 21);
            this.rbBasico.TabIndex = 3;
            this.rbBasico.TabStop = true;
            this.rbBasico.Text = "Basico";
            this.rbBasico.UseVisualStyleBackColor = true;
            // 
            // rbTerceros
            // 
            this.rbTerceros.AutoSize = true;
            this.rbTerceros.Location = new System.Drawing.Point(80, 57);
            this.rbTerceros.Name = "rbTerceros";
            this.rbTerceros.Size = new System.Drawing.Size(95, 21);
            this.rbTerceros.TabIndex = 4;
            this.rbTerceros.Text = "A Terceros";
            this.rbTerceros.UseVisualStyleBackColor = true;
            // 
            // rbTotal
            // 
            this.rbTotal.AutoSize = true;
            this.rbTotal.Location = new System.Drawing.Point(80, 84);
            this.rbTotal.Name = "rbTotal";
            this.rbTotal.Size = new System.Drawing.Size(56, 21);
            this.rbTotal.TabIndex = 5;
            this.rbTotal.Text = "Total";
            this.rbTotal.UseVisualStyleBackColor = true;
            // 
            // lblSeguro
            // 
            this.lblSeguro.AutoSize = true;
            this.lblSeguro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeguro.Location = new System.Drawing.Point(6, 30);
            this.lblSeguro.Name = "lblSeguro";
            this.lblSeguro.Size = new System.Drawing.Size(63, 18);
            this.lblSeguro.TabIndex = 3;
            this.lblSeguro.Text = "Seguro:";
            this.lblSeguro.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkAudio);
            this.groupBox1.Controls.Add(this.chkAire);
            this.groupBox1.Controls.Add(this.lblEquipo);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(306, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 129);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Equipamiento";
            // 
            // lblEquipo
            // 
            this.lblEquipo.AutoSize = true;
            this.lblEquipo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipo.Location = new System.Drawing.Point(6, 31);
            this.lblEquipo.Name = "lblEquipo";
            this.lblEquipo.Size = new System.Drawing.Size(62, 18);
            this.lblEquipo.TabIndex = 6;
            this.lblEquipo.Text = "Equipo:";
            // 
            // chkAire
            // 
            this.chkAire.AutoSize = true;
            this.chkAire.Location = new System.Drawing.Point(84, 30);
            this.chkAire.Name = "chkAire";
            this.chkAire.Size = new System.Drawing.Size(163, 22);
            this.chkAire.TabIndex = 7;
            this.chkAire.Text = "Aire acondicionado";
            this.chkAire.UseVisualStyleBackColor = true;
            // 
            // chkAudio
            // 
            this.chkAudio.AutoSize = true;
            this.chkAudio.Location = new System.Drawing.Point(84, 58);
            this.chkAudio.Name = "chkAudio";
            this.chkAudio.Size = new System.Drawing.Size(150, 22);
            this.chkAudio.TabIndex = 8;
            this.chkAudio.Text = "Sistema de audio";
            this.chkAudio.UseVisualStyleBackColor = true;
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCosto.Location = new System.Drawing.Point(21, 205);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(54, 18);
            this.lblCosto.TabIndex = 6;
            this.lblCosto.Text = "Costo:";
            // 
            // textConteo
            // 
            this.textConteo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textConteo.Location = new System.Drawing.Point(89, 205);
            this.textConteo.Multiline = true;
            this.textConteo.Name = "textConteo";
            this.textConteo.Size = new System.Drawing.Size(139, 23);
            this.textConteo.TabIndex = 7;
            this.textConteo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCotizar
            // 
            this.btnCotizar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCotizar.Location = new System.Drawing.Point(260, 207);
            this.btnCotizar.Name = "btnCotizar";
            this.btnCotizar.Size = new System.Drawing.Size(75, 23);
            this.btnCotizar.TabIndex = 8;
            this.btnCotizar.Text = "Cotizar";
            this.btnCotizar.UseVisualStyleBackColor = true;
            this.btnCotizar.Click += new System.EventHandler(this.btnCotizar_Click);
            // 
            // textCotizacion
            // 
            this.textCotizacion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCotizacion.Location = new System.Drawing.Point(15, 250);
            this.textCotizacion.Multiline = true;
            this.textCotizacion.Name = "textCotizacion";
            this.textCotizacion.Size = new System.Drawing.Size(683, 231);
            this.textCotizacion.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 493);
            this.Controls.Add(this.textCotizacion);
            this.Controls.Add(this.btnCotizar);
            this.Controls.Add(this.textConteo);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Grupo1);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Grupo1.ResumeLayout(false);
            this.Grupo1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.GroupBox Grupo1;
        private System.Windows.Forms.Label lblSeguro;
        private System.Windows.Forms.RadioButton rbTotal;
        private System.Windows.Forms.RadioButton rbTerceros;
        private System.Windows.Forms.RadioButton rbBasico;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkAudio;
        private System.Windows.Forms.CheckBox chkAire;
        private System.Windows.Forms.Label lblEquipo;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.TextBox textConteo;
        private System.Windows.Forms.Button btnCotizar;
        private System.Windows.Forms.TextBox textCotizacion;
    }
}

