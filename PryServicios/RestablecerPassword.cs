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
    public partial class RestablecerPassword : Form
    {
        public RestablecerPassword()
        {
            InitializeComponent();
            btnRestablecer.Hide();
            lblNuevaPass.Hide();
            lblReingresarPass.Hide();
            txtNuevaPass.Hide();
            txtReingresarNuevaPass.Hide();
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            string v_respuesta = "";

            v_respuesta = txtRespuestaSecreta.Text;

            for (int i = 0; i < Usuario.V_Contador; i++){
                 if(v_respuesta == Usuario.A_PreguntaSecreta[i]){
                     if (txtReingresarNuevaPass.Text == txtNuevaPass.Text)
                     {
                         Usuario.A_Password[i] = txtNuevaPass.Text;
                         
                     }
                     else
                     {
                         MessageBox.Show("Las contraseñas ingresadas no coinciden", "Mensaje de ServiFull", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                     }
                     break;
                 }
            }
            
        }

        private void txtReingresarNuevaPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNuevaPass_Click(object sender, EventArgs e)
        {

        }

        private void txtNuevaPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblReingresarPass_Click(object sender, EventArgs e)
        {

        }

        private void BtnValidar_Click(object sender, EventArgs e)
        {
            string v_respuesta = "";
            int v_edad = 0;

            v_respuesta = txtRespuestaSecreta.Text;
            v_edad = Int32.Parse(txtEdad.Text);

            for (int i = 0; i < Usuario.V_Contador; i++)
            {
                if (v_respuesta == Usuario.A_PreguntaSecreta[i] && v_edad == Usuario.A_Edad[i])
                {
                   
                  Usuario.A_Password[i] = txtNuevaPass.Text;
                  break;
                }
                
                else {
                    MessageBox.Show("Los datos ingresados son erroneos, deben de ser correctos para proceder", 
                                    "Mensaje de Serviful", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
