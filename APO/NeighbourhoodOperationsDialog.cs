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
    public partial class NeighbourhoodOperationsDialog : Form
    {
        // TODO: Move to Operation class
        enum NeighbourhoodOperation
        {
            LowPassFilter,
            HighPassFilter,
            EdgeDetection
        }

        // TODO: Move to Operation class
        enum NeighbourhoodScaling
        {
            FirstMethod,
            SecondMethod,
            ThirdMethod
        }

        private NeighbourhoodOperation operation = NeighbourhoodOperation.LowPassFilter;
        private NeighbourhoodScaling scaling = NeighbourhoodScaling.FirstMethod;
        private int[] finalMask = new int[9];
        private int[] defaultMaskFirst = new int[9];
        private int[] defaultMaskSecond = new int[9];
        private int[] defaultMaskThird = new int[9];
        private int[] defaultMaskFourth = new int[9];

        public int[] Mask {
            get {
                return finalMask;
            }
        }

        public NeighbourhoodOperation UsedOperation {
            get {
                return opeartion;
            }
        }

        public NeighbourhoodScaling UsedScaling {
            get {
                return sacling;
            }
        }

        public NeighbourhoodOperationsDialog()
        {
            InitializeComponent();
        }

        private void onOperationChange(object sender, EventArgs e)
        {
            if (radioLowPass.Checked)
            {
                onLowPassOperation();
            }
            else if (radioHighPass.Checked)
            {
                onHighPassOperation();
            }
            else if (radioEdgeDetection.Checked)
            {
                onEdgeDetectionOperation();
            }
        }

        private void onLowPassOperation()
        {
            operation = NeighbourhoodOperation.LowPassFilter;
            scalingBox.Visible = false;
            defaultMaskFirst = new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            defaultMaskSecond = new int[] { 1, 1, 1, 1, 2, 1, 1, 1, 1 };
            defaultMaskThird = new int[] { 1, 1, 1, 1, 4, 1, 1, 1, 1 };
            defaultMaskFourth = new int[] { 1, 2, 1, 2, 4, 2, 1, 2, 1 };
            defaultMask4Button.Visible = true;
        }

        private void onHighPassOperation()
        {
            operation = NeighbourhoodOperation.HighPassFilter;
            scalingBox.Visible = true;
            defaultMaskFirst = new int[] { 0, -1, 0, -1, 4, -1, 0, -1, 0 };
            defaultMaskSecond = new int[] { -1, -1, -1, -1, 8, -1, -1, -1, -1 };
            defaultMaskThird = new int[] { 1, -2, 1, -2, 4, -2, 1, -2, 1 };
            defaultMaskFourth = new int[] { -1, -1, -1, -1, 9, -1, -1, -1, -1 };
            defaultMask4Button.Visible = true;
        }

        private void onEdgeDetectionOperation()
        {
            operation = NeighbourhoodOperation.EdgeDetection;
            scalingBox.Visible = true;
            defaultMaskFirst = new int[] { 1, -2, 1, -2, 5, -2, 1, -2, 1 };
            defaultMaskSecond = new int[] { -1, -1, -1, -1, 9, -1, -1, -1, -1 };
            defaultMaskThird = new int[] { 0, -1, 0, -1, 5, -1, 0, -1, 0 };
            defaultMask4Button.Visible = false;
        }

        private void onDefaultMask1Click(object sender, EventArgs e)
        {
            setMask(defaultMaskFirst);
        }

        private void onDefaultMask2Click(object sender, EventArgs e)
        {
            setMask(defaultMaskSecond);
        }

        private void onDefaultMask3Click(object sender, EventArgs e)
        {
            setMask(defaultMaskThird);
        }

        private void onDefaultMask4Click(object sender, EventArgs e)
        {
            setMask(defaultMaskFourth);
        }

        private void setMask(int[] mask)
        {
            numericUpDown1.Value = mask[0];
            numericUpDown2.Value = mask[1];
            numericUpDown3.Value = mask[2];
            numericUpDown4.Value = mask[3];
            numericUpDown5.Value = mask[4];
            numericUpDown6.Value = mask[5];
            numericUpDown7.Value = mask[6];
            numericUpDown8.Value = mask[7];
            numericUpDown9.Value = mask[8];
        }

        private void onMaskValueChanged(object sender, EventArgs e)
        {
            NumericUpDown elem = (NumericUpDown) sender;
            finalMask[elem.TabIndex] = (int)elem.Value;
        }

        private void onScalingChange(object sender, EventArgs e)
        {
            if (radioScaling1.Checked)
            {
                scaling = Scaling.FirstMethod;
            }
            else if (radioScaling2.Checked)
            {
                scaling = Scaling.SecondMethod;
            }
            else if (radioScaling3.Checked)
            {
                scaling = Scaling.ThirdMethod;
            }
        }
    }
}
