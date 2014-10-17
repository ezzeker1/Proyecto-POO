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
        Main ObjMain = new Main();

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
            for (int i = 0; i < ObjMain.v_contador; i++)
            {
                DGUsuarios.Rows.Add(ObjMain.A_Usuario[i], ObjMain.A_TUsuario[i], ObjMain.A_Nombre[i],
                                ObjMain.A_ApellidoP[i], ObjMain.A_ApellidoM[i], ObjMain.A_Password[i],
                                ObjMain.A_Email[i], ObjMain.A_Telefono[i]);
            }
            DGUsuarios.Show();}

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MostrarUsuarios();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            
        }
        public void RegistrarUsuario(int p_tusuario,string p_usuario ,string p_password,string p_nombre, 
                                     string p_apellidop,string p_apellidom, string p_telefono, string p_email ){
                    
            ObjUsuarios.RegistrarUsuarios(p_usuario, p_nombre, p_apellidop, p_apellidom, 
                                          p_password, p_email, p_telefono, p_tusuario);
        }
        private void PanelAdministrativo_Load(object sender, EventArgs e)
        {

        }
    }
}
