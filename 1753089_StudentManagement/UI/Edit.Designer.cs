namespace UI
{
    partial class Edit
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
            this.adjcancelbttn = new System.Windows.Forms.Button();
            this.adjokbttn = new System.Windows.Forms.Button();
            this.subjectidlb = new System.Windows.Forms.Label();
            this.idlb = new System.Windows.Forms.Label();
            this.classlb = new System.Windows.Forms.Label();
            this.semlb = new System.Windows.Forms.Label();
            this.midtermtb = new System.Windows.Forms.TextBox();
            this.midtermlb = new System.Windows.Forms.Label();
            this.finaltb = new System.Windows.Forms.TextBox();
            this.finallb = new System.Windows.Forms.Label();
            this.othtb = new System.Windows.Forms.TextBox();
            this.othlb = new System.Windows.Forms.Label();
            this.ttllb = new System.Windows.Forms.Label();
            this.totaltb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // adjcancelbttn
            // 
            this.adjcancelbttn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.adjcancelbttn.Location = new System.Drawing.Point(402, 323);
            this.adjcancelbttn.Name = "adjcancelbttn";
            this.adjcancelbttn.Size = new System.Drawing.Size(75, 35);
            this.adjcancelbttn.TabIndex = 48;
            this.adjcancelbttn.Text = "Cancel";
            this.adjcancelbttn.UseVisualStyleBackColor = true;
            this.adjcancelbttn.Click += new System.EventHandler(this.Adjcancelbttn_Click);
            // 
            // adjokbttn
            // 
            this.adjokbttn.Location = new System.Drawing.Point(114, 323);
            this.adjokbttn.Name = "adjokbttn";
            this.adjokbttn.Size = new System.Drawing.Size(75, 35);
            this.adjokbttn.TabIndex = 47;
            this.adjokbttn.Text = "OK";
            this.adjokbttn.UseVisualStyleBackColor = true;
            this.adjokbttn.Click += new System.EventHandler(this.Adjokbttn_Click);
            // 
            // subjectidlb
            // 
            this.subjectidlb.AutoSize = true;
            this.subjectidlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectidlb.Location = new System.Drawing.Point(136, 79);
            this.subjectidlb.Name = "subjectidlb";
            this.subjectidlb.Size = new System.Drawing.Size(88, 20);
            this.subjectidlb.TabIndex = 37;
            this.subjectidlb.Text = "Subject ID:";
            // 
            // idlb
            // 
            this.idlb.AutoSize = true;
            this.idlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idlb.Location = new System.Drawing.Point(136, 37);
            this.idlb.Name = "idlb";
            this.idlb.Size = new System.Drawing.Size(91, 20);
            this.idlb.TabIndex = 33;
            this.idlb.Text = "Student ID:";
            // 
            // classlb
            // 
            this.classlb.AutoSize = true;
            this.classlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classlb.Location = new System.Drawing.Point(136, 121);
            this.classlb.Name = "classlb";
            this.classlb.Size = new System.Drawing.Size(52, 20);
            this.classlb.TabIndex = 51;
            this.classlb.Text = "Class:";
            // 
            // semlb
            // 
            this.semlb.AutoSize = true;
            this.semlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semlb.Location = new System.Drawing.Point(136, 166);
            this.semlb.Name = "semlb";
            this.semlb.Size = new System.Drawing.Size(82, 20);
            this.semlb.TabIndex = 53;
            this.semlb.Text = "Semester:";
            // 
            // midtermtb
            // 
            this.midtermtb.Location = new System.Drawing.Point(190, 210);
            this.midtermtb.Name = "midtermtb";
            this.midtermtb.Size = new System.Drawing.Size(75, 26);
            this.midtermtb.TabIndex = 38;
            // 
            // midtermlb
            // 
            this.midtermlb.AutoSize = true;
            this.midtermlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.midtermlb.Location = new System.Drawing.Point(81, 213);
            this.midtermlb.Name = "midtermlb";
            this.midtermlb.Size = new System.Drawing.Size(70, 20);
            this.midtermlb.TabIndex = 39;
            this.midtermlb.Text = "Midterm:";
            // 
            // finaltb
            // 
            this.finaltb.Location = new System.Drawing.Point(190, 253);
            this.finaltb.Name = "finaltb";
            this.finaltb.Size = new System.Drawing.Size(75, 26);
            this.finaltb.TabIndex = 40;
            // 
            // finallb
            // 
            this.finallb.AutoSize = true;
            this.finallb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finallb.Location = new System.Drawing.Point(81, 253);
            this.finallb.Name = "finallb";
            this.finallb.Size = new System.Drawing.Size(47, 20);
            this.finallb.TabIndex = 41;
            this.finallb.Text = "Final:";
            // 
            // othtb
            // 
            this.othtb.Location = new System.Drawing.Point(434, 207);
            this.othtb.Name = "othtb";
            this.othtb.Size = new System.Drawing.Size(75, 26);
            this.othtb.TabIndex = 42;
            // 
            // othlb
            // 
            this.othlb.AutoSize = true;
            this.othlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.othlb.Location = new System.Drawing.Point(325, 207);
            this.othlb.Name = "othlb";
            this.othlb.Size = new System.Drawing.Size(53, 20);
            this.othlb.TabIndex = 43;
            this.othlb.Text = "Other:";
            // 
            // ttllb
            // 
            this.ttllb.AutoSize = true;
            this.ttllb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttllb.Location = new System.Drawing.Point(325, 254);
            this.ttllb.Name = "ttllb";
            this.ttllb.Size = new System.Drawing.Size(48, 20);
            this.ttllb.TabIndex = 44;
            this.ttllb.Text = "Total:";
            // 
            // totaltb
            // 
            this.totaltb.Location = new System.Drawing.Point(434, 254);
            this.totaltb.Name = "totaltb";
            this.totaltb.Size = new System.Drawing.Size(75, 26);
            this.totaltb.TabIndex = 49;
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 379);
            this.Controls.Add(this.semlb);
            this.Controls.Add(this.classlb);
            this.Controls.Add(this.totaltb);
            this.Controls.Add(this.adjcancelbttn);
            this.Controls.Add(this.adjokbttn);
            this.Controls.Add(this.ttllb);
            this.Controls.Add(this.othlb);
            this.Controls.Add(this.othtb);
            this.Controls.Add(this.finallb);
            this.Controls.Add(this.finaltb);
            this.Controls.Add(this.midtermlb);
            this.Controls.Add(this.midtermtb);
            this.Controls.Add(this.subjectidlb);
            this.Controls.Add(this.idlb);
            this.Name = "Edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button adjcancelbttn;
        private System.Windows.Forms.Button adjokbttn;
        private System.Windows.Forms.Label subjectidlb;
        private System.Windows.Forms.Label idlb;
        private System.Windows.Forms.Label classlb;
        private System.Windows.Forms.Label semlb;
        private System.Windows.Forms.TextBox midtermtb;
        private System.Windows.Forms.Label midtermlb;
        private System.Windows.Forms.TextBox finaltb;
        private System.Windows.Forms.Label finallb;
        private System.Windows.Forms.TextBox othtb;
        private System.Windows.Forms.Label othlb;
        private System.Windows.Forms.Label ttllb;
        private System.Windows.Forms.TextBox totaltb;
    }
}