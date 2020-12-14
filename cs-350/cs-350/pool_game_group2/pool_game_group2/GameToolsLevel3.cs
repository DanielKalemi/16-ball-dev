using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pool_game_group2
{
    public class GameToolsLevel3
    {
        public List<Balls> _ballsOnTable; // list of the balls
        //------------------------------------------------------------
        public Stick stick;
        //------------------------------------------------------------
        public bool IsPoweringUp = false;
        //------------------------------------------------------------
        private int _power = 0;
        //------------------------------------------------------------
        public int Power
        {
            get
            {
                return _power;
            }
            set
            {
                if((value > 1) && (value <= 10))
                {
                    _power = value;
                }
            }
        }
        //------------------------------------------------------------
        public ExtraLine eLine;
        //------------------------------------------------------------
        private List<Balls> ResetGame()
        {
            return new List<Balls>()
            {
                // Middle line (4 balls)
                new BallsColor(Color.Yellow, false){DefX = 1050, DefY = 325}, //1st column, 4th line
                new BallsColor(Color.Blue, true){DefX = 900, DefY = 325}, // 2nd column, 4th line
                new BallsColor(Color.Red, false){DefX = 950, DefY = 325}, //3rd column, 4th line
                new BallsColor(Color.Purple, true){DefX = 1000, DefY = 325},//4th column, 4th line
                
                new BallsColor(Color.Orange, false) {DefX = 1050, DefY = 375 },
                new BallsColor(Color.Green, true) {DefX = 950, DefY = 375 },
                new BallsColor(Color.DarkRed, false) {DefX = 1000, DefY = 375 },
                //6th line/ 3,4 columns (2 balls)
                new BallsColor(Color.LightSeaGreen, false)  {DefX = 1100, DefY = 325 },
                new BallsColor(Color.Yellow, true) {DefX = 1000, DefY = 425 },
                //7th line/ 4th column (1 ball)
                new BallsColor(Color.Blue, false) {DefX = 1050, DefY = 275 },
                //3rd line / 2,3,4 columns (3 balss )
                new BallsColor(Color.Red, false) {DefX = 1200, DefY = 325 },
                new BallsColor(Color.Purple, true) {DefX = 950, DefY = 275 },
                new BallsColor(Color.Orange, false) {DefX = 1000, DefY = 275 },
                // 2nd line / 3,4, column (2 balls)
                new BallsColor(Color.Green, false) {DefX = 1150, DefY = 375 },
                new BallsColor(Color.DarkRed, true) {DefX = 1000, DefY = 225 },
                // 1st line / 4th column (1 ball)
                new BallsColor(Color.LightSeaGreen, false) {DefX = 1150, DefY = 275 },

                // the pockets dimetions 
                new Pockets(){DefX = 60, DefY = 60 },
                new Pockets(){DefX = 1200, DefY = 60 },

                new Pockets(){DefX = 60, DefY = 575 },
                new Pockets(){DefX = 1200, DefY = 575 },
            };
        }
        //------------------------------------------------------------
        private int _width;
        private int _height;
        //------------------------------------------------------------
        public GameToolsLevel3(int width, int height)
        {
            _ballsOnTable = this.ResetGame();
            stick = new Stick();
            eLine = new ExtraLine();

            foreach(var balls in _ballsOnTable)
            {
                balls.ResetPosition(); // from Balls class
            }

            this._width = width;
            this._height = height;
        }
        //------------------------------------------------------------
        public void AddBall(Balls b)
        {
            this._ballsOnTable.Add(b);
        }
        //------------------------------------------------------------
        public void Next()
        {
            foreach(Balls balls in _ballsOnTable)
            {
                balls.Move(); // from balls class
                balls.Clash(this._width, this._height);
            }
        }
        //------------------------------------------------------------
        private void Clash(Balls b1, Balls b2) // we copied pasted this part
        {
            float xDifferece = b1.X - b2.X;
            float yDifferece = b1.Y - b2.Y;
            float hypotenuse = Convert.ToSingle(Math.Pow(xDifferece, 2) + Math.Pow(yDifferece, 2));

            if (Math.Sqrt(hypotenuse) <= (b1.Radius + b2.Radius + b2.Radius))
            {

                if (b2 is Pockets || b1 is Pockets)
                {
                    Debug.WriteLine("ball is in the hole.");
                    b2.Vx = 0;
                    b2.Vy = 0;
                    b1.Vx = 0;
                    b1.Vy = 0;

                    if (b2 is Pockets)
                    {
                        if (b1 is WhiteBall)
                            b1.ResetPosition();
                        else
                            _ballsOnTable.Remove(b1);
                    }
                    else
                    {
                        if (b2 is WhiteBall)
                            b2.ResetPosition();
                        else
                            _ballsOnTable.Remove(b2);
                    }

                }
                else
                {
                    float Vx = b2.Vx - b1.Vx;
                    float Vy = b2.Vy - b1.Vy;
                    float dotProduct = xDifferece * Vx + yDifferece * Vy;

                    if (dotProduct > 0)
                    {
                        float collisionScale = dotProduct / hypotenuse;

                        float xCollision = (xDifferece * collisionScale);
                        float yCollision = (yDifferece * collisionScale);
                        float combinedMass = b1.Mass + b2.Mass;

                        float collisionWeightA = 2 * b2.Mass / combinedMass;
                        float collisionWeightB = 2 * b1.Mass / combinedMass;

                        b1.Vx += collisionWeightA * xCollision;
                        b1.Vy += collisionWeightA * yCollision;
                        b2.Vx -= collisionWeightB * xCollision;
                        b2.Vy -= collisionWeightB * yCollision;
                    }
                }
            }
        }
        //------------------------------------------------------------
        public void ToMake(Graphics g)
        {
            this.stick.ToMake(g);
            this.eLine.ToMake(g);

            for (int i = 0; i < this._ballsOnTable.Count; i++)
            {
                Balls a = this._ballsOnTable[i];
                a.ToMake(g);

                for (int j = i + 1; j < this._ballsOnTable.Count; j++)
                {
                    Balls b = this._ballsOnTable[j];
                    this.Clash(a, b);
                }
            }
        }
        //------------------------------------------------------------
        

    }
}
