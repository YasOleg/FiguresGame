using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Threading;
using System.IO;
using System.Globalization;
using System.Resources;
using System.Reflection;
using System.Diagnostics;
using System.Runtime.InteropServices;



namespace FiguresGame
{
   public partial class Form1 : Form
    {
        public Form1()
        {
           InitializeComponent();
        }

        public List<ClassFigures> figure = new List<ClassFigures>();
        public static ClassFigures FIG = new ClassFigures();
        ClassProgramState programstate = new ClassProgramState();
       
        private void Form1_Paint()
        {
            for (int i  = 0; i < figure.Count; i++)
            {
                figure.ElementAt(i).Paint(this);
            }
        }
       
        private void Form1_FormClosing()
        {
            for (int i = 0; i < figure.Count; i++)
            {
                figure.ElementAt(i).Th.Abort();
                figure.ElementAt(i).Th2.Abort();
            }
        }

       #region EVENT HANDLER
       public void HandlerEvent()
       {
           if (ClassFigures.Counter == 1)
           {
             FIG.instance = Process.Start(
             "C:\\Documents\\Visual Studio 2013\\Projects\\ConsoleCollision\\ConsoleCollision\\bin\\Debug\\ConsoleCollision.exe");
             FIG.instance.WaitForExit();
             timer1.Stop();
           }
       }
#endregion

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #region Control Buttons
        private void btnCirle_Click(object sender, EventArgs e)
        {
            tbSelect.Text = "Circle";
            MessageBox.Show("Circle selected", "Attantion!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClassCircle cc = new ClassCircle(this);
            cc.name = "Circle";
            cc.MyEventCollision += new MyCollision(HandlerEvent);
            figure.Add(cc);
            for (int i = 0; i < figure.Count; i++)
            {
                figure.ElementAt(i).detectCollision(figure);
                figure.ElementAt(i).Paint(this);
            }
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            tbSelect.Text = "Triangle";
            MessageBox.Show("Triangle selected", "Attantion!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClassTriangle tt = new ClassTriangle(this);
            tt.name = "Triangle";
            tt.MyEventCollision += new MyCollision(HandlerEvent);
            figure.Add(tt);
            for (int i = 0; i < figure.Count; i++)
            {
                figure.ElementAt(i).detectCollision(figure);
                figure.ElementAt(i).Paint(this);
            }
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            tbSelect.Text = "Rectangle";
            MessageBox.Show("Rectangle selected", "Attantion!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClassRectangle rr = new ClassRectangle(this);
            rr.name = "Rectangle";
            rr.MyEventCollision += new MyCollision(HandlerEvent);
            figure.Add(rr);
           for (int i = 0; i < figure.Count; i++)
            {
              figure.ElementAt(i).detectCollision(figure);
              figure.ElementAt(i).Paint(this);
            }
        }

       

        private void btnStart_Click(object sender, EventArgs e)
        {
            
            timer1.Start();

            ClassFigures.flag = false;
            ClassFigures.Collisian = false;
            ClassFigures.Counter = 0;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
#endregion


        #region Timers

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (figure.Count > 0)
            {
                var gr = Graphics.FromImage(pbMain.Image);
                gr.Clear(Color.Snow);
                for (int i = 0; i < figure.Count; i++)
                {
                    figure[i].Move();
                    figure[i].Paint(this); 
                    figure.ElementAt(i).detectCollision(figure);
                }
            }
        }

       private void timer2_Tick(object sender, EventArgs e)
        {

        }
        #endregion


        #region Change language
        private void ChangeLanguage(string newLanguageString)
        {
            var resources = new ComponentResourceManager(typeof (Form1));
            CultureInfo newCultureInfo = new CultureInfo(newLanguageString);
           
            //Применяем для каждого контрола на форме новую культуру
            foreach (Control c in this.Controls)
            {
                resources.ApplyResources(c, c.Name, newCultureInfo);
            }
            foreach (Control x in this.gbPanel.Controls)
            {
                resources.ApplyResources(x, x.Name, newCultureInfo);
            }
           
            foreach (ToolStripMenuItem y in this.menuStrip1.Items)
            {
                 resources.ApplyResources(y, y.Name, newCultureInfo);
            }
            foreach (ToolStripMenuItem y in this.mnuFile.DropDownItems)
            {
                resources.ApplyResources(y, y.Name, newCultureInfo);
            }
            foreach (ToolStripMenuItem y in this.mnuLanguage.DropDownItems)
            {
                resources.ApplyResources(y, y.Name, newCultureInfo);
            }
        }
        private void mnuEnglish_Click(object sender, EventArgs e)
        {
            ChangeLanguage("en-GB");
            programstate.selectLengtch = "en-GB";
        }

        private void mnuRussian_Click(object sender, EventArgs e)
        {
            ChangeLanguage("ru-RU");
            programstate.selectLengtch = "ru-RU";
        }
#endregion


        #region Save/Open figures

        private void mnuSave_Click(object sender, EventArgs e)
        {

        }

        private void TsmiXML_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < figure.Count; i++)
            {
                programstate.listfigure.Add(new figureSerialiaze(figure.ElementAt(i)));
            }
                ClassSerialiaze.SerialiazeToXml<ClassProgramState>(programstate, "testXML.xml");
                MessageBox.Show("Figures are save", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void TsmiJSON_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < figure.Count; i++)
            {
                programstate.listfigure.Add(new figureSerialiaze(figure.ElementAt(i)));
            }
            programstate.covert();
                ClassSerialiaze.SerialiazeToJson<ClassProgramState>(programstate, "testJSON.json");
                MessageBox.Show("Figures are save", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void TsmiBIN_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < figure.Count; i++)
            {
                programstate.listfigure.Add(new figureSerialiaze(figure.ElementAt(i)));
            }
            programstate.covert();
            ClassSerialiaze.SerialiazeToBIN<ClassProgramState>(programstate, "testBIN.bin");
            MessageBox.Show("Figures are save", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void TsmiSOAP_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < figure.Count; i++)
            {
                programstate.listfigure.Add(new figureSerialiaze(figure.ElementAt(i)));
            }
            programstate.covert();
            ClassSerialiaze.SerialiazeToSoap<ClassProgramState>(programstate, "testSOAP.soap");
            MessageBox.Show("Figures are save", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
 
        }

        private void xMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassProgramState temp = new ClassProgramState();
            ClassSerialiaze.DeserializationFromXml<ClassProgramState>(ref temp, "testXML.xml");
            for (int i = 0; i < temp.listfigure.Count; i++)
            {
                if (temp.listfigure[i].name == "Circle")
                {
                    ClassCircle cc = new ClassCircle();
                    cc.convert(temp.listfigure[i],this); 
                    figure.Add(cc);
                }
                else if (temp.listfigure[i].name == "Rectangle")
                {
                    ClassRectangle rr = new ClassRectangle();
                    rr.convert(temp.listfigure[i], this);
                    figure.Add(rr);
                }
                else if (temp.listfigure[i].name == "Triangle")
                {
                    ClassTriangle tt = new ClassTriangle();
                    tt.convert(temp.listfigure[i], this);
                    figure.Add(tt);
                }

            }
            for (int i = 0; i < figure.Count; i++)
            {
                figure.ElementAt(i).Paint(this);
            }
         }

        private void jSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassProgramState temp = new ClassProgramState();
            ClassSerialiaze.DeserializationFromJson<ClassProgramState>(ref temp, "testJSON.json");
            for (int i = 0; i < temp.array.Count(); i++)
            {
                if (temp.array[i].name == "Circle")
                {
                    ClassCircle cc = new ClassCircle();
                    cc.convert(temp.array[i], this);
                    figure.Add(cc);
                }
                else if (temp.array[i].name == "Rectangle")
                {
                    ClassRectangle rr = new ClassRectangle();
                    rr.convert(temp.array[i], this);
                    figure.Add(rr);
                }
                else if (temp.array[i].name == "Triangle")
                {
                    ClassTriangle tt = new ClassTriangle();
                    tt.convert(temp.array[i], this);
                    figure.Add(tt);
                }
            }
            for (int i = 0; i < figure.Count; i++)
            {
                figure.ElementAt(i).Paint(this);
            }
        }

