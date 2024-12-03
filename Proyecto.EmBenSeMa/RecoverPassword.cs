using SchoolMusic.Serv;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolMusic.Proyecto
{
    public partial class RecoverPassword : Form
    {
        public RecoverPassword()
        {
            InitializeComponent();
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            //if (txtUsuario.Text == "" || txtContrasena.Text == "")
            //{
            //    MessageBox.Show("Completa los campos requeridos");
            //}
            //else
            //{
            //    if (tipo == "Student")
            //    {
            //        if (loginService.RecoverPasswordStudent(txtContrasena.Text, txtUsuario.Text))
            //        {
            //            MessageBox.Show("Te enviamos un correo a tu email");
            //            this.Close();
            //        }
            //        else
            //        {
            //            MessageBox.Show("Hay errores en la validación de tu usuario");
            //            this.Close();
            //        }
            //    }
            //    else
            //    {
            //        if (loginService.RecoverPasswordTeacher(txtContrasena.Text, txtUsuario.Text))
            //        {
            //            MessageBox.Show("Te enviamos un correo a tu email");
            //            this.Close();
            //        }
            //        else
            //        {
            //            MessageBox.Show("Hay errores en la validación de tu usuario");
            //            this.Close();
            //        }
            //    }
            //}
        }
    }
}
