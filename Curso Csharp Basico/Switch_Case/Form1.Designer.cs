
namespace Switch_Case
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
            this.CboSemana = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnProximoExemplo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CboSemana
            // 
            this.CboSemana.FormattingEnabled = true;
            this.CboSemana.Items.AddRange(new object[] {
            "Domingo",
            "Segunda",
            "Terça",
            "Quarta",
            "Quinta",
            "Sexta",
            "Sábado"});
            this.CboSemana.Location = new System.Drawing.Point(80, 78);
            this.CboSemana.Name = "CboSemana";
            this.CboSemana.Size = new System.Drawing.Size(141, 23);
            this.CboSemana.TabIndex = 0;
            this.CboSemana.SelectedIndexChanged += new System.EventHandler(this.CboSemana_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(54, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Escolha um dia da semana";
            // 
            // BtnProximoExemplo
            // 
            this.BtnProximoExemplo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnProximoExemplo.Location = new System.Drawing.Point(217, 208);
            this.BtnProximoExemplo.Name = "BtnProximoExemplo";
            this.BtnProximoExemplo.Size = new System.Drawing.Size(75, 49);
            this.BtnProximoExemplo.TabIndex = 2;
            this.BtnProximoExemplo.Text = "Próximo Exemplo";
            this.BtnProximoExemplo.UseVisualStyleBackColor = true;
            this.BtnProximoExemplo.Click += new System.EventHandler(this.BtnProximoExemplo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 269);
            this.Controls.Add(this.BtnProximoExemplo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CboSemana);
            this.Name = "Form1";
            this.Text = "Switch Case";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CboSemana;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnProximoExemplo;
    }
}

