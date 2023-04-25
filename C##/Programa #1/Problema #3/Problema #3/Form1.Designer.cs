namespace Problema__3
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
            lblA = new Label();
            textA = new TextBox();
            textB = new TextBox();
            lblB = new Label();
            lblResultado = new Label();
            btnSuma = new Button();
            btnResta = new Button();
            btnDividir = new Button();
            btnMultiplicar = new Button();
            SuspendLayout();
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Location = new Point(12, 32);
            lblA.Name = "lblA";
            lblA.Size = new Size(18, 15);
            lblA.TabIndex = 0;
            lblA.Text = "A:";
            // 
            // textA
            // 
            textA.Location = new Point(36, 32);
            textA.Name = "textA";
            textA.Size = new Size(100, 23);
            textA.TabIndex = 1;
            textA.TextAlign = HorizontalAlignment.Right;
            // 
            // textB
            // 
            textB.Location = new Point(36, 80);
            textB.Name = "textB";
            textB.Size = new Size(100, 23);
            textB.TabIndex = 3;
            textB.TextAlign = HorizontalAlignment.Right;
            // 
            // lblB
            // 
            lblB.AutoSize = true;
            lblB.Location = new Point(12, 80);
            lblB.Name = "lblB";
            lblB.Size = new Size(17, 15);
            lblB.TabIndex = 2;
            lblB.Text = "B:";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(119, 128);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(17, 15);
            lblResultado.TabIndex = 4;
            lblResultado.Text = "B:";
            // 
            // btnSuma
            // 
            btnSuma.Location = new Point(142, 32);
            btnSuma.Name = "btnSuma";
            btnSuma.Size = new Size(36, 23);
            btnSuma.TabIndex = 5;
            btnSuma.Text = "+";
            btnSuma.UseVisualStyleBackColor = true;
            btnSuma.Click += btnSuma_Click;
            // 
            // btnResta
            // 
            btnResta.Location = new Point(184, 32);
            btnResta.Name = "btnResta";
            btnResta.Size = new Size(36, 23);
            btnResta.TabIndex = 6;
            btnResta.Text = "-";
            btnResta.UseVisualStyleBackColor = true;
            btnResta.Click += btnResta_Click;
            // 
            // btnDividir
            // 
            btnDividir.Location = new Point(184, 80);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(36, 23);
            btnDividir.TabIndex = 8;
            btnDividir.Text = "/";
            btnDividir.UseVisualStyleBackColor = true;
            btnDividir.Click += btnDividir_Click;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Location = new Point(142, 80);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(36, 23);
            btnMultiplicar.TabIndex = 7;
            btnMultiplicar.Text = "x";
            btnMultiplicar.UseVisualStyleBackColor = true;
            btnMultiplicar.Click += btnMultiplicar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 323);
            Controls.Add(btnDividir);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnResta);
            Controls.Add(btnSuma);
            Controls.Add(lblResultado);
            Controls.Add(textB);
            Controls.Add(lblB);
            Controls.Add(textA);
            Controls.Add(lblA);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblA;
        private TextBox textA;
        private TextBox textB;
        private Label lblB;
        private Label lblResultado;
        private Button btnSuma;
        private Button btnResta;
        private Button btnDividir;
        private Button btnMultiplicar;
    }
}