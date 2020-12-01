namespace Sunshine
{
    partial class Reward
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
            this.lbRewards = new System.Windows.Forms.Label();
            this.lbPoints = new System.Windows.Forms.Label();
            this.lbCoupon = new System.Windows.Forms.Label();
            this.lbDonate = new System.Windows.Forms.Label();
            this.btnGet = new System.Windows.Forms.Button();
            this.btnDonate = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbRewards
            // 
            this.lbRewards.AutoSize = true;
            this.lbRewards.Location = new System.Drawing.Point(94, 151);
            this.lbRewards.Name = "lbRewards";
            this.lbRewards.Size = new System.Drawing.Size(63, 17);
            this.lbRewards.TabIndex = 0;
            this.lbRewards.Text = "Rewards";
            // 
            // lbPoints
            // 
            this.lbPoints.AutoSize = true;
            this.lbPoints.Location = new System.Drawing.Point(313, 88);
            this.lbPoints.Name = "lbPoints";
            this.lbPoints.Size = new System.Drawing.Size(47, 17);
            this.lbPoints.TabIndex = 1;
            this.lbPoints.Text = "Points";
            // 
            // lbCoupon
            // 
            this.lbCoupon.AutoSize = true;
            this.lbCoupon.Location = new System.Drawing.Point(94, 186);
            this.lbCoupon.Name = "lbCoupon";
            this.lbCoupon.Size = new System.Drawing.Size(57, 17);
            this.lbCoupon.TabIndex = 2;
            this.lbCoupon.Text = "Coupon";
            // 
            // lbDonate
            // 
            this.lbDonate.AutoSize = true;
            this.lbDonate.Location = new System.Drawing.Point(94, 226);
            this.lbDonate.Name = "lbDonate";
            this.lbDonate.Size = new System.Drawing.Size(104, 17);
            this.lbDonate.TabIndex = 3;
            this.lbDonate.Text = "Donate to KWF";
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(283, 179);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(75, 23);
            this.btnGet.TabIndex = 4;
            this.btnGet.Text = "Get";
            this.btnGet.UseVisualStyleBackColor = true;
            // 
            // btnDonate
            // 
            this.btnDonate.Location = new System.Drawing.Point(285, 220);
            this.btnDonate.Name = "btnDonate";
            this.btnDonate.Size = new System.Drawing.Size(75, 23);
            this.btnDonate.TabIndex = 5;
            this.btnDonate.Text = "Donate";
            this.btnDonate.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(23, 23);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 41);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Reward
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDonate);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.lbDonate);
            this.Controls.Add(this.lbCoupon);
            this.Controls.Add(this.lbPoints);
            this.Controls.Add(this.lbRewards);
            this.Name = "Reward";
            this.Text = "Reward";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbRewards;
        private System.Windows.Forms.Label lbPoints;
        private System.Windows.Forms.Label lbCoupon;
        private System.Windows.Forms.Label lbDonate;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Button btnDonate;
        private System.Windows.Forms.Button btnBack;
    }
}