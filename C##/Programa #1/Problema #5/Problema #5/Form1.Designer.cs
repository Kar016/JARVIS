namespace Problema__5
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
            textA = new TextBox();
            textB = new TextBox();
            btnCalcular = new Button();
            gbOperaciones = new GroupBox();
            rbDividir = new RadioButton();
            rbMultiplicar = new RadioButton();
            rbResta = new RadioButton();
            rbSuma = new RadioButton();
            lblResultado = new Label();
            gbOperaciones.SuspendLayout();
            SuspendLayout();
            // 
            // textA
            // 
            textA.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textA.Location = new Point(12, 25);
            textA.Name = "textA";
            textA.Size = new Size(126, 25);
            textA.TabIndex = 0;
            textA.Text = "0";
            textA.TextAlign = HorizontalAlignment.Right;
            // 
            // textB
            // 
            textB.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textB.Location = new Point(12, 54);
            textB.Name = "textB";
            textB.Size = new Size(126, 25);
            textB.TabIndex = 1;
            textB.Text = "0";
            textB.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCalcular.Location = new Point(213, 25);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 25);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // gbOperaciones
            // 
            gbOperaciones.Controls.Add(rbDividir);
            gbOperaciones.Controls.Add(rbMultiplicar);
            gbOperaciones.Controls.Add(rbResta);
            gbOperaciones.Controls.Add(rbSuma);
            gbOperaciones.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            gbOperaciones.Location = new Point(12, 132);
            gbOperaciones.Name = "gbOperaciones";
            gbOperaciones.Size = new Size(200, 171);
            gbOperaciones.TabIndex = 3;
            gbOperaciones.TabStop = false;
            gbOperaciones.Text = "Operaciones";
            // 
            // rbDividir
            // 
            rbDividir.AutoSize = true;
            rbDividir.Location = new Point(6, 126);
            rbDividir.Name = "rbDividir";
            rbDividir.Size = new Size(78, 24);
            rbDividir.TabIndex = 7;
            rbDividir.Text = "/  (Dividir)";
            rbDividir.UseVisualStyleBackColor = true;
            // 
            // rbMultiplicar
            // 
            rbMultiplicar.AutoSize = true;
            rbMultiplicar.Location = new Point(6, 96);
            rbMultiplicar.Name = "rbMultiplicar";
            rbMultiplicar.Size = new Size(105, 24);
            rbMultiplicar.TabIndex = 6;
            rbMultiplicar.Text = "x  (Multiplicar)";
            rbMultiplicar.UseVisualStyleBackColor = true;
            // 
            // rbResta
            // 
            rbResta.AutoSize = true;
            rbResta.Location = new Point(6, 66);
            rbResta.Name = "rbResta";
            rbResta.Size = new Size(80, 24);
            rbResta.TabIndex = 5;
            rbResta.Text = "-   (Resta)";
            rbResta.UseVisualStyleBackColor = true;
            // 
            // rbSuma
            // 
            rbSuma.AutoSize = true;
            rbSuma.Checked = true;
            rbSuma.Location = new Point(6, 36);
            rbSuma.Name = "rbSuma";
            rbSuma.Size = new Size(81, 24);
            rbSuma.TabIndex = 4;
            rbSuma.TabStop = true;
            rbSuma.Text = "+  (Suma)";
            rbSuma.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultado.Location = new Point(88, 93);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(50, 20);
            lblResultado.TabIndex = 4;
            lblResultado.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(305, 345);
            Controls.Add(lblResultado);
            Controls.Add(gbOperaciones);
            Controls.Add(btnCalcular);
            Controls.Add(textB);
            Controls.Add(textA);
            Name = "Form1";
            Text = "Form1";
            gbOperaciones.ResumeLayout(false);
            gbOperaciones.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textA;
        private TextBox textB;
        private Button btnCalcular;
        private GroupBox gbOperaciones;
        private RadioButton rbDividir;
        private RadioButton rbMultiplicar;
        private RadioButton rbResta;
        private RadioButton rbSuma;
        private Label lblResultado;
    }
}