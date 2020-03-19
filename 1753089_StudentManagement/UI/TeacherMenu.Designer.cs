namespace UI
{
    partial class TeacherMenu
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
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.importstulist = new System.Windows.Forms.Button();
            this.viewstulist = new System.Windows.Forms.Button();
            this.addstu = new System.Windows.Forms.Button();
            this.importschedule = new System.Windows.Forms.Button();
            this.viewschedule = new System.Windows.Forms.Button();
            this.logoutbttn = new System.Windows.Forms.Button();
            this.importscorebttn = new System.Windows.Forms.Button();
            this.viewscorebttn = new System.Windows.Forms.Button();
            this.changepassbttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFile
            // 
            this.openFile.Filter = "CSV File|*.csv";
            // 
            // importstulist
            // 
            this.importstulist.Location = new System.Drawing.Point(44, 42);
            this.importstulist.Name = "importstulist";
            this.importstulist.Size = new System.Drawing.Size(209, 44);
            this.importstulist.TabIndex = 0;
            this.importstulist.Text = "Import Students List";
            this.importstulist.UseVisualStyleBackColor = true;
            this.importstulist.Click += new System.EventHandler(this.Importstulist_Click);
            // 
            // viewstulist
            // 
            this.viewstulist.Location = new System.Drawing.Point(44, 192);
            this.viewstulist.Name = "viewstulist";
            this.viewstulist.Size = new System.Drawing.Size(209, 44);
            this.viewstulist.TabIndex = 1;
            this.viewstulist.Text = "View Students List";
            this.viewstulist.UseVisualStyleBackColor = true;
            this.viewstulist.Click += new System.EventHandler(this.Viewstulist_Click);
            // 
            // addstu
            // 
            this.addstu.Location = new System.Drawing.Point(44, 92);
            this.addstu.Name = "addstu";
            this.addstu.Size = new System.Drawing.Size(209, 44);
            this.addstu.TabIndex = 3;
            this.addstu.Text = "Add Student";
            this.addstu.UseVisualStyleBackColor = true;
            this.addstu.Click += new System.EventHandler(this.Addstu_Click);
            // 
            // importschedule
            // 
            this.importschedule.Location = new System.Drawing.Point(44, 142);
            this.importschedule.Name = "importschedule";
            this.importschedule.Size = new System.Drawing.Size(209, 44);
            this.importschedule.TabIndex = 4;
            this.importschedule.Text = "Import Schedule";
            this.importschedule.UseVisualStyleBackColor = true;
            this.importschedule.Click += new System.EventHandler(this.Importschedule_Click);
            // 
            // viewschedule
            // 
            this.viewschedule.Location = new System.Drawing.Point(319, 42);
            this.viewschedule.Name = "viewschedule";
            this.viewschedule.Size = new System.Drawing.Size(209, 44);
            this.viewschedule.TabIndex = 5;
            this.viewschedule.Text = "View Schedule";
            this.viewschedule.UseVisualStyleBackColor = true;
            this.viewschedule.Click += new System.EventHandler(this.Viewschedule_Click);
            // 
            // logoutbttn
            // 
            this.logoutbttn.Location = new System.Drawing.Point(319, 257);
            this.logoutbttn.Name = "logoutbttn";
            this.logoutbttn.Size = new System.Drawing.Size(209, 44);
            this.logoutbttn.TabIndex = 6;
            this.logoutbttn.Text = "Log out";
            this.logoutbttn.UseVisualStyleBackColor = true;
            this.logoutbttn.Click += new System.EventHandler(this.Logoutbttn_Click);
            // 
            // importscorebttn
            // 
            this.importscorebttn.Location = new System.Drawing.Point(319, 92);
            this.importscorebttn.Name = "importscorebttn";
            this.importscorebttn.Size = new System.Drawing.Size(209, 44);
            this.importscorebttn.TabIndex = 7;
            this.importscorebttn.Text = "Import Scoreboard";
            this.importscorebttn.UseVisualStyleBackColor = true;
            this.importscorebttn.Click += new System.EventHandler(this.Importscorebttn_Click);
            // 
            // viewscorebttn
            // 
            this.viewscorebttn.Location = new System.Drawing.Point(319, 142);
            this.viewscorebttn.Name = "viewscorebttn";
            this.viewscorebttn.Size = new System.Drawing.Size(209, 44);
            this.viewscorebttn.TabIndex = 8;
            this.viewscorebttn.Text = "View Scoreboard";
            this.viewscorebttn.UseVisualStyleBackColor = true;
            this.viewscorebttn.Click += new System.EventHandler(this.Viewscorebttn_Click);
            // 
            // changepassbttn
            // 
            this.changepassbttn.Location = new System.Drawing.Point(44, 257);
            this.changepassbttn.Name = "changepassbttn";
            this.changepassbttn.Size = new System.Drawing.Size(209, 44);
            this.changepassbttn.TabIndex = 10;
            this.changepassbttn.Text = "Change Password";
            this.changepassbttn.UseVisualStyleBackColor = true;
            this.changepassbttn.Click += new System.EventHandler(this.Changepassbttn_Click);
            // 
            // TeacherMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 343);
            this.Controls.Add(this.changepassbttn);
            this.Controls.Add(this.viewscorebttn);
            this.Controls.Add(this.importscorebttn);
            this.Controls.Add(this.logoutbttn);
            this.Controls.Add(this.viewschedule);
            this.Controls.Add(this.importschedule);
            this.Controls.Add(this.addstu);
            this.Controls.Add(this.viewstulist);
            this.Controls.Add(this.importstulist);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TeacherMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Management";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Button importstulist;
        private System.Windows.Forms.Button viewstulist;
        private System.Windows.Forms.Button addstu;
        private System.Windows.Forms.Button importschedule;
        private System.Windows.Forms.Button viewschedule;
        private System.Windows.Forms.Button logoutbttn;
        private System.Windows.Forms.Button importscorebttn;
        private System.Windows.Forms.Button viewscorebttn;
        private System.Windows.Forms.Button changepassbttn;
    }
}