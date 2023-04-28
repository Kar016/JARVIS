namespace Problema__36
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.textNodo = new System.Windows.Forms.TextBox();
            this.textElemento = new System.Windows.Forms.TextBox();
            this.btnAdicionarNodo = new System.Windows.Forms.Button();
            this.btnAdicionarElemento = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(165, 338);
            this.treeView1.TabIndex = 0;
            // 
            // textNodo
            // 
            this.textNodo.Location = new System.Drawing.Point(200, 15);
            this.textNodo.Name = "textNodo";
            this.textNodo.Size = new System.Drawing.Size(100, 20);
            this.textNodo.TabIndex = 1;
            // 
            // textElemento
            // 
            this.textElemento.Location = new System.Drawing.Point(200, 44);
            this.textElemento.Name = "textElemento";
            this.textElemento.Size = new System.Drawing.Size(100, 20);
            this.textElemento.TabIndex = 2;
            // 
            // btnAdicionarNodo
            // 
            this.btnAdicionarNodo.Location = new System.Drawing.Point(336, 12);
            this.btnAdicionarNodo.Name = "btnAdicionarNodo";
            this.btnAdicionarNodo.Size = new System.Drawing.Size(116, 23);
            this.btnAdicionarNodo.TabIndex = 3;
            this.btnAdicionarNodo.Text = "Adicionar Nodo";
            this.btnAdicionarNodo.UseVisualStyleBackColor = true;
            this.btnAdicionarNodo.Click += new System.EventHandler(this.btnAdicionarNodo_Click);
            // 
            // btnAdicionarElemento
            // 
            this.btnAdicionarElemento.Location = new System.Drawing.Point(336, 41);
            this.btnAdicionarElemento.Name = "btnAdicionarElemento";
            this.btnAdicionarElemento.Size = new System.Drawing.Size(116, 23);
            this.btnAdicionarElemento.TabIndex = 4;
            this.btnAdicionarElemento.Text = "Adicionar Elemento";
            this.btnAdicionarElemento.UseVisualStyleBackColor = true;
            this.btnAdicionarElemento.Click += new System.EventHandler(this.btnAdicionarElemento_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(336, 70);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(116, 23);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(336, 99);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(116, 23);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 362);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAdicionarElemento);
            this.Controls.Add(this.btnAdicionarNodo);
            this.Controls.Add(this.textElemento);
            this.Controls.Add(this.textNodo);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox textNodo;
        private System.Windows.Forms.TextBox textElemento;
        private System.Windows.Forms.Button btnAdicionarNodo;
        private System.Windows.Forms.Button btnAdicionarElemento;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
    }
}

