namespace Problema__20
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ilFotos = new System.Windows.Forms.ImageList(this.components);
            this.lblFoto = new System.Windows.Forms.Label();
            this.btnCambio = new System.Windows.Forms.Button();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // ilFotos
            // 
            this.ilFotos.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilFotos.ImageStream")));
            this.ilFotos.TransparentColor = System.Drawing.Color.Transparent;
            this.ilFotos.Images.SetKeyName(0, "Astronauta.jpg");
            this.ilFotos.Images.SetKeyName(1, "Batman.jpg");
            this.ilFotos.Images.SetKeyName(2, "City.jpeg");
            this.ilFotos.Images.SetKeyName(3, "Cubo.jpg");
            this.ilFotos.Images.SetKeyName(4, "Flash.png");
            this.ilFotos.Images.SetKeyName(5, "Planeta.jpg");
            this.ilFotos.Images.SetKeyName(6, "StarWars 2.jpg");
            this.ilFotos.Images.SetKeyName(7, "StarWars.jpg");
            this.ilFotos.Images.SetKeyName(8, "Bitmap1.bmp");
            // 
            // lblFoto
            // 
            this.lblFoto.ImageIndex = 0;
            this.lblFoto.ImageList = this.ilFotos;
            this.lblFoto.Location = new System.Drawing.Point(12, 9);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(200, 200);
            this.lblFoto.TabIndex = 0;
            // 
            // btnCambio
            // 
            this.btnCambio.Location = new System.Drawing.Point(237, 12);
            this.btnCambio.Name = "btnCambio";
            this.btnCambio.Size = new System.Drawing.Size(75, 23);
            this.btnCambio.TabIndex = 1;
            this.btnCambio.Text = "Cambiar";
            this.btnCambio.UseVisualStyleBackColor = true;
            this.btnCambio.Click += new System.EventHandler(this.btnCambio_Click);
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(12, 250);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(200, 200);
            this.pbImagen.TabIndex = 2;
            this.pbImagen.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 462);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.btnCambio);
            this.Controls.Add(this.lblFoto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList ilFotos;
        private System.Windows.Forms.Label lblFoto;
        private System.Windows.Forms.Button btnCambio;
        private System.Windows.Forms.PictureBox pbImagen;
    }
}

