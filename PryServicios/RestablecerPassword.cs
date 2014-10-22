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
            
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            string v_respuesta = "";


            if (txtReingresarNuevaPass.Text == txtRespuestaSecreta.Text)
            {
                v_respuesta = txtRespuestaSecreta.Text.ToLower();
                
            }
            else
                MessageBox.Show("Las contraseñas ingresadas no coinciden", "Mensaje de ServiFull", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
    }
}
