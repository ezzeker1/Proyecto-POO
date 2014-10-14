﻿using System;
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
         * Fecha de Inicio de la programación: 21/09/2014 02:40 AM
         */
        Permisos ObjPermisos = new Permisos();
        Usuarios ObjUsuarios = new Usuarios();
        //Instanciar los forms a Utilizar
        //EligeServicio ObjElige = new EligeServicio();
        PanelAdministrativo ObjPanelADm = new PanelAdministrativo();

        public Main()
        {
            InitializeComponent();
            ObjUsuarios.A_Usuario[0] = "admin";
            ObjUsuarios.A_Password[0] = "pass";
            ObjUsuarios.A_TUsuario[0] = 1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Todos los derechos reservados a Ezzeker", "Aviso del Autor");
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            string v_usuario ="", v_password = "";
            int v_resultado = 18;
            

            //Asignacion de datos a las variables
            v_usuario = txtUsuario.Text;
            v_password = txtPassword.Text;
            v_resultado = ObjPermisos.ObtenerPermiso(v_usuario, v_password, ObjUsuarios);
      
            //Determinar si tiene permisos para ingresar al sistema y para que form
            if (v_resultado == 2) {
          //  ObjElige.Show();
          //  this.Hide();
            }
            else if (v_resultado == 1) {
                ObjPanelADm.Show();
                this.Hide();
            }
            else
                MessageBox.Show("No puedes ingresar...", "Algo Salio mal Aqui...", 
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
