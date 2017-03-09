using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace FiguresGame
{
    public class ClassTriangle : ClassFigures
    {
        
        public Point[] curvePoints = new Point[3];
        private bool running;

        public bool Running
        {
            get { return running; }
            set { running = value; }
        }

        
        private Color col;
        private Brush brush;
        
        private Thread th;
        private Thread th2;
        public Thread Th
        {
            get { return th; }
            set { th = value; }
        }

        public Thread Th2
        {
            get { return th2; }
            set { th2 = value; }
        }

        private Form1 fr;
        private Random rand = new Random();

        public ClassTriangle()
        {
           
        }

        public ClassTriangle(Form1 fr)
        {
           this.fr = fr;
           Thread.Sleep(5);

           x = rand.Next(1, fr.Width);
           y = rand.Next(1, fr.Height);

            //Point dA
            dA.X = rand.Next(12, fr.Width / 2);
            dA.Y = rand.Next(12, fr.Height / 2);
            //Point dB
            dB.X = rand.Next(12, fr.Width / 2);
            dB.Y = rand.Next(12, fr.Height / 2);
            //Point dC
            dC.X = rand.Next(12, fr.Width / 2);
            dC.Y = rand.Next(12, fr.Height / 2);

            curvePoints[0].X = dA.X;
            curvePoints[0].Y = dA.Y;
            curvePoints[1].X = dB.X;
            curvePoints[1].Y = dB.Y;
            curvePoints[2].X = dC.X;
            curvePoints[2].Y = dC.Y;
            
            n = rand.Next(30, 50);
            m = rand.Next(30, 50);
            
            dx = rand.Next(-5, 5);
            dy = rand.Next(-5, 5);

            colorR = rand.Next(255);
            colorG = rand.Next(255);
            colorB = rand.Next(255);
            col = Color.FromArgb(255, colorR, colorG, colorB);
            
            curvePoints[0] = new Point();
            curvePoints[0].X = dA.X;
            curvePoints[0].Y = dA.Y;
            
            curvePoints[1] = new Point();
            curvePoints[1].X = dB.X;
            curvePoints[1].Y = dB.Y;
            
            curvePoints[2] = new Point();
            curvePoints[2].X = dC.X;
            curvePoints[2].Y = dC.Y;
            
            init(fr);
        }

        public void Run()
        {
            for (; ; )
            {
                Thread.Sleep(20);
                if (!running) continue;
                Move();
                fr.Invalidate();
            }
        }

        public void Draw()
        {
            for (; ; )
            {
                Thread.Sleep(20);
                if (!running) continue;
                Paint(fr);
                fr.Invalidate();
            }
        }

        public override void Paint(Form1 frn)
        {
            var gr = Graphics.FromImage(frn.pbMain.Image);
            gr.FillPolygon(brush, curvePoints);
            frn.pbMain.Invalidate();
        }

        public override void Move()
        {
            for (int k = 0; k < curvePoints.Length; k++)
            {
                
                if (curvePoints[k].X + m > fr.Width)
                {
                    dx = -Math.Abs(dx);
                }
                if (curvePoints[k].Y + n + 2 > fr.Height)
                {
                    dy = -Math.Abs(dy);
                }
                if (curvePoints[k].X < 0)
                {
                    dx = Math.Abs(dx);
                }
                if (curvePoints[k].Y < 0)
                {
                    dy = Math.Abs(dy);
                }
                curvePoints[k].X += dx;
                curvePoints[k].Y += dy;
           }
        }

        public void Sss()
        {
            if (!th.IsAlive) th.Start();
            running = true;
        }

        public void Stop()
        {
            running = false;
        }

        public void convert(figureSerialiaze obj, Form1 fr)
        {
            name = obj.name;
            
            curvePoints[0] = obj.dA;
            curvePoints[1] = obj.dB;
            curvePoints[2] = obj.dC;

            x = obj.x;
            y = obj.y;

            n = obj.n;
            m = obj.m;
            dx = obj.dx;
            dy = obj.dy;
            col = Color.FromArgb(255, obj.colorR, obj.colorG, obj.colorB); 
            init(fr);
        }

        private void init(Form1 fr)
        {
            this.fr = fr;
            Thread.Sleep(5);
            brush = new SolidBrush(col);
            running = false;

            i = 0;
            j = 0;

            th2 = new Thread(new ThreadStart(Draw));
            th = new Thread(new ThreadStart(Run));
        }
    }
}
