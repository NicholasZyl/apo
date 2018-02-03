using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APO
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void onOpenFileClick(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Cursor = Cursors.WaitCursor;
                foreach (string filename in openFileDialog.FileNames)
                {
                    openImage(filename);
                }
                Cursor = Cursors.Default;
            }
        }

        private void onOpenFile(object sender, CancelEventArgs e)
        {
        }

        private void openImage(string file)
        {
            ImageForm form = new ImageForm(file);
            form.MdiParent = this;
            onImageOpen();
            form.Show();
        }

        public void onImageClosed()
        {
            // Disable only if it's last image form that was just closed
            if (MdiChildren.Count() == 1)
            {
                actionsMenu.Enabled = false;
                saveAsMenuItem.Enabled = false;
            }
        }

        private void onImageOpen()
        {
            actionsMenu.Enabled = true;
            saveAsMenuItem.Enabled = true;
        }

        private void onSaveAsClick(object sender, EventArgs e)
        {
            ImageForm form = (ImageForm)ActiveMdiChild;
            if (form == null)
            {
                return;
            }
            try
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Bitmap image = form.currentImage.BaseBitmap;
                    image.Save(saveFileDialog.FileName);
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Error while saving file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void onResetClick(object sender, EventArgs e)
        {
            ImageForm form = (ImageForm)ActiveMdiChild;
            form.resetImage();
        }

        private void onHistogramStretchClick(object sender, EventArgs e)
        {
            performOperation(new StretchHistogramOperation());
        }

        private void onHistogramMeanEqualizationClick(object sender, EventArgs e)
        {
            performOperation(new EqualizeHistogramOperation(EqualizeHistogramOperation.EqualizationMethod.Mean));
        }

        private void onHistogramRandomEqualizationClick(object sender, EventArgs e)
        {
            performOperation(new EqualizeHistogramOperation(EqualizeHistogramOperation.EqualizationMethod.Random));
        }

        private void onHistogramNeighboursEqualizationClick(object sender, EventArgs e)
        {
            performOperation(new EqualizeHistogramOperation(EqualizeHistogramOperation.EqualizationMethod.Neighbours));
        }

        private void onHistogramCustomEqualizationClick(object sender, EventArgs e)
        {
            performOperation(new EqualizeHistogramOperation(EqualizeHistogramOperation.EqualizationMethod.Custom));
        }

        private void onNegationClick(object sender, EventArgs e)
        {
            performOperation(new Negation());
        }

        private void onBinarizationClick(object sender, EventArgs e)
        {
            ImageForm form = (ImageForm)ActiveMdiChild;

            ComparisonDialog comparison = new ComparisonDialog(form.currentImage, new Binarization(256)); // TODO: dynamically count image levels
            if (comparison.ShowDialog() == DialogResult.OK)
            {
                form.setImage(comparison.finalImage);
            }
        }

        private void onThresholdingClick(object sender, EventArgs e)
        {
            ImageForm form = (ImageForm)ActiveMdiChild;

            ComparisonDialog comparison = new ComparisonDialog(form.currentImage, new Thresholding(256)); // TODO: dynamically count image levels
            if (comparison.ShowDialog() == DialogResult.OK)
            {
                form.setImage(comparison.finalImage);
            }
        }

        private void onReductionClick(object sender, EventArgs e)
        {
            ImageForm form = (ImageForm)ActiveMdiChild;

            ComparisonDialog comparison = new ComparisonDialog(form.currentImage, new Reduction(256)); // TODO: dynamically count image levels
            if (comparison.ShowDialog() == DialogResult.OK)
            {
                form.setImage(comparison.finalImage);
            }
        }

        private void onUniversalPointOperatorClick(object sender, EventArgs e)
        {
            UniversalPointOperatorDialog upoDialog = new UniversalPointOperatorDialog();
            if (upoDialog.ShowDialog() == DialogResult.OK)
            {
                performOperation(new UniversalPointOperator(upoDialog.Lut));
            }
        }

        private void onAddImageClick(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Cursor = Cursors.WaitCursor;
                foreach (string filename in openFileDialog.FileNames)
                {
                    ImageForm form = (ImageForm)ActiveMdiChild;
                    Operation add = new Add(form.currentImage);
                    form.setImage(add.perform(new FastBitmap(filename)));
                }
                Cursor = Cursors.Default;
            }
        }

        private void onSubImageClick(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Cursor = Cursors.WaitCursor;
                foreach (string filename in openFileDialog.FileNames)
                {
                    ImageForm form = (ImageForm)ActiveMdiChild;
                    Operation sub = new Sub(form.currentImage);
                    form.setImage(sub.perform(new FastBitmap(filename)));
                }
                Cursor = Cursors.Default;
            }
        }

        private void onDiffImageClick(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Cursor = Cursors.WaitCursor;
                foreach (string filename in openFileDialog.FileNames)
                {
                    ImageForm form = (ImageForm)ActiveMdiChild;
                    Operation diff = new Diff(form.currentImage);
                    form.setImage(diff.perform(new FastBitmap(filename)));
                }
                Cursor = Cursors.Default;
            }
        }

        private void onAndImageClick(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Cursor = Cursors.WaitCursor;
                foreach (string filename in openFileDialog.FileNames)
                {
                    ImageForm form = (ImageForm)ActiveMdiChild;
                    Operation and = new And(form.currentImage);
                    form.setImage(and.perform(new FastBitmap(filename)));
                }
                Cursor = Cursors.Default;
            }
        }

        private void onOrImageClick(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Cursor = Cursors.WaitCursor;
                foreach (string filename in openFileDialog.FileNames)
                {
                    ImageForm form = (ImageForm)ActiveMdiChild;
                    Operation or = new Or(form.currentImage);
                    form.setImage(or.perform(new FastBitmap(filename)));
                }
                Cursor = Cursors.Default;
            }
        }

        private void onXorImageClick(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Cursor = Cursors.WaitCursor;
                foreach (string filename in openFileDialog.FileNames)
                {
                    ImageForm form = (ImageForm)ActiveMdiChild;
                    Operation xor = new Xor(form.currentImage);
                    form.setImage(xor.perform(new FastBitmap(filename)));
                }
                Cursor = Cursors.Default;
            }
        }

        private void linearFilteringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NeighbourhoodOperationsDialog neighbourhoodOperationsDialog = new NeighbourhoodOperationsDialog();
            if (neighbourhoodOperationsDialog.ShowDialog() == DialogResult.OK)
            {
                performOperation(
                    new FilteringOperation(
                        neighbourhoodOperationsDialog.Mask,
                        neighbourhoodOperationsDialog.UsedOperation,
                        neighbourhoodOperationsDialog.EdgeProcessing,
                        neighbourhoodOperationsDialog.UsedScaling,
                        0
                    )
                );
            }
        }

        private void performOperation(Operation operation)
        {
            ImageForm form = (ImageForm)ActiveMdiChild;
            Cursor = Cursors.WaitCursor;
            form.setImage(operation.perform(form.currentImage));
            Cursor = Cursors.Default;
        }

        private void medianFilteringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MedianFilteringDialog operationDialog = new MedianFilteringDialog();
            if (operationDialog.ShowDialog() == DialogResult.OK)
            {
                performOperation(
                    new MedianFilteringOperation(
                        operationDialog.SizeX,
                        operationDialog.SizeY,
                        operationDialog.EdgeProcessing
                    )
                );
            }
        }

        private void dualMaskFilteringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DualMaskFilteringDialog operationDialog = new DualMaskFilteringDialog();
            if (operationDialog.ShowDialog() == DialogResult.OK)
            {
                performOperation(
                    new FilteringOperation(
                        operationDialog.Mask,
                        FilteringOperation.OperationType.LowPassFilter,
                        operationDialog.EdgeProcessing,
                        operationDialog.UsedScaling,
                        operationDialog.Divisor
                    )
                );
            }
        }

        private void thinningToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThinningDialog operationDialog = new ThinningDialog();
            if (operationDialog.ShowDialog() == DialogResult.OK)
            {
                performOperation(
                    new ThinningOperation(
                        operationDialog.EdgeProcessing
                    )
                );
            }
        }

        private void logicFilteringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogicFilteringDialog operationDialog = new LogicFilteringDialog();
            if (operationDialog.ShowDialog() == DialogResult.OK)
            {
                performOperation(
                    new LogicFilteringOperation(
                        operationDialog.Direction,
                        operationDialog.EdgeProcessing
                    )
                );
            }
        }

        private void gradientFilteringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GradientDialog operationDialog = new GradientDialog();
            if (operationDialog.ShowDialog() == DialogResult.OK)
            {
                performOperation(
                    new GradientOperation(
                        operationDialog.MaskOne,
                        operationDialog.MaskTwo,
                        operationDialog.EdgeProcessing,
                        operationDialog.UsedScaling
                    )
                );
            }
        }

        private void morphologicalOperationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MorphologicalDialog operationDialog = new MorphologicalDialog();
            if (operationDialog.ShowDialog() == DialogResult.OK)
            {
                performOperation(
                    new MorphologicalOperation(
                        operationDialog.DesiredOperator,
                        operationDialog.Structuring,
                        operationDialog.EdgeProcessing
                    )
                );
            }
        }

        private void thresholdingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DuplexBinarizationDialog operationDialog = new DuplexBinarizationDialog();
            if (operationDialog.ShowDialog() == DialogResult.OK)
            {
                performOperation(
                    new DuplexBinarizationOperation(
                        operationDialog.lowerBound,
                        operationDialog.upperBound
                    )
                );
            }
        }

        private void onSteganographyHideClick(object sender, EventArgs e)
        {
            ImageForm form = (ImageForm)ActiveMdiChild;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try {
                    Bitmap imageToHide = (Bitmap)Image.FromFile(openFileDialog.FileName);
                    SteganographyHideDialog dialog = new SteganographyHideDialog(form.currentImage, imageToHide);
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        performOperation(new SteganographyHideOperation(imageToHide, dialog.BitsNumber));
                    }
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void onSteganographyRevealClick(object sender, EventArgs e)
        {
            try
            {
                SteganographyRevealDialog dialog = new SteganographyRevealDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ImageForm form = (ImageForm)ActiveMdiChild;
                    Cursor = Cursors.WaitCursor;
                    Operation operation = new SteganographyRevealOperation(dialog.UsedBits, dialog.HiddenImageWidth, dialog.HiddenImageHeight);
                    ImageForm revealedImageForm = new ImageForm(operation.perform(form.currentImage));
                    revealedImageForm.MdiParent = this;
                    revealedImageForm.Show();
                    Cursor = Cursors.Default;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cursor = Cursors.Default;
            }
        }
    }
}
