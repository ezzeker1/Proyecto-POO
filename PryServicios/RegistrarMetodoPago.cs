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
    public partial class RegistrarMetodoPago : Form
    {
        public RegistrarMetodoPago()
        {
            InitializeComponent();
        }

        private string _user;

        //Metodos GET y SET para Obtener el Usuario
        public string vuser
        {
            get { return _user; }
            set { _user = value; }
        }

        private void RegistrarMetodoPago_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = vuser;
            CBTipo.Items.Add("Debito");
            CBTipo.Items.Add("Credito");
            CBProveedor.Items.Add("Visa");
            CBProveedor.Items.Add("American Express");
            CBProveedor.Items.Add("MasterCard");
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Tarjeta.A_Anio[Tarjeta.V_Contador] = txtAnio.Text;
            Tarjeta.A_Mes[Tarjeta.V_Contador] = txtMes.Text;
            Tarjeta.A_numero[Tarjeta.V_Contador] = txtNTarjeta.Text;
            Tarjeta.A_Proveedor[Tarjeta.V_Contador] = CBProveedor.Text;
            Tarjeta.A_Tipo[Tarjeta.V_Contador] = CBTipo.Text;
            Tarjeta.A_usuario[Tarjeta.V_Contador] = lblUsuario.Text;
            Tarjeta.A_Titular[Tarjeta.V_Contador] = txtTitular.Text;
            Tarjeta.V_Contador++;
           
            MessageBox.Show("Se registro la tarjeta con N° " + txtNTarjeta.Text + " Como metodo de pago", 
                             "Mensaje de SeviFull", MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.Close();
        }

       
    }
}