namespace GestorAtletismo_v2
{
    partial class frmStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStart));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.imglistIcones = new System.Windows.Forms.ImageList(this.components);
            this.btnAtletas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(110, 9);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 101);
            this.button1.TabIndex = 1;
            this.button1.Text = "Treinos";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(211, 9);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 101);
            this.button2.TabIndex = 2;
            this.button2.Text = "Planeamento";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(312, 9);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 101);
            this.button3.TabIndex = 3;
            this.button3.Text = "Marcas";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(413, 9);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(101, 101);
            this.button4.TabIndex = 4;
            this.button4.Text = "Analise";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // imglistIcones
            // 
            this.imglistIcones.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglistIcones.ImageStream")));
            this.imglistIcones.TransparentColor = System.Drawing.Color.Transparent;
            this.imglistIcones.Images.SetKeyName(0, "athlete_hover.png");
            this.imglistIcones.Images.SetKeyName(1, "athlete_off.png");
            // 
            // btnAtletas
            // 
            this.btnAtletas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAtletas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtletas.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtletas.Image = global::GestorAtletismo_v2.Properties.Resources.athlete_off;
            this.btnAtletas.Location = new System.Drawing.Point(9, 9);
            this.btnAtletas.Margin = new System.Windows.Forms.Padding(0);
            this.btnAtletas.Name = "btnAtletas";
            this.btnAtletas.Size = new System.Drawing.Size(101, 101);
            this.btnAtletas.TabIndex = 0;
            this.btnAtletas.Text = "Atletas";
            this.btnAtletas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAtletas.UseVisualStyleBackColor = true;
            this.btnAtletas.Click += new System.EventHandler(this.btnAtletas_Click);
            this.btnAtletas.MouseLeave += new System.EventHandler(this.btnAtletas_MouseLeave);
            this.btnAtletas.MouseHover += new System.EventHandler(this.btnAtletas_MouseHover);
            // 
            // frmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 119);
            this.ControlBox = false;
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAtletas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStart";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmStart_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAtletas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ImageList imglistIcones;
    }
}