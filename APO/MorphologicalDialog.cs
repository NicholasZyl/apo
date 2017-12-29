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
    public partial class MorphologicalDialog : Form
    {
        private MorphologicalOperation.Operator desiredOperator = MorphologicalOperation.Operator.Erosion;
        private MorphologicalOperation.Structuring structuring = MorphologicalOperation.Structuring.VonNeumann;
        private NeighbourhoodOperation.EdgeProcessing edgeProcessing = NeighbourhoodOperation.EdgeProcessing.IgnoreEdgeLines;

        public MorphologicalDialog()
        {
            InitializeComponent();
        }

        public MorphologicalOperation.Operator DesiredOperator
        {
            get
            {
                return desiredOperator;
            }
        }

        public MorphologicalOperation.Structuring Structuring
        {
            get
            {
                return structuring;
            }
        }

        public NeighbourhoodOperation.EdgeProcessing EdgeProcessing
        {
            get
            {
                return edgeProcessing;
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

        private void onOperatorChange(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                desiredOperator = MorphologicalOperation.Operator.Erosion;
            }
            else if (radioButton2.Checked)
            {
                desiredOperator = MorphologicalOperation.Operator.Dilatation;
            }
            else if (radioButton3.Checked)
            {
                desiredOperator = MorphologicalOperation.Operator.Opening;
            }
            else if (radioButton6.Checked)
            {
                desiredOperator = MorphologicalOperation.Operator.Closing;
            }
        }

        private void onStructuringChange(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                structuring = MorphologicalOperation.Structuring.VonNeumann;
            }
            else if (radioButton5.Checked)
            {
                structuring = MorphologicalOperation.Structuring.Moore;
            }
        }
    }
}
