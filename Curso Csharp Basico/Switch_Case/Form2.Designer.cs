
namespace Switch_Case
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CboOpcao = new System.Windows.Forms.ComboBox();
            this.lblRes = new System.Windows.Forms.Label();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(80, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rodízio de Veículos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(51, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Selecione o número final da placa";
            // 
            // CboOpcao
            // 
            this.CboOpcao.FormattingEnabled = true;
            this.CboOpcao.Items.AddRange(new object[] {
            "1 ou 2",
            "3 ou 4",
            "5 ou 6",
            "7 ou 8",
            "9 ou 0"});
            this.CboOpcao.Location = new System.Drawing.Point(113, 92);
            this.CboOpcao.Name = "CboOpcao";
            this.CboOpcao.Size = new System.Drawing.Size(121, 23);
            this.CboOpcao.TabIndex = 2;
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRes.Location = new System.Drawing.Point(38, 145);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(40, 15);
            this.lblRes.TabIndex = 3;
            this.lblRes.Text = "label3";
            this.lblRes.Click += new System.EventHandler(this.LblRes_Click);
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Location = new System.Drawing.Point(80, 205);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(75, 38);
            this.BtnConsultar.TabIndex = 4;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.Location = new System.Drawing.Point(202, 205);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(75, 38);
            this.BtnVoltar.TabIndex = 5;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = true;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 285);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.CboOpcao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CboOpcao;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.Button BtnVoltar;
    }
}