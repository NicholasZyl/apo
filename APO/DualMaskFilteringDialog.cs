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
    public partial class DualMaskFilteringDialog : Form
    {

        private int[] finalMask = new int[25];
        private int divisor;
        private NeighbourhoodOperation.Scaling scaling = NeighbourhoodOperation.Scaling.Proportional;
        private NeighbourhoodOperation.EdgeProcessing edgeProcessing = NeighbourhoodOperation.EdgeProcessing.IgnoreEdgeLines;
        private NumericUpDown[,] maskFirst;
        private NumericUpDown[,] maskSecond;
        private NumericUpDown[,] maskFinal;

        public DualMaskFilteringDialog()
        {
            InitializeComponent();
            maskFirst = new NumericUpDown[3,3]
            {
                { numericUpDown1, numericUpDown2, numericUpDown3, },
                { numericUpDown4, numericUpDown5, numericUpDown6, },
                { numericUpDown7, numericUpDown8, numericUpDown9, },
            };
            maskSecond = new NumericUpDown[3,3]
            {
                { numericUpDown10, numericUpDown11, numericUpDown12, },
                { numericUpDown13, numericUpDown14, numericUpDown15, },
                { numericUpDown16, numericUpDown17, numericUpDown18, },
            };
            maskFinal = new NumericUpDown[5,5]
            {
                { numericUpDown19, numericUpDown20, numericUpDown21, numericUpDown22, numericUpDown23, },
                { numericUpDown24, numericUpDown25, numericUpDown26, numericUpDown27, numericUpDown28, },
                { numericUpDown29, numericUpDown30, numericUpDown31, numericUpDown32, numericUpDown33, },
                { numericUpDown34, numericUpDown35, numericUpDown36, numericUpDown37, numericUpDown38, },
                { numericUpDown39, numericUpDown40, numericUpDown41, numericUpDown42, numericUpDown43, },
            };
        }

        public int[] Mask
        {
            get
            {
                return finalMask;
            }
        }

        public int Divisor
        {
            get
            {
                return divisor;
            }
        }

        public NeighbourhoodOperation.Scaling UsedScaling
        {
            get
            {
                return scaling;
            }
        }

        public NeighbourhoodOperation.EdgeProcessing EdgeProcessing
        {
            get
            {
                return edgeProcessing;
            }
        }

        private void onScalingChange(object sender, EventArgs e)
        {
            if (radioScaling1.Checked)
            {
                scaling = NeighbourhoodOperation.Scaling.Proportional;
            }
            else if (radioScaling2.Checked)
            {
                scaling = NeighbourhoodOperation.Scaling.EdgesOnly;
            }
            else if (radioScaling3.Checked)
            {
                scaling = NeighbourhoodOperation.Scaling.CutToScale;
            }
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

        private void onMaskChange(object sender, EventArgs e)
        {
            int[,] temp = new int[7, 7];
            divisor = 0;

            for (int i = 2; i < 5; i++)
            {
                for (int j = 2; j < 5; j++)
                {
                    int val = (int)maskFirst[i - 2, j - 2].Value;
                    temp[i, j] = val;
                    divisor += val;
                }
            }

            for (int i = 0; i < 5; ++i)
            {
                for (int j = 0; j < 5; ++j)
                {
                    int value = 0;
                    for (int k = 0; k < 3; ++k)
                    {
                        for (int l = 0; l < 3; ++l)
                        {
                            value += temp[i + k, j + l] * (int)maskSecond[k, l].Value;
                        }
                    }
                    maskFinal[i, j].Value = value;
                    finalMask[i * 5 + j] = value;
                }
            }
        }
    }
}
