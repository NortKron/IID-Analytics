namespace IIDA.View
{
    partial class Form_ManagerConnections
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_SQL = new System.Windows.Forms.RadioButton();
            this.radioButton_MDF = new System.Windows.Forms.RadioButton();
            this.radioButton_ACS = new System.Windows.Forms.RadioButton();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.Tab_MDF = new System.Windows.Forms.TabPage();
            this.button_OpenDialog1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Tab_Access = new System.Windows.Forms.TabPage();
            this.button_OpenDialog2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Tab_SQL = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.button_OK = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Test = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.Tab_MDF.SuspendLayout();
            this.Tab_Access.SuspendLayout();
            this.Tab_SQL.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_SQL);
            this.groupBox1.Controls.Add(this.radioButton_MDF);
            this.groupBox1.Controls.Add(this.radioButton_ACS);
            this.groupBox1.Location = new System.Drawing.Point(4, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(729, 114);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Источник данных";
            // 
            // radioButton_SQL
            // 
            this.radioButton_SQL.AutoSize = true;
            this.radioButton_SQL.Enabled = false;
            this.radioButton_SQL.Location = new System.Drawing.Point(39, 86);
            this.radioButton_SQL.Name = "radioButton_SQL";
            this.radioButton_SQL.Size = new System.Drawing.Size(95, 21);
            this.radioButton_SQL.TabIndex = 2;
            this.radioButton_SQL.TabStop = true;
            this.radioButton_SQL.Text = "SQL Server";
            this.radioButton_SQL.UseVisualStyleBackColor = true;
            this.radioButton_SQL.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // radioButton_MDF
            // 
            this.radioButton_MDF.AutoSize = true;
            this.radioButton_MDF.Checked = true;
            this.radioButton_MDF.Location = new System.Drawing.Point(39, 26);
            this.radioButton_MDF.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton_MDF.Name = "radioButton_MDF";
            this.radioButton_MDF.Size = new System.Drawing.Size(152, 21);
            this.radioButton_MDF.TabIndex = 0;
            this.radioButton_MDF.TabStop = true;
            this.radioButton_MDF.Text = "SQL localDB (*.MDF)";
            this.radioButton_MDF.UseVisualStyleBackColor = true;
            this.radioButton_MDF.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // radioButton_ACS
            // 
            this.radioButton_ACS.AutoSize = true;
            this.radioButton_ACS.Location = new System.Drawing.Point(39, 56);
            this.radioButton_ACS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton_ACS.Name = "radioButton_ACS";
            this.radioButton_ACS.Size = new System.Drawing.Size(152, 21);
            this.radioButton_ACS.TabIndex = 1;
            this.radioButton_ACS.Text = "MS Access (*.accdb)";
            this.radioButton_ACS.UseVisualStyleBackColor = true;
            this.radioButton_ACS.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // TabControl
            // 
            this.TabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.TabControl.Controls.Add(this.Tab_MDF);
            this.TabControl.Controls.Add(this.Tab_Access);
            this.TabControl.Controls.Add(this.Tab_SQL);
            this.TabControl.ItemSize = new System.Drawing.Size(0, 1);
            this.TabControl.Location = new System.Drawing.Point(0, 135);
            this.TabControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(737, 270);
            this.TabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabControl.TabIndex = 1;
            this.TabControl.TabStop = false;
            // 
            // Tab_MDF
            // 
            this.Tab_MDF.Controls.Add(this.button_OpenDialog1);
            this.Tab_MDF.Controls.Add(this.label1);
            this.Tab_MDF.Controls.Add(this.textBox1);
            this.Tab_MDF.Location = new System.Drawing.Point(4, 5);
            this.Tab_MDF.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Tab_MDF.Name = "Tab_MDF";
            this.Tab_MDF.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Tab_MDF.Size = new System.Drawing.Size(729, 261);
            this.Tab_MDF.TabIndex = 0;
            this.Tab_MDF.Text = "File MDF";
            // 
            // button_OpenDialog1
            // 
            this.button_OpenDialog1.Location = new System.Drawing.Point(285, 51);
            this.button_OpenDialog1.Name = "button_OpenDialog1";
            this.button_OpenDialog1.Size = new System.Drawing.Size(25, 25);
            this.button_OpenDialog1.TabIndex = 2;
            this.button_OpenDialog1.Text = "/";
            this.button_OpenDialog1.UseVisualStyleBackColor = true;
            this.button_OpenDialog1.Click += new System.EventHandler(this.button_OpenDialog_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Путь к файлу MDF";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(35, 51);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(245, 24);
            this.textBox1.TabIndex = 0;
            // 
            // Tab_Access
            // 
            this.Tab_Access.Controls.Add(this.button_OpenDialog2);
            this.Tab_Access.Controls.Add(this.label3);
            this.Tab_Access.Controls.Add(this.textBox2);
            this.Tab_Access.Location = new System.Drawing.Point(4, 5);
            this.Tab_Access.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Tab_Access.Name = "Tab_Access";
            this.Tab_Access.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Tab_Access.Size = new System.Drawing.Size(729, 261);
            this.Tab_Access.TabIndex = 1;
            this.Tab_Access.Text = "File MS Access";
            // 
            // button_OpenDialog2
            // 
            this.button_OpenDialog2.Location = new System.Drawing.Point(285, 51);
            this.button_OpenDialog2.Name = "button_OpenDialog2";
            this.button_OpenDialog2.Size = new System.Drawing.Size(25, 25);
            this.button_OpenDialog2.TabIndex = 5;
            this.button_OpenDialog2.Text = "/";
            this.button_OpenDialog2.UseVisualStyleBackColor = true;
            this.button_OpenDialog2.Click += new System.EventHandler(this.button_OpenDialog_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Путь к файлу MS Access";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(35, 51);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(245, 24);
            this.textBox2.TabIndex = 3;
            // 
            // Tab_SQL
            // 
            this.Tab_SQL.Controls.Add(this.label2);
            this.Tab_SQL.Location = new System.Drawing.Point(4, 5);
            this.Tab_SQL.Name = "Tab_SQL";
            this.Tab_SQL.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_SQL.Size = new System.Drawing.Size(729, 261);
            this.Tab_SQL.TabIndex = 2;
            this.Tab_SQL.Text = "SQL Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Настройки подключения к  SQK серверу";
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(534, 411);
            this.button_OK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(95, 34);
            this.button_OK.TabIndex = 3;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(638, 411);
            this.button_Cancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(95, 34);
            this.button_Cancel.TabIndex = 4;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_Test
            // 
            this.button_Test.Location = new System.Drawing.Point(4, 411);
            this.button_Test.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Test.Name = "button_Test";
            this.button_Test.Size = new System.Drawing.Size(145, 34);
            this.button_Test.TabIndex = 5;
            this.button_Test.Text = "Test connection";
            this.button_Test.UseVisualStyleBackColor = true;
            this.button_Test.Click += new System.EventHandler(this.button_Test_Click);
            // 
            // Form_ManagerConnections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 455);
            this.Controls.Add(this.button_Test);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_ManagerConnections";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager Connections";
            this.Load += new System.EventHandler(this.Form_ManagerConnections_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_ManagerConnections_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.TabControl.ResumeLayout(false);
            this.Tab_MDF.ResumeLayout(false);
            this.Tab_MDF.PerformLayout();
            this.Tab_Access.ResumeLayout(false);
            this.Tab_Access.PerformLayout();
            this.Tab_SQL.ResumeLayout(false);
            this.Tab_SQL.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_MDF;
        private System.Windows.Forms.RadioButton radioButton_ACS;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage Tab_MDF;
        private System.Windows.Forms.TabPage Tab_Access;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_OpenDialog1;
        private System.Windows.Forms.RadioButton radioButton_SQL;
        private System.Windows.Forms.TabPage Tab_SQL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_OpenDialog2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button_Test;
    }
}