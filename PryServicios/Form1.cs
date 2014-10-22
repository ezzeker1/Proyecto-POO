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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            Usuario.A_Usuario[0] = "admin";
            Usuario.A_Password[0] = "pass";
            Usuario.A_Permisos[0] = 1;
            Usuario.A_Nombres[0] = "Bryan Omar";
            Usuario.A_Apellidos[0] = "Ramirez Chavez";
            Usuario.A_Telefono[0] = "989773746";
            Usuario.A_Email[0] = "bryan@ezzeker.com";
        }

        Usuario ObjUsuario = new Usuario();

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            RegistroUsuario ObjRegistrarUsuario = new RegistroUsuario();
            Administracion ObjAdministracion = new Administracion();

            string v_usuario = "";
            int v_resultado1 = 0, v_resultado2 =0;
          
            v_usuario = txtUsuario.Text.ToLower();
            v_resultado1 = ObjUsuario.ValidarSiExiste(v_usuario, txtPassword.Text);
            
            if (v_resultado1 == 1)
                {
                    v_resultado2 = ObjUsuario.ObtenerPermisos(v_usuario);
                    ObjAdministracion.Show();
                }
            else {
                MessageBox.Show("El usuario O password ingresado no es correcto", "Mensaje de ServiFull", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void btnAdministracion_Click(object sender, EventArgs e)
        {
            Administracion ObjAdministracion = new Administracion();

            ObjAdministracion.Show();
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            RestablecerPassword ObjRestablecer = new RestablecerPassword();
            ObjRestablecer.Show();
        }

        private void btnCrearusuario_Click(object sender, EventArgs e)
        {
            RegistroUsuario ObjRegistroU = new RegistroUsuario();

            ObjRegistroU.Show();
        }
    }
}
