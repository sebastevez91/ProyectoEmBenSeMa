using Capa.Entidades;
using Capa.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Proyecto.EmBenSeMa
{
    public partial class FormContact : Form
    {
        public FormContact()
        {
            InitializeComponent();
        }
        // Instanciar la clase MailService
        MailService mailService = new MailService();
        // Botones
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (ValidarConsulta())
            {
                MailData mailData = new MailData();
                mailData.mailTo = txtCorreo.Text;
                mailData.subject = "Consulta";
                mailData.body = "Gracias por escribirnos, recibimos tu consulta, te contestaremos a la brevedad";
                mailService.sendMail(mailData);
                MessageBox.Show("El mensaje se envio correctamente.");
                this.Close();
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Validar datos
        private bool ValidarConsulta()
        {
            bool valido = true;
            var emailValido = ValidacionGeneral.mailValido(txtCorreo.Text);
            if(emailValido == false)
            {
                MessageBox.Show("El email ingresado no es valido");
                txtCorreo.Text = "";
                valido = false;
            }
            var telValido = ValidacionGeneral.telefonoValido(txtTel.Text);
            if (telValido == false)
            {
                MessageBox.Show("El telefono ingresado no es valido");
                txtTel.Text = "";
                valido = false;
            }
            return valido;
        }
    }
}
