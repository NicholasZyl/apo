namespace APO
{
    partial class DuplexBinarizationDialog
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
            this.upperBoundBox = new System.Windows.Forms.NumericUpDown();
            this.lowerBoundBox = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.upperBoundBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowerBoundBox)).BeginInit();
            this.SuspendLayout();
            // 
            // upperBoundBox
            // 
            this.upperBoundBox.Location = new System.Drawing.Point(101, 37);
            this.upperBoundBox.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.upperBoundBox.Name = "upperBoundBox";
            this.upperBoundBox.Size = new System.Drawing.Size(120, 20);
            this.upperBoundBox.TabIndex = 0;
            // 
            // lowerBoundBox
            // 
            this.lowerBoundBox.Location = new System.Drawing.Point(101, 11);
            this.lowerBoundBox.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.lowerBoundBox.Name = "lowerBoundBox";
            this.lowerBoundBox.Size = new System.Drawing.Size(120, 20);
            this.lowerBoundBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Upper bound";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lower bound";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(76, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(76, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // DuplexBinarizationDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 139);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lowerBoundBox);
            this.Controls.Add(this.upperBoundBox);
            this.Name = "DuplexBinarizationDialog";
            this.Text = "DuplexBinarizationDialog";
            ((System.ComponentModel.ISupportInitialize)(this.upperBoundBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowerBoundBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown upperBoundBox;
        private System.Windows.Forms.NumericUpDown lowerBoundBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}