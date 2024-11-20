namespace WindowsFormsApp1
{
    partial class loginform
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
            this.lbName = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.namebox = new System.Windows.Forms.TextBox();
            this.passwordbox = new System.Windows.Forms.TextBox();
            this.Loginbt = new System.Windows.Forms.Button();
            this.ResetBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(156, 77);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(131, 16);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "ENTER FULL NAME";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(156, 163);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(136, 16);
            this.lbPassword.TabIndex = 1;
            this.lbPassword.Text = "ENTER PASSWORD";
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(338, 74);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(274, 22);
            this.namebox.TabIndex = 2;
            // 
            // passwordbox
            // 
            this.passwordbox.Location = new System.Drawing.Point(338, 163);
            this.passwordbox.Name = "passwordbox";
            this.passwordbox.PasswordChar = '*';
            this.passwordbox.Size = new System.Drawing.Size(274, 22);
            this.passwordbox.TabIndex = 3;
            // 
            // Loginbt
            // 
            this.Loginbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginbt.Location = new System.Drawing.Point(159, 236);
            this.Loginbt.Name = "Loginbt";
            this.Loginbt.Size = new System.Drawing.Size(210, 59);
            this.Loginbt.TabIndex = 4;
            this.Loginbt.Text = "LOGIN";
            this.Loginbt.UseVisualStyleBackColor = true;
            this.Loginbt.Click += new System.EventHandler(this.Loginbt_Click);
            // 
            // ResetBt
            // 
            this.ResetBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetBt.Location = new System.Drawing.Point(402, 236);
            this.ResetBt.Name = "ResetBt";
            this.ResetBt.Size = new System.Drawing.Size(210, 59);
            this.ResetBt.TabIndex = 5;
            this.ResetBt.Text = "RESET";
            this.ResetBt.UseVisualStyleBackColor = true;
            this.ResetBt.Click += new System.EventHandler(this.ResetBt_Click);
            // 
            // loginform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ResetBt);
            this.Controls.Add(this.Loginbt);
            this.Controls.Add(this.passwordbox);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbName);
            this.Name = "loginform";
            this.Text = "LOGIN FORM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.TextBox passwordbox;
        private System.Windows.Forms.Button Loginbt;
        private System.Windows.Forms.Button ResetBt;
    }
}

