namespace Problema__21
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
            this.lvAlimentos = new System.Windows.Forms.ListView();
            this.textAlimentos = new System.Windows.Forms.TextBox();
            this.gbGrupo = new System.Windows.Forms.GroupBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.rbCarne = new System.Windows.Forms.RadioButton();
            this.rbFrutas = new System.Windows.Forms.RadioButton();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblSelecionado = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnActulizar = new System.Windows.Forms.Button();
            this.textImagen = new System.Windows.Forms.TextBox();
            this.gbGrupo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvAlimentos
            // 
            this.lvAlimentos.HideSelection = false;
            this.lvAlimentos.Location = new System.Drawing.Point(12, 12);
            this.lvAlimentos.Name = "lvAlimentos";
            this.lvAlimentos.Size = new System.Drawing.Size(408, 225);
            this.lvAlimentos.TabIndex = 0;
            this.lvAlimentos.UseCompatibleStateImageBehavior = false;
            this.lvAlimentos.View = System.Windows.Forms.View.SmallIcon;
            this.lvAlimentos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvAlimentos_MouseClick);
            // 
            // textAlimentos
            // 
            this.textAlimentos.Location = new System.Drawing.Point(57, 255);
            this.textAlimentos.Name = "textAlimentos";
            this.textAlimentos.Size = new System.Drawing.Size(137, 20);
            this.textAlimentos.TabIndex = 1;
            // 
            // gbGrupo
            // 
            this.gbGrupo.Controls.Add(this.btnAdicionar);
            this.gbGrupo.Controls.Add(this.rbCarne);
            this.gbGrupo.Controls.Add(this.rbFrutas);
            this.gbGrupo.Location = new System.Drawing.Point(220, 243);
            this.gbGrupo.Name = "gbGrupo";
            this.gbGrupo.Size = new System.Drawing.Size(200, 100);
            this.gbGrupo.TabIndex = 2;
            this.gbGrupo.TabStop = false;
            this.gbGrupo.Text = "Grupos";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(108, 25);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 2;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // rbCarne
            // 
            this.rbCarne.AutoSize = true;
            this.rbCarne.Location = new System.Drawing.Point(6, 54);
            this.rbCarne.Name = "rbCarne";
            this.rbCarne.Size = new System.Drawing.Size(53, 17);
            this.rbCarne.TabIndex = 1;
            this.rbCarne.Text = "Carne";
            this.rbCarne.UseVisualStyleBackColor = true;
            // 
            // rbFrutas
            // 
            this.rbFrutas.AutoSize = true;
            this.rbFrutas.Checked = true;
            this.rbFrutas.Location = new System.Drawing.Point(6, 31);
            this.rbFrutas.Name = "rbFrutas";
            this.rbFrutas.Size = new System.Drawing.Size(54, 17);
            this.rbFrutas.TabIndex = 0;
            this.rbFrutas.TabStop = true;
            this.rbFrutas.Text = "Frutas";
            this.rbFrutas.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(426, 34);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblSelecionado
            // 
            this.lblSelecionado.AutoSize = true;
            this.lblSelecionado.Location = new System.Drawing.Point(426, 18);
            this.lblSelecionado.Name = "lblSelecionado";
            this.lblSelecionado.Size = new System.Drawing.Size(35, 13);
            this.lblSelecionado.TabIndex = 4;
            this.lblSelecionado.Text = "label1";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(426, 63);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 5;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnActulizar
            // 
            this.btnActulizar.Location = new System.Drawing.Point(119, 320);
            this.btnActulizar.Name = "btnActulizar";
            this.btnActulizar.Size = new System.Drawing.Size(75, 23);
            this.btnActulizar.TabIndex = 6;
            this.btnActulizar.Text = "Actulizar";
            this.btnActulizar.UseVisualStyleBackColor = true;
            this.btnActulizar.Click += new System.EventHandler(this.btnActulizar_Click);
            // 
            // textImagen
            // 
            this.textImagen.Location = new System.Drawing.Point(57, 294);
            this.textImagen.Name = "textImagen";
            this.textImagen.Size = new System.Drawing.Size(137, 20);
            this.textImagen.TabIndex = 7;
            this.textImagen.Text = "0";
            this.textImagen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 367);
            this.Controls.Add(this.textImagen);
            this.Controls.Add(this.btnActulizar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.lblSelecionado);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.gbGrupo);
            this.Controls.Add(this.textAlimentos);
            this.Controls.Add(this.lvAlimentos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbGrupo.ResumeLayout(false);
            this.gbGrupo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvAlimentos;
        private System.Windows.Forms.TextBox textAlimentos;
        private System.Windows.Forms.GroupBox gbGrupo;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.RadioButton rbCarne;
        private System.Windows.Forms.RadioButton rbFrutas;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblSelecionado;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnActulizar;
        private System.Windows.Forms.TextBox textImagen;
    }
}

