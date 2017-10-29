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
            this.thresholdingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binarizationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reductionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.universalPointOperatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.addImagesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diffImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.andImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xorImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.neighbourhoodOperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.pointOperationsSubMenu,
            this.neighbourhoodOperationsToolStripMenuItem});
            this.actionsMenu.Enabled = false;
            this.actionsMenu.Name = "actionsMenu";
            this.actionsMenu.Size = new System.Drawing.Size(59, 20);
            this.actionsMenu.Text = "Actions";
            // 
            // resetMenuItem
            // 
            this.resetMenuItem.Name = "resetMenuItem";
            this.resetMenuItem.Size = new System.Drawing.Size(218, 22);
            this.resetMenuItem.Text = "Reset";
            this.resetMenuItem.Click += new System.EventHandler(this.onResetClick);
            // 
            // actionsMenuSeparator
            // 
            this.actionsMenuSeparator.Name = "actionsMenuSeparator";
            this.actionsMenuSeparator.Size = new System.Drawing.Size(215, 6);
            // 
            // histogramSubMenu
            // 
            this.histogramSubMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.histogramStretchingMenuItem,
            this.histogramEqualizationSubMenu});
            this.histogramSubMenu.Name = "histogramSubMenu";
            this.histogramSubMenu.Size = new System.Drawing.Size(218, 22);
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
            this.thresholdingToolStripMenuItem,
            this.binarizationToolStripMenuItem,
            this.reductionToolStripMenuItem,
            this.toolStripSeparator2,
            this.universalPointOperatorToolStripMenuItem,
            this.toolStripSeparator1,
            this.addImagesMenuItem,
            this.subImageToolStripMenuItem,
            this.diffImageToolStripMenuItem,
            this.andImageToolStripMenuItem,
            this.orImageToolStripMenuItem,
            this.xorImageToolStripMenuItem});
            this.pointOperationsSubMenu.Name = "pointOperationsSubMenu";
            this.pointOperationsSubMenu.Size = new System.Drawing.Size(218, 22);
            this.pointOperationsSubMenu.Text = "Point operations";
            // 
            // negationMenuItem
            // 
            this.negationMenuItem.Name = "negationMenuItem";
            this.negationMenuItem.Size = new System.Drawing.Size(203, 22);
            this.negationMenuItem.Text = "Negation";
            this.negationMenuItem.Click += new System.EventHandler(this.onNegationClick);
            // 
            // thresholdingToolStripMenuItem
            // 
            this.thresholdingToolStripMenuItem.Name = "thresholdingToolStripMenuItem";
            this.thresholdingToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.thresholdingToolStripMenuItem.Text = "Thresholding";
            this.thresholdingToolStripMenuItem.Click += new System.EventHandler(this.onThresholdingClick);
            // 
            // binarizationToolStripMenuItem
            // 
            this.binarizationToolStripMenuItem.Name = "binarizationToolStripMenuItem";
            this.binarizationToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.binarizationToolStripMenuItem.Text = "Binarization";
            this.binarizationToolStripMenuItem.Click += new System.EventHandler(this.onBinarizationClick);
            // 
            // reductionToolStripMenuItem
            // 
            this.reductionToolStripMenuItem.Name = "reductionToolStripMenuItem";
            this.reductionToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.reductionToolStripMenuItem.Text = "Reduction";
            this.reductionToolStripMenuItem.Click += new System.EventHandler(this.onReductionClick);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(200, 6);
            // 
            // universalPointOperatorToolStripMenuItem
            // 
            this.universalPointOperatorToolStripMenuItem.Name = "universalPointOperatorToolStripMenuItem";
            this.universalPointOperatorToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.universalPointOperatorToolStripMenuItem.Text = "Universal Point Operator";
            this.universalPointOperatorToolStripMenuItem.Click += new System.EventHandler(this.onUniversalPointOperatorClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(200, 6);
            // 
            // addImagesMenuItem
            // 
            this.addImagesMenuItem.Name = "addImagesMenuItem";
            this.addImagesMenuItem.Size = new System.Drawing.Size(203, 22);
            this.addImagesMenuItem.Text = "Add image";
            this.addImagesMenuItem.Click += new System.EventHandler(this.onAddImageClick);
            // 
            // subImageToolStripMenuItem
            // 
            this.subImageToolStripMenuItem.Name = "subImageToolStripMenuItem";
            this.subImageToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.subImageToolStripMenuItem.Text = "Sub image";
            this.subImageToolStripMenuItem.Click += new System.EventHandler(this.onSubImageClick);
            // 
            // diffImageToolStripMenuItem
            // 
            this.diffImageToolStripMenuItem.Name = "diffImageToolStripMenuItem";
            this.diffImageToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.diffImageToolStripMenuItem.Text = "Diff image";
            this.diffImageToolStripMenuItem.Click += new System.EventHandler(this.onDiffImageClick);
            // 
            // andImageToolStripMenuItem
            // 
            this.andImageToolStripMenuItem.Name = "andImageToolStripMenuItem";
            this.andImageToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.andImageToolStripMenuItem.Text = "And image";
            this.andImageToolStripMenuItem.Click += new System.EventHandler(this.onAndImageClick);
            // 
            // orImageToolStripMenuItem
            // 
            this.orImageToolStripMenuItem.Name = "orImageToolStripMenuItem";
            this.orImageToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.orImageToolStripMenuItem.Text = "Or image";
            this.orImageToolStripMenuItem.Click += new System.EventHandler(this.onOrImageClick);
            // 
            // xorImageToolStripMenuItem
            // 
            this.xorImageToolStripMenuItem.Name = "xorImageToolStripMenuItem";
            this.xorImageToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.xorImageToolStripMenuItem.Text = "Xor image";
            this.xorImageToolStripMenuItem.Click += new System.EventHandler(this.onXorImageClick);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Image files|*.jpg;*.jpeg;*.gif;*.png;*.bmp;*.tiff";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.onOpenFile);
            // 
            // neighbourhoodOperationsToolStripMenuItem
            // 
            this.neighbourhoodOperationsToolStripMenuItem.Name = "neighbourhoodOperationsToolStripMenuItem";
            this.neighbourhoodOperationsToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.neighbourhoodOperationsToolStripMenuItem.Text = "Neighbourhood operations";
            this.neighbourhoodOperationsToolStripMenuItem.Click += new System.EventHandler(this.neighbourhoodOperationsToolStripMenuItem_Click);
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
        private System.Windows.Forms.ToolStripMenuItem thresholdingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reductionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem universalPointOperatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem addImagesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diffImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem andImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xorImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neighbourhoodOperationsToolStripMenuItem;
    }
}

