namespace Proiect_MTP_PIUG
{
    partial class IncarcareAplicatie
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.ProgressCircle = new Guna.UI.WinForms.GunaCircleProgressBar();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(46, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "ManageStaff";
            // 
            // ProgressCircle
            // 
            this.ProgressCircle.AnimationSpeed = 0.6F;
            this.ProgressCircle.BackColor = System.Drawing.SystemColors.Control;
            this.ProgressCircle.BaseColor = System.Drawing.SystemColors.Control;
            this.ProgressCircle.ForeColor = System.Drawing.Color.SteelBlue;
            this.ProgressCircle.IdleColor = System.Drawing.Color.Gainsboro;
            this.ProgressCircle.IdleOffset = 20;
            this.ProgressCircle.IdleThickness = 10;
            this.ProgressCircle.Image = null;
            this.ProgressCircle.ImageSize = new System.Drawing.Size(52, 52);
            this.ProgressCircle.Location = new System.Drawing.Point(264, 65);
            this.ProgressCircle.Name = "ProgressCircle";
            this.ProgressCircle.ProgressMaxColor = System.Drawing.Color.SteelBlue;
            this.ProgressCircle.ProgressMinColor = System.Drawing.Color.SteelBlue;
            this.ProgressCircle.ProgressOffset = 20;
            this.ProgressCircle.ProgressThickness = 10;
            this.ProgressCircle.Size = new System.Drawing.Size(164, 158);
            this.ProgressCircle.TabIndex = 1;
            this.ProgressCircle.Click += new System.EventHandler(this.ProgressCircle_Click);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::Proiect_MTP_PIUG.Properties.Resources._514948881625157164_128;
            this.gunaPictureBox1.Location = new System.Drawing.Point(66, 95);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(131, 128);
            this.gunaPictureBox1.TabIndex = 0;
            this.gunaPictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // IncarcareAplicatie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(24F, 44F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 285);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.ProgressCircle);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.Name = "IncarcareAplicatie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.IncarcareAplicatie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaCircleProgressBar ProgressCircle;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}

