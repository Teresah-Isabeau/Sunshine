namespace Sunshine
{
    partial class Home
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
            this.btnPoints = new System.Windows.Forms.Button();
            this.lbHome = new System.Windows.Forms.Label();
            this.lbTemp = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbUV = new System.Windows.Forms.Label();
            this.lbIndication = new System.Windows.Forms.Label();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btLogout = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbSunscreen = new System.Windows.Forms.Label();
            this.sunscreenTimer = new System.Windows.Forms.Timer(this.components);
            this.lblOutOfSun = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPoints
            // 
            this.btnPoints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(225)))), ((int)(((byte)(195)))));
            this.btnPoints.Location = new System.Drawing.Point(16, 11);
            this.btnPoints.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPoints.Name = "btnPoints";
            this.btnPoints.Size = new System.Drawing.Size(75, 62);
            this.btnPoints.TabIndex = 0;
            this.btnPoints.Text = "Points";
            this.btnPoints.UseVisualStyleBackColor = false;
            this.btnPoints.Click += new System.EventHandler(this.btnPoints_Click);
            // 
            // lbHome
            // 
            this.lbHome.AutoSize = true;
            this.lbHome.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.lbHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(115)))), ((int)(((byte)(104)))));
            this.lbHome.Location = new System.Drawing.Point(112, 23);
            this.lbHome.Name = "lbHome";
            this.lbHome.Size = new System.Drawing.Size(140, 50);
            this.lbHome.TabIndex = 1;
            this.lbHome.Text = "Goodmorning\r\nSunShine!";
            this.lbHome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbTemp
            // 
            this.lbTemp.AutoSize = true;
            this.lbTemp.Location = new System.Drawing.Point(33, 155);
            this.lbTemp.Name = "lbTemp";
            this.lbTemp.Size = new System.Drawing.Size(90, 17);
            this.lbTemp.TabIndex = 2;
            this.lbTemp.Text = "Temperature";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(33, 215);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(38, 17);
            this.lbDate.TabIndex = 3;
            this.lbDate.Text = "Date";
            // 
            // lbUV
            // 
            this.lbUV.AutoSize = true;
            this.lbUV.Location = new System.Drawing.Point(33, 185);
            this.lbUV.Name = "lbUV";
            this.lbUV.Size = new System.Drawing.Size(27, 17);
            this.lbUV.TabIndex = 4;
            this.lbUV.Text = "UV";
            // 
            // lbIndication
            // 
            this.lbIndication.AutoSize = true;
            this.lbIndication.Location = new System.Drawing.Point(33, 485);
            this.lbIndication.Name = "lbIndication";
            this.lbIndication.Size = new System.Drawing.Size(68, 17);
            this.lbIndication.TabIndex = 5;
            this.lbIndication.Text = "Indication";
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.btnProfile.Location = new System.Drawing.Point(270, 11);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(75, 62);
            this.btnProfile.TabIndex = 8;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btLogout
            // 
            this.btLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(115)))), ((int)(((byte)(104)))));
            this.btLogout.Location = new System.Drawing.Point(82, 585);
            this.btLogout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(107, 38);
            this.btLogout.TabIndex = 9;
            this.btLogout.Text = "Logout";
            this.btLogout.UseVisualStyleBackColor = false;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.TimeNow_Tick);
            // 
            // lbSunscreen
            // 
            this.lbSunscreen.AutoSize = true;
            this.lbSunscreen.Location = new System.Drawing.Point(33, 397);
            this.lbSunscreen.Name = "lbSunscreen";
            this.lbSunscreen.Size = new System.Drawing.Size(124, 17);
            this.lbSunscreen.TabIndex = 11;
            this.lbSunscreen.Text = "Sunscreen factor: ";
            // 
            // sunscreenTimer
            // 
            this.sunscreenTimer.Tick += new System.EventHandler(this.sunscreenTimer_Tick);
            // 
            // lblOutOfSun
            // 
            this.lblOutOfSun.AutoSize = true;
            this.lblOutOfSun.Location = new System.Drawing.Point(33, 371);
            this.lblOutOfSun.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOutOfSun.Name = "lblOutOfSun";
            this.lblOutOfSun.Size = new System.Drawing.Size(46, 17);
            this.lblOutOfSun.TabIndex = 12;
            this.lblOutOfSun.Text = "label1";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(33, 245);
            this.lbTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(46, 17);
            this.lbTime.TabIndex = 10;
            this.lbTime.Text = "label1";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(120)))));
            this.ClientSize = new System.Drawing.Size(357, 765);
            this.Controls.Add(this.lblOutOfSun);
            this.Controls.Add(this.lbSunscreen);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.btLogout);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.lbIndication);
            this.Controls.Add(this.lbUV);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbTemp);
            this.Controls.Add(this.lbHome);
            this.Controls.Add(this.btnPoints);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPoints;
        private System.Windows.Forms.Label lbHome;
        private System.Windows.Forms.Label lbTemp;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbUV;
        private System.Windows.Forms.Label lbIndication;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbSunscreen;
        private System.Windows.Forms.Timer sunscreenTimer;
        private System.Windows.Forms.Label lblOutOfSun;
        private System.Windows.Forms.Label lbTime;
    }
}