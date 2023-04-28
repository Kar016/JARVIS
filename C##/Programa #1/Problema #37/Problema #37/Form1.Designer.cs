namespace Problema__37
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
            this.btnAbrirNotepad = new System.Windows.Forms.Button();
            this.btnCerrarNotePad = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.pNotePad = new System.Diagnostics.Process();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mostrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esconderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAbrirNotepad
            // 
            this.btnAbrirNotepad.Location = new System.Drawing.Point(228, 36);
            this.btnAbrirNotepad.Name = "btnAbrirNotepad";
            this.btnAbrirNotepad.Size = new System.Drawing.Size(90, 23);
            this.btnAbrirNotepad.TabIndex = 0;
            this.btnAbrirNotepad.Text = "Abrir NotePad";
            this.btnAbrirNotepad.UseVisualStyleBackColor = true;
            this.btnAbrirNotepad.Click += new System.EventHandler(this.btnAbrirNotepad_Click);
            // 
            // btnCerrarNotePad
            // 
            this.btnCerrarNotePad.Location = new System.Drawing.Point(228, 65);
            this.btnCerrarNotePad.Name = "btnCerrarNotePad";
            this.btnCerrarNotePad.Size = new System.Drawing.Size(90, 23);
            this.btnCerrarNotePad.TabIndex = 1;
            this.btnCerrarNotePad.Text = "Cerrar NotePad";
            this.btnCerrarNotePad.UseVisualStyleBackColor = true;
            this.btnCerrarNotePad.Click += new System.EventHandler(this.btnCerrarNotePad_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(33, 41);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(58, 13);
            this.lblEstado.TabIndex = 2;
            this.lblEstado.Text = "Esperando";
            // 
            // pNotePad
            // 
            this.pNotePad.StartInfo.Domain = "";
            this.pNotePad.StartInfo.FileName = "notepad.exe";
            this.pNotePad.StartInfo.LoadUserProfile = false;
            this.pNotePad.StartInfo.Password = null;
            this.pNotePad.StartInfo.StandardErrorEncoding = null;
            this.pNotePad.StartInfo.StandardOutputEncoding = null;
            this.pNotePad.StartInfo.UserName = "";
            this.pNotePad.StartInfo.WorkingDirectory = "%System%\\System32";
            this.pNotePad.SynchronizingObject = this;
            this.pNotePad.Exited += new System.EventHandler(this.pNotePad_Exited);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Abre Aplicaciones";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarToolStripMenuItem,
            this.esconderToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 48);
            // 
            // mostrarToolStripMenuItem
            // 
            this.mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            this.mostrarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mostrarToolStripMenuItem.Text = "Mostrar";
            this.mostrarToolStripMenuItem.Click += new System.EventHandler(this.mostrarToolStripMenuItem_Click);
            // 
            // esconderToolStripMenuItem
            // 
            this.esconderToolStripMenuItem.Name = "esconderToolStripMenuItem";
            this.esconderToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.esconderToolStripMenuItem.Text = "Esconder";
            this.esconderToolStripMenuItem.Click += new System.EventHandler(this.esconderToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 186);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.btnCerrarNotePad);
            this.Controls.Add(this.btnAbrirNotepad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAbrirNotepad;
        private System.Windows.Forms.Button btnCerrarNotePad;
        private System.Windows.Forms.Label lblEstado;
        private System.Diagnostics.Process pNotePad;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esconderToolStripMenuItem;
    }
}

