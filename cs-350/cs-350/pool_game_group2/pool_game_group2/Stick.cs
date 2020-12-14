using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pool_game_group2
{
    public class Stick 
    {
        private Point P1, P2;
        //------------------------------------------------------------
        public Stick()
        {
            this.P1 = new Point(0, 0);
            this.P2 = new Point(0, 0);
        }
        //------------------------------------------------------------
        public Stick(Point p1, Point p2)
        {
            this.P1 = p1;
            this.P2 = p2;
        }
        //------------------------------------------------------------
        public virtual void ToMake(Graphics g)
        {
            using (var p = new Pen(Color.Black, 6))
            {
                g.DrawLine(p, P1, P2);
            }
        }
        //------------------------------------------------------------
    }
}
