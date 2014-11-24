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
    public partial class RealizarPago : Form
    {
        public RealizarPago()
        {
            InitializeComponent();
           
        }
        private string _user;
        private int _ID;

        //Metodos GET y SET para Obtener el Usuario
        public string vuser
        {
            get { return _user; }
            set { _user = value; }
        }
        public int vID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        private void btnConfirmarCompra_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(txtMonto.Text) >= Vehiculo.A_Precio[vID])
            {
                Adquisiciones ObjAdquisiciones = new Adquisiciones();
                ObjAdquisiciones.RegistrarAdquisicion(vID, "Vehiculo", lblitem.Text, Int32.Parse(lblResValorCompra.Text), DateTime.Now, lblResUsuario.Text);
                
                MessageBox.Show("Se adquirio el Item '" + lblitem.Text + "' Por un monto de  USD" + lblResValorCompra.Text);
                
                Recibo ObjRecibo =new Recibo();
                ObjRecibo.RegistrarRecibo(vID, lblResUsuario.Text, lblResValorCompra.Text, lblResValorCompra.Text);

                this.Close();
            }
            else MessageBox.Show("Fondos insuficientes para cubrir el precio del Vehiculo","Mensaje de ServiFull",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void GBInfodeCompra_Enter(object sender, EventArgs e)
        {

        }

        private void RealizarPago_Load(object sender, EventArgs e)
        {
            lblResUsuario.Text = vuser;
            for (int i = 0; i < Tarjeta.V_Contador; i++)
            {
                if (Tarjeta.A_usuario[i] == lblResUsuario.Text)
                {
                    CBTarjetaCredito.Items.Add(Tarjeta.A_numero[i]);
                }
            }

            lblResValorCompra.Text = Vehiculo.A_Precio[vID].ToString();
            lblitem.Text = Vehiculo.A_Marca[vID].ToString() + " - " + Vehiculo.A_Modelo[vID].ToString() + " - " + Vehiculo.A_Anio[vID].ToString();
          
        }
        

        private void CBTarjetaCredito_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < Tarjeta.V_Contador; i++){
                if (CBTarjetaCredito.Text == Tarjeta.A_numero[i]) {
                    lblResNumero.Text = Tarjeta.A_numero[i];
                    lblResTarjeta.Text = Tarjeta.A_Proveedor[i];
                    lblResTipo.Text = Tarjeta.A_Tipo[i];
                    lblResVencimiento.Text = Tarjeta.A_Anio[i].ToString() + "/" + Tarjeta.A_Mes[i].ToString();
                }
        }}
    }
}
