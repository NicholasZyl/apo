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
    public partial class DuplexBinarizationDialog : Form
    {
        public int upperBound
        {
            get
            {
                return (int) upperBoundBox.Value;
            }
        }

        public int lowerBound
        {
            get
            {
                return (int) lowerBoundBox.Value;
            }
        }

        public DuplexBinarizationDialog()
        {
            InitializeComponent();
        }
    }
}
