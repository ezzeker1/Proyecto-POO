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
    public partial class RegistroUsuario : Form
    {
        public RegistroUsuario()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string v_usuario = "";
            int v_resultado = 0;

            v_usuario = txtUsuairo.Text.ToLower();
            
           // Usuario ObjUsuario = new Usuario();
            for (int i = 0; i < Usuario.V_Contador; i++ ){
                if (Usuario.A_Usuario[i] == v_usuario)
                {
                    v_resultado = 1;
                }
                else v_resultado = 2;
            }
            if (v_resultado == 2)
            {
                Usuario.A_Usuario[Usuario.V_Contador] = txtUsuairo.Text;
                Usuario.A_Password[Usuario.V_Contador] = txtPassword.Text;
                Usuario.A_Nombres[Usuario.V_Contador] = txtNombres.Text;
                Usuario.A_Apellidos[Usuario.V_Contador] = txtApellidos.Text;
                Usuario.A_Telefono[Usuario.V_Contador] = txtTelefonos.Text;
                Usuario.A_Edad[Usuario.V_Contador] = Int32.Parse(txtEdad.Text);
                Usuario.A_PreguntaSecreta[Usuario.V_Contador] = txtRespuesta.Text;
                Usuario.V_Contador++;
            }
            else MessageBox.Show("El usuario " + v_usuario + " Ya se encuentra registrado en el sitema", 
                                 "Mensaje de ServiFull", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void RegistroUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
