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
    public partial class SteganographyRevealDialog : Form
    {
        public int UsedBits
        {
            get
            {
                return (int) numericUpDown1.Value;
            }
        }

        public int HiddenImageWidth
        {
            get
            {
                return Int32.Parse(widthInput.Text);
            }
        }

        public int HiddenImageHeight
        {   
            get
            {
                return Int32.Parse(heightInput.Text);
            }
        }

        public SteganographyRevealDialog()
        {
            InitializeComponent();
        }
    }
}
