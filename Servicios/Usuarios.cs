using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    class Usuarios
    {
        public int v_contador = 1;
        public string[] A_Nombre = new string[100]; // Array para guardar los nombres
        public string[] A_ApellidoP = new string[100]; // Array para guardar los Apellidos Maternos
        public string[] A_ApellidoM = new string[100]; // Array para guardar los Apellidos Paterno
        public string[] A_Password = new string[100]; // Array para guardar las Contraseñas
        public string[] A_Email = new string[100]; // Array para guardar los Email
        public string[] A_Telefono = new string[100]; // Array para guardar los Telefono
        public int[] A_TUsuario = new int[100]; // Array para guardar El tipo de Usuario
        

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

        public void RegistrarUsuarios(
            string p_nombres,
            string p_apellidoP,
            string p_apellidoM,
            string p_password,
            string p_email,
            string p_telefono,
            int p_t_usuario)
        {
            A_ApellidoP[v_contador] = p_apellidoP;
            A_ApellidoM[v_contador] = p_apellidoM;
            A_Email[v_contador] = p_email;
            A_Nombre[v_contador] = p_nombres;
            A_Password[v_contador] = p_password;
            A_Telefono[v_contador] = p_telefono;
            A_TUsuario[v_contador] = p_t_usuario;
            v_contador++;  
        }
    }
}
