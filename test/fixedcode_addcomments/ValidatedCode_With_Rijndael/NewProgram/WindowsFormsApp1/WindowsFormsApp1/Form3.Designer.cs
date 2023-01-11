namespace WindowsFormsApp1
{
    partial class frmDecodeSteg
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
            this.pnlDecoder = new System.Windows.Forms.Panel();
            this.btnUpload = new System.Windows.Forms.Button();
            this.lblOR = new System.Windows.Forms.Label();
            this.pnlDragDropDeEncode = new System.Windows.Forms.Panel();
            this.lblDragDrop = new System.Windows.Forms.Label();
            this.lblDecrypt = new System.Windows.Forms.Label();
            this.pnlDecryptResult = new System.Windows.Forms.Panel();
            this.btnReturn = new System.Windows.Forms.Button();
            this.rtbDecrypt = new System.Windows.Forms.RichTextBox();
            this.lblDecryption = new System.Windows.Forms.Label();
            this.lblPreview = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDecryRes = new System.Windows.Forms.Label();
            this.pnlDecoder.SuspendLayout();
            this.pnlDragDropDeEncode.SuspendLayout();
            this.pnlDecryptResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDecoder
            // 
            this.pnlDecoder.Controls.Add(this.btnUpload);
            this.pnlDecoder.Controls.Add(this.lblOR);
            this.pnlDecoder.Controls.Add(this.pnlDragDropDeEncode);
            this.pnlDecoder.Controls.Add(this.lblDecrypt);
            this.pnlDecoder.Location = new System.Drawing.Point(906, 60);
            this.pnlDecoder.Name = "pnlDecoder";
            this.pnlDecoder.Size = new System.Drawing.Size(982, 553);
            this.pnlDecoder.TabIndex = 1;
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
            this.lblOR.Font = new System.Drawing.Font("Montserrat", 10.2F);
            this.lblOR.ForeColor = System.Drawing.Color.White;
            this.lblOR.Location = new System.Drawing.Point(476, 331);
            this.lblOR.Name = "lblOR";
            this.lblOR.Size = new System.Drawing.Size(36, 24);
            this.lblOR.TabIndex = 2;
            this.lblOR.Text = "OR";
            this.lblOR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlDragDropDeEncode
            // 
            this.pnlDragDropDeEncode.AllowDrop = true;
            this.pnlDragDropDeEncode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.pnlDragDropDeEncode.Controls.Add(this.lblDragDrop);
            this.pnlDragDropDeEncode.Location = new System.Drawing.Point(149, 90);
            this.pnlDragDropDeEncode.Name = "pnlDragDropDeEncode";
            this.pnlDragDropDeEncode.Size = new System.Drawing.Size(691, 222);
            this.pnlDragDropDeEncode.TabIndex = 1;
            this.pnlDragDropDeEncode.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnlDragDropDeEncode_DragDrop);
            this.pnlDragDropDeEncode.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnlDragDropDeEncode_DragEnter);
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
            // lblDecrypt
            // 
            this.lblDecrypt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblDecrypt.Font = new System.Drawing.Font("Montserrat", 40.2F, System.Drawing.FontStyle.Bold);
            this.lblDecrypt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.lblDecrypt.Location = new System.Drawing.Point(0, 461);
            this.lblDecrypt.Name = "lblDecrypt";
            this.lblDecrypt.Size = new System.Drawing.Size(982, 92);
            this.lblDecrypt.TabIndex = 0;
            this.lblDecrypt.Text = "Decrypt";
            this.lblDecrypt.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // pnlDecryptResult
            // 
            this.pnlDecryptResult.Controls.Add(this.btnReturn);
            this.pnlDecryptResult.Controls.Add(this.rtbDecrypt);
            this.pnlDecryptResult.Controls.Add(this.lblDecryption);
            this.pnlDecryptResult.Controls.Add(this.lblPreview);
            this.pnlDecryptResult.Controls.Add(this.pictureBox1);
            this.pnlDecryptResult.Controls.Add(this.lblDecryRes);
            this.pnlDecryptResult.Location = new System.Drawing.Point(109, 12);
            this.pnlDecryptResult.Name = "pnlDecryptResult";
            this.pnlDecryptResult.Size = new System.Drawing.Size(982, 553);
            this.pnlDecryptResult.TabIndex = 6;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(136)))), ((int)(((byte)(54)))));
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Telegraf", 15F, System.Drawing.FontStyle.Bold);
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Location = new System.Drawing.Point(420, 370);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(150, 40);
            this.btnReturn.TabIndex = 9;
            this.btnReturn.Text = "UPLOAD";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // rtbDecrypt
            // 
            this.rtbDecrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.rtbDecrypt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbDecrypt.Font = new System.Drawing.Font("Montserrat", 10.2F);
            this.rtbDecrypt.ForeColor = System.Drawing.Color.White;
            this.rtbDecrypt.Location = new System.Drawing.Point(653, 60);
            this.rtbDecrypt.Name = "rtbDecrypt";
            this.rtbDecrypt.ReadOnly = true;
            this.rtbDecrypt.Size = new System.Drawing.Size(265, 398);
            this.rtbDecrypt.TabIndex = 8;
            this.rtbDecrypt.Text = "";
            // 
            // lblDecryption
            // 
            this.lblDecryption.Font = new System.Drawing.Font("Montserrat", 10.2F);
            this.lblDecryption.ForeColor = System.Drawing.Color.White;
            this.lblDecryption.Location = new System.Drawing.Point(649, 33);
            this.lblDecryption.Name = "lblDecryption";
            this.lblDecryption.Size = new System.Drawing.Size(269, 24);
            this.lblDecryption.TabIndex = 7;
            this.lblDecryption.Text = "Decryption Result";
            this.lblDecryption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPreview
            // 
            this.lblPreview.Font = new System.Drawing.Font("Montserrat", 10.2F);
            this.lblPreview.ForeColor = System.Drawing.Color.White;
            this.lblPreview.Location = new System.Drawing.Point(49, 33);
            this.lblPreview.Name = "lblPreview";
            this.lblPreview.Size = new System.Drawing.Size(269, 24);
            this.lblPreview.TabIndex = 6;
            this.lblPreview.Text = "Preview";
            this.lblPreview.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(53, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(303, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblDecryRes
            // 
            this.lblDecryRes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblDecryRes.Font = new System.Drawing.Font("Montserrat", 40.2F, System.Drawing.FontStyle.Bold);
            this.lblDecryRes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.lblDecryRes.Location = new System.Drawing.Point(0, 461);
            this.lblDecryRes.Name = "lblDecryRes";
            this.lblDecryRes.Size = new System.Drawing.Size(982, 92);
            this.lblDecryRes.TabIndex = 0;
            this.lblDecryRes.Text = "Decrypt Result";
            this.lblDecryRes.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // frmDecodeSteg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.pnlDecryptResult);
            this.Controls.Add(this.pnlDecoder);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmDecodeSteg";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.frmDecodeSteg_Load);
            this.pnlDecoder.ResumeLayout(false);
            this.pnlDragDropDeEncode.ResumeLayout(false);
            this.pnlDecryptResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDecoder;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label lblOR;
        private System.Windows.Forms.Panel pnlDragDropDeEncode;
        private System.Windows.Forms.Label lblDragDrop;
        private System.Windows.Forms.Label lblDecrypt;
        private System.Windows.Forms.Panel pnlDecryptResult;
        private System.Windows.Forms.RichTextBox rtbDecrypt;
        private System.Windows.Forms.Label lblDecryption;
        private System.Windows.Forms.Label lblPreview;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDecryRes;
        private System.Windows.Forms.Button btnReturn;
    }
}