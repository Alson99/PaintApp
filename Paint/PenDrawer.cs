using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    public class PenDrawer : Instrument
    {
        Pen p = new Pen(Color.Black, 1);
        Pen eraser = new Pen(Color.White, 20);
        private Point? startPos = null;
        public bool Draw(Graphics g, Point eLocation)
        {
            if (startPos != null)
            {
                Pen p = new Pen(Color.Blue, 3);
                g.DrawLine(p, (Point)startPos, eLocation);
                startPos = eLocation;
                return true;
            }

            return false;
        }

        public void StartDrawing(Point eLocation)
        {
            startPos = eLocation;
        }

        public void StopDrawing()
        {
            startPos = null;
        }
    }
}
