using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifeGame
{
    public partial class Form1 : Form
    {
        private Random random = null;

        private int[,] field = null; 
        public Form1()
        {
            InitializeComponent();

            random = new Random();
            field = new int[10, 10];
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    if (field[x, y] == 1)
                    {
                        e.Graphics.FillRectangle(Brushes.Lime, x * 16, y * 16, 15, 15);
                    }
                }
            }
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 20; i++)
            {
                int x = random.Next(10);
                int y = random.Next(10);
                while(field[x, y] == 1)
                {
                    x = random.Next(10);
                    y = random.Next(10);
                }
                field[x, y] = 1;
            }

            pictureBox1.Refresh();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
            }
            else
            {
                timer1.Start();
            }
        }

        private int getFieldValue(int x, int y)
        {
            if (x < 0 || x >= 10 || y < 0 || y >= 10)
            {
                return 0;
            }

            return field[x, y];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ShowNextGeneration();
        }

        private void ShowNextGeneration()
        {
            int[,] nextField = new int[10, 10];
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    int sum = getFieldValue(x - 1, y) + getFieldValue(x + 1, y) + getFieldValue(x, y - 1) + getFieldValue(x, y + 1)
                        + getFieldValue(x - 1, y - 1) + getFieldValue(x - 1, y + 1) + getFieldValue(x + 1, y - 1) + getFieldValue(x + 1, y + 1);
                    if (field[x, y] == 0 && sum == 3)
                    {
                        nextField[x, y] = 1;
                    }
                    else if (field[x, y] == 1 && (sum == 2 || sum == 3))
                    {
                        nextField[x, y] = 1;
                    }
                    else if (field[x, y] == 1 && (sum == 1 || sum == 4))
                    {
                        nextField[x, y] = 0;
                    }
                }
            }

            field = nextField;
            pictureBox1.Refresh();
        }

        private void btnPat1_Click(object sender, EventArgs e)
        {
            field = new int[10, 10];
            field[5, 4] = 1;
            field[5, 5] = 1;
            field[5, 6] = 1;
            pictureBox1.Refresh();
        }

        private void btnPat2_Click(object sender, EventArgs e)
        {
            field = new int[10, 10];
            field[2, 0] = 1;
            field[2, 1] = 1;
            field[2, 2] = 1;

            field[5, 3] = 1;
            field[5, 4] = 1;
            field[5, 5] = 1;

            field[8, 6] = 1;
            field[8, 7] = 1;
            field[8, 8] = 1;
            pictureBox1.Refresh();
        }

        private void btnPat9_Click(object sender, EventArgs e)
        {
            field = new int[10, 10];
            field[2, 3] = 1;
            field[3, 3] = 1;
            field[4, 3] = 1;
            field[4, 2] = 1;
            field[3, 1] = 1;
            pictureBox1.Refresh();
        }
    }
}
