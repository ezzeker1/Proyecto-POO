using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    class Permisos
    {
        public string v_usuario;
        public string v_password;

        public Permisos()
        {
            // TODO: Complete member initialization
        }

        public void ContructorPermisos(string p_usuario,string p_password) {

            v_usuario = p_usuario;
            v_password = p_password;
          
        }

        public int ValidarPermisos(string p_usuario, string p_password) {
            int v_resultado = 0;
            PanelAdministrativo ObjPanelAdm = new PanelAdministrativo();

           
            if (p_usuario == "admin" && p_password == "pass")
            {
                v_resultado = 1;
            }
            else if (p_usuario == "bryan" && p_password == "pass")
            {
                v_resultado = 3;
            }
            else v_resultado = 4;
            return v_resultado;
        }
    }
}
