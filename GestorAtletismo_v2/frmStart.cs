using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorAtletismo_v2
{
    public partial class frmStart : Form
    {
        public frmStart()
        {
            InitializeComponent();

        }       

        private void frmStart_Load(object sender, EventArgs e)
        {
            if (this.MdiParent.Width > this.Width)
            {
                this.Location = new Point(Convert.ToInt32((this.MdiParent.Width - this.Width) / 2), this.Location.Y);
            }
            else
            {
                this.Location = new Point(0, this.Location.Y);
            }

            if (this.MdiParent.Height > this.Height)
            {
                this.Location = new Point(this.Location.X, Convert.ToInt32((this.MdiParent.Height - this.Height) / 2));
            }
            else
            {
                this.Location = new Point(this.Location.X, 0);
            }
        }

        private void btnAtletas_MouseHover(object sender, EventArgs e)
        {
            btnAtletas.Image = ((System.Drawing.Image)(Properties.Resources.athlete_hover));
        }

        private void btnAtletas_MouseLeave(object sender, EventArgs e)
        {
            btnAtletas.Image = ((System.Drawing.Image)(Properties.Resources.athlete_off));

        }

        private void btnAtletas_Click(object sender, EventArgs e)
        {
            frmAtleta Atleta = new frmAtleta();
            Atleta.MdiParent = this.MdiParent;
            this.Hide();
            Atleta.Show();
        }
    }
}
