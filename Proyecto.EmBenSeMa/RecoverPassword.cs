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
        private LoginService loginService;
        public RecoverPassword()
        {
            InitializeComponent();
            loginService = new LoginService();
        }
        private void btnCambiar_Click(object sender, EventArgs e)
        {
            etqResultado.Visible = false;

            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Para recuperar la contraseña debes ingresar tu mail");
                return;
            }
            else
            {
                var tipoUser = radioButtonStudent.Checked ? "Alumno" : radioButtonTeacher.Checked ? "Profesor" : null;

                if(tipoUser != null)
                {
                    if (loginService.RecoverPassword(txtEmail.Text, tipoUser))
                    {
                        txtEmail.Text = "";
                        radioButtonStudent.Checked = false;
                        radioButtonTeacher.Checked = false;
                        etqResultado.Visible = true;
                        etqResultado.Text = "Te enviamos un correo a tu email";
                    }
                    else
                    {
                        etqResultado.Visible = true;
                        etqResultado.Text = "No pudimos enviar el correo de recuperación de contraseña.\n" +
                            "Verifica los datos ingresados.";
                    }
                }
                else
                {
                    etqResultado.Visible = true;
                    etqResultado.Text = "No pudimos enviar el correo de recuperación de contraseña.\n" +
                        "Verifica los datos ingresados.";
                }
            }
        }
    }
}
