using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    interface Instrument
    {
        void StartDrawing(Point eLocation);
        bool Draw(Graphics ig, Point eLocation);
        void StopDrawing();
    }
}
