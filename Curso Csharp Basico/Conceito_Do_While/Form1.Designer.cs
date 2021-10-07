
namespace Conceito_Do_While
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
            this.BtnTesteDoWhile = new System.Windows.Forms.Button();
            this.lblNumero = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnTesteDoWhile
            // 
            this.BtnTesteDoWhile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnTesteDoWhile.Location = new System.Drawing.Point(119, 119);
            this.BtnTesteDoWhile.Name = "BtnTesteDoWhile";
            this.BtnTesteDoWhile.Size = new System.Drawing.Size(75, 56);
            this.BtnTesteDoWhile.TabIndex = 0;
            this.BtnTesteDoWhile.Text = "Teste Do While";
            this.BtnTesteDoWhile.UseVisualStyleBackColor = true;
            this.BtnTesteDoWhile.Click += new System.EventHandler(this.BtnTesteDoWhile_Click);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(139, 51);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(38, 15);
            this.lblNumero.TabIndex = 1;
            this.lblNumero.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 290);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.BtnTesteDoWhile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnTesteDoWhile;
        private System.Windows.Forms.Label lblNumero;
    }
}

