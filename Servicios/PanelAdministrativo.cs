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
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            RegistrarUsuario F_RUsuario = new RegistrarUsuario();
            F_RUsuario.Show();
        }

        public void MostrarUsuarios() {
            //Manipular el DataGrill
            DGUsuarios.Rows.Clear();
            for (int i = 0; i < ObjUsuarios.v_contador; i++) { 
            DGUsuarios.Rows.Add(ObjUsuarios.A_Usuario[i],ObjUsuarios.A_TUsuario[i],ObjUsuarios.A_Nombre[i],
                                ObjUsuarios.A_ApellidoP[i],ObjUsuarios.A_ApellidoM[i],ObjUsuarios.A_Password[i],
                                ObjUsuarios.A_Email[i],ObjUsuarios.A_Telefono[i]); }
            DGUsuarios.Show();}

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MostrarUsuarios();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            
        }

        private void PanelAdministrativo_Load(object sender, EventArgs e)
        {

        }
    }
}
