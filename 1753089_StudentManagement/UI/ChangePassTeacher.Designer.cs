namespace UI
{
    partial class ChangePassTeacher
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
            this.changecancelbttn = new System.Windows.Forms.Button();
            this.changeokbttn = new System.Windows.Forms.Button();
            this.newpasslb = new System.Windows.Forms.Label();
            this.newpasstb = new System.Windows.Forms.TextBox();
            this.oldpasslb = new System.Windows.Forms.Label();
            this.oldpasstb = new System.Windows.Forms.TextBox();
            this.idlb = new System.Windows.Forms.Label();
            this.idtb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // changecancelbttn
            // 
            this.changecancelbttn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.changecancelbttn.Location = new System.Drawing.Point(392, 207);
            this.changecancelbttn.Name = "changecancelbttn";
            this.changecancelbttn.Size = new System.Drawing.Size(75, 35);
            this.changecancelbttn.TabIndex = 27;
            this.changecancelbttn.Text = "Cancel";
            this.changecancelbttn.UseVisualStyleBackColor = true;
            this.changecancelbttn.Click += new System.EventHandler(this.changecancel_Click);
            // 
            // changeokbttn
            // 
            this.changeokbttn.Location = new System.Drawing.Point(146, 207);
            this.changeokbttn.Name = "changeokbttn";
            this.changeokbttn.Size = new System.Drawing.Size(75, 35);
            this.changeokbttn.TabIndex = 26;
            this.changeokbttn.Text = "OK";
            this.changeokbttn.UseVisualStyleBackColor = true;
            this.changeokbttn.Click += new System.EventHandler(this.changeokbt_Click);
            // 
            // newpasslb
            // 
            this.newpasslb.AutoSize = true;
            this.newpasslb.Location = new System.Drawing.Point(28, 154);
            this.newpasslb.Name = "newpasslb";
            this.newpasslb.Size = new System.Drawing.Size(117, 20);
            this.newpasslb.TabIndex = 25;
            this.newpasslb.Text = "New Password:";
            // 
            // newpasstb
            // 
            this.newpasstb.Location = new System.Drawing.Point(158, 148);
            this.newpasstb.Name = "newpasstb";
            this.newpasstb.PasswordChar = '*';
            this.newpasstb.Size = new System.Drawing.Size(400, 26);
            this.newpasstb.TabIndex = 24;
            // 
            // oldpasslb
            // 
            this.oldpasslb.AutoSize = true;
            this.oldpasslb.Location = new System.Drawing.Point(28, 96);
            this.oldpasslb.Name = "oldpasslb";
            this.oldpasslb.Size = new System.Drawing.Size(110, 20);
            this.oldpasslb.TabIndex = 23;
            this.oldpasslb.Text = "Old Password:";
            // 
            // oldpasstb
            // 
            this.oldpasstb.Location = new System.Drawing.Point(158, 93);
            this.oldpasstb.Name = "oldpasstb";
            this.oldpasstb.PasswordChar = '*';
            this.oldpasstb.Size = new System.Drawing.Size(400, 26);
            this.oldpasstb.TabIndex = 22;
            // 
            // idlb
            // 
            this.idlb.AutoSize = true;
            this.idlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idlb.Location = new System.Drawing.Point(28, 44);
            this.idlb.Name = "idlb";
            this.idlb.Size = new System.Drawing.Size(30, 20);
            this.idlb.TabIndex = 21;
            this.idlb.Text = "ID:";
            // 
            // idtb
            // 
            this.idtb.Location = new System.Drawing.Point(158, 44);
            this.idtb.Name = "idtb";
            this.idtb.Size = new System.Drawing.Size(400, 26);
            this.idtb.TabIndex = 20;
            // 
            // ChangePassTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 269);
            this.Controls.Add(this.changecancelbttn);
            this.Controls.Add(this.changeokbttn);
            this.Controls.Add(this.newpasslb);
            this.Controls.Add(this.newpasstb);
            this.Controls.Add(this.oldpasslb);
            this.Controls.Add(this.oldpasstb);
            this.Controls.Add(this.idlb);
            this.Controls.Add(this.idtb);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangePassTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChangePassTeacher_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button changecancelbttn;
        private System.Windows.Forms.Button changeokbttn;
        private System.Windows.Forms.Label newpasslb;
        private System.Windows.Forms.TextBox newpasstb;
        private System.Windows.Forms.Label oldpasslb;
        private System.Windows.Forms.TextBox oldpasstb;
        private System.Windows.Forms.Label idlb;
        private System.Windows.Forms.TextBox idtb;
    }
}