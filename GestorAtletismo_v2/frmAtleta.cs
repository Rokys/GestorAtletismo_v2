using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace GestorAtletismo_v2
{
    public partial class frmAtleta : Form
    {
        public frmAtleta()
        {
            InitializeComponent();
        }

        private void frmAtleta_Load(object sender, EventArgs e)
        {

            tbAtletas listanomes = new tbAtletas.getNomes();

            try
            {
                using (SQLiteConnection gatlDBconn = new SQLiteConnection("data source=C:\\Users\\Mario Lima\\Documents\\Visual Studio 2015\\Projects\\GestorAtletismo_v2\\GestorAtletismo_v2\\gestatl.db3"))
                {
                    using (SQLiteCommand comando = new SQLiteCommand())
                    {
                        comando.Connection = gatlDBconn;
                        gatlDBconn.Open();

                        SQLiteHelper sh = new SQLiteHelper(comando);

                        DataTable Atletas = sh.Select("SELECT nome_atleta FROM atleta ORDER BY nome_atleta;");

                        foreach (DataRow linha in Atletas.Rows)
                        {
                            foreach (var campo in linha.ItemArray)
                            {
                                lstboxAtletas.Items.Add(campo.ToString());
                            }
                        }

                    }

                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro.ToString());
            }

        }
    }
}
