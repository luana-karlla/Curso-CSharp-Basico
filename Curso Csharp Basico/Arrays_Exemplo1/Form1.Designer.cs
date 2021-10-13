
namespace Arrays_Exemplo1
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
            this.BtnTesteVetor = new System.Windows.Forms.Button();
            this.BtnVetorTextos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnTesteVetor
            // 
            this.BtnTesteVetor.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnTesteVetor.Location = new System.Drawing.Point(122, 39);
            this.BtnTesteVetor.Name = "BtnTesteVetor";
            this.BtnTesteVetor.Size = new System.Drawing.Size(147, 81);
            this.BtnTesteVetor.TabIndex = 0;
            this.BtnTesteVetor.Text = "Teste Vetor";
            this.BtnTesteVetor.UseVisualStyleBackColor = true;
            this.BtnTesteVetor.Click += new System.EventHandler(this.BtnTesteVetor_Click);
            // 
            // BtnVetorTextos
            // 
            this.BtnVetorTextos.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnVetorTextos.Location = new System.Drawing.Point(122, 155);
            this.BtnVetorTextos.Name = "BtnVetorTextos";
            this.BtnVetorTextos.Size = new System.Drawing.Size(147, 74);
            this.BtnVetorTextos.TabIndex = 1;
            this.BtnVetorTextos.Text = "Vetor Textos";
            this.BtnVetorTextos.UseVisualStyleBackColor = true;
            this.BtnVetorTextos.Click += new System.EventHandler(this.BtnVetorTextos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 293);
            this.Controls.Add(this.BtnVetorTextos);
            this.Controls.Add(this.BtnTesteVetor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnTesteVetor;
        private System.Windows.Forms.Button BtnVetorTextos;
    }
}

