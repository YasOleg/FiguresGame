namespace FiguresGame
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiXML = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiJSON = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiBIN = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiSOAP = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sOAPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEnglish = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRussian = new System.Windows.Forms.ToolStripMenuItem();
            this.gbPanel = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnTriangle = new System.Windows.Forms.Button();
            this.btnCirle = new System.Windows.Forms.Button();
            this.tbSelect = new System.Windows.Forms.TextBox();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.tvFigures = new System.Windows.Forms.TreeView();
            this.pbMain = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.gbPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuLanguage});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.BackColor = System.Drawing.Color.LimeGreen;
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSave,
            this.mnuOpen});
            this.mnuFile.Name = "mnuFile";
            resources.ApplyResources(this.mnuFile, "mnuFile");
            // 
            // mnuSave
            // 
            this.mnuSave.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiXML,
            this.TsmiJSON,
            this.TsmiBIN,
            this.TsmiSOAP});
            this.mnuSave.Name = "mnuSave";
            resources.ApplyResources(this.mnuSave, "mnuSave");
            this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
            // 
            // TsmiXML
            // 
            this.TsmiXML.Name = "TsmiXML";
            resources.ApplyResources(this.TsmiXML, "TsmiXML");
            this.TsmiXML.Click += new System.EventHandler(this.TsmiXML_Click);
            // 
            // TsmiJSON
            // 
            this.TsmiJSON.Name = "TsmiJSON";
            resources.ApplyResources(this.TsmiJSON, "TsmiJSON");
            this.TsmiJSON.Click += new System.EventHandler(this.TsmiJSON_Click);
            // 
            // TsmiBIN
            // 
            this.TsmiBIN.Name = "TsmiBIN";
            resources.ApplyResources(this.TsmiBIN, "TsmiBIN");
            this.TsmiBIN.Click += new System.EventHandler(this.TsmiBIN_Click);
            // 
            // TsmiSOAP
            // 
            this.TsmiSOAP.Name = "TsmiSOAP";
            resources.ApplyResources(this.TsmiSOAP, "TsmiSOAP");
            this.TsmiSOAP.Click += new System.EventHandler(this.TsmiSOAP_Click);
            // 
            // mnuOpen
            // 
            this.mnuOpen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xMLToolStripMenuItem,
            this.jSONToolStripMenuItem,
            this.bINToolStripMenuItem,
            this.sOAPToolStripMenuItem});
            this.mnuOpen.Name = "mnuOpen";
            resources.ApplyResources(this.mnuOpen, "mnuOpen");
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            resources.ApplyResources(this.xMLToolStripMenuItem, "xMLToolStripMenuItem");
            this.xMLToolStripMenuItem.Click += new System.EventHandler(this.xMLToolStripMenuItem_Click);
            // 
            // jSONToolStripMenuItem
            // 
            this.jSONToolStripMenuItem.Name = "jSONToolStripMenuItem";
            resources.ApplyResources(this.jSONToolStripMenuItem, "jSONToolStripMenuItem");
            this.jSONToolStripMenuItem.Click += new System.EventHandler(this.jSONToolStripMenuItem_Click);
            // 
            // bINToolStripMenuItem
            // 
            this.bINToolStripMenuItem.Name = "bINToolStripMenuItem";
            resources.ApplyResources(this.bINToolStripMenuItem, "bINToolStripMenuItem");
            this.bINToolStripMenuItem.Click += new System.EventHandler(this.bINToolStripMenuItem_Click);
            // 
            // sOAPToolStripMenuItem
            // 
            this.sOAPToolStripMenuItem.Name = "sOAPToolStripMenuItem";
            resources.ApplyResources(this.sOAPToolStripMenuItem, "sOAPToolStripMenuItem");
            this.sOAPToolStripMenuItem.Click += new System.EventHandler(this.sOAPToolStripMenuItem_Click);
            // 
            // mnuLanguage
            // 
            this.mnuLanguage.BackColor = System.Drawing.Color.LimeGreen;
            this.mnuLanguage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEnglish,
            this.mnuRussian});
            this.mnuLanguage.Name = "mnuLanguage";
            resources.ApplyResources(this.mnuLanguage, "mnuLanguage");
            // 
            // mnuEnglish
            // 
            this.mnuEnglish.Name = "mnuEnglish";
            resources.ApplyResources(this.mnuEnglish, "mnuEnglish");
            this.mnuEnglish.Click += new System.EventHandler(this.mnuEnglish_Click);
            // 
            // mnuRussian
            // 
            this.mnuRussian.Name = "mnuRussian";
            resources.ApplyResources(this.mnuRussian, "mnuRussian");
            this.mnuRussian.Click += new System.EventHandler(this.mnuRussian_Click);
            // 
            // gbPanel
            // 
            resources.ApplyResources(this.gbPanel, "gbPanel");
            this.gbPanel.BackColor = System.Drawing.SystemColors.GrayText;
            this.gbPanel.Controls.Add(this.btnStop);
            this.gbPanel.Controls.Add(this.btnStart);
            this.gbPanel.Controls.Add(this.btnTriangle);
            this.gbPanel.Controls.Add(this.btnCirle);
            this.gbPanel.Controls.Add(this.tbSelect);
            this.gbPanel.Controls.Add(this.btnRectangle);
            this.gbPanel.ForeColor = System.Drawing.Color.LimeGreen;
            this.gbPanel.Name = "gbPanel";
            this.gbPanel.TabStop = false;
            // 
            // btnStop
            // 
            resources.ApplyResources(this.btnStop, "btnStop");
            this.btnStop.ForeColor = System.Drawing.Color.LightYellow;
            this.btnStop.Name = "btnStop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            resources.ApplyResources(this.btnStart, "btnStart");
            this.btnStart.ForeColor = System.Drawing.Color.LightYellow;
            this.btnStart.Name = "btnStart";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnTriangle
            // 
            resources.ApplyResources(this.btnTriangle, "btnTriangle");
            this.btnTriangle.ForeColor = System.Drawing.Color.LightYellow;
            this.btnTriangle.Name = "btnTriangle";
            this.btnTriangle.UseVisualStyleBackColor = true;
            this.btnTriangle.Click += new System.EventHandler(this.btnTriangle_Click);
            // 
            // btnCirle
            // 
            resources.ApplyResources(this.btnCirle, "btnCirle");
            this.btnCirle.ForeColor = System.Drawing.Color.LightYellow;
            this.btnCirle.Name = "btnCirle";
            this.btnCirle.UseVisualStyleBackColor = true;
            this.btnCirle.Click += new System.EventHandler(this.btnCirle_Click);
            // 
            // tbSelect
            // 
            resources.ApplyResources(this.tbSelect, "tbSelect");
            this.tbSelect.ForeColor = System.Drawing.Color.LimeGreen;
            this.tbSelect.Name = "tbSelect";
            // 
            // btnRectangle
            // 
            resources.ApplyResources(this.btnRectangle, "btnRectangle");
            this.btnRectangle.ForeColor = System.Drawing.Color.LightYellow;
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.UseVisualStyleBackColor = true;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // tvFigures
            // 
            this.tvFigures.BackColor = System.Drawing.SystemColors.GrayText;
            resources.ApplyResources(this.tvFigures, "tvFigures");
            this.tvFigures.Name = "tvFigures";
            this.tvFigures.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            ((System.Windows.Forms.TreeNode)(resources.GetObject("tvFigures.Nodes")))});
            // 
            // pbMain
            // 
            resources.ApplyResources(this.pbMain, "pbMain");
            this.pbMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbMain.Name = "pbMain";
            this.pbMain.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.pbMain);
            this.Controls.Add(this.tvFigures);
            this.Controls.Add(this.gbPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbPanel.ResumeLayout(false);
            this.gbPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.ToolStripMenuItem mnuOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuLanguage;
        private System.Windows.Forms.ToolStripMenuItem mnuEnglish;
        private System.Windows.Forms.ToolStripMenuItem mnuRussian;
        private System.Windows.Forms.GroupBox gbPanel;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnTriangle;
        private System.Windows.Forms.Button btnCirle;
        private System.Windows.Forms.TextBox tbSelect;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.TreeView tvFigures;
        public System.Windows.Forms.PictureBox pbMain;
        private System.Windows.Forms.ToolStripMenuItem TsmiXML;
        private System.Windows.Forms.ToolStripMenuItem TsmiJSON;
        private System.Windows.Forms.ToolStripMenuItem TsmiBIN;
        private System.Windows.Forms.ToolStripMenuItem TsmiSOAP;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jSONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sOAPToolStripMenuItem;
        private System.Windows.Forms.Timer timer2;
        public System.Windows.Forms.Timer timer1;
    }
}

