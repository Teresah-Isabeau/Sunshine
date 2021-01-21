namespace Sunshine
{
    partial class AccountInfo
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
            this.lbName = new System.Windows.Forms.Label();
            this.lbAge = new System.Windows.Forms.Label();
            this.lbCountry = new System.Windows.Forms.Label();
            this.lbSkin = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.nudAge = new System.Windows.Forms.NumericUpDown();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.cbSkin = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(115)))), ((int)(((byte)(104)))));
            this.label1.Location = new System.Drawing.Point(55, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lets get started with \r\nfilling in some facts!";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbName.Location = new System.Drawing.Point(24, 306);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(56, 23);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Name";
            // 
            // lbAge
            // 
            this.lbAge.AutoSize = true;
            this.lbAge.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbAge.Location = new System.Drawing.Point(24, 358);
            this.lbAge.Name = "lbAge";
            this.lbAge.Size = new System.Drawing.Size(40, 23);
            this.lbAge.TabIndex = 2;
            this.lbAge.Text = "Age";
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbCountry.Location = new System.Drawing.Point(24, 415);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(73, 23);
            this.lbCountry.TabIndex = 3;
            this.lbCountry.Text = "Country";
            // 
            // lbSkin
            // 
            this.lbSkin.AutoSize = true;
            this.lbSkin.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbSkin.Location = new System.Drawing.Point(24, 473);
            this.lbSkin.Name = "lbSkin";
            this.lbSkin.Size = new System.Drawing.Size(83, 23);
            this.lbSkin.TabIndex = 4;
            this.lbSkin.Text = "Skin Type";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(115)))), ((int)(((byte)(104)))));
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(109, 553);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(135, 40);
            this.btnConfirm.TabIndex = 5;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(140, 308);
            this.tbName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(120, 22);
            this.tbName.TabIndex = 6;
            // 
            // nudAge
            // 
            this.nudAge.Location = new System.Drawing.Point(140, 361);
            this.nudAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudAge.Name = "nudAge";
            this.nudAge.Size = new System.Drawing.Size(120, 22);
            this.nudAge.TabIndex = 7;
            // 
            // cbCountry
            // 
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Location = new System.Drawing.Point(139, 417);
            this.cbCountry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(121, 24);
            this.cbCountry.TabIndex = 100;
            // 
            // cbSkin
            // 
            this.cbSkin.FormattingEnabled = true;
            this.cbSkin.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cbSkin.Location = new System.Drawing.Point(139, 475);
            this.cbSkin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSkin.Name = "cbSkin";
            this.cbSkin.Size = new System.Drawing.Size(121, 24);
            this.cbSkin.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sunshine.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(78, -8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 101;
            this.pictureBox1.TabStop = false;
            // 
            // AccountInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(120)))));
            this.ClientSize = new System.Drawing.Size(357, 765);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbSkin);
            this.Controls.Add(this.cbCountry);
            this.Controls.Add(this.nudAge);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lbSkin);
            this.Controls.Add(this.lbCountry);
            this.Controls.Add(this.lbAge);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AccountInfo";
            this.Text = "AccountInfo";
            this.Load += new System.EventHandler(this.AccountInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbAge;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.Label lbSkin;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.NumericUpDown nudAge;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.ComboBox cbSkin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}