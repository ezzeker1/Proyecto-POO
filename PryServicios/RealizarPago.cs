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
    public partial class RealizarPago : Form
    {
        public RealizarPago()
        {
            InitializeComponent();
        }
        private string _user;
        private int _ID;

        //Metodos GET y SET para Obtener el Usuario
        public string vuser
        {
            get { return _user; }
            set { _user = value; }
        }
        public int vID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        private void btnConfirmarCompra_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Se adquirio el Item " + lblitem.Text + " Por un monto de " + lblResValorCompra.Text);
        }

        private void GBInfodeCompra_Enter(object sender, EventArgs e)
        {

        }

        private void RealizarPago_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Tarjeta.V_Contador; i++) {
                if (Tarjeta.A_usuario[i] == lblResUsuario.Text){
                CBTarjetaCredito.Items.Add(Tarjeta.A_numero[i]);
                }
            }
        }
    }
}
