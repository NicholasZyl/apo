namespace APO
{
    partial class ComparisonDialog
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.baseImageBox = new System.Windows.Forms.PictureBox();
            this.changedImageBox = new System.Windows.Forms.PictureBox();
            this.slider = new System.Windows.Forms.TrackBar();
            this.textPreviewBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baseImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.changedImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.baseImageBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.changedImageBox);
            this.splitContainer1.Size = new System.Drawing.Size(921, 411);
            this.splitContainer1.SplitterDistance = 464;
            this.splitContainer1.TabIndex = 0;
            // 
            // baseImageBox
            // 
            this.baseImageBox.Location = new System.Drawing.Point(3, 3);
            this.baseImageBox.Name = "baseImageBox";
            this.baseImageBox.Size = new System.Drawing.Size(458, 403);
            this.baseImageBox.TabIndex = 0;
            this.baseImageBox.TabStop = false;
            // 
            // changedImageBox
            // 
            this.changedImageBox.Location = new System.Drawing.Point(3, 3);
            this.changedImageBox.Name = "changedImageBox";
            this.changedImageBox.Size = new System.Drawing.Size(446, 403);
            this.changedImageBox.TabIndex = 0;
            this.changedImageBox.TabStop = false;
            // 
            // slider
            // 
            this.slider.Location = new System.Drawing.Point(12, 442);
            this.slider.Name = "slider";
            this.slider.Size = new System.Drawing.Size(896, 45);
            this.slider.TabIndex = 1;
            this.slider.ValueChanged += new System.EventHandler(this.onSliderValueChange);
            this.slider.MouseUp += new System.Windows.Forms.MouseEventHandler(this.onParameterChangeMouseUp);
            // 
            // textPreviewBox
            // 
            this.textPreviewBox.Location = new System.Drawing.Point(411, 493);
            this.textPreviewBox.Name = "textPreviewBox";
            this.textPreviewBox.Size = new System.Drawing.Size(100, 20);
            this.textPreviewBox.TabIndex = 2;
            this.textPreviewBox.TextChanged += new System.EventHandler(this.onTextValueChanged);
            this.textPreviewBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.onParameterChangeMouseUp);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(386, 531);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.onOkClick);
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(467, 531);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.onCancelClick);
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            // 
            // ComparisonDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 566);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.textPreviewBox);
            this.Controls.Add(this.slider);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ComparisonDialog";
            this.Text = "ComparisonDialog";
            this.Load += new System.EventHandler(this.ComparisonForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.baseImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.changedImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox baseImageBox;
        private System.Windows.Forms.PictureBox changedImageBox;
        private System.Windows.Forms.TrackBar slider;
        private System.Windows.Forms.TextBox textPreviewBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
    }
}