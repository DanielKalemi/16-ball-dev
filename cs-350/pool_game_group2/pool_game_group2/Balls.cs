using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pool_game_group2
{
    public abstract class Balls
    {
        //------------------------------------------------------------
        public float Mass { get; set; }
        public float Radius { get; set; } = 12;
        //------------------------------------------------------------
        public Color Color { get; set; }
        public Color ColorBorder { get; set; }
        //------------------------------------------------------------
        public float X { get; set; }
        public float Y { get; set; }
        //------------------------------------------------------------
        public float Vx { get; set; }
        public float Vy { get; set; }
        //------------------------------------------------------------
        public float DefX { get; set; }
        public float DefY { get; set; }
        //------------------------------------------------------------
        public Balls() // mass for the balls
        {
            this.Mass = Radius * (float)1.3;
        }
        //------------------------------------------------------------
        public Balls(Color color, Color colorBorder) // for the color of balls
        {
            this.Color = color;
            this.ColorBorder = colorBorder;
            this.Mass = Radius * (float)1.3;
        }
        //------------------------------------------------------------
        public virtual void Move() // TODO
        {
            this.X = Convert.ToSingle(this.Vx + this.X);
            this.Y = Convert.ToSingle(this.Vy + this.Y);

            this.Vx *= (float)0.99;
            this.Vy *= (float)0.99;
        }
        //------------------------------------------------------------
        public void Clash(int gameWidth, int gameHeight)
        {
            if (this.X + this.Radius + 5 >= gameWidth - 60 || this.X - this.Radius - 5 <= 60)
            {
                this.Vx *= -1;
            }
            if (this.Y + this.Radius + 5 >= gameHeight - 60 || this.Y - this.Radius - 5 <= 60)
            {
                this.Vy *= -1;
            }
        }
        //------------------------------------------------------------
        public void ResetPosition()
        {
            this.X = this.DefX;
            this.Y = this.DefY;
        }
        //------------------------------------------------------------
        public void ToMake(Graphics g)
        {
            using (SolidBrush brush = new SolidBrush(this.Color))
            {
                g.FillEllipse(brush, Convert.ToSingle(this.X - this.Radius), Convert.ToSingle(this.Y - this.Radius), (this.Radius * 2), (this.Radius * 2));
            }
            using (Pen border = new Pen(this.ColorBorder, 12))
            {
                g.DrawEllipse(border, Convert.ToSingle(this.X - this.Radius), Convert.ToSingle(this.Y - this.Radius), this.Radius * 2, this.Radius * 2);
            }
         //------------------------------------------------------------
        }
    }
}
