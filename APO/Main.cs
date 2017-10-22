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

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void laboratorium1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
            operacjeToolStripMenuItem.Enabled = true;
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

        private void negacjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageForm form = (ImageForm)ActiveMdiChild;
            Cursor = Cursors.WaitCursor;
            form.setImage(operations.negation(form.currentImage));
            Cursor = Cursors.Default;
        }

        private void cofnijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageForm form = (ImageForm)ActiveMdiChild;
            form.resetImage();
        }
    }
}
