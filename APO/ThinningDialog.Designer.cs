﻿namespace APO
{
    partial class ThinningDialog
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioEdges1 = new System.Windows.Forms.RadioButton();
            this.radioEdges2 = new System.Windows.Forms.RadioButton();
            this.radioEdges3 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioEdges1);
            this.groupBox2.Controls.Add(this.radioEdges2);
            this.groupBox2.Controls.Add(this.radioEdges3);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(147, 72);
            this.groupBox2.TabIndex = 25;
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
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(47, 122);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 31;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(47, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            // 
            // ThinningDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(169, 156);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Name = "ThinningDialog";
            this.Text = "ThinningDialog";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioEdges1;
        private System.Windows.Forms.RadioButton radioEdges2;
        private System.Windows.Forms.RadioButton radioEdges3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}