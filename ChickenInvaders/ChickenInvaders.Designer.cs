namespace ChickenInvaders
{
    partial class ChickenInvaders
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
            this.lblScore = new System.Windows.Forms.Label();
            this.bulletsTm = new System.Windows.Forms.Timer(this.components);
            this.chickensTm = new System.Windows.Forms.Timer(this.components);
            this.eggsTm = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.ForeColor = System.Drawing.SystemColors.Control;
            this.lblScore.Location = new System.Drawing.Point(12, 9);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(78, 32);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "Score: 0";
            // 
            // bulletsTm
            // 
            this.bulletsTm.Enabled = true;
            this.bulletsTm.Interval = 20;
            this.bulletsTm.Tick += new System.EventHandler(this.bulletsTm_Tick);
            // 
            // chickensTm
            // 
            this.chickensTm.Enabled = true;
            this.chickensTm.Interval = 20;
            this.chickensTm.Tick += new System.EventHandler(this.chickensTm_Tick);
            // 
            // eggsTm
            // 
            this.eggsTm.Enabled = true;
            this.eggsTm.Interval = 20;
            this.eggsTm.Tick += new System.EventHandler(this.eggsTm_Tick);
            // 
            // ChickenInvaders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(750, 750);
            this.Controls.Add(this.lblScore);
            this.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.Name = "ChickenInvaders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ChickenInvaders_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ChickenInvaders_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer bulletsTm;
        private System.Windows.Forms.Timer chickensTm;
        private System.Windows.Forms.Timer eggsTm;
    }
}

