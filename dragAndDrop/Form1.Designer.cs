
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
            this.label1 = new System.Windows.Forms.Label();
            this.dragDrop.SuspendLayout();
            this.SuspendLayout();
            // 
            // dragDrop
            // 
            this.dragDrop.AllowDrop = true;
            this.dragDrop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dragDrop.Controls.Add(this.label1);
            this.dragDrop.Location = new System.Drawing.Point(234, 33);
            this.dragDrop.Name = "dragDrop";
            this.dragDrop.Size = new System.Drawing.Size(513, 271);
            this.dragDrop.TabIndex = 0;
            this.dragDrop.DragDrop += new System.Windows.Forms.DragEventHandler(this.dragDrop_DragDrop);
            this.dragDrop.DragEnter += new System.Windows.Forms.DragEventHandler(this.dragDrop_DragEnter);
            this.dragDrop.Paint += new System.Windows.Forms.PaintEventHandler(this.dragDrop_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.label1.Location = new System.Drawing.Point(207, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "test";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.dragDrop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.dragDrop.ResumeLayout(false);
            this.dragDrop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel dragDrop;
        private System.Windows.Forms.Label label1;
    }
}

