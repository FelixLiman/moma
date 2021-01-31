namespace Dashboard
{
    partial class Splash_Screen
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
            this.lbl_MoMa = new System.Windows.Forms.Label();
            this.lbl_Powered = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_MoMa
            // 
            this.lbl_MoMa.AutoSize = true;
            this.lbl_MoMa.Font = new System.Drawing.Font("Circular Std Bold", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MoMa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.lbl_MoMa.Location = new System.Drawing.Point(400, 160);
            this.lbl_MoMa.Name = "lbl_MoMa";
            this.lbl_MoMa.Size = new System.Drawing.Size(342, 122);
            this.lbl_MoMa.TabIndex = 0;
            this.lbl_MoMa.Text = "MoMa";
            // 
            // lbl_Powered
            // 
            this.lbl_Powered.AutoSize = true;
            this.lbl_Powered.Font = new System.Drawing.Font("Circular Std Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Powered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.lbl_Powered.Location = new System.Drawing.Point(420, 350);
            this.lbl_Powered.Name = "lbl_Powered";
            this.lbl_Powered.Size = new System.Drawing.Size(300, 41);
            this.lbl_Powered.TabIndex = 1;
            this.lbl_Powered.Text = "Powered by Ficasu";
            // 
            // Splash_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.lbl_Powered);
            this.Controls.Add(this.lbl_MoMa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash_Screen";
            this.Text = "Splash_Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_MoMa;
        private System.Windows.Forms.Label lbl_Powered;
    }
}