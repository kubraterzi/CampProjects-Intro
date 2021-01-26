
namespace TcKimlikDogrulama
{
    partial class IdentityVerification
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
            this.tbxIdentityNumber = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.tbxBirthYear = new System.Windows.Forms.TextBox();
            this.btnVerify = new System.Windows.Forms.Button();
            this.lblIdentityNumber = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLAstName = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxIdentityNumber
            // 
            this.tbxIdentityNumber.Location = new System.Drawing.Point(148, 53);
            this.tbxIdentityNumber.Name = "tbxIdentityNumber";
            this.tbxIdentityNumber.Size = new System.Drawing.Size(168, 20);
            this.tbxIdentityNumber.TabIndex = 0;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(148, 86);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(168, 20);
            this.tbxName.TabIndex = 1;
            // 
            // tbxLastName
            // 
            this.tbxLastName.Location = new System.Drawing.Point(148, 121);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(168, 20);
            this.tbxLastName.TabIndex = 2;
            // 
            // tbxBirthYear
            // 
            this.tbxBirthYear.Location = new System.Drawing.Point(148, 156);
            this.tbxBirthYear.Name = "tbxBirthYear";
            this.tbxBirthYear.Size = new System.Drawing.Size(168, 20);
            this.tbxBirthYear.TabIndex = 3;
            // 
            // btnVerify
            // 
            this.btnVerify.Location = new System.Drawing.Point(241, 196);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(75, 23);
            this.btnVerify.TabIndex = 4;
            this.btnVerify.Text = "VERIFY";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblIdentityNumber
            // 
            this.lblIdentityNumber.AutoSize = true;
            this.lblIdentityNumber.Location = new System.Drawing.Point(44, 56);
            this.lblIdentityNumber.Name = "lblIdentityNumber";
            this.lblIdentityNumber.Size = new System.Drawing.Size(84, 13);
            this.lblIdentityNumber.TabIndex = 5;
            this.lblIdentityNumber.Text = "Identity Number:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(90, 89);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name:";
            // 
            // lblLAstName
            // 
            this.lblLAstName.AutoSize = true;
            this.lblLAstName.Location = new System.Drawing.Point(67, 124);
            this.lblLAstName.Name = "lblLAstName";
            this.lblLAstName.Size = new System.Drawing.Size(61, 13);
            this.lblLAstName.TabIndex = 7;
            this.lblLAstName.Text = "Last Name:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(60, 159);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(68, 13);
            this.lblYear.TabIndex = 8;
            this.lblYear.Text = "Year of Birth:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "USE UPPERCASE LETTERS,PLEASE.";
            // 
            // IdentityVerification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 260);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblLAstName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblIdentityNumber);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.tbxBirthYear);
            this.Controls.Add(this.tbxLastName);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.tbxIdentityNumber);
            this.Name = "IdentityVerification";
            this.Text = "IDENTITY VERIFICATION";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxIdentityNumber;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.TextBox tbxBirthYear;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.Label lblIdentityNumber;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLAstName;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label label1;
    }
}

