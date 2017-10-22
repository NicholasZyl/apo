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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.resetMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionsMenuSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.histogramSubMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramStretchingMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramEqualizationSubMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramMeanEqualizationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramRandomEqualizationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramNeighboursEqualizationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramCusstomEqualizationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pointOperationsSubMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.negationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.actionsMenu});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menuStrip1";
            this.menu.Size = new System.Drawing.Size(1213, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            this.menu.UseWaitCursor = true;
            // 
            // toolStripMenuItem1
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openMenuItem});
            this.fileMenu.Name = "toolStripMenuItem1";
            this.fileMenu.Size = new System.Drawing.Size(38, 20);
            this.fileMenu.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openMenuItem.Name = "openToolStripMenuItem";
            this.openMenuItem.Size = new System.Drawing.Size(132, 22);
            this.openMenuItem.Text = "Open";
            this.openMenuItem.Click += new System.EventHandler(this.onOpenFileClick);
            // 
            // operacjeToolStripMenuItem
            // 
            this.actionsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetMenuItem,
            this.actionsMenuSeparator,
            this.histogramSubMenu,
            this.pointOperationsSubMenu});
            this.actionsMenu.Enabled = false;
            this.actionsMenu.Name = "operacjeToolStripMenuItem";
            this.actionsMenu.Size = new System.Drawing.Size(66, 20);
            this.actionsMenu.Text = "Actions";
            // 
            // cofnijToolStripMenuItem
            // 
            this.resetMenuItem.Name = "cofnijToolStripMenuItem";
            this.resetMenuItem.Size = new System.Drawing.Size(177, 22);
            this.resetMenuItem.Text = "Reset";
            this.resetMenuItem.Click += new System.EventHandler(this.onResetClick);
            // 
            // toolStripSeparator1
            // 
            this.actionsMenuSeparator.Name = "toolStripSeparator1";
            this.actionsMenuSeparator.Size = new System.Drawing.Size(174, 6);
            // 
            // laboratorium1ToolStripMenuItem
            // 
            this.histogramSubMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.histogramStretchingMenuItem,
            this.histogramEqualizationSubMenu});
            this.histogramSubMenu.Name = "laboratorium1ToolStripMenuItem";
            this.histogramSubMenu.Size = new System.Drawing.Size(177, 22);
            this.histogramSubMenu.Text = "Histogram";
            // 
            // histogramToolStripMenuItem
            // 
            this.histogramStretchingMenuItem.Name = "histogramToolStripMenuItem";
            this.histogramStretchingMenuItem.Size = new System.Drawing.Size(146, 22);
            this.histogramStretchingMenuItem.Text = "Stretch";
            this.histogramStretchingMenuItem.Click += new System.EventHandler(this.onHistogramStretchClick);
            // 
            // wyrownanieToolStripMenuItem
            // 
            this.histogramEqualizationSubMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.histogramMeanEqualizationMenuItem,
            this.histogramRandomEqualizationMenuItem,
            this.histogramNeighboursEqualizationMenuItem,
            this.histogramCusstomEqualizationMenuItem});
            this.histogramEqualizationSubMenu.Name = "wyrownanieToolStripMenuItem";
            this.histogramEqualizationSubMenu.Size = new System.Drawing.Size(146, 22);
            this.histogramEqualizationSubMenu.Text = "Equalization";
            // 
            // metodaSrednichToolStripMenuItem
            // 
            this.histogramMeanEqualizationMenuItem.Name = "metodaSrednichToolStripMenuItem";
            this.histogramMeanEqualizationMenuItem.Size = new System.Drawing.Size(174, 22);
            this.histogramMeanEqualizationMenuItem.Text = "Mean method";
            this.histogramMeanEqualizationMenuItem.Click += new System.EventHandler(this.onHistogramMeanEqualizationClick);
            // 
            // metodaLosowaToolStripMenuItem
            // 
            this.histogramRandomEqualizationMenuItem.Name = "metodaLosowaToolStripMenuItem";
            this.histogramRandomEqualizationMenuItem.Size = new System.Drawing.Size(174, 22);
            this.histogramRandomEqualizationMenuItem.Text = "Random method";
            this.histogramRandomEqualizationMenuItem.Click += new System.EventHandler(this.onHistogramRandomEqualizationClick);
            // 
            // metodaSasiedztwaToolStripMenuItem
            // 
            this.histogramNeighboursEqualizationMenuItem.Name = "metodaSasiedztwaToolStripMenuItem";
            this.histogramNeighboursEqualizationMenuItem.Size = new System.Drawing.Size(174, 22);
            this.histogramNeighboursEqualizationMenuItem.Text = "Neighbours method";
            this.histogramNeighboursEqualizationMenuItem.Click += new System.EventHandler(this.onHistogramNeighboursEqualizationClick);
            // 
            // metodaWlasnaToolStripMenuItem
            // 
            this.histogramCusstomEqualizationMenuItem.Name = "metodaWlasnaToolStripMenuItem";
            this.histogramCusstomEqualizationMenuItem.Size = new System.Drawing.Size(174, 22);
            this.histogramCusstomEqualizationMenuItem.Text = "Custom method";
            this.histogramCusstomEqualizationMenuItem.Click += new System.EventHandler(this.onHistogramCustomEqualizationClick);
            // 
            // operacjaToolStripMenuItem
            // 
            this.pointOperationsSubMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.negationMenuItem});
            this.pointOperationsSubMenu.Name = "operacjaToolStripMenuItem";
            this.pointOperationsSubMenu.Size = new System.Drawing.Size(177, 22);
            this.pointOperationsSubMenu.Text = "Point operations";
            // 
            // negacjaToolStripMenuItem
            // 
            this.negationMenuItem.Name = "negacjaToolStripMenuItem";
            this.negationMenuItem.Size = new System.Drawing.Size(152, 22);
            this.negationMenuItem.Text = "Negation";
            this.negationMenuItem.Click += new System.EventHandler(this.onNegationClick);
            // 
            // openFileDialog
            // 
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
            this.Controls.Add(this.menu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menu;
            this.Name = "Main";
            this.Text = "APO";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Main_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem openMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionsMenu;
        private System.Windows.Forms.ToolStripMenuItem resetMenuItem;
        private System.Windows.Forms.ToolStripSeparator actionsMenuSeparator;
        private System.Windows.Forms.ToolStripMenuItem histogramSubMenu;
        private System.Windows.Forms.ToolStripMenuItem histogramStretchingMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramEqualizationSubMenu;
        private System.Windows.Forms.ToolStripMenuItem histogramMeanEqualizationMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramRandomEqualizationMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramNeighboursEqualizationMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramCusstomEqualizationMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripMenuItem pointOperationsSubMenu;
        private System.Windows.Forms.ToolStripMenuItem negationMenuItem;
    }
}

