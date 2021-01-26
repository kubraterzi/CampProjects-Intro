
namespace IdendityVerification
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
            this.lblIdentityNumber = new System.Windows.Forms.Label();
            this.tbxIdentityNumber = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.tbxYearOfBirth = new System.Windows.Forms.TextBox();
            this.lblYearOfBirth = new System.Windows.Forms.Label();
            this.btnVerify = new System.Windows.Forms.Button();
            this.lblWarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblIdentityNumber
            // 
            this.lblIdentityNumber.AutoSize = true;
            this.lblIdentityNumber.Font = new System.Drawing.Font("Malgun Gothic Semilight", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIdentityNumber.Location = new System.Drawing.Point(36, 46);
            this.lblIdentityNumber.Name = "lblIdentityNumber";
            this.lblIdentityNumber.Size = new System.Drawing.Size(112, 15);
            this.lblIdentityNumber.TabIndex = 0;
            this.lblIdentityNumber.Text = "Identity Number:";
            // 
            // tbxIdentityNumber
            // 
            this.tbxIdentityNumber.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxIdentityNumber.Location = new System.Drawing.Point(167, 44);
            this.tbxIdentityNumber.Name = "tbxIdentityNumber";
            this.tbxIdentityNumber.Size = new System.Drawing.Size(202, 25);
            this.tbxIdentityNumber.TabIndex = 1;
            // 
            // tbxName
            // 
            this.tbxName.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxName.Location = new System.Drawing.Point(167, 83);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(202, 25);
            this.tbxName.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Malgun Gothic Semilight", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName.Location = new System.Drawing.Point(102, 85);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(46, 15);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name:";
            // 
            // tbxLastName
            // 
            this.tbxLastName.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxLastName.Location = new System.Drawing.Point(166, 119);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(203, 25);
            this.tbxLastName.TabIndex = 5;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Malgun Gothic Semilight", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLastName.Location = new System.Drawing.Point(73, 121);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(75, 15);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "Last Name:";
            // 
            // tbxYearOfBirth
            // 
            this.tbxYearOfBirth.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxYearOfBirth.Location = new System.Drawing.Point(167, 154);
            this.tbxYearOfBirth.Name = "tbxYearOfBirth";
            this.tbxYearOfBirth.Size = new System.Drawing.Size(202, 25);
            this.tbxYearOfBirth.TabIndex = 7;
            // 
            // lblYearOfBirth
            // 
            this.lblYearOfBirth.AutoSize = true;
            this.lblYearOfBirth.Font = new System.Drawing.Font("Malgun Gothic Semilight", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYearOfBirth.Location = new System.Drawing.Point(59, 156);
            this.lblYearOfBirth.Name = "lblYearOfBirth";
            this.lblYearOfBirth.Size = new System.Drawing.Size(89, 15);
            this.lblYearOfBirth.TabIndex = 6;
            this.lblYearOfBirth.Text = "Year of Birth:";
            // 
            // btnVerify
            // 
            this.btnVerify.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVerify.Location = new System.Drawing.Point(294, 194);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(75, 30);
            this.btnVerify.TabIndex = 8;
            this.btnVerify.Text = "VERIFY";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Malgun Gothic Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWarning.ForeColor = System.Drawing.Color.Red;
            this.lblWarning.Location = new System.Drawing.Point(12, 234);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(187, 15);
            this.lblWarning.TabIndex = 9;
            this.lblWarning.Text = "USE UPPERCASE LETTERS, PLEASE.";
            // 
            // IdentityVerification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 258);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.tbxYearOfBirth);
            this.Controls.Add(this.lblYearOfBirth);
            this.Controls.Add(this.tbxLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbxIdentityNumber);
            this.Controls.Add(this.lblIdentityNumber);
            this.Name = "IdentityVerification";
            this.Text = "IDENTITY VERIFICATION";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdentityNumber;
        private System.Windows.Forms.TextBox tbxIdentityNumber;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox tbxYearOfBirth;
        private System.Windows.Forms.Label lblYearOfBirth;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.Label lblWarning;
    }
}

