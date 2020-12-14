using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pool_game_group2
{
    public class Pockets : Balls
    {
        public Pockets()
        {
            base.Color = System.Drawing.Color.Transparent;
            base.ColorBorder = System.Drawing.Color.Black;
            base.Radius = 12;
        }
    }
}
