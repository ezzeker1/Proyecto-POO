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
    public partial class PanelAdministrativo : Form
    {
        //Creamos la Instancia
        Usuarios ObjUsuarios = new Usuarios();
        Permisos ObjPermisos = new Permisos();

        public PanelAdministrativo()
        {
            InitializeComponent();
            DGUsuarios.Hide();
            ObjUsuarios.A_Nombre[0] = "admin";
            ObjUsuarios.A_Password[0] = "pass";
            CBTUsuario.Items.Add("Administrador");
            CBTUsuario.Items.Add("Usuario");
            CBTUsuario.Items.Add("Proveedor");
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {

            // ==============================================================================
            //Variables a las que se le asignara los valores ingresados por el operario
            String v_nombre = "", v_apellidoP = "", v_ApellidoM = "", v_Password = "", v_email = "", v_telefono ="";
            int v_t_usuario = 0;
            // ==============================================================================


            //Asignacion de los valores
            v_nombre = txtPANombre.Text;
            v_apellidoP = txtPAApellidoP.Text;
            v_ApellidoM = txtPAApellidoM.Text;
            v_email = txtPAEmail.Text;
            v_Password = txtPAPassword.Text;
            v_t_usuario = ObjPermisos.Decodificar(CBTUsuario.Items.ToString()); // Devuelve el Valor que representa al permiso seleccionado
            // ==============================================================================
           
            //Utilizar el objeto y agregar datos y Aumenta el contador del Array.
            ObjUsuarios.ConstructorUsuarios(v_nombre,
                v_apellidoP,
                v_ApellidoM,
                v_Password,
                v_email,
                v_t_usuario);
            ObjUsuarios.RegistrarUsuarios(
                v_nombre,
                v_apellidoP,
                v_ApellidoM,
                v_Password,
                v_email,
                v_telefono,
                v_t_usuario);
            
            // ==============================================================================
           
           
        }
        public void MostrarUsuarios() {
            //Manipular el DataGrill
            DGUsuarios.Rows.Clear();
         //   MessageBox.Show(ObjUsuarios.TamanioArray().ToString());
            for (int i = 0; i < ObjUsuarios.v_contador; i++) { 
            DGUsuarios.Rows.Add(ObjUsuarios.A_TUsuario[i],ObjUsuarios.A_Nombre[i],ObjUsuarios.A_ApellidoP[i],
                                ObjUsuarios.A_ApellidoM[i],ObjUsuarios.A_Password[i],ObjUsuarios.A_Email[i], 
                                ObjUsuarios.A_Telefono[i]); }
                //for (int i = 0; i <= v_contador - 1; i++){
                //    DGUsuarios.Rows.Add(
                //        ObjAUsuarios[i].v_t_Usurio,
                //        ObjAUsuarios[i].v_usuario,
                //        ObjAUsuarios[i].v_apellidoP,
                //        ObjAUsuarios[i].v_ApellidoM,
                //        ObjAUsuarios[i].v_password,
                //        ObjAUsuarios[i].v_Email
                //        );}
                DGUsuarios.Show();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MostrarUsuarios();
        }
    }
}
