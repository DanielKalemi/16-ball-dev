using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pool_game_group2
{
    public class BallsColor : Balls
    {
        public BallsColor(Color mainColor, bool line)
        {
            if (line)
            {
                base.ColorBorder = mainColor;
                base.Color = System.Drawing.Color.LightGreen; 
            }
            else
            {
                base.Color = mainColor;
                base.ColorBorder = System.Drawing.Color.LightGreen;
            }
        }
    }
}
