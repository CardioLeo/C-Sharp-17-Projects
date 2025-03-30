using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maze_Game_Project
{
    public partial class Form1: Form
    {
        System.Media.SoundPlayer startSoundPlayer = new System.Media.SoundPlayer(@"C:\Windows\Media\ring09.wav");
        System.Media.SoundPlayer finishSoundPlayer = new System.Media.SoundPlayer(@"C:\Windows\Media\ring10.wav");
        System.Media.SoundPlayer hitWallSoundPlayer = new System.Media.SoundPlayer(@"C:\Windows\Media\ring08.wav");
        public Form1()
        {
            InitializeComponent();
            MoveToStart();
            startSoundPlayer.Play();
        }

        private void finishLabel_MouseEnter(object sender, EventArgs e)
        {
            // writing code to finish game here

            // play sound at finish of game
            finishSoundPlayer.Play();

            // winning message displayed here:
            MessageBox.Show("Congratulations! You won!");

            // ends game:
            Close();
        }

        // method to restart game, put pointer back at startLabel
        private void MoveToStart()
        {
            // move mouse pointer 10 pixels down and to the right of starting point
            // defines field within which startingPoint exists
            Point startingPoint = panel1.Location;
            // locates startingPoint within panel1 at a specific place
            startingPoint.Offset(60, 30); // he had it at 10, 10, but 60, 30 works better for me
            // sets cursor position to startingPoint variable
            Cursor.Position = PointToScreen(startingPoint);
        }

        // method for when the walls are touched by the mouse
        private void wall_MouseEnter(object sender, EventArgs e)
        {
            // play sound for hitting wall
            hitWallSoundPlayer.Play();
            // first, calls same method as when the game starts
            MoveToStart();
            // prints message so my kids know what happened
            // this message needs to not be in MoveToStart(), tho, or it gets called when the game starts
            MessageBox.Show("Oh, no! you touched a wall!\n\nYou've been moved back to the start of the maze\n\nPress enter to continue");
        }
    }
}
