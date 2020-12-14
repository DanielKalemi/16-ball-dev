using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pool_game_group2
{
    public class ExtraLine : Stick
    {
        private Point P1, P2;
        //------------------------------------------------------------
        public ExtraLine()
        {
            this.P1 = new Point(0, 0);
            this.P2 = new Point(0, 0);
        }
        //------------------------------------------------------------
        public ExtraLine(Point p1, Point p2)
        {
            this.P1 = p1;
            this.P2 = p2;
        }
        //------------------------------------------------------------
        public override void ToMake(Graphics g)
        {
            using (var p = new Pen(Color.LightGray, 2))
            {
                g.DrawLine(p, P1, P2);
            }
        }
    }
}
