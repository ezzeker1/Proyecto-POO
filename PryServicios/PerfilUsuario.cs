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
    public partial class PerfilUsuario : Form
    {
        public PerfilUsuario()
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

        private void PerfilUsuario_Load(object sender, EventArgs e)
        {
            lblResUsuario.Text = vuser;
            int v_posicion = 0;

            v_posicion = Usuario.PosicionUsuario(lblResUsuario.Text);

            for (int i = 0; i <= Tarjeta.V_Contador; i++)
            {
                if (Tarjeta.A_usuario[i] == lblResUsuario.Text) {
                    CBSeleccion.Items.Add(Tarjeta.A_numero[i]);
                }
            }
                if (v_posicion > -1)
                {
                    lblResDUsuario.Text = Usuario.A_Usuario[v_posicion];
                    lblResNombres.Text = Usuario.A_Nombres[v_posicion];
                    lblResApellidos.Text = Usuario.A_Apellidos[v_posicion];
                    lblResTelefono.Text = Usuario.A_Telefono[v_posicion];
                    lblResEmail.Text = Usuario.A_Email[v_posicion];
                    lblResPregunta.Text = Usuario.A_PreguntaSecreta[v_posicion];
                    lblResEdad.Text = Usuario.A_Edad[v_posicion].ToString();
                }
          }

        private void CBSeleccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            for (int i = 0; i <= Tarjeta.V_Contador; i++) {
                if (CBSeleccion.Text == Tarjeta.A_numero[i])
                {
                    lblResTitular.Text = Tarjeta.A_Titular[i];
                    lblResVencimiento.Text = Tarjeta.A_Mes[i] + "/" + Tarjeta.A_Anio[i];
                    lblResproveedor.Text = Tarjeta.A_Proveedor[i];
                    lblResTipo.Text = Tarjeta.A_Tipo[i];
                }
            }

        }

        private void btnMUsuario_Click(object sender, EventArgs e)
        {
            ModificarUsuario ObjModificarUsuario = new ModificarUsuario();
            ObjModificarUsuario.vuser = lblResUsuario.Text;
            ObjModificarUsuario.Show();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            RegistrarMetodoPago ObjMetodoPago = new RegistrarMetodoPago();
            ObjMetodoPago.vuser = lblResUsuario.Text;
            ObjMetodoPago.Show();
        }

        private void btnMPago_Click(object sender, EventArgs e)
        {
            ModificarMetodoPago ObjMMetodoPago = new ModificarMetodoPago();
            ObjMMetodoPago.vuser = lblResUsuario.Text;
            ObjMMetodoPago.Show();
        }

        private void btnFRegistrar_Click(object sender, EventArgs e)
        {
            RegistrarInfoFacturacion OBjInfoFacturacion = new RegistrarInfoFacturacion();
            OBjInfoFacturacion.vuser = lblResUsuario.Text;
            OBjInfoFacturacion.Show();
        }

    }
}
