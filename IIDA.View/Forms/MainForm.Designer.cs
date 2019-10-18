namespace IIDA.View
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MainMenu_File = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu_OpenProject = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu_CreateProject = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu_Windows = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu_ProjectManager = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu_TableFeatures = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu_Map = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu_Calcs = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu_Reports = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu_GetHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu_Web = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu_About = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.tabControl_Main = new System.Windows.Forms.TabControl();
            this.tabPage_Main = new System.Windows.Forms.TabPage();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabControl_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            resources.ApplyResources(this.toolStripStatusLabel1, "toolStripStatusLabel1");
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenu_File,
            this.MainMenu_Windows,
            this.MainMenu_Help});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // MainMenu_File
            // 
            this.MainMenu_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenu_OpenProject,
            this.MainMenu_CreateProject,
            this.MainMenu_Exit});
            this.MainMenu_File.Name = "MainMenu_File";
            resources.ApplyResources(this.MainMenu_File, "MainMenu_File");
            // 
            // MainMenu_OpenProject
            // 
            this.MainMenu_OpenProject.Name = "MainMenu_OpenProject";
            resources.ApplyResources(this.MainMenu_OpenProject, "MainMenu_OpenProject");
            // 
            // MainMenu_CreateProject
            // 
            this.MainMenu_CreateProject.Name = "MainMenu_CreateProject";
            resources.ApplyResources(this.MainMenu_CreateProject, "MainMenu_CreateProject");
            // 
            // MainMenu_Exit
            // 
            this.MainMenu_Exit.Name = "MainMenu_Exit";
            resources.ApplyResources(this.MainMenu_Exit, "MainMenu_Exit");
            // 
            // MainMenu_Windows
            // 
            this.MainMenu_Windows.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenu_ProjectManager,
            this.MainMenu_TableFeatures,
            this.MainMenu_Map,
            this.MainMenu_Calcs,
            this.MainMenu_Reports});
            this.MainMenu_Windows.Name = "MainMenu_Windows";
            resources.ApplyResources(this.MainMenu_Windows, "MainMenu_Windows");
            // 
            // MainMenu_ProjectManager
            // 
            this.MainMenu_ProjectManager.Name = "MainMenu_ProjectManager";
            resources.ApplyResources(this.MainMenu_ProjectManager, "MainMenu_ProjectManager");
            this.MainMenu_ProjectManager.Click += new System.EventHandler(this.MainMenu_ProjectManager_Click);
            // 
            // MainMenu_TableFeatures
            // 
            this.MainMenu_TableFeatures.Name = "MainMenu_TableFeatures";
            resources.ApplyResources(this.MainMenu_TableFeatures, "MainMenu_TableFeatures");
            this.MainMenu_TableFeatures.Click += new System.EventHandler(this.MainMenu_Table_Click);
            // 
            // MainMenu_Map
            // 
            this.MainMenu_Map.Name = "MainMenu_Map";
            resources.ApplyResources(this.MainMenu_Map, "MainMenu_Map");
            this.MainMenu_Map.Click += new System.EventHandler(this.MainMenu_Map_Click);
            // 
            // MainMenu_Calcs
            // 
            this.MainMenu_Calcs.Name = "MainMenu_Calcs";
            resources.ApplyResources(this.MainMenu_Calcs, "MainMenu_Calcs");
            this.MainMenu_Calcs.Click += new System.EventHandler(this.MainMenu_Calcs_Click);
            // 
            // MainMenu_Reports
            // 
            this.MainMenu_Reports.Name = "MainMenu_Reports";
            resources.ApplyResources(this.MainMenu_Reports, "MainMenu_Reports");
            this.MainMenu_Reports.Click += new System.EventHandler(this.MainMenu_Report_Click);
            // 
            // MainMenu_Help
            // 
            this.MainMenu_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenu_GetHelp,
            this.MainMenu_Web,
            this.MainMenu_About});
            this.MainMenu_Help.Name = "MainMenu_Help";
            resources.ApplyResources(this.MainMenu_Help, "MainMenu_Help");
            // 
            // MainMenu_GetHelp
            // 
            this.MainMenu_GetHelp.Name = "MainMenu_GetHelp";
            resources.ApplyResources(this.MainMenu_GetHelp, "MainMenu_GetHelp");
            // 
            // MainMenu_Web
            // 
            this.MainMenu_Web.Name = "MainMenu_Web";
            resources.ApplyResources(this.MainMenu_Web, "MainMenu_Web");
            // 
            // MainMenu_About
            // 
            this.MainMenu_About.Name = "MainMenu_About";
            resources.ApplyResources(this.MainMenu_About, "MainMenu_About");
            this.MainMenu_About.Click += new System.EventHandler(this.MainMenu_About_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripButton6});
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.Name = "toolStrip1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.toolStripButton2, "toolStripButton2");
            this.toolStripButton2.Name = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.toolStripButton3, "toolStripButton3");
            this.toolStripButton3.Name = "toolStripButton3";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.toolStripButton4, "toolStripButton4");
            this.toolStripButton4.Name = "toolStripButton4";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.toolStripButton5, "toolStripButton5");
            this.toolStripButton5.Name = "toolStripButton5";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.toolStripButton6, "toolStripButton6");
            this.toolStripButton6.Name = "toolStripButton6";
            // 
            // tabControl_Main
            // 
            this.tabControl_Main.Controls.Add(this.tabPage_Main);
            resources.ApplyResources(this.tabControl_Main, "tabControl_Main");
            this.tabControl_Main.Name = "tabControl_Main";
            this.tabControl_Main.SelectedIndex = 0;
            // 
            // tabPage_Main
            // 
            resources.ApplyResources(this.tabPage_Main, "tabPage_Main");
            this.tabPage_Main.Name = "tabPage_Main";
            this.tabPage_Main.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl_Main);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl_Main.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MainMenu_File;
        private System.Windows.Forms.ToolStripMenuItem MainMenu_OpenProject;
        private System.Windows.Forms.ToolStripMenuItem MainMenu_Windows;
        private System.Windows.Forms.ToolStripMenuItem MainMenu_Help;
        private System.Windows.Forms.ToolStripMenuItem MainMenu_CreateProject;
        private System.Windows.Forms.ToolStripMenuItem MainMenu_Exit;
        private System.Windows.Forms.ToolStripMenuItem MainMenu_ProjectManager;
        private System.Windows.Forms.ToolStripMenuItem MainMenu_TableFeatures;
        private System.Windows.Forms.ToolStripMenuItem MainMenu_Map;
        private System.Windows.Forms.ToolStripMenuItem MainMenu_Calcs;
        private System.Windows.Forms.ToolStripMenuItem MainMenu_Reports;
        private System.Windows.Forms.ToolStripMenuItem MainMenu_GetHelp;
        private System.Windows.Forms.ToolStripMenuItem MainMenu_Web;
        private System.Windows.Forms.ToolStripMenuItem MainMenu_About;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.TabControl tabControl_Main;
        private System.Windows.Forms.TabPage tabPage_Main;
    }
}

