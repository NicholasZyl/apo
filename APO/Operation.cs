﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APO
{
    public interface Operation
    {
        Bitmap perform(Bitmap image);
    }
}