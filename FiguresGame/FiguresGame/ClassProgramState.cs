using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;




   namespace FiguresGame
   {
   [Serializable]  public  class ClassProgramState
     {
       [SoapElement] public  string selectLengtch = "en-GB";
       [NonSerialized] public List<figureSerialiaze> listfigure = new List<figureSerialiaze>();
       [SoapElement] public  figureSerialiaze[] array ;

   public ClassProgramState()
       {
           
       }
       
   public void covert()
        {
            array = new figureSerialiaze[listfigure.Count];
            for (int i = 0; i < listfigure.Count; i++)
            {
                array[i] = listfigure.ElementAt(i);
            }
        }
   }
    
   [Serializable] public class figureSerialiaze
    {
           [SoapElement] public string name;
           [SoapElement] public int x, y;
           [SoapElement] public int n, m;
           [SoapElement] public int dx, dy;
            
           [SoapElement] public int colorR;
           [SoapElement] public int colorG;
           [SoapElement] public int colorB;
            
           [SoapElement] public Point dA;
           [SoapElement] public Point dB;
           [SoapElement] public Point dC;

   public figureSerialiaze()
    {
        
    }

    public  figureSerialiaze(ClassFigures obj)
        {
                name = obj.name;
        
                dA = obj.dA;
                dB = obj.dB;
                dC = obj.dC;

                y = obj.y;
                n = obj.n;
                x = obj.x;
                m = obj.m;
                dx = obj.dx;
                dy = obj.dy;
                colorR = obj.colorR;
                colorG= obj.colorG;
                colorB = obj.colorB;
        }
    }
}