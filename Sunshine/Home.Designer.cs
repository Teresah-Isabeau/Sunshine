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
            this.btnPoints.Location = new System.Drawing.Point(520, 14);
            this.btnPoints.Margin = new System.Windows.Forms.Padding(2);
            this.btnPoints.Name = "btnPoints";
            this.btnPoints.Size = new System.Drawing.Size(56, 50);
            this.btnPoints.TabIndex = 0;
            this.btnPoints.Text = "Points";
            this.btnPoints.UseVisualStyleBackColor = true;
            this.btnPoints.Click += new System.EventHandler(this.btnPoints_Click);
            // 
            // lbHome
            // 
            this.lbHome.AutoSize = true;
            this.lbHome.Location = new System.Drawing.Point(232, 33);
            this.lbHome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbHome.Name = "lbHome";
            this.lbHome.Size = new System.Drawing.Size(122, 13);
            this.lbHome.TabIndex = 1;
            this.lbHome.Text = "Goodmorning SunShine!";
            // 
            // lbTemp
            // 
            this.lbTemp.AutoSize = true;
            this.lbTemp.Location = new System.Drawing.Point(103, 74);
            this.lbTemp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTemp.Name = "lbTemp";
            this.lbTemp.Size = new System.Drawing.Size(67, 13);
            this.lbTemp.TabIndex = 2;
            this.lbTemp.Text = "Temperature";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(103, 124);
            this.lbDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(30, 13);
            this.lbDate.TabIndex = 3;
            this.lbDate.Text = "Date";
            // 
            // lbUV
            // 
            this.lbUV.AutoSize = true;
            this.lbUV.Location = new System.Drawing.Point(103, 99);
            this.lbUV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUV.Name = "lbUV";
            this.lbUV.Size = new System.Drawing.Size(22, 13);
            this.lbUV.TabIndex = 4;
            this.lbUV.Text = "UV";
            // 
            // lbIndication
            // 
            this.lbIndication.AutoSize = true;
            this.lbIndication.Location = new System.Drawing.Point(183, 271);
            this.lbIndication.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbIndication.Name = "lbIndication";
            this.lbIndication.Size = new System.Drawing.Size(53, 13);
            this.lbIndication.TabIndex = 5;
            this.lbIndication.Text = "Indication";
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(12, 14);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(2);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(56, 50);
            this.btnProfile.TabIndex = 8;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btLogout
            // 
            this.btLogout.Location = new System.Drawing.Point(12, 339);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(80, 31);
            this.btLogout.TabIndex = 9;
            this.btLogout.Text = "Logout";
            this.btLogout.UseVisualStyleBackColor = true;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.TimeNow_Tick);
            // 
            // lbSunscreen
            // 
            this.lbSunscreen.AutoSize = true;
            this.lbSunscreen.Location = new System.Drawing.Point(182, 232);
            this.lbSunscreen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSunscreen.Name = "lbSunscreen";
            this.lbSunscreen.Size = new System.Drawing.Size(94, 13);
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
            this.lblOutOfSun.Location = new System.Drawing.Point(201, 196);
            this.lblOutOfSun.Name = "lblOutOfSun";
            this.lblOutOfSun.Size = new System.Drawing.Size(35, 13);
            this.lblOutOfSun.TabIndex = 12;
            this.lblOutOfSun.Text = "label1";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(103, 150);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(35, 13);
            this.lbTime.TabIndex = 10;
            this.lbTime.Text = "label1";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 382);
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
            this.Margin = new System.Windows.Forms.Padding(2);
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