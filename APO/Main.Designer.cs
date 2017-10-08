namespace APO
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszJakoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cofnijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.laboratorium1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyrownanieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metodaSrednichToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metodaLosowaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metodaSasiedztwaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metodaWlasnaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.operacjeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1213, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.UseWaitCursor = true;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.zapiszToolStripMenuItem,
            this.zapiszJakoToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(38, 20);
            this.toolStripMenuItem1.Text = "Plik";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Otwórz";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // zapiszToolStripMenuItem
            // 
            this.zapiszToolStripMenuItem.Enabled = false;
            this.zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            this.zapiszToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.zapiszToolStripMenuItem.Text = "Zapisz";
            // 
            // zapiszJakoToolStripMenuItem
            // 
            this.zapiszJakoToolStripMenuItem.Enabled = false;
            this.zapiszJakoToolStripMenuItem.Name = "zapiszJakoToolStripMenuItem";
            this.zapiszJakoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.zapiszJakoToolStripMenuItem.Text = "Zapisz jako";
            // 
            // operacjeToolStripMenuItem
            // 
            this.operacjeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cofnijToolStripMenuItem,
            this.toolStripSeparator1,
            this.laboratorium1ToolStripMenuItem});
            this.operacjeToolStripMenuItem.Enabled = false;
            this.operacjeToolStripMenuItem.Name = "operacjeToolStripMenuItem";
            this.operacjeToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.operacjeToolStripMenuItem.Text = "Operacje";
            // 
            // cofnijToolStripMenuItem
            // 
            this.cofnijToolStripMenuItem.Name = "cofnijToolStripMenuItem";
            this.cofnijToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.cofnijToolStripMenuItem.Text = "Cofnij";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(127, 6);
            // 
            // laboratorium1ToolStripMenuItem
            // 
            this.laboratorium1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.histogramToolStripMenuItem,
            this.wyrownanieToolStripMenuItem});
            this.laboratorium1ToolStripMenuItem.Name = "laboratorium1ToolStripMenuItem";
            this.laboratorium1ToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.laboratorium1ToolStripMenuItem.Text = "Histogram";
            this.laboratorium1ToolStripMenuItem.Click += new System.EventHandler(this.laboratorium1ToolStripMenuItem_Click);
            // 
            // histogramToolStripMenuItem
            // 
            this.histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            this.histogramToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.histogramToolStripMenuItem.Text = "Rozciagniecie";
            // 
            // wyrownanieToolStripMenuItem
            // 
            this.wyrownanieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.metodaSrednichToolStripMenuItem,
            this.metodaLosowaToolStripMenuItem,
            this.metodaSasiedztwaToolStripMenuItem,
            this.metodaWlasnaToolStripMenuItem});
            this.wyrownanieToolStripMenuItem.Name = "wyrownanieToolStripMenuItem";
            this.wyrownanieToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.wyrownanieToolStripMenuItem.Text = "Wyrownanie";
            // 
            // metodaSrednichToolStripMenuItem
            // 
            this.metodaSrednichToolStripMenuItem.Name = "metodaSrednichToolStripMenuItem";
            this.metodaSrednichToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.metodaSrednichToolStripMenuItem.Text = "Metoda srednich";
            // 
            // metodaLosowaToolStripMenuItem
            // 
            this.metodaLosowaToolStripMenuItem.Name = "metodaLosowaToolStripMenuItem";
            this.metodaLosowaToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.metodaLosowaToolStripMenuItem.Text = "Metoda losowa";
            // 
            // metodaSasiedztwaToolStripMenuItem
            // 
            this.metodaSasiedztwaToolStripMenuItem.Name = "metodaSasiedztwaToolStripMenuItem";
            this.metodaSasiedztwaToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.metodaSasiedztwaToolStripMenuItem.Text = "Metoda sasiedztwa";
            // 
            // metodaWlasnaToolStripMenuItem
            // 
            this.metodaWlasnaToolStripMenuItem.Name = "metodaWlasnaToolStripMenuItem";
            this.metodaWlasnaToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.metodaWlasnaToolStripMenuItem.Text = "Metoda wlasna";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Multiselect = false;
            this.openFileDialog.Filter = "Image files|*.jpg;*.jpeg;*.gif;*.png;*.bmp;*.tiff";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.onOpenFile);
            // 
            // Main
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1213, 702);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "APO";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszJakoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cofnijToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem laboratorium1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wyrownanieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metodaSrednichToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metodaLosowaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metodaSasiedztwaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metodaWlasnaToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

