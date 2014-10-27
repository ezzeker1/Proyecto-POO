using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryServicios
{
    public partial class RegistrarInfoFacturacion : Form
    {
        public RegistrarInfoFacturacion()
        {
            InitializeComponent();
        }

        private string _user;

        //Metodos GET y SET para Obtener el Usuario
        public string vuser
        {
            get { return _user; }
            set { _user = value; }
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            lblResUsuario.Text = vuser;
        }
    }
}
