using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    class Validaciones
    {
        //Validar Direccion de Correo
        public int ValidarFormaCorreo(string p_email){
            int v_resultado1 = 0,v_resultado2 = 0,v_resultado = 0 ,v_longitud = 0;
            v_longitud = p_email.Length;
            v_resultado1 = p_email.IndexOf("@");
            v_resultado2 = p_email.IndexOf(".");
            v_resultado = v_resultado1 + v_resultado2;
            return v_resultado;}
    }
}
