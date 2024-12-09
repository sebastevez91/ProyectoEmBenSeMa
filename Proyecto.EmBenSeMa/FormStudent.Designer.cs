namespace SchoolMusic.Proyecto
{
    partial class FormStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStudent));
            groupBox1 = new GroupBox();
            etqData = new Label();
            lvCursos = new ListView();
            IdCursada = new ColumnHeader();
            completoName = new ColumnHeader();
            instrument = new ColumnHeader();
            StartTime = new ColumnHeader();
            EndTime = new ColumnHeader();
            btnSalir = new Button();
            button1 = new Button();
            menuStrip1 = new MenuStrip();
            aulaToolStripMenuItem = new ToolStripMenuItem();
            modificarPerfilToolStripMenuItem = new ToolStripMenuItem();
            cerrarSecciónToolStripMenuItem = new ToolStripMenuItem();
            cerrarSessiónToolStripMenuItem = new ToolStripMenuItem();
            verCursoToolStripMenuItem = new ToolStripMenuItem();
            foroToolStripMenuItem = new ToolStripMenuItem();
            contactoToolStripMenuItem = new ToolStripMenuItem();
            asistenciaToolStripMenuItem = new ToolStripMenuItem();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            acercaDeLaSchoolMusicToolStripMenuItem = new ToolStripMenuItem();
            btnNotificacion = new Button();
            btnMostrar = new Button();
            btnTablon = new Button();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(etqData);
            groupBox1.Location = new Point(22, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(526, 125);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del usuario";
            // 
            // etqData
            // 
            etqData.AutoSize = true;
            etqData.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            etqData.Location = new Point(15, 27);
            etqData.Name = "etqData";
            etqData.Size = new Size(0, 24);
            etqData.TabIndex = 0;
            // 
            // lvCursos
            // 
            lvCursos.BackColor = Color.OliveDrab;
            lvCursos.Columns.AddRange(new ColumnHeader[] { IdCursada, completoName, instrument, StartTime, EndTime });
            lvCursos.Location = new Point(22, 180);
            lvCursos.Name = "lvCursos";
            lvCursos.Size = new Size(667, 124);
            lvCursos.TabIndex = 1;
            lvCursos.UseCompatibleStateImageBehavior = false;
            lvCursos.View = View.Details;
            lvCursos.SelectedIndexChanged += lvCursos_SelectedIndexChanged;
            // 
            // IdCursada
            // 
            IdCursada.Text = "N° ";
            IdCursada.Width = 40;
            // 
            // completoName
            // 
            completoName.DisplayIndex = 2;
            completoName.Text = "Profesor";
            completoName.Width = 200;
            // 
            // instrument
            // 
            instrument.DisplayIndex = 1;
            instrument.Text = "Nombre del curso";
            instrument.Width = 180;
            // 
            // StartTime
            // 
            StartTime.Text = "Hora de clase";
            StartTime.Width = 120;
            // 
            // EndTime
            // 
            EndTime.Text = "Hora de finalización";
            EndTime.Width = 120;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(673, 370);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe Fluent Icons", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(187, 310);
            button1.Name = "button1";
            button1.Size = new Size(161, 40);
            button1.TabIndex = 3;
            button1.Text = "Inscripbirse a";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { aulaToolStripMenuItem, verCursoToolStripMenuItem, contactoToolStripMenuItem, ayudaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(760, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // aulaToolStripMenuItem
            // 
            aulaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { modificarPerfilToolStripMenuItem, cerrarSecciónToolStripMenuItem, cerrarSessiónToolStripMenuItem });
            aulaToolStripMenuItem.Name = "aulaToolStripMenuItem";
            aulaToolStripMenuItem.Size = new Size(46, 20);
            aulaToolStripMenuItem.Text = "Perfil";
            // 
            // modificarPerfilToolStripMenuItem
            // 
            modificarPerfilToolStripMenuItem.Name = "modificarPerfilToolStripMenuItem";
            modificarPerfilToolStripMenuItem.Size = new Size(180, 22);
            modificarPerfilToolStripMenuItem.Text = "Modificar Perfil";
            modificarPerfilToolStripMenuItem.Click += modificarPerfilToolStripMenuItem_Click;
            // 
            // cerrarSecciónToolStripMenuItem
            // 
            cerrarSecciónToolStripMenuItem.Name = "cerrarSecciónToolStripMenuItem";
            cerrarSecciónToolStripMenuItem.Size = new Size(180, 22);
            cerrarSecciónToolStripMenuItem.Text = "Notificaciones";
            cerrarSecciónToolStripMenuItem.Click += cerrarSecciónToolStripMenuItem_Click;
            // 
            // cerrarSessiónToolStripMenuItem
            // 
            cerrarSessiónToolStripMenuItem.Name = "cerrarSessiónToolStripMenuItem";
            cerrarSessiónToolStripMenuItem.Size = new Size(180, 22);
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
            foroToolStripMenuItem.Enabled = false;
            foroToolStripMenuItem.Name = "foroToolStripMenuItem";
            foroToolStripMenuItem.Size = new Size(180, 22);
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
            asistenciaToolStripMenuItem.Size = new Size(180, 22);
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
            // btnNotificacion
            // 
            btnNotificacion.BackgroundImage = (Image)resources.GetObject("btnNotificacion.BackgroundImage");
            btnNotificacion.FlatStyle = FlatStyle.Flat;
            btnNotificacion.Font = new Font("Segoe Fluent Icons", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNotificacion.ForeColor = Color.Transparent;
            btnNotificacion.Image = (Image)resources.GetObject("btnNotificacion.Image");
            btnNotificacion.ImageAlign = ContentAlignment.MiddleLeft;
            btnNotificacion.Location = new Point(583, 38);
            btnNotificacion.Name = "btnNotificacion";
            btnNotificacion.Size = new Size(165, 41);
            btnNotificacion.TabIndex = 21;
            btnNotificacion.Text = "Notificaciones";
            btnNotificacion.TextAlign = ContentAlignment.MiddleRight;
            btnNotificacion.UseVisualStyleBackColor = true;
            btnNotificacion.Click += btnNotificacion_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.BackgroundImage = (Image)resources.GetObject("btnMostrar.BackgroundImage");
            btnMostrar.BackgroundImageLayout = ImageLayout.Stretch;
            btnMostrar.FlatStyle = FlatStyle.Flat;
            btnMostrar.Font = new Font("Segoe Fluent Icons", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnMostrar.ForeColor = Color.White;
            btnMostrar.Location = new Point(22, 310);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(159, 40);
            btnMostrar.TabIndex = 24;
            btnMostrar.Text = "Mis incripciones";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnTablon
            // 
            btnTablon.BackgroundImage = (Image)resources.GetObject("btnTablon.BackgroundImage");
            btnTablon.Enabled = false;
            btnTablon.FlatStyle = FlatStyle.Flat;
            btnTablon.Font = new Font("Segoe Fluent Icons", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnTablon.ForeColor = Color.Transparent;
            btnTablon.ImageAlign = ContentAlignment.MiddleLeft;
            btnTablon.Location = new Point(583, 85);
            btnTablon.Name = "btnTablon";
            btnTablon.Size = new Size(165, 41);
            btnTablon.TabIndex = 26;
            btnTablon.Text = "Tablon";
            btnTablon.UseVisualStyleBackColor = true;
            btnTablon.Click += btnForo_Click;
            // 
            // FormStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(760, 450);
            Controls.Add(btnTablon);
            Controls.Add(btnMostrar);
            Controls.Add(btnNotificacion);
            Controls.Add(button1);
            Controls.Add(btnSalir);
            Controls.Add(lvCursos);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormStudent";
            Text = "FormAula";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ListView lvCursos;
        private ColumnHeader IdCursada;
        private ColumnHeader instrument;
        private ColumnHeader completoName;
        private Button btnSalir;
        private Button button1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem aulaToolStripMenuItem;
        private ToolStripMenuItem modificarPerfilToolStripMenuItem;
        private ToolStripMenuItem verCursoToolStripMenuItem;
        private ToolStripMenuItem contactoToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripMenuItem cerrarSecciónToolStripMenuItem;
        private ToolStripMenuItem asistenciaToolStripMenuItem;
        private ToolStripMenuItem acercaDeLaSchoolMusicToolStripMenuItem;
        private ToolStripMenuItem cerrarSessiónToolStripMenuItem;
        private Label etqData;
        private Button btnNotificacion;
        private Button btnMostrar;
        private ColumnHeader StartTime;
        private ColumnHeader EndTime;
        private Button btnTablon;
        private ToolStripMenuItem foroToolStripMenuItem;
    }
}