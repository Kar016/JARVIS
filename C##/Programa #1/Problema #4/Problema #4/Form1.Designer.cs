namespace Problema__4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            chkMonitor = new CheckBox();
            chkTeclado = new CheckBox();
            chkMouse = new CheckBox();
            lblMensaje = new Label();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // chkMonitor
            // 
            chkMonitor.AutoSize = true;
            chkMonitor.Location = new Point(12, 28);
            chkMonitor.Name = "chkMonitor";
            chkMonitor.Size = new Size(96, 19);
            chkMonitor.TabIndex = 0;
            chkMonitor.Text = "Monitor $250";
            chkMonitor.UseVisualStyleBackColor = true;
            chkMonitor.CheckedChanged += chkMonitor_CheckedChanged;
            // 
            // chkTeclado
            // 
            chkTeclado.AutoSize = true;
            chkTeclado.Location = new Point(12, 53);
            chkTeclado.Name = "chkTeclado";
            chkTeclado.Size = new Size(87, 19);
            chkTeclado.TabIndex = 1;
            chkTeclado.Text = "Teclado $15";
            chkTeclado.UseVisualStyleBackColor = true;
            chkTeclado.CheckedChanged += chkTeclado_CheckedChanged;
            // 
            // chkMouse
            // 
            chkMouse.AutoSize = true;
            chkMouse.Location = new Point(12, 78);
            chkMouse.Name = "chkMouse";
            chkMouse.Size = new Size(83, 19);
            chkMouse.TabIndex = 2;
            chkMouse.Text = "Mouse $20";
            chkMouse.UseVisualStyleBackColor = true;
            chkMouse.CheckedChanged += chkMouse_CheckedChanged;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(70, 116);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(38, 15);
            lblMensaje.TabIndex = 3;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCalcular.Location = new Point(163, 28);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(301, 181);
            Controls.Add(btnCalcular);
            Controls.Add(lblMensaje);
            Controls.Add(chkMouse);
            Controls.Add(chkTeclado);
            Controls.Add(chkMonitor);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkMonitor;
        private CheckBox chkTeclado;
        private CheckBox chkMouse;
        private Label lblMensaje;
        private Button btnCalcular;
    }
}