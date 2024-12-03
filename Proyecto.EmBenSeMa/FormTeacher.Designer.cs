namespace SchoolMusic.Proyecto
{
    partial class FormTeacher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTeacher));
            groupBox1 = new GroupBox();
            txtDni = new TextBox();
            txtNombreCompleto = new TextBox();
            txtMail = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            etqTitleCurso = new Label();
            eqtTitulo = new Label();
            btnSalir = new Button();
            btnNotificacion = new Button();
            menuStrip1 = new MenuStrip();
            aulaToolStripMenuItem = new ToolStripMenuItem();
            modificarPerfilToolStripMenuItem = new ToolStripMenuItem();
            notificationToolStripMenuItem = new ToolStripMenuItem();
            cerrarSessiónToolStripMenuItem = new ToolStripMenuItem();
            verCursoToolStripMenuItem = new ToolStripMenuItem();
            foroToolStripMenuItem = new ToolStripMenuItem();
            contactoToolStripMenuItem = new ToolStripMenuItem();
            asistenciaToolStripMenuItem = new ToolStripMenuItem();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            acercaDeLaSchoolMusicToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            grBoxCursada = new GroupBox();
            txtCuota = new TextBox();
            label11 = new Label();
            txtDescription = new TextBox();
            label10 = new Label();
            label9 = new Label();
            dateEnd = new DateTimePicker();
            txtVacantes = new TextBox();
            txtDia = new TextBox();
            btnEnviar = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            dateStart = new DateTimePicker();
            dateFinish = new DateTimePicker();
            dateInitiation = new DateTimePicker();
            comboCourse = new ComboBox();
            btnCursada = new Button();
            comboCursada = new ComboBox();
            label12 = new Label();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            grBoxCursada.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(txtDni);
            groupBox1.Controls.Add(txtNombreCompleto);
            groupBox1.Controls.Add(txtMail);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 78);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(459, 112);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del usuario";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(138, 80);
            txtDni.Name = "txtDni";
            txtDni.ReadOnly = true;
            txtDni.Size = new Size(163, 25);
            txtDni.TabIndex = 6;
            // 
            // txtNombreCompleto
            // 
            txtNombreCompleto.Location = new Point(138, 19);
            txtNombreCompleto.Name = "txtNombreCompleto";
            txtNombreCompleto.ReadOnly = true;
            txtNombreCompleto.Size = new Size(292, 25);
            txtNombreCompleto.TabIndex = 4;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(138, 49);
            txtMail.Name = "txtMail";
            txtMail.ReadOnly = true;
            txtMail.Size = new Size(292, 25);
            txtMail.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(92, 84);
            label2.Name = "label2";
            label2.Size = new Size(34, 17);
            label2.TabIndex = 1;
            label2.Text = "Dni:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(82, 57);
            label3.Name = "label3";
            label3.Size = new Size(50, 17);
            label3.TabIndex = 2;
            label3.Text = "Email: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(6, 27);
            label1.Name = "label1";
            label1.Size = new Size(126, 17);
            label1.TabIndex = 0;
            label1.Text = "Nombre Completo:";
            // 
            // etqTitleCurso
            // 
            etqTitleCurso.AutoSize = true;
            etqTitleCurso.BackColor = Color.Transparent;
            etqTitleCurso.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            etqTitleCurso.ForeColor = Color.White;
            etqTitleCurso.Location = new Point(7, 22);
            etqTitleCurso.Name = "etqTitleCurso";
            etqTitleCurso.Size = new Size(47, 17);
            etqTitleCurso.TabIndex = 3;
            etqTitleCurso.Text = "Curso ";
            // 
            // eqtTitulo
            // 
            eqtTitulo.AutoSize = true;
            eqtTitulo.BackColor = Color.Transparent;
            eqtTitulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            eqtTitulo.ForeColor = Color.White;
            eqtTitulo.Location = new Point(50, 35);
            eqtTitulo.Name = "eqtTitulo";
            eqtTitulo.Size = new Size(168, 37);
            eqtTitulo.TabIndex = 6;
            eqtTitulo.Text = "Bienvenido ";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(666, 439);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnNotificacion
            // 
            btnNotificacion.BackgroundImage = (Image)resources.GetObject("btnNotificacion.BackgroundImage");
            btnNotificacion.FlatStyle = FlatStyle.Flat;
            btnNotificacion.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNotificacion.ForeColor = Color.Transparent;
            btnNotificacion.Image = (Image)resources.GetObject("btnNotificacion.Image");
            btnNotificacion.ImageAlign = ContentAlignment.MiddleLeft;
            btnNotificacion.Location = new Point(687, 27);
            btnNotificacion.Name = "btnNotificacion";
            btnNotificacion.Size = new Size(180, 45);
            btnNotificacion.TabIndex = 22;
            btnNotificacion.Text = "Notificaciones";
            btnNotificacion.TextAlign = ContentAlignment.MiddleRight;
            btnNotificacion.UseVisualStyleBackColor = true;
            btnNotificacion.Click += btnNotificacion_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { aulaToolStripMenuItem, verCursoToolStripMenuItem, contactoToolStripMenuItem, ayudaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(888, 24);
            menuStrip1.TabIndex = 24;
            menuStrip1.Text = "menuStrip1";
            // 
            // aulaToolStripMenuItem
            // 
            aulaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { modificarPerfilToolStripMenuItem, notificationToolStripMenuItem, cerrarSessiónToolStripMenuItem });
            aulaToolStripMenuItem.Name = "aulaToolStripMenuItem";
            aulaToolStripMenuItem.Size = new Size(46, 20);
            aulaToolStripMenuItem.Text = "Perfil";
            // 
            // modificarPerfilToolStripMenuItem
            // 
            modificarPerfilToolStripMenuItem.Name = "modificarPerfilToolStripMenuItem";
            modificarPerfilToolStripMenuItem.Size = new Size(155, 22);
            modificarPerfilToolStripMenuItem.Text = "Modificar Perfil";
            modificarPerfilToolStripMenuItem.Click += modificarPerfilToolStripMenuItem_Click;
            // 
            // notificationToolStripMenuItem
            // 
            notificationToolStripMenuItem.Name = "notificationToolStripMenuItem";
            notificationToolStripMenuItem.Size = new Size(155, 22);
            notificationToolStripMenuItem.Text = "Notificaciones";
            notificationToolStripMenuItem.Click += notificationToolStripMenuItem_Click;
            // 
            // cerrarSessiónToolStripMenuItem
            // 
            cerrarSessiónToolStripMenuItem.Name = "cerrarSessiónToolStripMenuItem";
            cerrarSessiónToolStripMenuItem.Size = new Size(155, 22);
            cerrarSessiónToolStripMenuItem.Text = "Cerrar Sessión";
            cerrarSessiónToolStripMenuItem.Click += cerrarSessiónToolStripMenuItem_Click;
            // 
            // verCursoToolStripMenuItem
            // 
            verCursoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { foroToolStripMenuItem });
            verCursoToolStripMenuItem.Name = "verCursoToolStripMenuItem";
            verCursoToolStripMenuItem.Size = new Size(50, 20);
            verCursoToolStripMenuItem.Text = "Curso";
            // 
            // foroToolStripMenuItem
            // 
            foroToolStripMenuItem.Name = "foroToolStripMenuItem";
            foroToolStripMenuItem.Size = new Size(98, 22);
            foroToolStripMenuItem.Text = "Foro";
            foroToolStripMenuItem.Click += foroToolStripMenuItem_Click;
            // 
            // contactoToolStripMenuItem
            // 
            contactoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { asistenciaToolStripMenuItem });
            contactoToolStripMenuItem.Name = "contactoToolStripMenuItem";
            contactoToolStripMenuItem.Size = new Size(68, 20);
            contactoToolStripMenuItem.Text = "Contacto";
            // 
            // asistenciaToolStripMenuItem
            // 
            asistenciaToolStripMenuItem.Name = "asistenciaToolStripMenuItem";
            asistenciaToolStripMenuItem.Size = new Size(157, 22);
            asistenciaToolStripMenuItem.Text = "Soporte técnico";
            asistenciaToolStripMenuItem.Click += asistenciaToolStripMenuItem_Click;
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { acercaDeLaSchoolMusicToolStripMenuItem });
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new Size(53, 20);
            ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeLaSchoolMusicToolStripMenuItem
            // 
            acercaDeLaSchoolMusicToolStripMenuItem.Name = "acercaDeLaSchoolMusicToolStripMenuItem";
            acercaDeLaSchoolMusicToolStripMenuItem.Size = new Size(212, 22);
            acercaDeLaSchoolMusicToolStripMenuItem.Text = "Acerca de la School Music";
            acercaDeLaSchoolMusicToolStripMenuItem.Click += acercaDeLaSchoolMusicToolStripMenuItem_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(537, 27);
            button1.Name = "button1";
            button1.Size = new Size(137, 45);
            button1.TabIndex = 27;
            button1.Text = "Agregar Cursada";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // grBoxCursada
            // 
            grBoxCursada.BackColor = Color.OliveDrab;
            grBoxCursada.Controls.Add(txtCuota);
            grBoxCursada.Controls.Add(label11);
            grBoxCursada.Controls.Add(txtDescription);
            grBoxCursada.Controls.Add(label10);
            grBoxCursada.Controls.Add(label9);
            grBoxCursada.Controls.Add(dateEnd);
            grBoxCursada.Controls.Add(txtVacantes);
            grBoxCursada.Controls.Add(txtDia);
            grBoxCursada.Controls.Add(btnEnviar);
            grBoxCursada.Controls.Add(label8);
            grBoxCursada.Controls.Add(label7);
            grBoxCursada.Controls.Add(label6);
            grBoxCursada.Controls.Add(label5);
            grBoxCursada.Controls.Add(label4);
            grBoxCursada.Controls.Add(dateStart);
            grBoxCursada.Controls.Add(dateFinish);
            grBoxCursada.Controls.Add(dateInitiation);
            grBoxCursada.Controls.Add(comboCourse);
            grBoxCursada.Controls.Add(etqTitleCurso);
            grBoxCursada.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            grBoxCursada.ForeColor = Color.White;
            grBoxCursada.Location = new Point(522, 78);
            grBoxCursada.Name = "grBoxCursada";
            grBoxCursada.Size = new Size(347, 332);
            grBoxCursada.TabIndex = 26;
            grBoxCursada.TabStop = false;
            grBoxCursada.Text = "Nueva Cursada";
            grBoxCursada.Visible = false;
            // 
            // txtCuota
            // 
            txtCuota.Location = new Point(112, 264);
            txtCuota.Name = "txtCuota";
            txtCuota.Size = new Size(79, 23);
            txtCuota.TabIndex = 35;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(7, 265);
            label11.Name = "label11";
            label11.Size = new Size(103, 17);
            label11.TabIndex = 34;
            label11.Text = "Precio de cuota";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(93, 182);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(244, 80);
            txtDescription.TabIndex = 33;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(7, 186);
            label10.Name = "label10";
            label10.Size = new Size(80, 17);
            label10.TabIndex = 32;
            label10.Text = "Descripción";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(6, 133);
            label9.Name = "label9";
            label9.Size = new Size(183, 17);
            label9.TabIndex = 31;
            label9.Text = "Hora finalización de cursada";
            // 
            // dateEnd
            // 
            dateEnd.Format = DateTimePickerFormat.Time;
            dateEnd.Location = new Point(191, 129);
            dateEnd.Name = "dateEnd";
            dateEnd.ShowUpDown = true;
            dateEnd.Size = new Size(81, 23);
            dateEnd.TabIndex = 30;
            dateEnd.Value = new DateTime(2024, 6, 30, 0, 0, 0, 0);
            // 
            // txtVacantes
            // 
            txtVacantes.Location = new Point(274, 264);
            txtVacantes.Name = "txtVacantes";
            txtVacantes.Size = new Size(63, 23);
            txtVacantes.TabIndex = 29;
            // 
            // txtDia
            // 
            txtDia.Location = new Point(112, 155);
            txtDia.Name = "txtDia";
            txtDia.Size = new Size(225, 23);
            txtDia.TabIndex = 28;
            // 
            // btnEnviar
            // 
            btnEnviar.ForeColor = Color.Black;
            btnEnviar.Location = new Point(180, 303);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(75, 23);
            btnEnviar.TabIndex = 14;
            btnEnviar.Text = "ENVIAR";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(7, 161);
            label8.Name = "label8";
            label8.Size = new Size(99, 17);
            label8.TabIndex = 12;
            label8.Text = "Dia de cursada";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(6, 83);
            label7.Name = "label7";
            label7.Size = new Size(137, 17);
            label7.TabIndex = 11;
            label7.Text = "Fecha de finalización";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(6, 107);
            label6.Name = "label6";
            label6.Size = new Size(146, 17);
            label6.TabIndex = 10;
            label6.Text = "Hora inicio de cursada";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(206, 265);
            label5.Name = "label5";
            label5.Size = new Size(62, 17);
            label5.TabIndex = 9;
            label5.Text = "Vacantes";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(7, 52);
            label4.Name = "label4";
            label4.Size = new Size(100, 17);
            label4.TabIndex = 8;
            label4.Text = "Fecha de inicio";
            // 
            // dateStart
            // 
            dateStart.Format = DateTimePickerFormat.Time;
            dateStart.Location = new Point(154, 104);
            dateStart.Name = "dateStart";
            dateStart.ShowUpDown = true;
            dateStart.Size = new Size(81, 23);
            dateStart.TabIndex = 3;
            dateStart.Value = new DateTime(2024, 6, 30, 0, 0, 0, 0);
            // 
            // dateFinish
            // 
            dateFinish.Format = DateTimePickerFormat.Short;
            dateFinish.Location = new Point(154, 77);
            dateFinish.Name = "dateFinish";
            dateFinish.Size = new Size(108, 23);
            dateFinish.TabIndex = 2;
            // 
            // dateInitiation
            // 
            dateInitiation.Format = DateTimePickerFormat.Short;
            dateInitiation.Location = new Point(113, 47);
            dateInitiation.Name = "dateInitiation";
            dateInitiation.Size = new Size(106, 23);
            dateInitiation.TabIndex = 1;
            // 
            // comboCourse
            // 
            comboCourse.FormattingEnabled = true;
            comboCourse.Location = new Point(60, 21);
            comboCourse.Name = "comboCourse";
            comboCourse.Size = new Size(142, 23);
            comboCourse.TabIndex = 0;
            // 
            // btnCursada
            // 
            btnCursada.BackgroundImage = (Image)resources.GetObject("btnCursada.BackgroundImage");
            btnCursada.Enabled = false;
            btnCursada.FlatStyle = FlatStyle.Flat;
            btnCursada.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCursada.ForeColor = Color.Transparent;
            btnCursada.ImageAlign = ContentAlignment.MiddleLeft;
            btnCursada.Location = new Point(363, 196);
            btnCursada.Name = "btnCursada";
            btnCursada.Size = new Size(129, 33);
            btnCursada.TabIndex = 28;
            btnCursada.Text = "Ver cursada";
            btnCursada.TextAlign = ContentAlignment.TopCenter;
            btnCursada.UseVisualStyleBackColor = true;
            btnCursada.Click += btnForo_Click;
            // 
            // comboCursada
            // 
            comboCursada.FormattingEnabled = true;
            comboCursada.Location = new Point(104, 200);
            comboCursada.Name = "comboCursada";
            comboCursada.Size = new Size(243, 23);
            comboCursada.TabIndex = 30;
            comboCursada.Text = "Seleccione una cursada";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.White;
            label12.Location = new Point(18, 206);
            label12.Name = "label12";
            label12.Size = new Size(86, 17);
            label12.TabIndex = 31;
            label12.Text = "Tus cursadas";
            // 
            // FormTeacher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(888, 474);
            Controls.Add(comboCursada);
            Controls.Add(label12);
            Controls.Add(btnCursada);
            Controls.Add(button1);
            Controls.Add(grBoxCursada);
            Controls.Add(menuStrip1);
            Controls.Add(btnNotificacion);
            Controls.Add(btnSalir);
            Controls.Add(eqtTitulo);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormTeacher";
            Text = "FormAulaProfe";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            grBoxCursada.ResumeLayout(false);
            grBoxCursada.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtDni;
        private TextBox txtNombreCompleto;
        private TextBox txtMail;
        private Label label2;
        private Label etqTitleCurso;
        private Label label3;
        private Label label1;
        private ColumnHeader numAlum;
        private ColumnHeader nombreAlum;
        private ColumnHeader apellidoAlum;
        private ColumnHeader curso;
        private Label eqtTitulo;
        private Button btnSalir;
        private Button btnNotificacion;
        private Button btnMostrar;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem aulaToolStripMenuItem;
        private ToolStripMenuItem modificarPerfilToolStripMenuItem;
        private ToolStripMenuItem notificationToolStripMenuItem;
        private ToolStripMenuItem cerrarSessiónToolStripMenuItem;
        private ToolStripMenuItem verCursoToolStripMenuItem;
        private ToolStripMenuItem contactoToolStripMenuItem;
        private ToolStripMenuItem asistenciaToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripMenuItem acercaDeLaSchoolMusicToolStripMenuItem;
        private Button button1;
        private GroupBox grBoxCursada;
        private Label label5;
        private Label label4;
        private DateTimePicker dateStart;
        private DateTimePicker dateFinish;
        private DateTimePicker dateInitiation;
        private ComboBox comboCourse;
        private Label label7;
        private Label label6;
        private Label label8;
        private Button btnEnviar;
        private TextBox txtVacantes;
        private TextBox txtDia;
        private Label label9;
        private DateTimePicker dateEnd;
        private TextBox txtDescription;
        private Label label10;
        private TextBox txtCuota;
        private Label label11;
        private Button btnCursada;
        private ListView lvCursada;
        private ColumnHeader NameStudent;
        private ColumnHeader Surname;
        private ColumnHeader Curse;
        private ColumnHeader DateTime;
        private ToolStripMenuItem foroToolStripMenuItem;
        private ComboBox comboCursada;
        private Label label12;
    }
}