
namespace Arrays_Multi
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
            this.BtnArrayMult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnArrayMult
            // 
            this.BtnArrayMult.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnArrayMult.Location = new System.Drawing.Point(101, 76);
            this.BtnArrayMult.Name = "BtnArrayMult";
            this.BtnArrayMult.Size = new System.Drawing.Size(299, 59);
            this.BtnArrayMult.TabIndex = 0;
            this.BtnArrayMult.Text = "Array Multidimensional";
            this.BtnArrayMult.UseVisualStyleBackColor = true;
            this.BtnArrayMult.Click += new System.EventHandler(this.BtnArrayMult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 231);
            this.Controls.Add(this.BtnArrayMult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnArrayMult;
    }
}

