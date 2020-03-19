namespace UI
{
    partial class LoginForm
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
            this.logincancel = new System.Windows.Forms.Button();
            this.loginokbt = new System.Windows.Forms.Button();
            this.passlb = new System.Windows.Forms.Label();
            this.passtb = new System.Windows.Forms.TextBox();
            this.usernamelb = new System.Windows.Forms.Label();
            this.loginlabel = new System.Windows.Forms.Label();
            this.usernametb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // logincancel
            // 
            this.logincancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.logincancel.Location = new System.Drawing.Point(342, 209);
            this.logincancel.Name = "logincancel";
            this.logincancel.Size = new System.Drawing.Size(75, 35);
            this.logincancel.TabIndex = 13;
            this.logincancel.Text = "Cancel";
            this.logincancel.UseVisualStyleBackColor = true;
            this.logincancel.Click += new System.EventHandler(this.Logincancel_Click);
            // 
            // loginokbt
            // 
            this.loginokbt.Location = new System.Drawing.Point(96, 209);
            this.loginokbt.Name = "loginokbt";
            this.loginokbt.Size = new System.Drawing.Size(75, 35);
            this.loginokbt.TabIndex = 12;
            this.loginokbt.Text = "OK";
            this.loginokbt.UseVisualStyleBackColor = true;
            this.loginokbt.Click += new System.EventHandler(this.Loginokbt_Click);
            // 
            // passlb
            // 
            this.passlb.AutoSize = true;
            this.passlb.Location = new System.Drawing.Point(34, 165);
            this.passlb.Name = "passlb";
            this.passlb.Size = new System.Drawing.Size(82, 20);
            this.passlb.TabIndex = 11;
            this.passlb.Text = "Password:";
            // 
            // passtb
            // 
            this.passtb.Location = new System.Drawing.Point(148, 159);
            this.passtb.Name = "passtb";
            this.passtb.PasswordChar = '*';
            this.passtb.Size = new System.Drawing.Size(258, 26);
            this.passtb.TabIndex = 10;
            // 
            // usernamelb
            // 
            this.usernamelb.AutoSize = true;
            this.usernamelb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamelb.Location = new System.Drawing.Point(34, 113);
            this.usernamelb.Name = "usernamelb";
            this.usernamelb.Size = new System.Drawing.Size(87, 20);
            this.usernamelb.TabIndex = 9;
            this.usernamelb.Text = "Username:";
            // 
            // loginlabel
            // 
            this.loginlabel.AutoSize = true;
            this.loginlabel.Font = new System.Drawing.Font(".VnBook-Antiqua", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginlabel.Location = new System.Drawing.Point(174, 24);
            this.loginlabel.Name = "loginlabel";
            this.loginlabel.Size = new System.Drawing.Size(151, 61);
            this.loginlabel.TabIndex = 8;
            this.loginlabel.Text = "Login";
            this.loginlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usernametb
            // 
            this.usernametb.Location = new System.Drawing.Point(148, 110);
            this.usernametb.Name = "usernametb";
            this.usernametb.Size = new System.Drawing.Size(258, 26);
            this.usernametb.TabIndex = 7;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 277);
            this.Controls.Add(this.logincancel);
            this.Controls.Add(this.loginokbt);
            this.Controls.Add(this.passlb);
            this.Controls.Add(this.passtb);
            this.Controls.Add(this.usernamelb);
            this.Controls.Add(this.loginlabel);
            this.Controls.Add(this.usernametb);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Management";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logincancel;
        private System.Windows.Forms.Button loginokbt;
        private System.Windows.Forms.Label passlb;
        private System.Windows.Forms.TextBox passtb;
        private System.Windows.Forms.Label usernamelb;
        private System.Windows.Forms.Label loginlabel;
        private System.Windows.Forms.TextBox usernametb;
    }
}