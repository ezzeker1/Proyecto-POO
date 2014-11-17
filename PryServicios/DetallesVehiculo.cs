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
    public partial class DetallesVehiculo : Form
    {
        public DetallesVehiculo()
        {
            InitializeComponent();
            if (Int32.Parse(lblID.Text) == 0)
            {
                PBVehiculo.Image = PryServicios.Properties.Resources.R8;
            }
            else if (Int32.Parse(lblID.Text) == 1)
            {
                PBVehiculo.Image = PryServicios.Properties.Resources.bmw6;
            }
            else if (Int32.Parse(lblID.Text) == 2)
            {
                PBVehiculo.Image = PryServicios.Properties.Resources.Mercedez;
            }
            else if (Int32.Parse(lblID.Text) == 2)
            {
                PBVehiculo.Image = PryServicios.Properties.Resources.Rio;
            }
            else if (Int32.Parse(lblID.Text) == 2)
            {
                PBVehiculo.Image = PryServicios.Properties.Resources.Yaris;
            }
            else if (Int32.Parse(lblID.Text) == 2)
            {
                PBVehiculo.Image = PryServicios.Properties.Resources.Ninja;
            }
            else if (Int32.Parse(lblID.Text) == 2)
            {
                PBVehiculo.Image = PryServicios.Properties.Resources.A7;
            }
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


        private void btnComprar_Click(object sender, EventArgs e)
        {
            RealizarPago ObjRealizarPago = new RealizarPago();
            ObjRealizarPago.vuser = lblResUsuario.Text;
            ObjRealizarPago.vID = Int32.Parse(lblID.Text);

        }

        private void DetallesVehiculo_Load(object sender, EventArgs e)
        {
            
            lblResUsuario.Text = vuser;
            lblID.Text = vID.ToString();
            lblResCondicion.Text = Vehiculo.A_Condicion[_ID];
            lblResKilometraje.Text = Vehiculo.A_Kilometraje[_ID].ToString();
            lblresMarca.Text = Vehiculo.A_Marca[_ID];
            lblResprecio.Text = Vehiculo.A_Precio[_ID].ToString();
            lblModelo.Text = Vehiculo.A_Modelo[_ID];

        }
    }
}
