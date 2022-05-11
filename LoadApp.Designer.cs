namespace Proiect_MTP_PIUG
{
    partial class LoadApp
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
            this.MyProgress = new Guna.UI.WinForms.GunaCircleProgressBar();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.MyProgress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(49, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "EMPLOYEE MANAGEMENT SYSTEM";
            // 
            // MyProgress
            // 
            this.MyProgress.AnimationSpeed = 0.6F;
            this.MyProgress.BackColor = System.Drawing.SystemColors.Control;
            this.MyProgress.BaseColor = System.Drawing.Color.White;
            this.MyProgress.Controls.Add(this.gunaPictureBox1);
            this.MyProgress.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.MyProgress.IdleColor = System.Drawing.Color.Gainsboro;
            this.MyProgress.IdleOffset = 20;
            this.MyProgress.Image = null;
            this.MyProgress.ImageSize = new System.Drawing.Size(52, 52);
            this.MyProgress.Location = new System.Drawing.Point(144, 49);
            this.MyProgress.Name = "MyProgress";
            this.MyProgress.ProgressMaxColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.MyProgress.ProgressMinColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.MyProgress.ProgressOffset = 20;
            this.MyProgress.Size = new System.Drawing.Size(265, 264);
            this.MyProgress.TabIndex = 1;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::Proiect_MTP_PIUG.Properties.Resources._514948881625157164_128;
            this.gunaPictureBox1.Location = new System.Drawing.Point(63, 67);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(131, 128);
            this.gunaPictureBox1.TabIndex = 0;
            this.gunaPictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(24F, 44F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 325);
            this.Controls.Add(this.MyProgress);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MyProgress.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaCircleProgressBar MyProgress;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
    }
}

