namespace UI
{
    partial class ChangePassStudent
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
            this.oldpasslb = new System.Windows.Forms.Label();
            this.oldpasstb = new System.Windows.Forms.TextBox();
            this.idlb = new System.Windows.Forms.Label();
            this.idtb = new System.Windows.Forms.TextBox();
            this.newpasslb = new System.Windows.Forms.Label();
            this.newpasstb = new System.Windows.Forms.TextBox();
            this.changecancelbttn = new System.Windows.Forms.Button();
            this.changeokbttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // oldpasslb
            // 
            this.oldpasslb.AutoSize = true;
            this.oldpasslb.Location = new System.Drawing.Point(23, 94);
            this.oldpasslb.Name = "oldpasslb";
            this.oldpasslb.Size = new System.Drawing.Size(110, 20);
            this.oldpasslb.TabIndex = 15;
            this.oldpasslb.Text = "Old Password:";
            // 
            // oldpasstb
            // 
            this.oldpasstb.Location = new System.Drawing.Point(153, 91);
            this.oldpasstb.Name = "oldpasstb";
            this.oldpasstb.PasswordChar = '*';
            this.oldpasstb.Size = new System.Drawing.Size(400, 26);
            this.oldpasstb.TabIndex = 14;
            // 
            // idlb
            // 
            this.idlb.AutoSize = true;
            this.idlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idlb.Location = new System.Drawing.Point(23, 42);
            this.idlb.Name = "idlb";
            this.idlb.Size = new System.Drawing.Size(30, 20);
            this.idlb.TabIndex = 13;
            this.idlb.Text = "ID:";
            // 
            // idtb
            // 
            this.idtb.Location = new System.Drawing.Point(153, 42);
            this.idtb.Name = "idtb";
            this.idtb.Size = new System.Drawing.Size(400, 26);
            this.idtb.TabIndex = 12;
            // 
            // newpasslb
            // 
            this.newpasslb.AutoSize = true;
            this.newpasslb.Location = new System.Drawing.Point(23, 152);
            this.newpasslb.Name = "newpasslb";
            this.newpasslb.Size = new System.Drawing.Size(117, 20);
            this.newpasslb.TabIndex = 17;
            this.newpasslb.Text = "New Password:";
            // 
            // newpasstb
            // 
            this.newpasstb.Location = new System.Drawing.Point(153, 146);
            this.newpasstb.Name = "newpasstb";
            this.newpasstb.PasswordChar = '*';
            this.newpasstb.Size = new System.Drawing.Size(400, 26);
            this.newpasstb.TabIndex = 16;
            // 
            // changecancelbttn
            // 
            this.changecancelbttn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.changecancelbttn.Location = new System.Drawing.Point(387, 205);
            this.changecancelbttn.Name = "changecancelbttn";
            this.changecancelbttn.Size = new System.Drawing.Size(75, 35);
            this.changecancelbttn.TabIndex = 19;
            this.changecancelbttn.Text = "Cancel";
            this.changecancelbttn.UseVisualStyleBackColor = true;
            this.changecancelbttn.Click += new System.EventHandler(this.Logincancel_Click);
            // 
            // changeokbttn
            // 
            this.changeokbttn.Location = new System.Drawing.Point(141, 205);
            this.changeokbttn.Name = "changeokbttn";
            this.changeokbttn.Size = new System.Drawing.Size(75, 35);
            this.changeokbttn.TabIndex = 18;
            this.changeokbttn.Text = "OK";
            this.changeokbttn.UseVisualStyleBackColor = true;
            this.changeokbttn.Click += new System.EventHandler(this.Loginokbt_Click);
            // 
            // ChangePassStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 268);
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
            this.Name = "ChangePassStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChangePassStudent_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label oldpasslb;
        private System.Windows.Forms.TextBox oldpasstb;
        private System.Windows.Forms.Label idlb;
        private System.Windows.Forms.TextBox idtb;
        private System.Windows.Forms.Label newpasslb;
        private System.Windows.Forms.TextBox newpasstb;
        private System.Windows.Forms.Button changecancelbttn;
        private System.Windows.Forms.Button changeokbttn;
    }
}