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
    public partial class Inmuebles : Form
    {
        public Inmuebles()
        {
            InitializeComponent();
        }

        private void Inmuebles_Load(object sender, EventArgs e)
        {
            Inmueble objInmueble = new Inmueble();

            objInmueble.RegistrarInmueble(30, "Departamento", 0, 457812, "Si", "Av. salaverry 111", "San isidro");
            objInmueble.RegistrarInmueble(31, "Departamento", 0, 850000, "Si", "Jr. Olmos 345", "La Molina");
            objInmueble.RegistrarInmueble(32, "Departamento", 5, 150000, "No", "Av. Space 222", "Surco");
            objInmueble.RegistrarInmueble(33, "Oficina", 2, 200000, "Si", "Av. Naranjas 111", "Ate");
            objInmueble.RegistrarInmueble(34, "Casa", 0, 1500000, "Si", "Av. Almendras 111", "Lurin");
            objInmueble.RegistrarInmueble(35, "Casa", 4, 457812, "No", "Av. Fresas 111", "Chosica");
            objInmueble.RegistrarInmueble(36, "Terreno", 5, 900000, "No", "Av. Frutales 444", "Lurigancho");
            objInmueble.RegistrarInmueble(37, "Oficina", 5, 800000, "Si", "Av. ASD 321", "San Borja");

            for (int i = 0; i < Inmueble.v_contador; i++){
                cbDistrito.Items.Add(Inmueble.a_Distrito[i]);
                
            }
            
        }
    }
}
