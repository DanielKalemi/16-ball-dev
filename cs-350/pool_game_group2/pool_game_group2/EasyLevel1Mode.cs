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
    public partial class EasyLevel1Mode : Form
    {
        private GameToolsLevel1 _gameToolsLevel1;
        public WhiteBall _whiteball = new WhiteBall();

        public EasyLevel1Mode()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this._gameToolsLevel1 = new GameToolsLevel1(this.pictureBoxTrainMode.Width, this.pictureBoxTrainMode.Height);

            this._gameToolsLevel1.AddBall(this._whiteball);
            this._whiteball.ResetPosition();
            this.timer1.Enabled = true;

        }

        private void TrainMode_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxTrainMode_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxMouseDown(object sender, MouseEventArgs e)
        {
            _gameToolsLevel1.stick = new Stick(new Point(e.X, e.Y), new Point((int)this._whiteball.X, (int)this._whiteball.Y));
            _gameToolsLevel1.eLine = new ExtraLine(new Point(-e.X, -e.Y), new Point((int)this._whiteball.X, (int)this._whiteball.Y));

        }

        private void pictureBoxMouseMove(object sender, MouseEventArgs e)
        {
            this.label1.Text = $"X: {e.X}, Y: {e.Y} Power: " + _gameToolsLevel1.Power.ToString();// this is label shos the coordinates in order to place the pockets

            if (_whiteball.Vx <= 0.00 && _whiteball.Vy <= 0.00 && _whiteball.Vx >= -0.00 && _whiteball.Vy <= -0.00)
            {
                _gameToolsLevel1.stick = new Stick(new Point(e.X, e.Y), new Point((int)this._whiteball.X, (int)this._whiteball.Y));
                _gameToolsLevel1.eLine = new ExtraLine(new Point(-e.X, -e.Y), new Point((int)this._whiteball.X, (int)this._whiteball.Y));
            }
        }

        private void pictureBoxPaint(object sender, PaintEventArgs e)
        {

            this._gameToolsLevel1.ToMake(e.Graphics);
        }

        private void pictureBoxMouseUp(object sender, MouseEventArgs e)
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
                _gameToolsLevel1.IsPoweringUp = false;
            }
            this.pictureBoxTrainMode.Refresh();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this._gameToolsLevel1.Next();
            this.pictureBoxTrainMode.Refresh();

            if (_gameToolsLevel1.IsPoweringUp)
            {
                _gameToolsLevel1.Power += 1;
                Debug.WriteLine("Power: " + _gameToolsLevel1.Power.ToString());
            }
        }
    }
}
