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
    public partial class LogicFilteringDialog : Form
    {
        private NeighbourhoodOperation.EdgeProcessing edgeProcessing = NeighbourhoodOperation.EdgeProcessing.IgnoreEdgeLines;
        private LogicFilteringOperation.Direction direction = LogicFilteringOperation.Direction.Horizontal;

        public LogicFilteringDialog()
        {
            InitializeComponent();
        }

        public NeighbourhoodOperation.EdgeProcessing EdgeProcessing
        {
            get
            {
                return edgeProcessing;
            }
        }

        public LogicFilteringOperation.Direction Direction
        {
            get
            {
                return direction;
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

        private void onDirectionChange(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                direction = LogicFilteringOperation.Direction.Horizontal;
            }
            else if (radioButton2.Checked)
            {
                direction = LogicFilteringOperation.Direction.Vertical;
            }
        }
    }
}
