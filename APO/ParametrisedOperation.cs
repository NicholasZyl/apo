using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APO
{
    public interface ParametrisedOperation
    {
        String name();

        void adaptSlider(System.Windows.Forms.TrackBar slider);

        Bitmap perform(Bitmap image, int parameter);
    }
}
