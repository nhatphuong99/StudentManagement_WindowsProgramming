namespace UI
{
    partial class ViewScoreboard
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
            this.listscore = new System.Windows.Forms.ListView();
            this.classcb = new System.Windows.Forms.ComboBox();
            this.classlb = new System.Windows.Forms.Label();
            this.subjectcb = new System.Windows.Forms.ComboBox();
            this.subjectlb = new System.Windows.Forms.Label();
            this.editbttn = new System.Windows.Forms.Button();
            this.Addbttn = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listscore
            // 
            this.listscore.Location = new System.Drawing.Point(12, 68);
            this.listscore.Name = "listscore";
            this.listscore.Size = new System.Drawing.Size(776, 357);
            this.listscore.TabIndex = 5;
            this.listscore.UseCompatibleStateImageBehavior = false;
            // 
            // classcb
            // 
            this.classcb.FormattingEnabled = true;
            this.classcb.Location = new System.Drawing.Point(128, 25);
            this.classcb.Name = "classcb";
            this.classcb.Size = new System.Drawing.Size(121, 28);
            this.classcb.TabIndex = 4;
            this.classcb.SelectedIndexChanged += new System.EventHandler(this.Classcb_SelectedIndexChanged);
            // 
            // classlb
            // 
            this.classlb.AutoSize = true;
            this.classlb.Location = new System.Drawing.Point(54, 28);
            this.classlb.Name = "classlb";
            this.classlb.Size = new System.Drawing.Size(52, 20);
            this.classlb.TabIndex = 3;
            this.classlb.Text = "Class:";
            // 
            // subjectcb
            // 
            this.subjectcb.FormattingEnabled = true;
            this.subjectcb.Location = new System.Drawing.Point(394, 25);
            this.subjectcb.Name = "subjectcb";
            this.subjectcb.Size = new System.Drawing.Size(121, 28);
            this.subjectcb.TabIndex = 7;
            this.subjectcb.SelectedIndexChanged += new System.EventHandler(this.Subjectcb_SelectedIndexChanged);
            // 
            // subjectlb
            // 
            this.subjectlb.AutoSize = true;
            this.subjectlb.Location = new System.Drawing.Point(320, 28);
            this.subjectlb.Name = "subjectlb";
            this.subjectlb.Size = new System.Drawing.Size(67, 20);
            this.subjectlb.TabIndex = 6;
            this.subjectlb.Text = "Subject:";
            // 
            // editbttn
            // 
            this.editbttn.Location = new System.Drawing.Point(471, 439);
            this.editbttn.Name = "editbttn";
            this.editbttn.Size = new System.Drawing.Size(105, 35);
            this.editbttn.TabIndex = 21;
            this.editbttn.Text = "Edit score";
            this.editbttn.UseVisualStyleBackColor = true;
            this.editbttn.Click += new System.EventHandler(this.Editbttn_Click);
            // 
            // Addbttn
            // 
            this.Addbttn.Location = new System.Drawing.Point(171, 439);
            this.Addbttn.Name = "Addbttn";
            this.Addbttn.Size = new System.Drawing.Size(105, 35);
            this.Addbttn.TabIndex = 22;
            this.Addbttn.Text = "Add";
            this.Addbttn.UseVisualStyleBackColor = true;
            this.Addbttn.Click += new System.EventHandler(this.Addbttn_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(324, 439);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(105, 35);
            this.delete.TabIndex = 23;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // ViewScoreboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 486);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.Addbttn);
            this.Controls.Add(this.editbttn);
            this.Controls.Add(this.subjectcb);
            this.Controls.Add(this.subjectlb);
            this.Controls.Add(this.listscore);
            this.Controls.Add(this.classcb);
            this.Controls.Add(this.classlb);
            this.Name = "ViewScoreboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewScoreboard_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listscore;
        private System.Windows.Forms.ComboBox classcb;
        private System.Windows.Forms.Label classlb;
        private System.Windows.Forms.ComboBox subjectcb;
        private System.Windows.Forms.Label subjectlb;
        private System.Windows.Forms.Button editbttn;
        private System.Windows.Forms.Button Addbttn;
        private System.Windows.Forms.Button delete;
    }
}