using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong
{
    public partial class frmPingPong : Form
    {
        int WertX = 5;
        int WertY = 2;
        public frmPingPong()
        {
            InitializeComponent();
            this.TopMost = true;
            this.Bounds = Screen.PrimaryScreen.Bounds;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tmrSpiel.Start();
        }

        private void tmrSpiel_Tick(object sender, EventArgs e)
        {
             picBall.Location = new Point(picBall.Location.X+WertX, picBall.Location.Y+WertY);

            if(picBall.Location.X>=pnlSpiel.Width-picBall.Width)
            {
                WertX = -WertX;
            }

            else if(picBall.Location.Y>=pnlSpiel.Height-picBall.Height)
            {
                WertY = -WertY;
            }

            else if (picBall.Location.X <= 0)
            {
                WertX = -WertX;
            }

            else if (picBall.Location.Y <= 0)
            {
                WertY = -WertY;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            tmrSpiel.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlSpiel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmPingPong_Load(object sender, EventArgs e)
        {

        }
    }
}