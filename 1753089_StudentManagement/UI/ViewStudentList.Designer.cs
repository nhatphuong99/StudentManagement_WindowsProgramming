namespace UI
{
    partial class ViewStudentList
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
            this.classlb = new System.Windows.Forms.Label();
            this.classcb = new System.Windows.Forms.ComboBox();
            this.liststudent = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // classlb
            // 
            this.classlb.AutoSize = true;
            this.classlb.Location = new System.Drawing.Point(54, 41);
            this.classlb.Name = "classlb";
            this.classlb.Size = new System.Drawing.Size(52, 20);
            this.classlb.TabIndex = 0;
            this.classlb.Text = "Class:";
            // 
            // classcb
            // 
            this.classcb.FormattingEnabled = true;
            this.classcb.Location = new System.Drawing.Point(128, 38);
            this.classcb.Name = "classcb";
            this.classcb.Size = new System.Drawing.Size(121, 28);
            this.classcb.TabIndex = 1;
            this.classcb.SelectedIndexChanged += new System.EventHandler(this.Classcb_SelectedIndexChanged);
            // 
            // liststudent
            // 
            this.liststudent.Location = new System.Drawing.Point(12, 81);
            this.liststudent.Name = "liststudent";
            this.liststudent.Size = new System.Drawing.Size(776, 357);
            this.liststudent.TabIndex = 2;
            this.liststudent.UseCompatibleStateImageBehavior = false;
            // 
            // ViewStudentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.liststudent);
            this.Controls.Add(this.classcb);
            this.Controls.Add(this.classlb);
            this.Name = "ViewStudentList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewStudentList_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label classlb;
        private System.Windows.Forms.ComboBox classcb;
        private System.Windows.Forms.ListView liststudent;
    }
}