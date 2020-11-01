namespace WindowsFormsApp3
{
    partial class Form1
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
            this.srchLbl = new System.Windows.Forms.Label();
            this.srchBx = new System.Windows.Forms.TextBox();
            this.GoBtn = new System.Windows.Forms.Button();
            this.srcCodeBx = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.DownBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // srchLbl
            // 
            this.srchLbl.AutoSize = true;
            this.srchLbl.Location = new System.Drawing.Point(108, 44);
            this.srchLbl.Name = "srchLbl";
            this.srchLbl.Size = new System.Drawing.Size(44, 13);
            this.srchLbl.TabIndex = 0;
            this.srchLbl.Text = "Search:";
            // 
            // srchBx
            // 
            this.srchBx.Location = new System.Drawing.Point(171, 40);
            this.srchBx.Name = "srchBx";
            this.srchBx.Size = new System.Drawing.Size(68, 20);
            this.srchBx.TabIndex = 1;
            // 
            // GoBtn
            // 
            this.GoBtn.Location = new System.Drawing.Point(268, 38);
            this.GoBtn.Name = "GoBtn";
            this.GoBtn.Size = new System.Drawing.Size(30, 24);
            this.GoBtn.TabIndex = 2;
            this.GoBtn.Text = "Go";
            this.GoBtn.UseVisualStyleBackColor = true;
            this.GoBtn.Click += new System.EventHandler(this.GoBtn_Click);
            // 
            // srcCodeBx
            // 
            this.srcCodeBx.Location = new System.Drawing.Point(427, 100);
            this.srcCodeBx.Multiline = true;
            this.srcCodeBx.Name = "srcCodeBx";
            this.srcCodeBx.ReadOnly = true;
            this.srcCodeBx.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.srcCodeBx.Size = new System.Drawing.Size(368, 339);
            this.srcCodeBx.TabIndex = 3;
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(12, 100);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(387, 339);
            this.webBrowser.TabIndex = 4;
            // 
            // DownBtn
            // 
            this.DownBtn.Location = new System.Drawing.Point(543, 36);
            this.DownBtn.Name = "DownBtn";
            this.DownBtn.Size = new System.Drawing.Size(133, 29);
            this.DownBtn.TabIndex = 5;
            this.DownBtn.Text = "Download emotes";
            this.DownBtn.UseVisualStyleBackColor = true;
            this.DownBtn.Click += new System.EventHandler(this.DownBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 455);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "©AnonDevs";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 478);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DownBtn);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.srcCodeBx);
            this.Controls.Add(this.GoBtn);
            this.Controls.Add(this.srchBx);
            this.Controls.Add(this.srchLbl);
            this.Name = "Form1";
            this.Text = "Emote Downloader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label srchLbl;
        private System.Windows.Forms.TextBox srchBx;
        private System.Windows.Forms.Button GoBtn;
        private System.Windows.Forms.TextBox srcCodeBx;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Button DownBtn;
        private System.Windows.Forms.Label label1;
    }
}

