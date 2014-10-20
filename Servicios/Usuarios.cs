using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{  
    class Usuarios
    {
        //Main ObjMain = new Main();
        //public int v_contador = 1;
        //public string[] A_Usuario = new string[100]; //Usuario para el ingreso al sistema
        //public string[] A_Nombre = new string[100]; // Array para guardar los nombres
        //public string[] A_ApellidoP = new string[100]; // Array para guardar los Apellidos Maternos
        //public string[] A_ApellidoM = new string[100]; // Array para guardar los Apellidos Paterno
        //public string[] A_Password = new string[100]; // Array para guardar las Contraseñas
        //public string[] A_Email = new string[100]; // Array para guardar los Email
        //public string[] A_Telefono = new string[100]; // Array para guardar los Telefono
        //public int[] A_TUsuario = new int[100]; // Array para guardar El tipo de Usuario
        

        public string v_usuario;
        public string v_password;
        public string v_apellidoP;
        public string v_ApellidoM;
        public string v_Email;
        public int v_t_Usurio;
       

        public void ConstructorUsuarios(
            string p_usuario, 
            string p_apellidop, 
            string p_apellidom, 
            string p_password, 
            string p_email, 
            int p_tusuario)
        {

            v_usuario = p_usuario;
            v_password = p_password;
            v_apellidoP = p_apellidop;
            v_ApellidoM = p_apellidom;
            v_Email = p_email;
            v_t_Usurio = p_tusuario;

        }

        //Registrar al Usuario en el Sistema
        public void RegistrarUsuarios(
            string p_usuario,
            string p_nombres,
            string p_apellidoP,
            string p_apellidoM,
            string p_password,
            string p_email,
            string p_telefono,
            int p_t_usuario)
        {
            
            //ObjMain.A_Usuario[ObjMain.v_contador] = p_usuario;
            //ObjMain.A_ApellidoP[ObjMain.v_contador] = p_apellidoP;
            //ObjMain.A_ApellidoM[ObjMain.v_contador] = p_apellidoM;
            //ObjMain.A_Email[ObjMain.v_contador] = p_email;
            //ObjMain.A_Nombre[ObjMain.v_contador] = p_nombres;
            //ObjMain.A_Password[ObjMain.v_contador] = p_password;
            //ObjMain.A_Telefono[ObjMain.v_contador] = p_telefono;
            //ObjMain.A_TUsuario[ObjMain.v_contador] = p_t_usuario;
            //ObjMain.v_contador++;  
        }

        //Modificar al Usuario
        public void ModificarUsuario(int p_tusuario, string p_usuario,string p_password ,string p_nombre,
                                     string p_apellidop, string p_apellidom, string p_email,string p_telefono) {

                //                         for (int i = 0; i < ObjMain.A_Usuario.Length; i++)
                //                         {
                //                             if (p_usuario == ObjMain.A_Usuario[i])
                //                             {
                //                                 //ObjMain.A_Nombre[i] = p_nombre;
                //                                 //ObjMain.A_ApellidoP[i] = p_apellidop;
                //                                 //ObjMain.A_ApellidoM[i] = p_apellidom;
                //                                 //ObjMain.A_Email[i] = p_email;
                //                                 //ObjMain.A_Telefono[i] = p_telefono;
                //                                 //ObjMain.A_Password[i] = p_password;
                //                                 //ObjMain.A_Usuario[i] = p_usuario;
                //       break;
                //   }
                //}
        }
        //Eliminar al Usuario
        public void EliminarUsuario(string p_usuario) {
            //for (int i = 0; i < ObjMain.A_Usuario.Length; i++)
            //{
            //    if (p_usuario == ObjMain.A_Usuario[i])
            //    {
            //        Array.Clear(ObjMain.A_Usuario, i, 1);
            //        Array.Clear(ObjMain.A_Nombre, i, 1);
            //        Array.Clear(ObjMain.A_ApellidoP, i, 1);
            //        Array.Clear(ObjMain.A_ApellidoM, i, 1);
            //        Array.Clear(ObjMain.A_Telefono, i, 1);
            //        Array.Clear(ObjMain.A_Email, i, 1);
            //        Array.Clear(ObjMain.A_Password, i, 1);
            //        Array.Clear(ObjMain.A_TUsuario, i, 1);
            //        break;
            //    }
            //}
        }
    }
}
