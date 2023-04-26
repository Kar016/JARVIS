namespace Problema__14
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
            this.chlbAlimentos = new System.Windows.Forms.CheckedListBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.textNuevoAlimento = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chlbAlimentos
            // 
            this.chlbAlimentos.CheckOnClick = true;
            this.chlbAlimentos.FormattingEnabled = true;
            this.chlbAlimentos.Items.AddRange(new object[] {
            "Arroz",
            "Maiz"});
            this.chlbAlimentos.Location = new System.Drawing.Point(12, 12);
            this.chlbAlimentos.Name = "chlbAlimentos";
            this.chlbAlimentos.Size = new System.Drawing.Size(231, 94);
            this.chlbAlimentos.TabIndex = 0;
            this.chlbAlimentos.SelectedIndexChanged += new System.EventHandler(this.chlbAlimentos_SelectedIndexChanged);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(168, 155);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 1;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // textNuevoAlimento
            // 
            this.textNuevoAlimento.Location = new System.Drawing.Point(12, 155);
            this.textNuevoAlimento.Multiline = true;
            this.textNuevoAlimento.Name = "textNuevoAlimento";
            this.textNuevoAlimento.Size = new System.Drawing.Size(100, 23);
            this.textNuevoAlimento.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 128);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(35, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 261);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.textNuevoAlimento);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.chlbAlimentos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chlbAlimentos;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TextBox textNuevoAlimento;
        private System.Windows.Forms.Label lblNombre;
    }
}

