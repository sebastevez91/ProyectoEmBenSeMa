﻿using SchoolMusic.Entidades;
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
    public partial class FormCursada : Form
    {
        private Users userSesion = new Users();
        private Cursada cursada;
        private Course course;
        private CursadaService _cursadaService;
        private List<Student> listStudents;
        private FormTablon formTablon;
        public FormCursada()
        {
            InitializeComponent();
            cursada = new Cursada();
            course = new Course();
            _cursadaService = new CursadaService();
            listStudents = new List<Student>();
        }

        public void ShowCursada(Users user, int id)
        {
            int inscriptos = 0;

            // Almaceno el usuario en sesión
            userSesion = user;

            cursada = _cursadaService.GetCursada(id);

            if (cursada != null)
            {
                inscriptos = _cursadaService.GetCantidad(cursada.IdCursada);
                course = _cursadaService.GetCourse(cursada.IdCourse);

                txtInfo.Text = $"Cursada de {course.Instrument}\n\n" +
                    $"Inicia el {cursada.Initiation.ToString("dd/MM/yyyy")}\n" +
                    $"Termina el {cursada.Finish.ToString("dd/MM/yyyy")}\n" +
                    $"Cantidad de vacantes {cursada.Vacantes}\n" +
                    $"Vacantes disponibles {cursada.Vacantes - inscriptos}\n" +
                    $"Los dias de cursada son los {cursada.Days}\n" +
                    $"Horario de cursada {cursada.StarTime.ToString("t")} a {cursada.EndTime.ToString("t")}\n" +
                    $"Contenido de esta cursada: {cursada.Description}";
            }

        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            // Obtener la lista de estudiantes
            var students = _cursadaService.GetStudentList(cursada.IdCursada);
            if (students != null)
            {
                listStudents = students;
                btnEnviar.Enabled = true;
                // Limpiar el ListView
                listViewStudent.Items.Clear();

                // Rellenar el ListView con los nombres de los estudiantes
                foreach (var student in listStudents)
                {
                    // Crear un nuevo ListViewItem con el nombre del estudiante
                    ListViewItem item = new ListViewItem(student.IdUser.ToString());

                    // Añadir los subitems al ListViewItem
                    item.SubItems.Add(student.NameStudent);
                    item.SubItems.Add(student.Surname);
                    item.SubItems.Add(student.Mail);

                    // Añadir el item al ListView
                    listViewStudent.Items.Add(item);
                }
            }

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            // Muestro la parte de enviar mensajes
            groupBoxMensaje.Visible = true;

            comboBoxStudent.DataSource = null;
            comboBoxStudent.DataSource = listStudents;
            comboBoxStudent.ValueMember = "NameStudent";
            comboBoxStudent.SelectedValue = "IdUser";
            comboBoxStudent.SelectedIndex = -1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                viewTablon();
                formTablon.Show();
                formTablon.SesionTablon(userSesion, cursada.IdCursada);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede abrir más de una ventana");
            }
        }

        private void viewTablon()
        {
            // Verifica si ya existe una instancia del formulario
            if (formTablon == null || formTablon.IsDisposed)
            {
                // Si no existe, crea una nueva instancia
                formTablon = new FormTablon();
            }

            // Verifica si el formulario está visible
            if (formTablon.Visible)
            {
                // Si está visible, cierra la instancia existente
                formTablon.Close();
            }

            // Muestra el formulario actual
            this.Visible = true;
        }
    }
}