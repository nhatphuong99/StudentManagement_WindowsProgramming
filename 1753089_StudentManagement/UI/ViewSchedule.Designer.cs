namespace UI
{
    partial class ViewSchedule
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
            this.subjectcb = new System.Windows.Forms.ComboBox();
            this.subjectlb = new System.Windows.Forms.Label();
            this.listschedule = new System.Windows.Forms.ListView();
            this.classcb = new System.Windows.Forms.ComboBox();
            this.classlb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // subjectcb
            // 
            this.subjectcb.FormattingEnabled = true;
            this.subjectcb.Location = new System.Drawing.Point(394, 25);
            this.subjectcb.Name = "subjectcb";
            this.subjectcb.Size = new System.Drawing.Size(121, 28);
            this.subjectcb.TabIndex = 12;
            this.subjectcb.SelectedIndexChanged += new System.EventHandler(this.Classcb_SelectedIndexChanged);
            // 
            // subjectlb
            // 
            this.subjectlb.AutoSize = true;
            this.subjectlb.Location = new System.Drawing.Point(320, 28);
            this.subjectlb.Name = "subjectlb";
            this.subjectlb.Size = new System.Drawing.Size(67, 20);
            this.subjectlb.TabIndex = 11;
            this.subjectlb.Text = "Subject:";
            // 
            // listschedule
            // 
            this.listschedule.Location = new System.Drawing.Point(12, 68);
            this.listschedule.Name = "listschedule";
            this.listschedule.Size = new System.Drawing.Size(776, 357);
            this.listschedule.TabIndex = 10;
            this.listschedule.UseCompatibleStateImageBehavior = false;
            // 
            // classcb
            // 
            this.classcb.FormattingEnabled = true;
            this.classcb.Location = new System.Drawing.Point(128, 25);
            this.classcb.Name = "classcb";
            this.classcb.Size = new System.Drawing.Size(121, 28);
            this.classcb.TabIndex = 9;
            this.classcb.SelectedIndexChanged += new System.EventHandler(this.Classcb_SelectedIndexChanged);
            // 
            // classlb
            // 
            this.classlb.AutoSize = true;
            this.classlb.Location = new System.Drawing.Point(54, 28);
            this.classlb.Name = "classlb";
            this.classlb.Size = new System.Drawing.Size(52, 20);
            this.classlb.TabIndex = 8;
            this.classlb.Text = "Class:";
            // 
            // ViewSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.subjectcb);
            this.Controls.Add(this.subjectlb);
            this.Controls.Add(this.listschedule);
            this.Controls.Add(this.classcb);
            this.Controls.Add(this.classlb);
            this.Name = "ViewSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewSchedule_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox subjectcb;
        private System.Windows.Forms.Label subjectlb;
        private System.Windows.Forms.ListView listschedule;
        private System.Windows.Forms.ComboBox classcb;
        private System.Windows.Forms.Label classlb;
    }
}