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

    public partial class MedianFilteringDialog : Form
    {
        private int sizeX;
        private int sizeY;
        private NeighbourhoodOperation.EdgeProcessing edgeProcessing = NeighbourhoodOperation.EdgeProcessing.IgnoreEdgeLines;

        public NeighbourhoodOperation.EdgeProcessing EdgeProcessing
        {
            get
            {
                return edgeProcessing;
            }
        }

        public int SizeX
        {
            get
            {
                return sizeX;
            }
        }

        public int SizeY
        {
            get
            {
                return sizeY;
            }
        }

        public MedianFilteringDialog()
        {
            InitializeComponent();
        }

        private void onEdgeProcessingChange(object sender, EventArgs e)
        {
            if (radioEdges1.Checked)
            {
                edgeProcessing = NeighbourhoodOperation.EdgeProcessing.IgnoreEdgeLines;
            }
            else if (radioEdges2.Checked)
            {
                edgeProcessing = NeighbourhoodOperation.EdgeProcessing.DuplicateEdges;
            }
            else if (radioEdges3.Checked)
            {
                edgeProcessing = NeighbourhoodOperation.EdgeProcessing.OnlyExistingNeighbourhood;
            }
        }

        private void onMaskSizeChange(object sender, EventArgs e)
        {
            switch ((String) maskSizeBox.SelectedItem)
            {
                case "3x3":
                    sizeX = 3;
                    sizeY = 3;
                    break;
                case "3x5":
                    sizeX = 3;
                    sizeY = 5;
                    break;
                case "5x3":
                    sizeX = 5;
                    sizeY = 3;
                    break;
                case "5x5":
                    sizeX = 5;
                    sizeY = 5;
                    break;
                case "7x7":
                    sizeX = 7;
                    sizeY = 7;
                    break;
            }
        }
    }
}
