using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APO
{
    public partial class ImageForm : Form
    {
        private string path;
        private Bitmap bmp;

        public ImageForm(string file)
        {
            InitializeComponent();

            path = file;
            Text = Path.GetFileName(path);

            StreamReader reader = new StreamReader(file);
            bmp = (Bitmap)Bitmap.FromStream(reader.BaseStream);
            reader.Close();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
