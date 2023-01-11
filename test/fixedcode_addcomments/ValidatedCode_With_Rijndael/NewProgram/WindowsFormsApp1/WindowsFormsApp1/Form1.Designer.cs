namespace WindowsFormsApp1
{
    partial class frmEncode
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
            this.pnlSendReport = new System.Windows.Forms.Panel();
            this.btnScreenshot = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.lblOR = new System.Windows.Forms.Label();
            this.pnlDragDrop = new System.Windows.Forms.Panel();
            this.lblDragDrop = new System.Windows.Forms.Label();
            this.lblSendReport = new System.Windows.Forms.Label();
            this.pnlPreviewEncode = new System.Windows.Forms.Panel();
            this.btnNo = new System.Windows.Forms.Button();
            this.btnYes = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblScreenshotQuestion = new System.Windows.Forms.Label();
            this.lblPreviewEncode = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlSendReport.SuspendLayout();
            this.pnlDragDrop.SuspendLayout();
            this.pnlPreviewEncode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSendReport
            // 
            this.pnlSendReport.Controls.Add(this.btnScreenshot);
            this.pnlSendReport.Controls.Add(this.btnUpload);
            this.pnlSendReport.Controls.Add(this.lblOR);
            this.pnlSendReport.Controls.Add(this.pnlDragDrop);
            this.pnlSendReport.Controls.Add(this.lblSendReport);
            this.pnlSendReport.Location = new System.Drawing.Point(90, 68);
            this.pnlSendReport.Name = "pnlSendReport";
            this.pnlSendReport.Size = new System.Drawing.Size(982, 553);
            this.pnlSendReport.TabIndex = 0;
            // 
            // btnScreenshot
            // 
            this.btnScreenshot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(136)))), ((int)(((byte)(54)))));
            this.btnScreenshot.FlatAppearance.BorderSize = 0;
            this.btnScreenshot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScreenshot.Font = new System.Drawing.Font("Telegraf", 15F, System.Drawing.FontStyle.Bold);
            this.btnScreenshot.ForeColor = System.Drawing.Color.White;
            this.btnScreenshot.Location = new System.Drawing.Point(384, 418);
            this.btnScreenshot.Name = "btnScreenshot";
            this.btnScreenshot.Size = new System.Drawing.Size(220, 40);
            this.btnScreenshot.TabIndex = 4;
            this.btnScreenshot.Text = "SCREENSHOT";
            this.btnScreenshot.UseVisualStyleBackColor = false;
            this.btnScreenshot.Click += new System.EventHandler(this.btnScreenshot_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(136)))), ((int)(((byte)(54)))));
            this.btnUpload.FlatAppearance.BorderSize = 0;
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpload.Font = new System.Drawing.Font("Telegraf", 15F, System.Drawing.FontStyle.Bold);
            this.btnUpload.ForeColor = System.Drawing.Color.White;
            this.btnUpload.Location = new System.Drawing.Point(419, 358);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(150, 40);
            this.btnUpload.TabIndex = 3;
            this.btnUpload.Text = "UPLOAD";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // lblOR
            // 
            this.lblOR.ForeColor = System.Drawing.Color.White;
            this.lblOR.Location = new System.Drawing.Point(476, 331);
            this.lblOR.Name = "lblOR";
            this.lblOR.Size = new System.Drawing.Size(36, 24);
            this.lblOR.TabIndex = 2;
            this.lblOR.Text = "OR";
            this.lblOR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlDragDrop
            // 
            this.pnlDragDrop.AllowDrop = true;
            this.pnlDragDrop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.pnlDragDrop.Controls.Add(this.lblDragDrop);
            this.pnlDragDrop.Location = new System.Drawing.Point(149, 90);
            this.pnlDragDrop.Name = "pnlDragDrop";
            this.pnlDragDrop.Size = new System.Drawing.Size(691, 222);
            this.pnlDragDrop.TabIndex = 1;
            this.pnlDragDrop.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnlDragDrop_DragDrop);
            this.pnlDragDrop.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnlDragDrop_DragEnter);
            // 
            // lblDragDrop
            // 
            this.lblDragDrop.Font = new System.Drawing.Font("Montserrat", 19.8F, System.Drawing.FontStyle.Bold);
            this.lblDragDrop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.lblDragDrop.Location = new System.Drawing.Point(61, 90);
            this.lblDragDrop.Name = "lblDragDrop";
            this.lblDragDrop.Size = new System.Drawing.Size(572, 46);
            this.lblDragDrop.TabIndex = 0;
            this.lblDragDrop.Text = "Drag and Drop Screenshot Here";
            this.lblDragDrop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSendReport
            // 
            this.lblSendReport.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblSendReport.Font = new System.Drawing.Font("Montserrat", 40.2F, System.Drawing.FontStyle.Bold);
            this.lblSendReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.lblSendReport.Location = new System.Drawing.Point(0, 461);
            this.lblSendReport.Name = "lblSendReport";
            this.lblSendReport.Size = new System.Drawing.Size(982, 92);
            this.lblSendReport.TabIndex = 0;
            this.lblSendReport.Text = "Send Report";
            this.lblSendReport.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // pnlPreviewEncode
            // 
            this.pnlPreviewEncode.Controls.Add(this.btnNo);
            this.pnlPreviewEncode.Controls.Add(this.btnYes);
            this.pnlPreviewEncode.Controls.Add(this.pictureBox1);
            this.pnlPreviewEncode.Controls.Add(this.lblScreenshotQuestion);
            this.pnlPreviewEncode.Controls.Add(this.lblPreviewEncode);
            this.pnlPreviewEncode.Location = new System.Drawing.Point(654, 12);
            this.pnlPreviewEncode.Name = "pnlPreviewEncode";
            this.pnlPreviewEncode.Size = new System.Drawing.Size(982, 553);
            this.pnlPreviewEncode.TabIndex = 5;
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(136)))), ((int)(((byte)(54)))));
            this.btnNo.FlatAppearance.BorderSize = 0;
            this.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNo.Font = new System.Drawing.Font("Telegraf", 12F, System.Drawing.FontStyle.Bold);
            this.btnNo.ForeColor = System.Drawing.Color.White;
            this.btnNo.Location = new System.Drawing.Point(506, 396);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(60, 30);
            this.btnNo.TabIndex = 5;
            this.btnNo.Text = "NO";
            this.btnNo.UseVisualStyleBackColor = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnYes
            // 
            this.btnYes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(136)))), ((int)(((byte)(54)))));
            this.btnYes.FlatAppearance.BorderSize = 0;
            this.btnYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYes.Font = new System.Drawing.Font("Telegraf", 12F, System.Drawing.FontStyle.Bold);
            this.btnYes.ForeColor = System.Drawing.Color.White;
            this.btnYes.Location = new System.Drawing.Point(396, 396);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(60, 30);
            this.btnYes.TabIndex = 4;
            this.btnYes.Text = "YES";
            this.btnYes.UseVisualStyleBackColor = false;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(192, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(582, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblScreenshotQuestion
            // 
            this.lblScreenshotQuestion.ForeColor = System.Drawing.Color.White;
            this.lblScreenshotQuestion.Location = new System.Drawing.Point(347, 367);
            this.lblScreenshotQuestion.Name = "lblScreenshotQuestion";
            this.lblScreenshotQuestion.Size = new System.Drawing.Size(269, 24);
            this.lblScreenshotQuestion.TabIndex = 2;
            this.lblScreenshotQuestion.Text = "Would you like to submit this?";
            this.lblScreenshotQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPreviewEncode
            // 
            this.lblPreviewEncode.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblPreviewEncode.Font = new System.Drawing.Font("Montserrat", 40.2F, System.Drawing.FontStyle.Bold);
            this.lblPreviewEncode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.lblPreviewEncode.Location = new System.Drawing.Point(0, 461);
            this.lblPreviewEncode.Name = "lblPreviewEncode";
            this.lblPreviewEncode.Size = new System.Drawing.Size(982, 92);
            this.lblPreviewEncode.TabIndex = 0;
            this.lblPreviewEncode.Text = "Preview";
            this.lblPreviewEncode.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Montserrat", 19.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.label2.Location = new System.Drawing.Point(61, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(572, 46);
            this.label2.TabIndex = 0;
            this.label2.Text = "Drag and Drop Screenshot Here";
            // 
            // frmEncode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.pnlPreviewEncode);
            this.Controls.Add(this.pnlSendReport);
            this.Font = new System.Drawing.Font("Montserrat", 10.2F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmEncode";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmEncode_Load);
            this.pnlSendReport.ResumeLayout(false);
            this.pnlDragDrop.ResumeLayout(false);
            this.pnlPreviewEncode.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSendReport;
        private System.Windows.Forms.Panel pnlDragDrop;
        private System.Windows.Forms.Label lblDragDrop;
        private System.Windows.Forms.Label lblSendReport;
        private System.Windows.Forms.Button btnScreenshot;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label lblOR;
        private System.Windows.Forms.Panel pnlPreviewEncode;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblScreenshotQuestion;
        private System.Windows.Forms.Label lblPreviewEncode;
        private System.Windows.Forms.Label label2;
    }
}

