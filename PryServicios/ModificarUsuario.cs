﻿using System;
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
    public partial class ModificarUsuario : Form
    {
        public ModificarUsuario()
        {
            InitializeComponent();
            lblMUsuario.Hide();
        }

        private string _user;
        private int v_posicion = 0;
        //Metodos GET y SET para Obtener el Usuario
        public string vuser
        {
            get { return _user; }
            set { _user = value; }
        }

        private void ModificarUsuario_Load(object sender, EventArgs e)
        {
            lblMUsuario.Text = vuser;

            for (int i = 0; i <= Usuario.V_Contador; i++)
            {
                if (lblMUsuario.Text == Usuario.A_Usuario[i])
                {
                    v_posicion = i;
                    txtApellidos.Text = Usuario.A_Apellidos[i];
                    txtEdad.Text = Usuario.A_Edad[i].ToString();
                    txtEmail.Text = Usuario.A_Email[i];
                    txtNombres.Text = Usuario.A_Nombres[i];
                    txtPassword.Text = Usuario.A_Password[i];
                    txtRespuesta.Text = Usuario.A_PreguntaSecreta[i];
                    txtTelefonos.Text = Usuario.A_Telefono[i];
                    txtUsuairo.Text = Usuario.A_Usuario[i];
                }
            }
            }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            Usuario.A_Usuario[v_posicion] = txtUsuairo.Text;
            Usuario.A_Apellidos[v_posicion] = txtApellidos.Text;
            Usuario.A_Edad[v_posicion] = Int32.Parse(txtEdad.Text);
            Usuario.A_Email[v_posicion] = txtEmail.Text;
            Usuario.A_Nombres[v_posicion] = txtNombres.Text;
            Usuario.A_Password[v_posicion] = txtPassword.Text;
            Usuario.A_PreguntaSecreta[v_posicion] = txtRespuesta.Text;
            Usuario.A_Telefono[v_posicion] = txtTelefonos.Text;

            MessageBox.Show("Se guardaron todos los cambios", "Mensaje de ServiFull", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
           
        }


    }

