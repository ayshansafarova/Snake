using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{    public partial class Form1 : Form
    {
        Animal head;
        Food fruit;
        Graphics g;
        int dirX = 0, dirY = 0;
        Boolean isX = true, isY = true;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
            head = new Animal(10, 10);
            fruit = new Food();
            g = myPicBox.CreateGraphics();
        }
        public void move()
        {
            head.setCoordinate(head.getX() + dirX, head.getY() + dirY);
        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            g.Clear(Color.LightGreen);
            head.draw(g);
            fruit.draw(g);
            move();
            intersectionTail();
            intersectionWall();
            if (head.intersection(fruit))
            {
                fruit.randomise();
                head.setAgain();
                score = score + 5;
                myLabel2.Text = score.ToString();
            }
        }
        public void intersectionWall()
        {
            if (head.getX() < 0 || head.getX() > 928 || head.getY() < 0 || head.getY() > 485)
            {
                endOfGame();
            }
        }
        public void endOfGame()
        {
            score = 0;
            myLabel2.Text = "0";
            isX = true;
            isY = true;
            dirX = 0;
            dirY = 0;
            head = new Animal(10, 10);
            fruit = new Food();
            MessageBox.Show("You lost the game!");
        }
        public void intersectionTail()
        {
            Animal temp;
            try
            {
                temp = head.getTail().getTail();
            }
            catch (Exception er)
            {
                temp = null;
            }
            while (temp != null)
            {
                if (head.intersection(temp))
                {
                    endOfGame();
                }
                else
                {
                    temp = temp.getTail();
                }
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(isX)
            {
                if (e.KeyCode == Keys.Up)
                {
                    dirY = -10;
                    dirX = 0;
                    isX = false;
                    isY = true;
                }
                if (e.KeyCode == Keys.Down)
                {
                    dirY = 10;
                    dirX = 0;
                    isX = false;
                    isY = true;
                }
            }
            if (isY)
            {
                if (e.KeyCode == Keys.Right)
                {
                    dirY = 0;
                    dirX = 10;
                    isX = true;
                    isY = false;
                }
                if (e.KeyCode == Keys.Left)
                {
                    dirY = 0;
                    dirX = -10;
                    isX = true;
                    isY = false;
                }
            }
        }
    }
}
