namespace GestorAtletismo_v2
{
    partial class frmAtleta
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
            this.lstboxAtletas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstboxAtletas
            // 
            this.lstboxAtletas.FormattingEnabled = true;
            this.lstboxAtletas.Location = new System.Drawing.Point(12, 12);
            this.lstboxAtletas.Name = "lstboxAtletas";
            this.lstboxAtletas.Size = new System.Drawing.Size(120, 290);
            this.lstboxAtletas.TabIndex = 0;
            // 
            // frmAtleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 315);
            this.Controls.Add(this.lstboxAtletas);
            this.Name = "frmAtleta";
            this.Text = "frmAtleta";
            this.Load += new System.EventHandler(this.frmAtleta_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstboxAtletas;
    }
}