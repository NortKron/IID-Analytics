namespace IIDA.View
{
    partial class Form_TableFeatures
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_TableFeatures));            
            this.tablitcaosobennosteiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tablitcaosobennosteiBindingSource)).BeginInit();
            this.SuspendLayout();
            
            // 
            // Form_TableFeatures
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "Form_TableFeatures";
            this.Load += new System.EventHandler(this.Form_TableFeatures_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablitcaosobennosteiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
                
        private System.Windows.Forms.BindingSource tablitcaosobennosteiBindingSource;        
    }
}