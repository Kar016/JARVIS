namespace Problema__13
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblValor = new System.Windows.Forms.Label();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnDetener = new System.Windows.Forms.Button();
            this.trbIntervalo = new System.Windows.Forms.TrackBar();
            this.lblTValor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trbIntervalo)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(34, 39);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(35, 13);
            this.lblValor.TabIndex = 0;
            this.lblValor.Text = "label1";
            // 
            // btnInicio
            // 
            this.btnInicio.Location = new System.Drawing.Point(175, 29);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(75, 23);
            this.btnInicio.TabIndex = 1;
            this.btnInicio.Text = "Iniciar";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnDetener
            // 
            this.btnDetener.Location = new System.Drawing.Point(175, 58);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(75, 23);
            this.btnDetener.TabIndex = 2;
            this.btnDetener.Text = "Detener";
            this.btnDetener.UseVisualStyleBackColor = true;
            this.btnDetener.Click += new System.EventHandler(this.btnDetener_Click);
            // 
            // trbIntervalo
            // 
            this.trbIntervalo.Location = new System.Drawing.Point(12, 124);
            this.trbIntervalo.Maximum = 1000;
            this.trbIntervalo.Minimum = 100;
            this.trbIntervalo.Name = "trbIntervalo";
            this.trbIntervalo.Size = new System.Drawing.Size(256, 45);
            this.trbIntervalo.TabIndex = 3;
            this.trbIntervalo.TickFrequency = 100;
            this.trbIntervalo.Value = 100;
            this.trbIntervalo.Scroll += new System.EventHandler(this.trbIntervalo_Scroll);
            // 
            // lblTValor
            // 
            this.lblTValor.AutoSize = true;
            this.lblTValor.Location = new System.Drawing.Point(118, 172);
            this.lblTValor.Name = "lblTValor";
            this.lblTValor.Size = new System.Drawing.Size(35, 13);
            this.lblTValor.TabIndex = 4;
            this.lblTValor.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 253);
            this.Controls.Add(this.lblTValor);
            this.Controls.Add(this.trbIntervalo);
            this.Controls.Add(this.btnDetener);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.lblValor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.trbIntervalo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnDetener;
        private System.Windows.Forms.TrackBar trbIntervalo;
        private System.Windows.Forms.Label lblTValor;
    }
}

