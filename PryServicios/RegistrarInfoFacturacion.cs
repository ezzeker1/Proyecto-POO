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
            string v_resultado = "";
            lblResUsuario.Text = vuser;
            //string p_predeterminado, string p_ntarjeta, string p_pais, string p_departamento, string p_provincia,string p_distrito, string p_direccion)

            v_resultado = InfoFacturacion.ValidarInfoFacturacion(CBPredeterminado.Text, CBNTarjeta.Text, CBPais.Text, CBDepartamento.Text, CBProvincia.Text, CBDistrito.Text,
                txtDireccion.Text);
            if (v_resultado == "0")
            {
                InfoFacturacion.A_Departamento[InfoFacturacion.V_Contador] = 
            }
        }
    }
}
