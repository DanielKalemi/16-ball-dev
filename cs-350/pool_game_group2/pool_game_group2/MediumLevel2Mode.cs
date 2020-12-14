using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pool_game_group2
{
    public partial class MediumLevel2Mode : Form
    {

        private GameToolsLevel2 _gameTools;
        public WhiteBall _whiteball = new WhiteBall();

        public MediumLevel2Mode()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this._gameTools = new GameToolsLevel2(this.pictureBoxMedium.Width, this.pictureBoxMedium.Height);

            this._gameTools.AddBall(this._whiteball);
            this._whiteball.ResetPosition();

            this.timer1.Enabled = true; // start the timer

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this._gameTools.Next();
            this.pictureBoxMedium.Refresh();

            if (_gameTools.IsPoweringUp)
            {
                _gameTools.Power += 1;
                Debug.WriteLine("Power: " + _gameTools.Power.ToString());
            }
        }

        private void pictureboxMouseDown(object sender, MouseEventArgs e)
        {
            _gameTools.stick = new Stick(new Point(e.X, e.Y), new Point((int)this._whiteball.X, (int)this._whiteball.Y));
            _gameTools.eLine = new ExtraLine(new Point(-e.X, -e.Y), new Point((int)this._whiteball.X, (int)this._whiteball.Y));

        }

        private void pictureboxMouseMove(object sender, MouseEventArgs e)
        {
            this.label1.Text = $"X: {e.X}, Y: {e.Y} Power: " + _gameTools.Power.ToString();// this is label shos the coordinates in order to place the pockets

            if (_whiteball.Vx <= 0.00 && _whiteball.Vy <= 0.00 && _whiteball.Vx >= -0.00 && _whiteball.Vy <= -0.00)
            {
                _gameTools.stick = new Stick(new Point(e.X, e.Y), new Point((int)this._whiteball.X, (int)this._whiteball.Y));
                _gameTools.eLine = new ExtraLine(new Point(-e.X, -e.Y), new Point((int)this._whiteball.X, (int)this._whiteball.Y));
            }
        }

        private void pictureboxMouseUp(object sender, MouseEventArgs e)
        {
            if (_whiteball.Vx <= 0.01 && _whiteball.Vy <= 0.01)
            {
                var newX = Convert.ToSingle((e.X - this._whiteball.X) * -0.1);
                var newY = Convert.ToSingle((e.Y - this._whiteball.Y) * -0.1);
                this._whiteball.Vx = newX;
                this._whiteball.Vy = newY;
            }

            if (e.Button == MouseButtons.Left)
            {
                _gameTools.IsPoweringUp = false;
            }
            this.pictureBoxMedium.Refresh();
        }

        private void pictureboxPaint(object sender, PaintEventArgs e)
        {

            this._gameTools.ToMake(e.Graphics);
        }
    }
}
