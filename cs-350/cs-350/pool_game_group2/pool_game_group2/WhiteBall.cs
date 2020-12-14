using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pool_game_group2
{
    public class WhiteBall : Balls
    {
        public WhiteBall()
        {
            base.Color = System.Drawing.Color.White;
            base.ColorBorder = System.Drawing.Color.White;
            base.DefX = 340;
            base.DefY = 318;
        }
    }
}
