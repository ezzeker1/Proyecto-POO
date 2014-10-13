﻿using System;
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
        public int Decodificar(string p_permiso) {
            /*
             * Tipos de Permisos
             * 1 = Administrador
             * 2 = Usuario
             * 3 = proveedor
             */
            int v_resultado = 0;
            p_permiso = p_permiso.ToLower();
            if (p_permiso == "administrador") {
                v_resultado = 1;
            }
            else if (p_permiso == "usuario") {
                v_resultado = 2;
            }
            else if (p_permiso == "proveedor") {
                v_resultado = 3;
            }
            return v_resultado;
        }

        //Este metodo toma el usuario y password para obtener el permisos que tiene asignado en el Array
        public int ObtenerPermiso(string p_usuario, string p_password) {
            Usuarios ObjUsuario = new Usuarios();
            int v_resultado = 0;
            for (int i = 0; i < ObjUsuario.v_contador; i++) {
                if (p_usuario == ObjUsuario.A_Nombre[i] && p_password == ObjUsuario.A_Password[i]) {
                    v_resultado = ObjUsuario.A_TUsuario[i];
                }
            }
                return v_resultado;
        }

    }
}
