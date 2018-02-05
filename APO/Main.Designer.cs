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
            this.duplicateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.neighbourhoodOperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linearFilteringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medianFilteringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logicFilteringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gradientFilteringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dualMaskFilteringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.morphologicalOperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thinningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.segmentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thresholdingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.steganographyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SteganographyHideMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SteganographyRevealMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.actionsMenu,
            this.aboutMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1213, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openMenuItem,
            this.duplicateMenuItem,
            this.saveAsMenuItem});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "File";
            // 
            // openMenuItem
            // 
            this.openMenuItem.Name = "openMenuItem";
            this.openMenuItem.Size = new System.Drawing.Size(124, 22);
            this.openMenuItem.Text = "Open";
            this.openMenuItem.Click += new System.EventHandler(this.onOpenFileClick);
            // 
            // duplicateMenuItem
            // 
            this.duplicateMenuItem.Enabled = false;
            this.duplicateMenuItem.Name = "duplicateMenuItem";
            this.duplicateMenuItem.Size = new System.Drawing.Size(124, 22);
            this.duplicateMenuItem.Text = "Duplicate";
            this.duplicateMenuItem.Click += new System.EventHandler(this.onDulicateClick);
            // 
            // saveAsMenuItem
            // 
            this.saveAsMenuItem.Enabled = false;
            this.saveAsMenuItem.Name = "saveAsMenuItem";
            this.saveAsMenuItem.Size = new System.Drawing.Size(124, 22);
            this.saveAsMenuItem.Text = "Save as...";
            this.saveAsMenuItem.Click += new System.EventHandler(this.onSaveAsClick);
            // 
            // actionsMenu
            // 
            this.actionsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetMenuItem,
            this.actionsMenuSeparator,
            this.histogramSubMenu,
            this.pointOperationsSubMenu,
            this.neighbourhoodOperationsToolStripMenuItem,
            this.morphologicalOperationsToolStripMenuItem,
            this.thinningToolStripMenuItem,
            this.segmentationToolStripMenuItem,
            this.steganographyToolStripMenuItem});
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
            // neighbourhoodOperationsToolStripMenuItem
            // 
            this.neighbourhoodOperationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.linearFilteringToolStripMenuItem,
            this.medianFilteringToolStripMenuItem,
            this.logicFilteringToolStripMenuItem,
            this.gradientFilteringToolStripMenuItem,
            this.dualMaskFilteringToolStripMenuItem});
            this.neighbourhoodOperationsToolStripMenuItem.Name = "neighbourhoodOperationsToolStripMenuItem";
            this.neighbourhoodOperationsToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.neighbourhoodOperationsToolStripMenuItem.Text = "Neighbourhood operations";
            // 
            // linearFilteringToolStripMenuItem
            // 
            this.linearFilteringToolStripMenuItem.Name = "linearFilteringToolStripMenuItem";
            this.linearFilteringToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.linearFilteringToolStripMenuItem.Text = "Linear filtering";
            this.linearFilteringToolStripMenuItem.Click += new System.EventHandler(this.linearFilteringToolStripMenuItem_Click);
            // 
            // medianFilteringToolStripMenuItem
            // 
            this.medianFilteringToolStripMenuItem.Name = "medianFilteringToolStripMenuItem";
            this.medianFilteringToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.medianFilteringToolStripMenuItem.Text = "Median filtering";
            this.medianFilteringToolStripMenuItem.Click += new System.EventHandler(this.medianFilteringToolStripMenuItem_Click);
            // 
            // logicFilteringToolStripMenuItem
            // 
            this.logicFilteringToolStripMenuItem.Name = "logicFilteringToolStripMenuItem";
            this.logicFilteringToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.logicFilteringToolStripMenuItem.Text = "Logic filtering";
            this.logicFilteringToolStripMenuItem.Click += new System.EventHandler(this.logicFilteringToolStripMenuItem_Click);
            // 
            // gradientFilteringToolStripMenuItem
            // 
            this.gradientFilteringToolStripMenuItem.Name = "gradientFilteringToolStripMenuItem";
            this.gradientFilteringToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.gradientFilteringToolStripMenuItem.Text = "Gradient filtering";
            this.gradientFilteringToolStripMenuItem.Click += new System.EventHandler(this.gradientFilteringToolStripMenuItem_Click);
            // 
            // dualMaskFilteringToolStripMenuItem
            // 
            this.dualMaskFilteringToolStripMenuItem.Name = "dualMaskFilteringToolStripMenuItem";
            this.dualMaskFilteringToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.dualMaskFilteringToolStripMenuItem.Text = "Dual mask filtering";
            this.dualMaskFilteringToolStripMenuItem.Click += new System.EventHandler(this.dualMaskFilteringToolStripMenuItem_Click);
            // 
            // morphologicalOperationsToolStripMenuItem
            // 
            this.morphologicalOperationsToolStripMenuItem.Name = "morphologicalOperationsToolStripMenuItem";
            this.morphologicalOperationsToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.morphologicalOperationsToolStripMenuItem.Text = "Morphological operations";
            this.morphologicalOperationsToolStripMenuItem.Click += new System.EventHandler(this.morphologicalOperationsToolStripMenuItem_Click);
            // 
            // thinningToolStripMenuItem
            // 
            this.thinningToolStripMenuItem.Name = "thinningToolStripMenuItem";
            this.thinningToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.thinningToolStripMenuItem.Text = "Thinning";
            this.thinningToolStripMenuItem.Click += new System.EventHandler(this.thinningToolStripMenuItem_Click);
            // 
            // segmentationToolStripMenuItem
            // 
            this.segmentationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thresholdingToolStripMenuItem1});
            this.segmentationToolStripMenuItem.Name = "segmentationToolStripMenuItem";
            this.segmentationToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.segmentationToolStripMenuItem.Text = "Segmentation";
            // 
            // thresholdingToolStripMenuItem1
            // 
            this.thresholdingToolStripMenuItem1.Name = "thresholdingToolStripMenuItem1";
            this.thresholdingToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.thresholdingToolStripMenuItem1.Text = "Thresholding";
            this.thresholdingToolStripMenuItem1.Click += new System.EventHandler(this.thresholdingToolStripMenuItem1_Click);
            // 
            // steganographyToolStripMenuItem
            // 
            this.steganographyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SteganographyHideMenuItem,
            this.SteganographyRevealMenuItem});
            this.steganographyToolStripMenuItem.Name = "steganographyToolStripMenuItem";
            this.steganographyToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.steganographyToolStripMenuItem.Text = "Steganography";
            // 
            // SteganographyHideMenuItem
            // 
            this.SteganographyHideMenuItem.Name = "SteganographyHideMenuItem";
            this.SteganographyHideMenuItem.Size = new System.Drawing.Size(108, 22);
            this.SteganographyHideMenuItem.Text = "Hide";
            this.SteganographyHideMenuItem.Click += new System.EventHandler(this.onSteganographyHideClick);
            // 
            // SteganographyRevealMenuItem
            // 
            this.SteganographyRevealMenuItem.Name = "SteganographyRevealMenuItem";
            this.SteganographyRevealMenuItem.Size = new System.Drawing.Size(108, 22);
            this.SteganographyRevealMenuItem.Text = "Reveal";
            this.SteganographyRevealMenuItem.Click += new System.EventHandler(this.onSteganographyRevealClick);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Image files|*.jpg;*.jpeg;*.gif;*.png;*.bmp;*.tiff";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.onOpenFile);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Image files|*.jpg;*.jpeg;*.gif;*.png;*.bmp;*.tiff";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutMenuItem.Text = "About";
            this.aboutMenuItem.Click += new System.EventHandler(this.onAboutClick);
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
            this.Load += new System.EventHandler(this.Main_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;

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
        private System.Windows.Forms.ToolStripMenuItem medianFilteringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dualMaskFilteringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thinningToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logicFilteringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gradientFilteringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linearFilteringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem morphologicalOperationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem segmentationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thresholdingToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveAsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem steganographyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SteganographyHideMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SteganographyRevealMenuItem;
        private System.Windows.Forms.ToolStripMenuItem duplicateMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
    }
}

