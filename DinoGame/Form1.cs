using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinoGame
{
    public partial class Form1 : Form
    {
        public Point InitialPoint { get; set; }
        public Point FlowerInitialPoint { get; set; }
        private bool isSapcePressed = false;
        private int counter = 0;

        public Form1()
        {
            InitializeComponent();
            FlowerInitialPoint = FlowerPictureBox.Location;
            InitialPoint = DinoPictureBox.Location;

            gamOverPanel.Visible = false;
        }

        async void DinoGamePlay()
        {
            counter++;
            pointLabel.Text = (counter * 5).ToString("00000");

            if (isSapcePressed)
            {
                DinoPictureBox.Image = Properties.Resources.DinoStart;
                DinoPictureBox.Location = new Point(InitialPoint.X, InitialPoint.Y - 100);

                await Task.Delay(900);

                isSapcePressed = false;
            }
            else if (counter % 2 == 0)
            {
                DinoPictureBox.Image = Properties.Resources.DinoRun1;
                DinoPictureBox.Location = InitialPoint;
            }
            else
            {
                DinoPictureBox.Image = Properties.Resources.DinoRun2;
                DinoPictureBox.Location = InitialPoint;
            }
        }

        void SandMove()
        {
            if (sandPcitureBox.Location.X <= -300)
            {
                sandPcitureBox.Location = new Point(0, sandPcitureBox.Location.Y);
            }
            else
            {
                sandPcitureBox.Location = new Point(sandPcitureBox.Location.X - 20, sandPcitureBox.Location.Y);
            }
        }

        void FlowerMove()
        {
            if (counter * 5 % 50 == 0 && FlowerPictureBox.Location.X <= 0)
            {
                FlowerPictureBox.Location = new Point(800, FlowerPictureBox.Location.Y);
            }
            else
            {
                FlowerPictureBox.Location = new Point(FlowerPictureBox.Location.X - 20, FlowerPictureBox.Location.Y);
            }
        }

        void CheckGameOver()
        {
            if (DinoPictureBox.Bounds.IntersectsWith(FlowerPictureBox.Bounds))
            {
                gameTimer.Stop();
                scoreLabel.Text = $"Score: {counter * 5}";
                this.gamOverPanel.Visible = true;
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            DinoGamePlay();
            SandMove();
            FlowerMove();
            CheckGameOver();
        }


        private void startButton_Click(object sender, EventArgs e)
        {
            startButton.Visible = false;
            gameTimer.Interval = 100;
            gameTimer.Start();
            this.Focus();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                isSapcePressed = true;
            }
        }

        private void restartBtn_Click(object sender, EventArgs e)
        {
            this.gamOverPanel.Visible = false;
            counter = 0;
            DinoPictureBox.Location = InitialPoint;
            FlowerPictureBox.Location = FlowerInitialPoint;
            isSapcePressed = false;
            gameTimer.Interval = 100;
            gameTimer.Start();
            this.Focus();
        }
    }
}
