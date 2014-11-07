namespace AdvocateDigitalDiary
{
    partial class frmCaseType
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
            this.SuspendLayout();
            // 
            // frmCaseType
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "frmCaseType";
            this.Load += new System.EventHandler(this.frmCaseType_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel sslabelCaseType;
        private System.Windows.Forms.TextBox txtCaeTypeDescription;
        private System.Windows.Forms.Button btnCaseTypeCancle;
        private System.Windows.Forms.Button btnSaveCaseType;
        private System.Windows.Forms.Label lblCaseTypeDescription;
        private System.Windows.Forms.TextBox txtCaseTypeName;
        private System.Windows.Forms.Label lblCaseTypeName;


    }
}