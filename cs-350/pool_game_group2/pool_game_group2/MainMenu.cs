using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pool_game_group2
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            HardLevel3Mode pool = new HardLevel3Mode();
            pool.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("There are two modes to play this game" +
                "1) 16-Pool Game: The 16-Ball game is played with 16 numbered balls and the white ball. (Seventeen in total)." +
                "On each shot, the first ball the white one should hit another ball on the table. " +
                "After a player hits the ball then is the turn of the other to play. " +
                "This continues until someone pockets all the balls and wins. " +
                "The incoming player must shoot the white ball from the position left by the previous player, but if someone pockets the white ball, it starts from the start position. ",
                "Game Instructions" +
                "2) Trainning Mode: ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MediumLevel2Mode mode = new MediumLevel2Mode();
            mode.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EasyLevel1Mode mode = new EasyLevel1Mode();
            mode.ShowDialog();
        }
    }
}
