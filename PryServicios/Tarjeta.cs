using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PryServicios
{
    class Tarjeta
    {
        public static string[] A_numero = new string[100];
        public static string[] A_Anio = new string[100];
        public static string[] A_Mes = new string[100];
        public static string[] A_Titular = new string[100];
        public static string[] A_Proveedor = new string[100];
        public static string[] A_Tipo = new string[100];
        public static string[] A_usuario = new string[100];
        public static int V_Contador = 0;

        public static void RegistrarTarjeta(string p_numero, string p_anio, string p_mes, string p_titular, string p_proveedor,
                                            string p_tipo, string p_usuario) {

                                                A_Anio[V_Contador] = p_anio;
                                                A_Mes[V_Contador] = p_mes;
                                                A_numero[V_Contador] = p_numero;
                                                A_Proveedor[V_Contador] = p_proveedor;
                                                A_Tipo[V_Contador] = p_tipo;
                                                A_Titular[V_Contador] = p_tipo;
                                                A_usuario[V_Contador] = p_usuario;
                                                V_Contador++;
        }

    }
}
