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
            this.btnBack = new System.Windows.Forms.Button();
            this.listRewards = new System.Windows.Forms.ListBox();
            this.lbLevel = new System.Windows.Forms.Label();
            this.btnClaim = new System.Windows.Forms.Button();
            this.lbClaimedReward = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbRewards
            // 
            this.lbRewards.AutoSize = true;
            this.lbRewards.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbRewards.Location = new System.Drawing.Point(20, 294);
            this.lbRewards.Name = "lbRewards";
            this.lbRewards.Size = new System.Drawing.Size(75, 23);
            this.lbRewards.TabIndex = 0;
            this.lbRewards.Text = "Rewards";
            // 
            // lbPoints
            // 
            this.lbPoints.AutoSize = true;
            this.lbPoints.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbPoints.Location = new System.Drawing.Point(20, 136);
            this.lbPoints.Name = "lbPoints";
            this.lbPoints.Size = new System.Drawing.Size(56, 23);
            this.lbPoints.TabIndex = 1;
            this.lbPoints.Text = "Points";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(23, 23);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 41);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // listRewards
            // 
            this.listRewards.FormattingEnabled = true;
            this.listRewards.ItemHeight = 16;
            this.listRewards.Location = new System.Drawing.Point(23, 321);
            this.listRewards.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listRewards.Name = "listRewards";
            this.listRewards.Size = new System.Drawing.Size(316, 228);
            this.listRewards.TabIndex = 7;
            // 
            // lbLevel
            // 
            this.lbLevel.AutoSize = true;
            this.lbLevel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbLevel.Location = new System.Drawing.Point(20, 168);
            this.lbLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLevel.Name = "lbLevel";
            this.lbLevel.Size = new System.Drawing.Size(49, 23);
            this.lbLevel.TabIndex = 8;
            this.lbLevel.Text = "Level";
            // 
            // btnClaim
            // 
            this.btnClaim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(115)))), ((int)(((byte)(104)))));
            this.btnClaim.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnClaim.ForeColor = System.Drawing.Color.White;
            this.btnClaim.Location = new System.Drawing.Point(87, 557);
            this.btnClaim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClaim.Name = "btnClaim";
            this.btnClaim.Size = new System.Drawing.Size(187, 39);
            this.btnClaim.TabIndex = 9;
            this.btnClaim.Text = "Claim Reward";
            this.btnClaim.UseVisualStyleBackColor = false;
            this.btnClaim.Click += new System.EventHandler(this.btnClaim_Click);
            // 
            // lbClaimedReward
            // 
            this.lbClaimedReward.AutoSize = true;
            this.lbClaimedReward.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbClaimedReward.Location = new System.Drawing.Point(20, 659);
            this.lbClaimedReward.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbClaimedReward.Name = "lbClaimedReward";
            this.lbClaimedReward.Size = new System.Drawing.Size(179, 23);
            this.lbClaimedReward.TabIndex = 10;
            this.lbClaimedReward.Text = "Last Claimed Reward: ";
            // 
            // Reward
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(120)))));
            this.ClientSize = new System.Drawing.Size(357, 765);
            this.Controls.Add(this.lbClaimedReward);
            this.Controls.Add(this.btnClaim);
            this.Controls.Add(this.lbLevel);
            this.Controls.Add(this.listRewards);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lbPoints);
            this.Controls.Add(this.lbRewards);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Reward";
            this.Text = "Reward";
            this.Load += new System.EventHandler(this.Reward_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbRewards;
        private System.Windows.Forms.Label lbPoints;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListBox listRewards;
        private System.Windows.Forms.Label lbLevel;
        private System.Windows.Forms.Button btnClaim;
        private System.Windows.Forms.Label lbClaimedReward;
    }
}