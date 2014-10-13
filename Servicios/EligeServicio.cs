using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Servicios
{
    public partial class EligeServicio : Form
    {

        Permisos ObjPermisos = new Permisos();
        Main ObjMain = new Main();
        
        public EligeServicio()
        {
            InitializeComponent();
            
        }
        public EligeServicio(string p_usuario)
        {
            string v_user = p_usuario;
            LblESResUsuario.Text = v_user;
        }


        private void EligeServicio_Load(object sender, EventArgs e)
        {
            
        }

        private void EligeServicio_FormClosed(object sender, FormClosedEventArgs e)
        {

           
           
        }
    }
}
