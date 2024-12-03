namespace Proyecto.EmBenSeMa
{
    partial class FormRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistration));
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDni = new TextBox();
            txtEdad = new TextBox();
            txtCorreo = new TextBox();
            txtUsuario = new TextBox();
            txtContra = new TextBox();
            txtConfirma = new TextBox();
            label8 = new Label();
            etqRegistro = new Label();
            btnRegistrar = new Button();
            btnCancelar = new Button();
            etqNotifica = new Label();
            checkMostrar = new CheckBox();
            grBoxGenero = new GroupBox();
            raBtnMas = new RadioButton();
            raBtnFem = new RadioButton();
            radioButton1 = new RadioButton();
            label9 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            grBoxDUser = new GroupBox();
            groupRol = new GroupBox();
            radioButton2 = new RadioButton();
            raBtnAlumno = new RadioButton();
            radioButton4 = new RadioButton();
            label10 = new Label();
            grBoxGenero.SuspendLayout();
            groupBox1.SuspendLayout();
            grBoxDUser.SuspendLayout();
            groupRol.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(6, 48);
            label2.Name = "label2";
            label2.Size = new Size(79, 22);
            label2.TabIndex = 1;
            label2.Text = "Apellido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(10, 79);
            label3.Name = "label3";
            label3.Size = new Size(41, 22);
            label3.TabIndex = 2;
            label3.Text = "DNI:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(219, 77);
            label4.Name = "label4";
            label4.Size = new Size(55, 22);
            label4.TabIndex = 3;
            label4.Text = "Edad:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(12, 102);
            label5.Name = "label5";
            label5.Size = new Size(67, 22);
            label5.TabIndex = 4;
            label5.Text = "Correo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(18, 19);
            label6.Name = "label6";
            label6.Size = new Size(135, 22);
            label6.TabIndex = 5;
            label6.Text = "Nombre usuario:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(6, 94);
            label7.Name = "label7";
            label7.Size = new Size(185, 22);
            label7.TabIndex = 6;
            label7.Text = "Contraseña de usuario:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(92, 16);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Ingrese su nombre";
            txtNombre.Size = new Size(218, 23);
            txtNombre.TabIndex = 7;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(92, 45);
            txtApellido.Name = "txtApellido";
            txtApellido.PlaceholderText = "Ingrese su apellido";
            txtApellido.Size = new Size(218, 23);
            txtApellido.TabIndex = 8;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(57, 76);
            txtDni.Name = "txtDni";
            txtDni.PlaceholderText = "Ingrese su DNI";
            txtDni.Size = new Size(156, 23);
            txtDni.TabIndex = 9;
            txtDni.KeyPress += txtDni_KeyPress;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(275, 76);
            txtEdad.Name = "txtEdad";
            txtEdad.PlaceholderText = "Su edad";
            txtEdad.Size = new Size(56, 23);
            txtEdad.TabIndex = 10;
            txtEdad.KeyPress += txtEdad_KeyPress;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(79, 105);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PlaceholderText = "Ejemplo@embensema.com";
            txtCorreo.Size = new Size(261, 23);
            txtCorreo.TabIndex = 11;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(159, 16);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Ingrese el nombre de usuario";
            txtUsuario.Size = new Size(218, 23);
            txtUsuario.TabIndex = 12;
            // 
            // txtContra
            // 
            txtContra.Location = new Point(197, 93);
            txtContra.Name = "txtContra";
            txtContra.PasswordChar = '*';
            txtContra.PlaceholderText = "Ingrese su contraseña";
            txtContra.Size = new Size(186, 23);
            txtContra.TabIndex = 13;
            // 
            // txtConfirma
            // 
            txtConfirma.Location = new Point(197, 130);
            txtConfirma.Name = "txtConfirma";
            txtConfirma.PasswordChar = '*';
            txtConfirma.PlaceholderText = "Reingrese su contraseña";
            txtConfirma.Size = new Size(186, 23);
            txtConfirma.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(18, 128);
            label8.Name = "label8";
            label8.Size = new Size(173, 22);
            label8.TabIndex = 15;
            label8.Text = "Confirma contraseña:";
            // 
            // etqRegistro
            // 
            etqRegistro.AutoSize = true;
            etqRegistro.BackColor = Color.Transparent;
            etqRegistro.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            etqRegistro.ForeColor = Color.White;
            etqRegistro.Location = new Point(56, 46);
            etqRegistro.Name = "etqRegistro";
            etqRegistro.Size = new Size(176, 29);
            etqRegistro.TabIndex = 18;
            etqRegistro.Text = "Nuevo Usuario";
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.Transparent;
            btnRegistrar.BackgroundImage = (Image)resources.GetObject("btnRegistrar.BackgroundImage");
            btnRegistrar.BackgroundImageLayout = ImageLayout.Stretch;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistrar.ForeColor = Color.Transparent;
            btnRegistrar.Image = (Image)resources.GetObject("btnRegistrar.Image");
            btnRegistrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegistrar.Location = new Point(238, 353);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(137, 41);
            btnRegistrar.TabIndex = 19;
            btnRegistrar.Text = "Enviar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackgroundImage = (Image)resources.GetObject("btnCancelar.BackgroundImage");
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.Transparent;
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(64, 353);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(137, 41);
            btnCancelar.TabIndex = 20;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // etqNotifica
            // 
            etqNotifica.BackColor = Color.Red;
            etqNotifica.ForeColor = Color.Black;
            etqNotifica.Location = new Point(230, 155);
            etqNotifica.Name = "etqNotifica";
            etqNotifica.Size = new Size(153, 32);
            etqNotifica.TabIndex = 21;
            etqNotifica.Text = "La contraseña debe tener 8 carácteres como minmo";
            etqNotifica.Visible = false;
            // 
            // checkMostrar
            // 
            checkMostrar.AutoSize = true;
            checkMostrar.BackColor = Color.Transparent;
            checkMostrar.Location = new Point(18, 158);
            checkMostrar.Name = "checkMostrar";
            checkMostrar.Size = new Size(128, 19);
            checkMostrar.TabIndex = 25;
            checkMostrar.Text = "Mostrar contraseña";
            checkMostrar.UseVisualStyleBackColor = false;
            checkMostrar.CheckedChanged += checkMostrar_CheckedChanged;
            // 
            // grBoxGenero
            // 
            grBoxGenero.BackColor = Color.Transparent;
            grBoxGenero.Controls.Add(raBtnMas);
            grBoxGenero.Controls.Add(raBtnFem);
            grBoxGenero.Controls.Add(radioButton1);
            grBoxGenero.ForeColor = Color.White;
            grBoxGenero.Location = new Point(80, 130);
            grBoxGenero.Name = "grBoxGenero";
            grBoxGenero.Size = new Size(177, 47);
            grBoxGenero.TabIndex = 26;
            grBoxGenero.TabStop = false;
            // 
            // raBtnMas
            // 
            raBtnMas.AutoSize = true;
            raBtnMas.Location = new Point(91, 14);
            raBtnMas.Name = "raBtnMas";
            raBtnMas.Size = new Size(80, 19);
            raBtnMas.TabIndex = 2;
            raBtnMas.TabStop = true;
            raBtnMas.Text = "Masculino";
            raBtnMas.UseVisualStyleBackColor = true;
            // 
            // raBtnFem
            // 
            raBtnFem.AutoSize = true;
            raBtnFem.Location = new Point(6, 14);
            raBtnFem.Name = "raBtnFem";
            raBtnFem.Size = new Size(78, 19);
            raBtnFem.TabIndex = 1;
            raBtnFem.TabStop = true;
            raBtnFem.Text = "Femenino";
            raBtnFem.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(-42, 176);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(94, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(9, 141);
            label9.Name = "label9";
            label9.Size = new Size(70, 22);
            label9.TabIndex = 27;
            label9.Text = "Genero:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(10, 19);
            label1.Name = "label1";
            label1.Size = new Size(75, 22);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(grBoxGenero);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(txtApellido);
            groupBox1.Controls.Add(txtDni);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtEdad);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtCorreo);
            groupBox1.Location = new Point(58, 78);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(351, 208);
            groupBox1.TabIndex = 29;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Personales";
            // 
            // grBoxDUser
            // 
            grBoxDUser.BackColor = Color.Transparent;
            grBoxDUser.Controls.Add(groupRol);
            grBoxDUser.Controls.Add(label10);
            grBoxDUser.Controls.Add(label7);
            grBoxDUser.Controls.Add(label6);
            grBoxDUser.Controls.Add(label8);
            grBoxDUser.Controls.Add(checkMostrar);
            grBoxDUser.Controls.Add(txtUsuario);
            grBoxDUser.Controls.Add(txtContra);
            grBoxDUser.Controls.Add(etqNotifica);
            grBoxDUser.Controls.Add(txtConfirma);
            grBoxDUser.Location = new Point(415, 78);
            grBoxDUser.Name = "grBoxDUser";
            grBoxDUser.Size = new Size(389, 208);
            grBoxDUser.TabIndex = 30;
            grBoxDUser.TabStop = false;
            grBoxDUser.Text = "Datos de usuario";
            // 
            // groupRol
            // 
            groupRol.BackColor = Color.Transparent;
            groupRol.Controls.Add(radioButton2);
            groupRol.Controls.Add(raBtnAlumno);
            groupRol.Controls.Add(radioButton4);
            groupRol.ForeColor = Color.White;
            groupRol.Location = new Point(159, 45);
            groupRol.Name = "groupRol";
            groupRol.Size = new Size(177, 42);
            groupRol.TabIndex = 28;
            groupRol.TabStop = false;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(90, 14);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(69, 19);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.Text = "Profesor";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // raBtnAlumno
            // 
            raBtnAlumno.AutoSize = true;
            raBtnAlumno.Location = new Point(6, 14);
            raBtnAlumno.Name = "raBtnAlumno";
            raBtnAlumno.Size = new Size(68, 19);
            raBtnAlumno.TabIndex = 1;
            raBtnAlumno.TabStop = true;
            raBtnAlumno.Text = "Alumno";
            raBtnAlumno.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(-42, 176);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(94, 19);
            radioButton4.TabIndex = 0;
            radioButton4.TabStop = true;
            radioButton4.Text = "radioButton4";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(18, 49);
            label10.Name = "label10";
            label10.Size = new Size(134, 22);
            label10.TabIndex = 27;
            label10.Text = "Tipo de usuario:";
            // 
            // FormRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(958, 505);
            Controls.Add(grBoxDUser);
            Controls.Add(groupBox1);
            Controls.Add(btnCancelar);
            Controls.Add(btnRegistrar);
            Controls.Add(etqRegistro);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormRegistration";
            Text = "Registrarse";
            grBoxGenero.ResumeLayout(false);
            grBoxGenero.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            grBoxDUser.ResumeLayout(false);
            grBoxDUser.PerformLayout();
            groupRol.ResumeLayout(false);
            groupRol.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDni;
        private TextBox txtEdad;
        private TextBox txtCorreo;
        private TextBox txtUsuario;
        private TextBox txtContra;
        private TextBox txtConfirma;
        private Label label8;
        private Label etqRegistro;
        private Button btnRegistrar;
        private Button btnCancelar;
        private Label etqNotifica;
        private CheckBox checkMostrar;
        private GroupBox grBoxGenero;
        private RadioButton raBtnFem;
        private RadioButton radioButton1;
        private RadioButton raBtnMas;
        private Label label9;
        private Label label1;
        private GroupBox groupBox1;
        private GroupBox grBoxDUser;
        private Label label10;
        private GroupBox groupRol;
        private RadioButton radioButton2;
        private RadioButton raBtnAlumno;
        private RadioButton radioButton4;
    }
}