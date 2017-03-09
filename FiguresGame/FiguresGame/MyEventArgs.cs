using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;

namespace FiguresGame
{
    public delegate void MyCollision();
    
    public abstract class MyEventArgs 
    {
        public static bool Collisian = false;
        public event MyCollision MyEventCollision;
    }
 }