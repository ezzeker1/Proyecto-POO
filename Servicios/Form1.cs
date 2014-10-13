using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Servicios
{
    public partial class Main : Form
    {
        /*
         * Vamos a Hardcodear lo menos posible e investigar funciones adicionales para este proyecto.
         * Fecha de Inicio de la programación: 21/09/2014 02:40 AM
         */
        Permisos ObjPermisos = new Permisos();
        public Main()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Todos los derechos reservados a Ezzeker", "Aviso del Autor");
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            string v_usuario ="", v_password = "";
            int v_resultado = 0;
            EligeServicio ObjElige = new EligeServicio();
            PanelAdministrativo ObjPanelADm = new PanelAdministrativo();

            v_usuario = txtUsuario.Text;
            v_password = txtPassword.Text;

            v_resultado = ObjPermisos.ValidarPermisos(v_usuario, v_password);
            /*
             * 2 = Acceso al panel de Usuario.
             * 3 = Acceso al Panel Administrativo.
             * 1 = No tiene Acceso a la aplicación.
             */
            if (v_resultado == 2) {
            ObjElige.Show();
            this.Hide();
            }
            else if (v_resultado == 3) {
                ObjPanelADm.Show();
                this.Hide();
            }
            else
                MessageBox.Show("No puedes ingresar...", "Algo Salio mal Aqui...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
