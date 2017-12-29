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
    public partial class ThinningDialog : Form
    {
        private NeighbourhoodOperation.EdgeProcessing edgeProcessing = NeighbourhoodOperation.EdgeProcessing.IgnoreEdgeLines;

        public ThinningDialog()
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
    }
}
