namespace APO
{
    partial class SteganographyHideDialog
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
            this.widthInfo = new System.Windows.Forms.TextBox();
            this.heightInfo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.hideButton = new System.Windows.Forms.Button();
            this.baseImageWidth = new System.Windows.Forms.TextBox();
            this.bitsNumberInput = new System.Windows.Forms.NumericUpDown();
            this.baseImageHeight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.imageToHideBox = new System.Windows.Forms.PictureBox();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.bitsNumberInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageToHideBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // widthInfo
            // 
            this.widthInfo.Location = new System.Drawing.Point(133, 135);
            this.widthInfo.Name = "widthInfo";
            this.widthInfo.ReadOnly = true;
            this.widthInfo.Size = new System.Drawing.Size(34, 20);
            this.widthInfo.TabIndex = 7;
            // 
            // heightInfo
            // 
            this.heightInfo.Location = new System.Drawing.Point(133, 161);
            this.heightInfo.Name = "heightInfo";
            this.heightInfo.ReadOnly = true;
            this.heightInfo.Size = new System.Drawing.Size(34, 20);
            this.heightInfo.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Image to hide height:";
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(6, 101);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(161, 23);
            this.openFileButton.TabIndex = 9;
            this.openFileButton.Text = "Choose file to hide...";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.onChooseFileClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Image to hide width:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Base image width:";
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(92, 202);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Base image height:";
            // 
            // hideButton
            // 
            this.hideButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.hideButton.Enabled = false;
            this.hideButton.Location = new System.Drawing.Point(6, 202);
            this.hideButton.Name = "hideButton";
            this.hideButton.Size = new System.Drawing.Size(75, 23);
            this.hideButton.TabIndex = 3;
            this.hideButton.Text = "Hide";
            this.hideButton.UseVisualStyleBackColor = true;
            // 
            // baseImageWidth
            // 
            this.baseImageWidth.Location = new System.Drawing.Point(133, 34);
            this.baseImageWidth.Name = "baseImageWidth";
            this.baseImageWidth.ReadOnly = true;
            this.baseImageWidth.Size = new System.Drawing.Size(34, 20);
            this.baseImageWidth.TabIndex = 12;
            // 
            // bitsNumberInput
            // 
            this.bitsNumberInput.Location = new System.Drawing.Point(133, 1);
            this.bitsNumberInput.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.bitsNumberInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bitsNumberInput.Name = "bitsNumberInput";
            this.bitsNumberInput.Size = new System.Drawing.Size(34, 20);
            this.bitsNumberInput.TabIndex = 1;
            this.bitsNumberInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bitsNumberInput.ValueChanged += new System.EventHandler(this.onBitsValueChanged);
            // 
            // baseImageHeight
            // 
            this.baseImageHeight.Location = new System.Drawing.Point(133, 60);
            this.baseImageHeight.Name = "baseImageHeight";
            this.baseImageHeight.ReadOnly = true;
            this.baseImageHeight.Size = new System.Drawing.Size(34, 20);
            this.baseImageHeight.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number of bits to hide in:";
            // 
            // imageToHideBox
            // 
            this.imageToHideBox.Location = new System.Drawing.Point(3, 3);
            this.imageToHideBox.Name = "imageToHideBox";
            this.imageToHideBox.Size = new System.Drawing.Size(452, 341);
            this.imageToHideBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imageToHideBox.TabIndex = 0;
            this.imageToHideBox.TabStop = false;
            this.imageToHideBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.onCropImageMouseDown);
            this.imageToHideBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.onCropImageMouseMove);
            this.imageToHideBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.onCropImageMouseUp);
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.AutoScroll = true;
            this.splitContainer.Panel1.Controls.Add(this.imageToHideBox);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.label1);
            this.splitContainer.Panel2.Controls.Add(this.baseImageHeight);
            this.splitContainer.Panel2.Controls.Add(this.bitsNumberInput);
            this.splitContainer.Panel2.Controls.Add(this.baseImageWidth);
            this.splitContainer.Panel2.Controls.Add(this.hideButton);
            this.splitContainer.Panel2.Controls.Add(this.label4);
            this.splitContainer.Panel2.Controls.Add(this.button2);
            this.splitContainer.Panel2.Controls.Add(this.label5);
            this.splitContainer.Panel2.Controls.Add(this.label2);
            this.splitContainer.Panel2.Controls.Add(this.openFileButton);
            this.splitContainer.Panel2.Controls.Add(this.label3);
            this.splitContainer.Panel2.Controls.Add(this.heightInfo);
            this.splitContainer.Panel2.Controls.Add(this.widthInfo);
            this.splitContainer.Size = new System.Drawing.Size(651, 346);
            this.splitContainer.SplitterDistance = 458;
            this.splitContainer.TabIndex = 14;
            // 
            // SteganographyHideDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 346);
            this.Controls.Add(this.splitContainer);
            this.MinimumSize = new System.Drawing.Size(600, 385);
            this.Name = "SteganographyHideDialog";
            this.Text = "SteganographyHideDialog";
            ((System.ComponentModel.ISupportInitialize)(this.bitsNumberInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageToHideBox)).EndInit();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox widthInfo;
        private System.Windows.Forms.TextBox heightInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button hideButton;
        private System.Windows.Forms.TextBox baseImageWidth;
        private System.Windows.Forms.NumericUpDown bitsNumberInput;
        private System.Windows.Forms.TextBox baseImageHeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox imageToHideBox;
        private System.Windows.Forms.SplitContainer splitContainer;
    }
}