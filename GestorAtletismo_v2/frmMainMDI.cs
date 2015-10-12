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
    public partial class frmMainMDI : Form
    {
        public frmMainMDI()
        {
            InitializeComponent();
        }

        private void frmMainMDI_Load(object sender, EventArgs e)
        {
            frmStart barra = new frmStart();
            barra.MdiParent = this;
            barra.Show();
        }

    }

}
