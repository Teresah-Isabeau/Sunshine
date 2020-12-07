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
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lets get started with filling in some facts!";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(108, 90);
            this.lbName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(35, 13);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Name";
            // 
            // lbAge
            // 
            this.lbAge.AutoSize = true;
            this.lbAge.Location = new System.Drawing.Point(108, 123);
            this.lbAge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAge.Name = "lbAge";
            this.lbAge.Size = new System.Drawing.Size(26, 13);
            this.lbAge.TabIndex = 2;
            this.lbAge.Text = "Age";
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Location = new System.Drawing.Point(108, 154);
            this.lbCountry.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(43, 13);
            this.lbCountry.TabIndex = 3;
            this.lbCountry.Text = "Country";
            // 
            // lbSkin
            // 
            this.lbSkin.AutoSize = true;
            this.lbSkin.Location = new System.Drawing.Point(108, 184);
            this.lbSkin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSkin.Name = "lbSkin";
            this.lbSkin.Size = new System.Drawing.Size(55, 13);
            this.lbSkin.TabIndex = 4;
            this.lbSkin.Text = "Skin Type";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(224, 282);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(62, 39);
            this.btnConfirm.TabIndex = 5;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(224, 85);
            this.tbName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(91, 20);
            this.tbName.TabIndex = 6;
            // 
            // nudAge
            // 
            this.nudAge.Location = new System.Drawing.Point(224, 119);
            this.nudAge.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudAge.Name = "nudAge";
            this.nudAge.Size = new System.Drawing.Size(90, 20);
            this.nudAge.TabIndex = 7;
            // 
            // cbCountry
            // 
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Location = new System.Drawing.Point(224, 147);
            this.cbCountry.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(92, 21);
            this.cbCountry.TabIndex = 100;
            // 
            // cbSkin
            // 
            this.cbSkin.FormattingEnabled = true;
            this.cbSkin.Location = new System.Drawing.Point(224, 178);
            this.cbSkin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbSkin.Name = "cbSkin";
            this.cbSkin.Size = new System.Drawing.Size(92, 21);
            this.cbSkin.TabIndex = 9;
            // 
            // AccountInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AccountInfo";
            this.Text = "AccountInfo";
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).EndInit();
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
    }
}