        private void bINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassProgramState temp = new ClassProgramState();
            ClassSerialiaze.DeserializationFromBIN<ClassProgramState>(ref temp, "testBIN.bin");
            for (var i = 0; i < temp.array.Count(); i++)
            {
                if (temp.array[i].name == "Circle")
                {
                    ClassCircle cc = new ClassCircle();
                    cc.convert(temp.array[i], this); 
                    figure.Add(cc);
                }
                else if (temp.array[i].name == "Rectangle")
                {
                    ClassRectangle rr = new ClassRectangle();
                    rr.convert(temp.array[i], this);
                    figure.Add(rr);
                }
                else if (temp.array[i].name == "Triangle")
                {
                    ClassTriangle tt = new ClassTriangle();
                    tt.convert(temp.array[i], this);
                    figure.Add(tt);
                }
            }
            for (int i = 0; i < figure.Count; i++)
            {
                figure.ElementAt(i).Paint(this);
            }
        }

        private void sOAPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassProgramState temp1 = new ClassProgramState();
            ClassSerialiaze.DeserializationFromSoap<ClassProgramState>(ref temp1, "testSOAP.soap");
            for (var k = 0; k < temp1.array.Count(); k++)
            {
                if (temp1.array[k].name == "Circle")
                {
                    ClassCircle cc = new ClassCircle();
                    cc.convert(temp1.array[k], this);
                    figure.Add(cc);
                }
                else if (temp1.array[k].name == "Rectangle")
                {
                    ClassRectangle rr = new ClassRectangle();
                    rr.convert(temp1.array[k], this);
                    figure.Add(rr);
                }
                else if (temp1.array[k].name == "Triangle")
                {
                    ClassTriangle tt = new ClassTriangle();
                    tt.convert(temp1.array[k], this);
                    figure.Add(tt);
                }
            }
            for (int i = 0; i < figure.Count; i++)
            {
                figure.ElementAt(i).Paint(this);
            }
        }

        #endregion
    }
 }