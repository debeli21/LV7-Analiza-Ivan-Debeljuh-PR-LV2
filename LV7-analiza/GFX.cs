using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace LV7_analiza
{
    public class GFX
    {
        private static Graphics gObject;
        
        public GFX(Graphics g)
        {
            gObject = g;
            drawBoard();
        }

        public static void drawBoard()
        {
            gObject.FillRectangle(new SolidBrush(Color.White), new Rectangle(0,0,390,390));
            gObject.DrawLine(new Pen(Color.Black, 5), new Point(0, 130), new Point(390, 130));
            gObject.DrawLine(new Pen(Color.Black, 5), new Point(0, 260), new Point(390, 260));
            gObject.DrawLine(new Pen(Color.Black, 5), new Point(130, 0), new Point(130, 390));
            gObject.DrawLine(new Pen(Color.Black, 5), new Point(260, 0), new Point(260, 390));
        }

        public static void drawX(Point loc)
        {
            Pen xPen = new Pen(Color.Blue, 4);
            int xAbs = loc.X * 130;
            int yAbs = loc.Y * 130;

            gObject.DrawLine(xPen, xAbs+10, yAbs+10, xAbs + 120, yAbs + 120);
            gObject.DrawLine(xPen, xAbs+120, yAbs+10, xAbs+10, yAbs + 120);
        }

        public static void drawO(Point loc)
        {
            Pen oPen = new Pen(Color.Orchid, 4);
            int xAbs = loc.X * 130;
            int yAbs = loc.Y * 130;

            gObject.DrawEllipse(oPen, xAbs+10, yAbs+10 , 110, 110);

        }
    }
}
