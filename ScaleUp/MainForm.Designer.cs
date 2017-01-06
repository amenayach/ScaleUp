namespace ScaleUp
{
    partial class MainForm
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
            this.numTargetWidth = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.picWorkingImage = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numTargetWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWorkingImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numTargetWidth
            // 
            this.numTargetWidth.Location = new System.Drawing.Point(77, 3);
            this.numTargetWidth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numTargetWidth.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numTargetWidth.Name = "numTargetWidth";
            this.numTargetWidth.Size = new System.Drawing.Size(120, 20);
            this.numTargetWidth.TabIndex = 3;
            this.numTargetWidth.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Target width";
            // 
            // picWorkingImage
            // 
            this.picWorkingImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picWorkingImage.Location = new System.Drawing.Point(12, 12);
            this.picWorkingImage.Name = "picWorkingImage";
            this.picWorkingImage.Size = new System.Drawing.Size(368, 303);
            this.picWorkingImage.TabIndex = 5;
            this.picWorkingImage.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel1.Controls.Add(this.numTargetWidth);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(79, 314);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 26);
            this.panel1.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 345);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picWorkingImage);
            this.Name = "MainForm";
            this.Text = "ScaleUp - Just any image ;)";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.numTargetWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWorkingImage)).EndInit();
            this.Icon = Properties.Resources.scaleicon;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numTargetWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picWorkingImage;
        private System.Windows.Forms.Panel panel1;
    }
}

