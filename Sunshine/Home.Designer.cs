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
            this.btnPoints = new System.Windows.Forms.Button();
            this.lbHome = new System.Windows.Forms.Label();
            this.lbTemp = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbUV = new System.Windows.Forms.Label();
            this.lbIndication = new System.Windows.Forms.Label();
            this.lbCountry = new System.Windows.Forms.Label();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.btnProfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPoints
            // 
            this.btnPoints.Location = new System.Drawing.Point(683, 30);
            this.btnPoints.Name = "btnPoints";
            this.btnPoints.Size = new System.Drawing.Size(75, 62);
            this.btnPoints.TabIndex = 0;
            this.btnPoints.Text = "Points";
            this.btnPoints.UseVisualStyleBackColor = true;
            // 
            // lbHome
            // 
            this.lbHome.AutoSize = true;
            this.lbHome.Location = new System.Drawing.Point(296, 53);
            this.lbHome.Name = "lbHome";
            this.lbHome.Size = new System.Drawing.Size(162, 17);
            this.lbHome.TabIndex = 1;
            this.lbHome.Text = "Goodmorning SunShine!";
            // 
            // lbTemp
            // 
            this.lbTemp.AutoSize = true;
            this.lbTemp.Location = new System.Drawing.Point(137, 122);
            this.lbTemp.Name = "lbTemp";
            this.lbTemp.Size = new System.Drawing.Size(90, 17);
            this.lbTemp.TabIndex = 2;
            this.lbTemp.Text = "Temperature";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(137, 162);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(38, 17);
            this.lbDate.TabIndex = 3;
            this.lbDate.Text = "Date";
            // 
            // lbUV
            // 
            this.lbUV.AutoSize = true;
            this.lbUV.Location = new System.Drawing.Point(137, 203);
            this.lbUV.Name = "lbUV";
            this.lbUV.Size = new System.Drawing.Size(27, 17);
            this.lbUV.TabIndex = 4;
            this.lbUV.Text = "UV";
            // 
            // lbIndication
            // 
            this.lbIndication.AutoSize = true;
            this.lbIndication.Location = new System.Drawing.Point(341, 241);
            this.lbIndication.Name = "lbIndication";
            this.lbIndication.Size = new System.Drawing.Size(68, 17);
            this.lbIndication.TabIndex = 5;
            this.lbIndication.Text = "Indication";
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Location = new System.Drawing.Point(137, 319);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(57, 17);
            this.lbCountry.TabIndex = 6;
            this.lbCountry.Text = "Country";
            // 
            // cbCountry
            // 
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Location = new System.Drawing.Point(314, 312);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(121, 24);
            this.cbCountry.TabIndex = 7;
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(26, 30);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(75, 62);
            this.btnProfile.TabIndex = 8;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.cbCountry);
            this.Controls.Add(this.lbCountry);
            this.Controls.Add(this.lbIndication);
            this.Controls.Add(this.lbUV);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbTemp);
            this.Controls.Add(this.lbHome);
            this.Controls.Add(this.btnPoints);
            this.Name = "Home";
            this.Text = "Home";
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
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.Button btnProfile;
    }
}