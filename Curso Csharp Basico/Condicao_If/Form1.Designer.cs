
namespace Condicao_If
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
            this.label1 = new System.Windows.Forms.Label();
            this.textCaixa1 = new System.Windows.Forms.TextBox();
            this.VerificarIdade = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(106, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite sua idade";
            // 
            // textCaixa1
            // 
            this.textCaixa1.Location = new System.Drawing.Point(106, 89);
            this.textCaixa1.Name = "textCaixa1";
            this.textCaixa1.Size = new System.Drawing.Size(198, 23);
            this.textCaixa1.TabIndex = 1;
            this.textCaixa1.TextChanged += new System.EventHandler(this.textCaixa1_TextChanged);
            // 
            // VerificarIdade
            // 
            this.VerificarIdade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.VerificarIdade.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.VerificarIdade.Location = new System.Drawing.Point(144, 157);
            this.VerificarIdade.Name = "VerificarIdade";
            this.VerificarIdade.Size = new System.Drawing.Size(104, 32);
            this.VerificarIdade.TabIndex = 2;
            this.VerificarIdade.Text = "Verificar Idade";
            this.VerificarIdade.UseVisualStyleBackColor = true;
            this.VerificarIdade.Click += new System.EventHandler(this.VerificarIdade_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 278);
            this.Controls.Add(this.VerificarIdade);
            this.Controls.Add(this.textCaixa1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textCaixa1;
        private System.Windows.Forms.Button VerificarIdade;
    }
}

