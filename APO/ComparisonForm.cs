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
    public partial class ComparisonForm : Form
    {
        private Bitmap changedImage;

        private Operations operations = new Operations();

        public ComparisonForm(Bitmap image)
        {
            InitializeComponent();
            baseImageBox.Image = image;
            baseImageBox.SizeMode = PictureBoxSizeMode.CenterImage;

            changedImage = (Bitmap)image.Clone();
            changedImageBox.Image = changedImage;
            changedImageBox.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void ComparisonForm_Load(object sender, EventArgs e)
        {

        }

        private void onSliderValueChange(object sender, EventArgs e)
        {
            textPreviewBox.Text = slider.Value.ToString();
        }

        private void onCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
