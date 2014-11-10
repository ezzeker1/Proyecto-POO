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
            
            ////Cargar tipos de vehiculos
            //CBTVehiculo.Items.Add("Auto");
            //CBTVehiculo.Items.Add("Moto");

            ////Año
            //CBAnio.Items.Add(2014);
            //CBAnio.Items.Add(2013);

            ////Cargar condicion
            //CBCondicion.Items.Add("Nuevo");
            //CBCondicion.Items.Add("Usado");

            //Cargar Vehiculo
            // Vehiculo 0
            Vehiculo.A_Anio[0] = 2013;
            Vehiculo.A_Kilometraje[0] = 0;
            Vehiculo.A_Marca[0] = "Audi";
            Vehiculo.A_Modelo[0] = "R8";
            Vehiculo.A_Precio[0] = 250000;
            Vehiculo.A_modena[0] = "Dolares";
            Vehiculo.A_TVehiculo[0] = "Auto";
            Vehiculo.A_ID[0] = 0;
            Vehiculo.A_Condicion[0] = "Nuevo";


            // Vehiculo 1
            Vehiculo.A_Anio[1] = 2014;
            Vehiculo.A_Kilometraje[1] = 0;
            Vehiculo.A_Marca[1] = "BMW";
            Vehiculo.A_Modelo[1] = "X6";
            Vehiculo.A_Precio[1] = 132000;
            Vehiculo.A_modena[1] = "Soles";
            Vehiculo.A_TVehiculo[1] = "Auto";
            Vehiculo.A_ID[1] = 1;
            Vehiculo.A_Condicion[1] = "Nuevo";

            // Vehiculo 2
            Vehiculo.A_Anio[2] = 2011;
            Vehiculo.A_Kilometraje[2] = 0;
            Vehiculo.A_Marca[2] = "Mercedez";
            Vehiculo.A_Modelo[2] = "AMG";
            Vehiculo.A_Precio[2] = 150000;
            Vehiculo.A_modena[2] = "Dolares";
            Vehiculo.A_TVehiculo[2] = "Auto";
            Vehiculo.A_ID[2] = 2;
            Vehiculo.A_Condicion[2] = "Nuevo";

            // Vehiculo 3
            Vehiculo.A_Anio[3] = 2014;
            Vehiculo.A_Kilometraje[3] = 0;
            Vehiculo.A_Marca[3] = "Kia";
            Vehiculo.A_Modelo[3] = "Rio";
            Vehiculo.A_Precio[3] = 14000;
            Vehiculo.A_modena[3] = "Dolares";
            Vehiculo.A_TVehiculo[3] = "Auto";
            Vehiculo.A_ID[3] = 3;
            Vehiculo.A_Condicion[3] = "Nuevo";

            // Vehiculo 4
            Vehiculo.A_Anio[4] = 2011;
            Vehiculo.A_Kilometraje[4] = 50000;
            Vehiculo.A_Marca[4] = "Toyota";
            Vehiculo.A_Modelo[4] = "Yaris";
            Vehiculo.A_Precio[4] = 25000;
            Vehiculo.A_modena[4] = "Soles";
            Vehiculo.A_TVehiculo[4] = "Auto";
            Vehiculo.A_ID[4] = 4;
            Vehiculo.A_Condicion[4] = "Usado";

            // Vehiculo 5
            Vehiculo.A_Anio[5] = 2012;
            Vehiculo.A_Kilometraje[5] = 0;
            Vehiculo.A_Marca[5] = "Honda";
            Vehiculo.A_Modelo[5] = "CBR 250";
            Vehiculo.A_Precio[5] = 14000;
            Vehiculo.A_modena[5] = "Soles";
            Vehiculo.A_TVehiculo[5] = "Moto";
            Vehiculo.A_ID[5] = 5;
            Vehiculo.A_Condicion[5] = "Nuevo";

            // Vehiculo 6
            Vehiculo.A_Anio[6] = 2012;
            Vehiculo.A_Kilometraje[6] = 15000;
            Vehiculo.A_Marca[6] = "Kawasaki";
            Vehiculo.A_Modelo[6] = "Ninja";
            Vehiculo.A_Precio[6] = 11000;
            Vehiculo.A_modena[6] = "Dolares";
            Vehiculo.A_TVehiculo[6] = "Moto";
            Vehiculo.A_ID[6] = 6;
            Vehiculo.A_Condicion[6] = "Usado";

            // Vehiculo 7
            Vehiculo.A_Anio[7] = 2013;
            Vehiculo.A_Kilometraje[7] = 0;
            Vehiculo.A_Marca[7] = "Audi";
            Vehiculo.A_Modelo[7] = "A7";
            Vehiculo.A_Precio[7] = 75000;
            Vehiculo.A_modena[7] = "Dolares";
            Vehiculo.A_TVehiculo[7] = "Auto";
            Vehiculo.A_ID[7] = 7;
            Vehiculo.A_Condicion[7] = "Nuevo";
        }
        private string _user;

        //Metodos GET y SET para Obtener el Usuario
        public string vuser
        {
            get { return _user; }
            set { _user = value; }
        }

         private void Vehiculos_Load(object sender, EventArgs e)
        {
            lblResUsuario.Text = vuser;
        }

         private void CBTVehiculo_SelectedIndexChanged(object sender, EventArgs e)
         {
             //if (CBTVehiculo.Text == "Auto") {
                
             //    CBMarca.Items.Add("Audi");
             //    CBMarca.Items.Add("BMW");
             //    CBMarca.Items.Add("Mercedez");
               
             //}
             //else if (CBTVehiculo.Text == "Moto") {

             //    CBMarca.Items.Add("Honda");
             //    CBMarca.Items.Add("Kawazaki");
             //    CBMarca.Items.Add("Ronco");
             //}

             for (int i = 0; i<= Vehiculo.v_contador; i++){
                 if (Vehiculo.A_TVehiculo[i] == CBTVehiculo.Text){
                     DGVehiculos.Rows.Add(Vehiculo.A_ID[i], Vehiculo.A_TVehiculo[i], Vehiculo.A_Marca[i],
                         Vehiculo.A_Modelo[i], Vehiculo.A_Condicion[i], Vehiculo.A_Precio[i],
                         Vehiculo.A_Anio[i], Vehiculo.A_Kilometraje[i]);
                 }
                

             }
                 }
         

         private void CBMarca_SelectedIndexChanged(object sender, EventArgs e)
         {
             //if (CBMarca.Text == "Audi") {
             //    Cargar Modelo
             //    CBModelo.Items.Add("A4"); // Para Audi
             //}
             //else if (CBMarca.Text == "BMW") {
             //    CBModelo.Items.Add("X6"); // Para BMW

             //}
             //else if (CBMarca.Text == "Mercedez") {
             //    CBModelo.Items.Add("AMG"); // Para AMG               
             //}
             //else if (CBMarca.Text == "Honda") {
             //    CBModelo.Items.Add("CRB 250");  // Para Honda
             
             //}
             //else if (CBMarca.Text == "Kawasaki") {
             //    CBModelo.Items.Add("Ninja");  // Para Kawazaki
             //}
             //else if (CBMarca.Text == "Ronco"){
             //    CBModelo.Items.Add("Generico"); //Para ronco
             //}
         }

         private void btnBuscar_Click(object sender, EventArgs e)
         {

         }

         private void Vehiculos_Load_1(object sender, EventArgs e)
         {
             int v_contador = -1;

             for (int i = 0; i <= Vehiculo.v_contador; i++) {
                 for (int j = 1; j <= CBTVehiculo.Items.Count; j++)
                 {
                     if (Vehiculo.A_TVehiculo[i] == CBTVehiculo.Items[j].ToString() ) {
                         v_contador = 1;
                     }
                }
                 if (v_contador == -1) {
                    CBTVehiculo.Items.Add(Vehiculo.A_TVehiculo[i]);
                 }
             
             }
         }
        }

       
    }

