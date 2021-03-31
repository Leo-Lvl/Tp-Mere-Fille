namespace FenetreMereFille
{
    partial class FFille
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
            this.btnChanger = new System.Windows.Forms.Button();
            this.btnMaMere = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnChanger
            // 
            this.btnChanger.Location = new System.Drawing.Point(419, 36);
            this.btnChanger.Name = "btnChanger";
            this.btnChanger.Size = new System.Drawing.Size(75, 23);
            this.btnChanger.TabIndex = 0;
            this.btnChanger.Text = "Changer";
            this.btnChanger.UseVisualStyleBackColor = true;
            this.btnChanger.Click += new System.EventHandler(this.btnChanger_Click);
            // 
            // btnMaMere
            // 
            this.btnMaMere.Location = new System.Drawing.Point(217, 84);
            this.btnMaMere.Name = "btnMaMere";
            this.btnMaMere.Size = new System.Drawing.Size(75, 23);
            this.btnMaMere.TabIndex = 1;
            this.btnMaMere.Text = "Ma Mere";
            this.btnMaMere.UseVisualStyleBackColor = true;
            this.btnMaMere.Click += new System.EventHandler(this.btnMaMere_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.ForeColor = System.Drawing.Color.Black;
            this.lbl1.Location = new System.Drawing.Point(61, 39);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(98, 13);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Je change de nom:";
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(192, 36);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(221, 20);
            this.tb1.TabIndex = 3;
            
            // 
            // FFille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 131);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnMaMere);
            this.Controls.Add(this.btnChanger);
            this.Name = "FFille";
            this.Text = "FFille";
            this.Load += new System.EventHandler(this.FFille_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChanger;
        private System.Windows.Forms.Button btnMaMere;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox tb1;
    }
}