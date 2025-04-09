using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGuadalupeLunaGestionInventario
{
    public partial class frmGestion : Form
    {
        public frmGestion()
        {
            InitializeComponent();
        }
        clsConexionBD bd = new clsConexionBD();

        private void frmGestion_Load(object sender, EventArgs e)
        {
            //mostrar
            bd.listarInventario(dgvInventario);
        }

    }
}
