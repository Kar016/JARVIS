namespace Problema__18
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
            this.lbFrutas = new System.Windows.Forms.ListBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.textFruta = new System.Windows.Forms.TextBox();
            this.lblFruta = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbFrutas
            // 
            this.lbFrutas.FormattingEnabled = true;
            this.lbFrutas.Items.AddRange(new object[] {
            "Manzana",
            "Pera",
            "Durazno"});
            this.lbFrutas.Location = new System.Drawing.Point(12, 12);
            this.lbFrutas.Name = "lbFrutas";
            this.lbFrutas.Size = new System.Drawing.Size(120, 95);
            this.lbFrutas.TabIndex = 0;
            this.lbFrutas.SelectedIndexChanged += new System.EventHandler(this.lbFrutas_SelectedIndexChanged);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(137, 150);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(71, 24);
            this.btnAdicionar.TabIndex = 1;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // textFruta
            // 
            this.textFruta.Location = new System.Drawing.Point(12, 150);
            this.textFruta.Name = "textFruta";
            this.textFruta.Size = new System.Drawing.Size(119, 20);
            this.textFruta.TabIndex = 2;
            // 
            // lblFruta
            // 
            this.lblFruta.AutoSize = true;
            this.lblFruta.Location = new System.Drawing.Point(12, 119);
            this.lblFruta.Name = "lblFruta";
            this.lblFruta.Size = new System.Drawing.Size(35, 13);
            this.lblFruta.TabIndex = 3;
            this.lblFruta.Text = "label1";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(137, 180);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(71, 24);
            this.btnBorrar.TabIndex = 4;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 281);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.lblFruta);
            this.Controls.Add(this.textFruta);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.lbFrutas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbFrutas;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TextBox textFruta;
        private System.Windows.Forms.Label lblFruta;
        private System.Windows.Forms.Button btnBorrar;
    }
}

