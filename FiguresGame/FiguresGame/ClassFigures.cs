using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;


namespace FiguresGame
{
    public class ClassFigures : MyEventArgs
    {
        public event MyCollision MyEventCollision;

        public Thread th;
        public Thread th2;

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
        
        public string name;
        public int x;
        public int y;
        public int n, m;
        public int dx, dy;
        public int i, j;
        public bool running;

        public Point dA = new Point();
        public Point dB = new Point();
        public Point dC = new Point();
        

        public int colorR;
        public int colorG;
        public int colorB;
        
        public static Form1 fr;
        public Process instance;

        public static bool flag = false;

        public static int Counter;
       
        public ClassFigures()
        {
            
        }
        
        public virtual void Paint(Form1 fr)
        {

        }

        public virtual void Move()
        {
            
        }

        public void detectCollision(List<ClassFigures> list)
        {
            for (int k = 0; k < list.Count; k++)
            {
                if (flag == true)
                {
                    Collisian = true;
                    Counter++;
                }
                
                if (this != list[k])
                {
                   if ((list.ElementAt(k) is ClassRectangle) && (this is ClassRectangle) && (this!=list.ElementAt(k)))
                    {
                        if ((this.x >= list[k].x) && (this.x <= (list[k].x + list[k].m))
                            && (this.y >= list[k].y) &&
                            (this.y <= (list[k].y + list[k].n))) { flag = true; } // КОЛЛИЗИЯ точка А

                        else if (((this.x + this.m) >= list[k].x) &&
                                 ((this.x + this.m) <= (list[k].x + list[k].m))
                                 && ((this.y + this.n) >= list[k].y) &&
                                 ((this.y + this.n) <= (list[k].y + list[k].n))) { flag = true; } // КОЛЛИЗИЯ точка В

                        else if (((this.x + this.m) >= list[k].x) &&
                                 ((this.x + this.m) <= (list[k].x + list[k].m))
                                 && (this.y >= list[k].y) &&
                                 (this.y <= (list[k].y + list[k].n))) { flag = true; } // КОЛЛИЗИЯ точка С

                        else if ((this.x >= list[k].x) &&
                                 (this.x <= (list[k].x + list[k].m))
                                 && ((this.y + this.n) >= list[k].y) &&
                                 ((this.y + this.n) <= (list[k].y + list[k].n))) { flag = true; } // КОЛЛИЗИЯ точка D
                     }

                   if (Collisian == true)
                   {
                       if (MyEventCollision != null) MyEventCollision();
                   }
                }
            }
        }
    }
  }