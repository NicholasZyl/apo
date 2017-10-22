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
        private Operations operations = new Operations();

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

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

        public void onChildModified(ImageForm image)
        {

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
            ImageForm form = (ImageForm)ActiveMdiChild;
            Cursor = Cursors.WaitCursor;
            form.setImage(operations.stretchHistogram(form.currentImage));
            Cursor = Cursors.Default;
        }

        private void onHistogramMeanEqualizationClick(object sender, EventArgs e)
        {
            ImageForm form = (ImageForm)ActiveMdiChild;
            Cursor = Cursors.WaitCursor;
            form.setImage(operations.meanEqualizationHistogram(form.currentImage, Operations.EqualizationMethod.Mean));
            Cursor = Cursors.Default;
        }

        private void onHistogramRandomEqualizationClick(object sender, EventArgs e)
        {
            ImageForm form = (ImageForm)ActiveMdiChild;
            Cursor = Cursors.WaitCursor;
            form.setImage(operations.meanEqualizationHistogram(form.currentImage, Operations.EqualizationMethod.Random));
            Cursor = Cursors.Default;
        }

        private void onHistogramNeighboursEqualizationClick(object sender, EventArgs e)
        {
            ImageForm form = (ImageForm)ActiveMdiChild;
            Cursor = Cursors.WaitCursor;
            form.setImage(operations.meanEqualizationHistogram(form.currentImage, Operations.EqualizationMethod.Neighbours));
            Cursor = Cursors.Default;
        }

        private void onHistogramCustomEqualizationClick(object sender, EventArgs e)
        {
            ImageForm form = (ImageForm)ActiveMdiChild;
            Cursor = Cursors.WaitCursor;
            form.setImage(operations.meanEqualizationHistogram(form.currentImage, Operations.EqualizationMethod.Custom));
            Cursor = Cursors.Default;
        }

        private void onNegationClick(object sender, EventArgs e)
        {
            ImageForm form = (ImageForm)ActiveMdiChild;
            Cursor = Cursors.WaitCursor;
            Operation negation = new Negation();
            form.setImage(negation.perform(form.currentImage));
            Cursor = Cursors.Default;
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
    }
}
