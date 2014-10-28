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
    public partial class ModificarMetodoPago : Form
    {
        public ModificarMetodoPago()
        {
            InitializeComponent();
            CBTipo.Items.Add("Debito");
            CBTipo.Items.Add("Credito");
            CBProveedor.Items.Add("Visa");
            CBProveedor.Items.Add("American Express");
            CBProveedor.Items.Add("MasterCard");
        }

        int v_posicion = 0;
        private string _user;

        //Metodos GET y SET para Obtener el Usuario
        public string vuser
        {
            get { return _user; }
            set { _user = value; }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        { 
            Tarjeta.A_Anio[v_posicion] = txtResAnio.Text;
            Tarjeta.A_Mes[v_posicion] = txtResMes.Text;
            Tarjeta.A_numero[v_posicion] = CBNTarjeta.Text;
            Tarjeta.A_Proveedor[v_posicion] = CBProveedor.Text;
            Tarjeta.A_Tipo[v_posicion] = CBTipo.Text;
            Tarjeta.A_Titular[v_posicion] = txtResTitular.Text;

            MessageBox.Show("Se Guardaron los cambios para la tarjeta", "Mensaje de Servifull", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ModificarMetodoPago_Load(object sender, EventArgs e)
        {
            lblResUsuario.Text = vuser;
            for (int i = 0; i <= Tarjeta.V_Contador; i++)
            {
                if (Tarjeta.A_usuario[i] == lblResUsuario.Text)
                {
                    CBNTarjeta.Items.Add(Tarjeta.A_numero[i]);
                }
            }
        }

        private void CBNTarjeta_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i <= Tarjeta.V_Contador; i++)
            {
                if (CBNTarjeta.Text == Tarjeta.A_numero[i])
                {
                    v_posicion = i;

                    if(Tarjeta.A_Titular[i] == "Credito"){
                        CBTipo.SelectedIndex = 1;
                    }
                    else if (Tarjeta.A_Tipo[i] == "Debito")
                    {
                        CBTipo.SelectedIndex = 0;
                    }
                    if(Tarjeta.A_Proveedor[i] == "Visa"){
                        CBProveedor.SelectedIndex = 0;
                    }
                    else if (Tarjeta.A_Proveedor[i] == "American Express"){
                        CBProveedor.SelectedIndex = 1;
                    }
                    else if (Tarjeta.A_Proveedor[i] == "MasterCard")
                    {
                        CBProveedor.SelectedIndex = 2;               
                    }
                    txtResAnio.Text = Tarjeta.A_Anio[i];
                    txtResMes.Text = Tarjeta.A_Mes[i];
                    txtResTitular.Text = Tarjeta.A_Titular[i];
                }
            }
        }
    }
}
