namespace UI
{
    partial class StudentViewScore
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
            this.liststudentscore = new System.Windows.Forms.ListView();
            this.subjectcb = new System.Windows.Forms.ComboBox();
            this.subjectlb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // liststudentscore
            // 
            this.liststudentscore.Location = new System.Drawing.Point(12, 68);
            this.liststudentscore.Name = "liststudentscore";
            this.liststudentscore.Size = new System.Drawing.Size(776, 357);
            this.liststudentscore.TabIndex = 5;
            this.liststudentscore.UseCompatibleStateImageBehavior = false;
            // 
            // subjectcb
            // 
            this.subjectcb.FormattingEnabled = true;
            this.subjectcb.Location = new System.Drawing.Point(128, 25);
            this.subjectcb.Name = "subjectcb";
            this.subjectcb.Size = new System.Drawing.Size(121, 28);
            this.subjectcb.TabIndex = 4;
            this.subjectcb.SelectedIndexChanged += new System.EventHandler(this.Subjectcb_SelectedIndexChanged);
            // 
            // subjectlb
            // 
            this.subjectlb.AutoSize = true;
            this.subjectlb.Location = new System.Drawing.Point(54, 28);
            this.subjectlb.Name = "subjectlb";
            this.subjectlb.Size = new System.Drawing.Size(67, 20);
            this.subjectlb.TabIndex = 3;
            this.subjectlb.Text = "Subject:";
            // 
            // StudentViewScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.liststudentscore);
            this.Controls.Add(this.subjectcb);
            this.Controls.Add(this.subjectlb);
            this.Name = "StudentViewScore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StudentViewScore_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView liststudentscore;
        private System.Windows.Forms.ComboBox subjectcb;
        private System.Windows.Forms.Label subjectlb;
    }
}