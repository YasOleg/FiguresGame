using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;


namespace FiguresGame
{
    public class ClassRectangle : ClassFigures
    {
        public bool Running
        {
            get { return running; }
            set { running = value; }
        }
        Color col;
        Brush brush;

        Thread th; Thread th2;
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

        Form1 fr;
        Random rand = new Random();
        
        public ClassRectangle()
        {

        }
        
        public ClassRectangle(Form1 fr)
        {
            this.fr = fr;
            x = rand.Next(1, fr.Width);
            y = rand.Next(1, fr.Height);
            Thread.Sleep(5);
            n = rand.Next(30, 50);
            m = rand.Next(30, 50);
            dx = rand.Next(-5, 5);
            dy = rand.Next(-5, 5);
            colorR = rand.Next(255);
            colorG = rand.Next(255);
            colorB = rand.Next(255);
            col = Color.FromArgb(255, colorR, colorG, colorB);

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
            gr.FillRectangle(brush, (int)x, (int)y, (int)m, (int)n);
            frn.pbMain.Invalidate();
        }

        public override void Move()
        {
            if (x + m > fr.Width)
            {
                dx = -Math.Abs(dx);
            }
            if (y + n + 2 > fr.Height)
            {
                dy = -Math.Abs(dy);
            }
            if (x < 0)
            {
                dx = Math.Abs(dx);
            }
            if (y < 0)
            {
                dy = Math.Abs(dy);
            }
            x += dx;
            y += dy;
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