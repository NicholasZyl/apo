using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace APO
{
    public partial class GradientDialog : Form
    {
        private NeighbourhoodOperation.Scaling scaling = NeighbourhoodOperation.Scaling.Proportional;
        private NeighbourhoodOperation.EdgeProcessing edgeProcessing = NeighbourhoodOperation.EdgeProcessing.IgnoreEdgeLines;
        private int[] maskOne = new int[9];
        private int[] maskTwo = new int[9];

        public GradientDialog()
        {
            InitializeComponent();
            maskOne = new int[] { 0, 0, 0, 0, 1, 0, 0, 0, -1 };
            maskTwo = new int[] { 0, 0, 0, 0, 0, -1, 0, 1, 0 };
            setMasksReadOnly(true);
            setMasks();
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

        public int[] MaskOne
        {
            get
            {
                return maskOne;
            }
        }

        public int[] MaskTwo
        {
            get
            {
                return maskTwo;
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
            if (radioButton1.Checked)
            {
                maskOne = new int[] { 0, 0, 0, 0, 1, 0, 0, 0, -1 };
                maskTwo = new int[] { 0, 0, 0, 0, 0, -1, 0, 1, 0 };
                setMasksReadOnly(true);
            }
            else if (radioButton2.Checked)
            {
                maskOne = new int[] { -1, 0, 1, -2, 0, 2, -1, 0, 1 };
                maskTwo = new int[] { -1, -2, -1, 0, 0, 0, 1, 2, 1 };
                setMasksReadOnly(true);
            }
            else if (radioButton3.Checked)
            {
                maskOne = new int[] { -1, 0, 1, -1, 0, 1, -1, 0, 1 };
                maskTwo = new int[] { -1, -1, -1, 0, 0, 0, 1, 1, 1 };
                setMasksReadOnly(true);
            }
            else if (radioButton4.Checked)
            {
                maskOne = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                maskTwo = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                setMasksReadOnly(false);
            }
            setMasks();
        }

        private void onMaskValueChanged(object sender, EventArgs e)
        {
            NumericUpDown s = (NumericUpDown)sender;

            switch (s.Name)
            {
                case "1":
                    maskOne[0] = (int)s.Value;
                    break;
                case "2":
                    maskOne[1] = (int)s.Value;
                    break;
                case "3":
                    maskOne[2] = (int)s.Value;
                    break;
                case "4":
                    maskOne[3] = (int)s.Value;
                    break;
                case "5":
                    maskOne[4] = (int)s.Value;
                    break;
                case "6":
                    maskOne[5] = (int)s.Value;
                    break;
                case "7":
                    maskOne[6] = (int)s.Value;
                    break;
                case "8":
                    maskOne[7] = (int)s.Value;
                    break;
                case "9":
                    maskOne[8] = (int)s.Value;
                    break;
                case "10":
                    maskTwo[0] = (int)s.Value;
                    break;
                case "11":
                    maskTwo[1] = (int)s.Value;
                    break;
                case "12":
                    maskTwo[2] = (int)s.Value;
                    break;
                case "13":
                    maskTwo[3] = (int)s.Value;
                    break;
                case "14":
                    maskTwo[4] = (int)s.Value;
                    break;
                case "15":
                    maskTwo[5] = (int)s.Value;
                    break;
                case "16":
                    maskTwo[6] = (int)s.Value;
                    break;
                case "17":
                    maskTwo[7] = (int)s.Value;
                    break;
                case "18":
                    maskTwo[8] = (int)s.Value;
                    break;
            }
        }

        private void setMasks()
        {
            numericUpDown1.Value = maskOne[0];
            numericUpDown2.Value = maskOne[1];
            numericUpDown3.Value = maskOne[2];
            numericUpDown4.Value = maskOne[3];
            numericUpDown5.Value = maskOne[4];
            numericUpDown6.Value = maskOne[5];
            numericUpDown7.Value = maskOne[6];
            numericUpDown8.Value = maskOne[7];
            numericUpDown9.Value = maskOne[8];

            numericUpDown10.Value = maskTwo[0];
            numericUpDown11.Value = maskTwo[1];
            numericUpDown12.Value = maskTwo[2];
            numericUpDown13.Value = maskTwo[3];
            numericUpDown14.Value = maskTwo[4];
            numericUpDown15.Value = maskTwo[5];
            numericUpDown16.Value = maskTwo[6];
            numericUpDown17.Value = maskTwo[7];
            numericUpDown18.Value = maskTwo[8];
        }

        private void setMasksReadOnly(bool disabled)
        {
            numericUpDown1.ReadOnly = disabled;
            numericUpDown2.ReadOnly = disabled;
            numericUpDown3.ReadOnly = disabled;
            numericUpDown4.ReadOnly = disabled;
            numericUpDown5.ReadOnly = disabled;
            numericUpDown6.ReadOnly = disabled;
            numericUpDown7.ReadOnly = disabled;
            numericUpDown8.ReadOnly = disabled;
            numericUpDown9.ReadOnly = disabled;

            numericUpDown10.ReadOnly = disabled;
            numericUpDown11.ReadOnly = disabled;
            numericUpDown12.ReadOnly = disabled;
            numericUpDown13.ReadOnly = disabled;
            numericUpDown14.ReadOnly = disabled;
            numericUpDown15.ReadOnly = disabled;
            numericUpDown16.ReadOnly = disabled;
            numericUpDown17.ReadOnly = disabled;
            numericUpDown18.ReadOnly = disabled;
        }
    }
}
