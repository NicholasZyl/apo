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
            }
        }

        private void onImageOpen()
        {
            actionsMenu.Enabled = true;
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
                    Bitmap image = (Bitmap)Image.FromFile(filename);
                    form.setImage(add.perform(image));
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
                    Bitmap image = (Bitmap)Image.FromFile(filename);
                    form.setImage(sub.perform(image));
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
                    Bitmap image = (Bitmap)Image.FromFile(filename);
                    form.setImage(diff.perform(image));
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
                    Bitmap image = (Bitmap)Image.FromFile(filename);
                    form.setImage(and.perform(image));
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
                    Bitmap image = (Bitmap)Image.FromFile(filename);
                    form.setImage(or.perform(image));
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
                    Bitmap image = (Bitmap)Image.FromFile(filename);
                    form.setImage(xor.perform(image));
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
    }
}
