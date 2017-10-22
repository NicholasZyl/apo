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
    public partial class ComparisonDialog : Form
    {
        private Bitmap originalImage;
        private Bitmap changedImage;
        private ParametrisedOperation operation;

        public ComparisonDialog(Bitmap image, ParametrisedOperation operation)
        {
            InitializeComponent();

            originalImage = image;
            baseImageBox.Image = originalImage;
            baseImageBox.SizeMode = PictureBoxSizeMode.CenterImage;

            changedImage = (Bitmap)image.Clone();
            changedImageBox.Image = changedImage;
            changedImageBox.SizeMode = PictureBoxSizeMode.CenterImage;

            this.operation = operation;
            operation.adaptSlider(slider);
            this.Text = operation.name();
        }

        public Bitmap finalImage
        {
            get
            {
                return changedImage;
            }
        }

        private void ComparisonForm_Load(object sender, EventArgs e)
        {

        }

        private void onSliderValueChange(object sender, EventArgs e)
        {
            textPreviewBox.Text = slider.Value.ToString();
        }

        private void onTextValueChanged(object sender, EventArgs e)
        {
            int newValue;
            if (!Int32.TryParse(textPreviewBox.Text, out newValue))
            {
                MessageBox.Show(
                    "You can use only integer values here!",
                    "Error!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                newValue = slider.Value;
            } else  if (newValue < slider.Minimum || slider.Maximum < newValue)
            {
                MessageBox.Show(
                    "Value out of bounds!",
                    "Error!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                newValue = slider.Value;
            }
            slider.Value = newValue;
        }

        private void onParameterChangeMouseUp(object sender, EventArgs e)
        {
            performOperation();
        }

        private void onCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void onOkClick(object sender, EventArgs e)
        {
            performOperation();
        }

        private void performOperation()
        {
            changedImage = operation.perform(originalImage, slider.Value);
            changedImageBox.Image = changedImage;
            changedImageBox.SizeMode = PictureBoxSizeMode.CenterImage;
        }
    }
}
