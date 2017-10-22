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

        private Operations operations = new Operations();

        public ComparisonForm(Bitmap image)
        {
            InitializeComponent();
            pictureBox1.Image = image;
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.Image = image;
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void ComparisonForm_Load(object sender, EventArgs e)
        {

        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = trackBar1.Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
