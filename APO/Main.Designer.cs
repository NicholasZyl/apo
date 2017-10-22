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
            this.binarizationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.actionsMenu});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1213, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            this.menu.UseWaitCursor = true;
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openMenuItem});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "File";
            // 
            // openMenuItem
            // 
            this.openMenuItem.Name = "openMenuItem";
            this.openMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openMenuItem.Text = "Open";
            this.openMenuItem.Click += new System.EventHandler(this.onOpenFileClick);
            // 
            // actionsMenu
            // 
            this.actionsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetMenuItem,
            this.actionsMenuSeparator,
            this.histogramSubMenu,
            this.pointOperationsSubMenu});
            this.actionsMenu.Enabled = false;
            this.actionsMenu.Name = "actionsMenu";
            this.actionsMenu.Size = new System.Drawing.Size(59, 20);
            this.actionsMenu.Text = "Actions";
            // 
            // resetMenuItem
            // 
            this.resetMenuItem.Name = "resetMenuItem";
            this.resetMenuItem.Size = new System.Drawing.Size(161, 22);
            this.resetMenuItem.Text = "Reset";
            this.resetMenuItem.Click += new System.EventHandler(this.onResetClick);
            // 
            // actionsMenuSeparator
            // 
            this.actionsMenuSeparator.Name = "actionsMenuSeparator";
            this.actionsMenuSeparator.Size = new System.Drawing.Size(158, 6);
            // 
            // histogramSubMenu
            // 
            this.histogramSubMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.histogramStretchingMenuItem,
            this.histogramEqualizationSubMenu});
            this.histogramSubMenu.Name = "histogramSubMenu";
            this.histogramSubMenu.Size = new System.Drawing.Size(161, 22);
            this.histogramSubMenu.Text = "Histogram";
            // 
            // histogramStretchingMenuItem
            // 
            this.histogramStretchingMenuItem.Name = "histogramStretchingMenuItem";
            this.histogramStretchingMenuItem.Size = new System.Drawing.Size(138, 22);
            this.histogramStretchingMenuItem.Text = "Stretch";
            this.histogramStretchingMenuItem.Click += new System.EventHandler(this.onHistogramStretchClick);
            // 
            // histogramEqualizationSubMenu
            // 
            this.histogramEqualizationSubMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.histogramMeanEqualizationMenuItem,
            this.histogramRandomEqualizationMenuItem,
            this.histogramNeighboursEqualizationMenuItem,
            this.histogramCusstomEqualizationMenuItem});
            this.histogramEqualizationSubMenu.Name = "histogramEqualizationSubMenu";
            this.histogramEqualizationSubMenu.Size = new System.Drawing.Size(138, 22);
            this.histogramEqualizationSubMenu.Text = "Equalization";
            // 
            // histogramMeanEqualizationMenuItem
            // 
            this.histogramMeanEqualizationMenuItem.Name = "histogramMeanEqualizationMenuItem";
            this.histogramMeanEqualizationMenuItem.Size = new System.Drawing.Size(181, 22);
            this.histogramMeanEqualizationMenuItem.Text = "Mean method";
            this.histogramMeanEqualizationMenuItem.Click += new System.EventHandler(this.onHistogramMeanEqualizationClick);
            // 
            // histogramRandomEqualizationMenuItem
            // 
            this.histogramRandomEqualizationMenuItem.Name = "histogramRandomEqualizationMenuItem";
            this.histogramRandomEqualizationMenuItem.Size = new System.Drawing.Size(181, 22);
            this.histogramRandomEqualizationMenuItem.Text = "Random method";
            this.histogramRandomEqualizationMenuItem.Click += new System.EventHandler(this.onHistogramRandomEqualizationClick);
            // 
            // histogramNeighboursEqualizationMenuItem
            // 
            this.histogramNeighboursEqualizationMenuItem.Name = "histogramNeighboursEqualizationMenuItem";
            this.histogramNeighboursEqualizationMenuItem.Size = new System.Drawing.Size(181, 22);
            this.histogramNeighboursEqualizationMenuItem.Text = "Neighbours method";
            this.histogramNeighboursEqualizationMenuItem.Click += new System.EventHandler(this.onHistogramNeighboursEqualizationClick);
            // 
            // histogramCusstomEqualizationMenuItem
            // 
            this.histogramCusstomEqualizationMenuItem.Name = "histogramCusstomEqualizationMenuItem";
            this.histogramCusstomEqualizationMenuItem.Size = new System.Drawing.Size(181, 22);
            this.histogramCusstomEqualizationMenuItem.Text = "Custom method";
            this.histogramCusstomEqualizationMenuItem.Click += new System.EventHandler(this.onHistogramCustomEqualizationClick);
            // 
            // pointOperationsSubMenu
            // 
            this.pointOperationsSubMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.negationMenuItem,
            this.binarizationToolStripMenuItem});
            this.pointOperationsSubMenu.Name = "pointOperationsSubMenu";
            this.pointOperationsSubMenu.Size = new System.Drawing.Size(161, 22);
            this.pointOperationsSubMenu.Text = "Point operations";
            // 
            // negationMenuItem
            // 
            this.negationMenuItem.Name = "negationMenuItem";
            this.negationMenuItem.Size = new System.Drawing.Size(152, 22);
            this.negationMenuItem.Text = "Negation";
            this.negationMenuItem.Click += new System.EventHandler(this.onNegationClick);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Image files|*.jpg;*.jpeg;*.gif;*.png;*.bmp;*.tiff";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.onOpenFile);
            // 
            // binarizationToolStripMenuItem
            // 
            this.binarizationToolStripMenuItem.Name = "binarizationToolStripMenuItem";
            this.binarizationToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.binarizationToolStripMenuItem.Text = "Binarization";
            this.binarizationToolStripMenuItem.Click += new System.EventHandler(this.onBinarizationClick);
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
        private System.Windows.Forms.ToolStripMenuItem binarizationToolStripMenuItem;
    }
}

