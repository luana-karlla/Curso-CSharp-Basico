
namespace ExemplodeClick
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
            this.textName = new System.Windows.Forms.TextBox();
            this.bntClick = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(200, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mensagem";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(91, 95);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(361, 23);
            this.textName.TabIndex = 1;
            // 
            // bntClick
            // 
            this.bntClick.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bntClick.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bntClick.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bntClick.ForeColor = System.Drawing.Color.White;
            this.bntClick.Location = new System.Drawing.Point(200, 194);
            this.bntClick.Name = "bntClick";
            this.bntClick.Size = new System.Drawing.Size(128, 50);
            this.bntClick.TabIndex = 2;
            this.bntClick.Text = "Clique Aqui";
            this.bntClick.UseVisualStyleBackColor = false;
            this.bntClick.Click += new System.EventHandler(this.bntClick_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 450);
            this.Controls.Add(this.bntClick);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Button bntClick;
    }
}

