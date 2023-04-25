namespace Problema__7;

partial class Screen1
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
        btnAbrir = new Button();
        SuspendLayout();
        // 
        // btnAbrir
        // 
        btnAbrir.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
        btnAbrir.Location = new Point(215, 91);
        btnAbrir.Name = "btnAbrir";
        btnAbrir.Size = new Size(89, 34);
        btnAbrir.TabIndex = 0;
        btnAbrir.Text = "Abrir";
        btnAbrir.UseVisualStyleBackColor = true;
        btnAbrir.Click += btnAbrir_Click;
        // 
        // Screen1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(316, 137);
        Controls.Add(btnAbrir);
        Name = "Screen1";
        Text = "Screen 1";
        ResumeLayout(false);
    }

    #endregion

    private Button btnAbrir;
}
