
namespace dragAndDrop
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
            this.dragDrop = new System.Windows.Forms.Panel();
            this.picBoxImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dragDrop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // dragDrop
            // 
            this.dragDrop.AllowDrop = true;
            this.dragDrop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dragDrop.Controls.Add(this.picBoxImage);
            this.dragDrop.Controls.Add(this.label1);
            this.dragDrop.Location = new System.Drawing.Point(12, 22);
            this.dragDrop.Name = "dragDrop";
            this.dragDrop.Size = new System.Drawing.Size(513, 271);
            this.dragDrop.TabIndex = 0;
            this.dragDrop.DragDrop += new System.Windows.Forms.DragEventHandler(this.dragDrop_DragDrop);
            this.dragDrop.DragEnter += new System.Windows.Forms.DragEventHandler(this.dragDrop_DragEnter);
            this.dragDrop.Paint += new System.Windows.Forms.PaintEventHandler(this.dragDrop_Paint);
            // 
            // picBoxImage
            // 
            this.picBoxImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.picBoxImage.Location = new System.Drawing.Point(26, 13);
            this.picBoxImage.Name = "picBoxImage";
            this.picBoxImage.Size = new System.Drawing.Size(462, 239);
            this.picBoxImage.TabIndex = 1;
            this.picBoxImage.TabStop = false;
            this.picBoxImage.Click += new System.EventHandler(this.picBoxImage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(145, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Drag and Drop";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(582, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dragDrop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.dragDrop.ResumeLayout(false);
            this.dragDrop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel dragDrop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picBoxImage;
        private System.Windows.Forms.Label label2;
    }
}

