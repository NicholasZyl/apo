namespace APO
{
    partial class MedianFilteringDialog
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskSizeBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioEdges1 = new System.Windows.Forms.RadioButton();
            this.radioEdges2 = new System.Windows.Forms.RadioButton();
            this.radioEdges3 = new System.Windows.Forms.RadioButton();
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maskSizeBox);
            this.groupBox1.Location = new System.Drawing.Point(59, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 49);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mask size";
            // 
            // maskSizeBox
            // 
            this.maskSizeBox.FormattingEnabled = true;
            this.maskSizeBox.Items.AddRange(new object[] {
            "3x3",
            "3x5",
            "5x3",
            "5x5",
            "7x7"});
            this.maskSizeBox.Location = new System.Drawing.Point(12, 19);
            this.maskSizeBox.Name = "maskSizeBox";
            this.maskSizeBox.Size = new System.Drawing.Size(121, 21);
            this.maskSizeBox.TabIndex = 0;
            this.maskSizeBox.SelectedValueChanged += new System.EventHandler(this.onMaskSizeChange);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioEdges1);
            this.groupBox2.Controls.Add(this.radioEdges2);
            this.groupBox2.Controls.Add(this.radioEdges3);
            this.groupBox2.Location = new System.Drawing.Point(59, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(149, 72);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edges processing";
            // 
            // radioEdges1
            // 
            this.radioEdges1.AutoSize = true;
            this.radioEdges1.Checked = true;
            this.radioEdges1.Location = new System.Drawing.Point(6, 16);
            this.radioEdges1.Name = "radioEdges1";
            this.radioEdges1.Size = new System.Drawing.Size(87, 17);
            this.radioEdges1.TabIndex = 15;
            this.radioEdges1.TabStop = true;
            this.radioEdges1.Text = "Ignore edges";
            this.radioEdges1.UseVisualStyleBackColor = true;
            this.radioEdges1.CheckedChanged += new System.EventHandler(this.onEdgeProcessingChange);
            // 
            // radioEdges2
            // 
            this.radioEdges2.AutoSize = true;
            this.radioEdges2.Location = new System.Drawing.Point(6, 32);
            this.radioEdges2.Name = "radioEdges2";
            this.radioEdges2.Size = new System.Drawing.Size(102, 17);
            this.radioEdges2.TabIndex = 16;
            this.radioEdges2.Text = "Duplicate edges";
            this.radioEdges2.UseVisualStyleBackColor = true;
            this.radioEdges2.CheckedChanged += new System.EventHandler(this.onEdgeProcessingChange);
            // 
            // radioEdges3
            // 
            this.radioEdges3.AutoSize = true;
            this.radioEdges3.Location = new System.Drawing.Point(6, 48);
            this.radioEdges3.Name = "radioEdges3";
            this.radioEdges3.Size = new System.Drawing.Size(99, 17);
            this.radioEdges3.TabIndex = 17;
            this.radioEdges3.Text = "Only on existing";
            this.radioEdges3.UseVisualStyleBackColor = true;
            this.radioEdges3.CheckedChanged += new System.EventHandler(this.onEdgeProcessingChange);
            // 
            // okBtn
            // 
            this.okBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okBtn.Location = new System.Drawing.Point(59, 158);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 16;
            this.okBtn.Text = "Ok";
            this.okBtn.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(133, 158);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 17;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // MedianFilteringDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 206);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MedianFilteringDialog";
            this.Text = "MedianFilteringDialog";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox maskSizeBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioEdges1;
        private System.Windows.Forms.RadioButton radioEdges2;
        private System.Windows.Forms.RadioButton radioEdges3;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}