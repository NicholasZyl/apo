namespace APO
{
    partial class UniversalPointOperatorDialog
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
            this.lutGraphPanel = new System.Windows.Forms.Panel();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lutGraphPanel
            // 
            this.lutGraphPanel.Location = new System.Drawing.Point(12, 12);
            this.lutGraphPanel.Name = "lutGraphPanel";
            this.lutGraphPanel.Size = new System.Drawing.Size(256, 266);
            this.lutGraphPanel.TabIndex = 0;
            this.lutGraphPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.onLutGraphPaint);
            this.lutGraphPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.onLutGraphMouseMove);
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(51, 293);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(146, 293);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // UniversalPointOperatorDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 328);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.lutGraphPanel);
            this.Name = "UniversalPointOperatorDialog";
            this.Text = "Universal Point Operator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel lutGraphPanel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
    }
}