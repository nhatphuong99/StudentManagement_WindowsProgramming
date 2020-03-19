namespace UI
{
    partial class StudentMenu
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
            this.logoutbttn = new System.Windows.Forms.Button();
            this.viewscorebttn = new System.Windows.Forms.Button();
            this.changepassbttn = new System.Windows.Forms.Button();
            this.idlb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // logoutbttn
            // 
            this.logoutbttn.Location = new System.Drawing.Point(73, 235);
            this.logoutbttn.Name = "logoutbttn";
            this.logoutbttn.Size = new System.Drawing.Size(209, 44);
            this.logoutbttn.TabIndex = 7;
            this.logoutbttn.Text = "Log out";
            this.logoutbttn.UseVisualStyleBackColor = true;
            this.logoutbttn.Click += new System.EventHandler(this.Logoutbttn_Click);
            // 
            // viewscorebttn
            // 
            this.viewscorebttn.Location = new System.Drawing.Point(73, 117);
            this.viewscorebttn.Name = "viewscorebttn";
            this.viewscorebttn.Size = new System.Drawing.Size(209, 44);
            this.viewscorebttn.TabIndex = 8;
            this.viewscorebttn.Text = "View Score";
            this.viewscorebttn.UseVisualStyleBackColor = true;
            this.viewscorebttn.Click += new System.EventHandler(this.Viewscorebttn_Click);
            // 
            // changepassbttn
            // 
            this.changepassbttn.Location = new System.Drawing.Point(73, 176);
            this.changepassbttn.Name = "changepassbttn";
            this.changepassbttn.Size = new System.Drawing.Size(209, 44);
            this.changepassbttn.TabIndex = 9;
            this.changepassbttn.Text = "Change Password";
            this.changepassbttn.UseVisualStyleBackColor = true;
            this.changepassbttn.Click += new System.EventHandler(this.Changepassbttn_Click);
            // 
            // idlb
            // 
            this.idlb.AutoSize = true;
            this.idlb.CausesValidation = false;
            this.idlb.Location = new System.Drawing.Point(69, 55);
            this.idlb.Name = "idlb";
            this.idlb.Size = new System.Drawing.Size(91, 20);
            this.idlb.TabIndex = 10;
            this.idlb.Text = "Student ID:";
            // 
            // StudentMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 307);
            this.Controls.Add(this.idlb);
            this.Controls.Add(this.changepassbttn);
            this.Controls.Add(this.viewscorebttn);
            this.Controls.Add(this.logoutbttn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StudentMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Management";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logoutbttn;
        private System.Windows.Forms.Button viewscorebttn;
        private System.Windows.Forms.Button changepassbttn;
        private System.Windows.Forms.Label idlb;
    }
}