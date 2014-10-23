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
    public partial class Vehiculos : Form
    {
        public Vehiculos()
        {
            InitializeComponent();
            CBCondicion.Items.Add("Nuevo");
            CBCondicion.Items.Add("Usado");
            CBKilometraje.Items.Add("0");
            CBKilometraje.Items.Add("1 a 5000");
            CBKilometraje.Items.Add("5001 a 10000");
            CBKilometraje.Items.Add("10001 a 50000");
            CBMarca.Items.Add("BMW");
            CBMarca.Items.Add("Audi");
            CBMarca.Items.Add("Mercedes Benz");
            CBMarca.Items.Add("Volvo");
            CBMarca.Items.Add("Kia");
            CBMarca.Items.Add("Toyota");
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void CBMarca_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CBMarca.SelectedIndex.ToString() ==  "Audi"){
                CBModelo.Items.Add("R8");
                CBModelo.Items.Add("A4");
                CBModelo.Items.Add("A5");
                CBModelo.Items.Add("A6");
            }
            else if (CBMarca.SelectedIndex.ToString() == "BMW"){
                CBModelo.Items.Add("DFT");

            }
            }
    }
}
