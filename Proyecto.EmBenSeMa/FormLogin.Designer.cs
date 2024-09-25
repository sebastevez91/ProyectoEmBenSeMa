namespace Proyecto.EmBenSeMa
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            etqUsuario = new Label();
            txtUsuario = new TextBox();
            txtContrasena = new TextBox();
            checkMostrar = new CheckBox();
            btnInicio = new Button();
            btnCerrar = new Button();
            linkCambiar = new LinkLabel();
            etqPass = new Label();
            etqPlataforma = new Label();
            btnRegistrarse = new Button();
            pictureBox1 = new PictureBox();
            btnCambiar = new Button();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // etqUsuario
            // 
            etqUsuario.AutoSize = true;
            etqUsuario.BackColor = Color.Transparent;
            etqUsuario.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            etqUsuario.ForeColor = Color.Snow;
            etqUsuario.Location = new Point(72, 94);
            etqUsuario.Name = "etqUsuario";
            etqUsuario.Size = new Size(73, 22);
            etqUsuario.TabIndex = 0;
            etqUsuario.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(151, 93);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Ingrese su usuario";
            txtUsuario.Size = new Size(274, 23);
            txtUsuario.TabIndex = 2;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(151, 138);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.PasswordChar = '*';
            txtContrasena.PlaceholderText = "Ingrese su contraseña";
            txtContrasena.Size = new Size(274, 23);
            txtContrasena.TabIndex = 3;
            // 
            // checkMostrar
            // 
            checkMostrar.AutoSize = true;
            checkMostrar.BackColor = Color.Transparent;
            checkMostrar.ForeColor = Color.Snow;
            checkMostrar.Location = new Point(151, 167);
            checkMostrar.Name = "checkMostrar";
            checkMostrar.Size = new Size(128, 19);
            checkMostrar.TabIndex = 4;
            checkMostrar.Text = "Mostrar contraseña";
            checkMostrar.UseVisualStyleBackColor = false;
            checkMostrar.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.Transparent;
            btnInicio.BackgroundImage = (Image)resources.GetObject("btnInicio.BackgroundImage");
            btnInicio.BackgroundImageLayout = ImageLayout.Stretch;
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Segoe Print", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnInicio.ForeColor = Color.Transparent;
            btnInicio.Image = (Image)resources.GetObject("btnInicio.Image");
            btnInicio.ImageAlign = ContentAlignment.MiddleLeft;
            btnInicio.Location = new Point(407, 216);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(106, 45);
            btnInicio.TabIndex = 5;
            btnInicio.Text = "Iniciar";
            btnInicio.TextAlign = ContentAlignment.MiddleRight;
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Transparent;
            btnCerrar.BackgroundImage = (Image)resources.GetObject("btnCerrar.BackgroundImage");
            btnCerrar.BackgroundImageLayout = ImageLayout.Stretch;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Segoe Print", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCerrar.ForeColor = Color.Transparent;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCerrar.Location = new Point(284, 216);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(106, 45);
            btnCerrar.TabIndex = 6;
            btnCerrar.Text = "Cerrar";
            btnCerrar.TextAlign = ContentAlignment.MiddleRight;
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // linkCambiar
            // 
            linkCambiar.AutoSize = true;
            linkCambiar.BackColor = Color.Transparent;
            linkCambiar.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            linkCambiar.LinkColor = Color.DarkRed;
            linkCambiar.Location = new Point(295, 167);
            linkCambiar.Name = "linkCambiar";
            linkCambiar.Size = new Size(183, 15);
            linkCambiar.TabIndex = 7;
            linkCambiar.TabStop = true;
            linkCambiar.Text = "¿Has olvidado tu contraseña?";
            linkCambiar.LinkClicked += linkLabel1_LinkClicked;
            // 
            // etqPass
            // 
            etqPass.AutoSize = true;
            etqPass.BackColor = Color.Transparent;
            etqPass.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            etqPass.ForeColor = Color.Snow;
            etqPass.Location = new Point(44, 139);
            etqPass.Name = "etqPass";
            etqPass.Size = new Size(101, 22);
            etqPass.TabIndex = 8;
            etqPass.Text = "Contraseña:";
            // 
            // etqPlataforma
            // 
            etqPlataforma.AutoSize = true;
            etqPlataforma.BackColor = Color.Transparent;
            etqPlataforma.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            etqPlataforma.ForeColor = Color.Snow;
            etqPlataforma.Location = new Point(55, 44);
            etqPlataforma.Name = "etqPlataforma";
            etqPlataforma.Size = new Size(243, 29);
            etqPlataforma.TabIndex = 9;
            etqPlataforma.Text = "Plataforma Alumnos";
            // 
            // btnRegistrarse
            // 
            btnRegistrarse.BackColor = Color.Transparent;
            btnRegistrarse.BackgroundImage = (Image)resources.GetObject("btnRegistrarse.BackgroundImage");
            btnRegistrarse.BackgroundImageLayout = ImageLayout.Stretch;
            btnRegistrarse.FlatStyle = FlatStyle.Flat;
            btnRegistrarse.Font = new Font("Segoe Print", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistrarse.ForeColor = Color.Transparent;
            btnRegistrarse.Image = (Image)resources.GetObject("btnRegistrarse.Image");
            btnRegistrarse.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegistrarse.Location = new Point(55, 216);
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.Size = new Size(181, 61);
            btnRegistrarse.TabIndex = 10;
            btnRegistrarse.Text = "Registrarse";
            btnRegistrarse.TextAlign = ContentAlignment.MiddleRight;
            btnRegistrarse.UseVisualStyleBackColor = false;
            btnRegistrarse.Click += btnRegistrarse_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(435, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(169, 130);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // btnCambiar
            // 
            btnCambiar.BackColor = Color.Transparent;
            btnCambiar.BackgroundImage = (Image)resources.GetObject("btnCambiar.BackgroundImage");
            btnCambiar.BackgroundImageLayout = ImageLayout.Stretch;
            btnCambiar.FlatStyle = FlatStyle.Flat;
            btnCambiar.Font = new Font("Segoe Print", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCambiar.ForeColor = Color.Transparent;
            btnCambiar.Image = (Image)resources.GetObject("btnCambiar.Image");
            btnCambiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCambiar.Location = new Point(407, 216);
            btnCambiar.Name = "btnCambiar";
            btnCambiar.Size = new Size(123, 45);
            btnCambiar.TabIndex = 13;
            btnCambiar.Text = "Cambiar";
            btnCambiar.TextAlign = ContentAlignment.MiddleRight;
            btnCambiar.UseVisualStyleBackColor = false;
            btnCambiar.Visible = false;
            btnCambiar.Click += btnCambiar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(350, 44);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 14;
            btnVolver.Text = "Volver atras";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Visible = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(630, 322);
            Controls.Add(btnVolver);
            Controls.Add(btnCambiar);
            Controls.Add(pictureBox1);
            Controls.Add(btnRegistrarse);
            Controls.Add(etqPlataforma);
            Controls.Add(etqPass);
            Controls.Add(linkCambiar);
            Controls.Add(btnCerrar);
            Controls.Add(btnInicio);
            Controls.Add(checkMostrar);
            Controls.Add(txtContrasena);
            Controls.Add(txtUsuario);
            Controls.Add(etqUsuario);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLogin";
            Text = "FormLogin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label etqUsuario;
        private TextBox txtUsuario;
        private TextBox txtContrasena;
        private CheckBox checkMostrar;
        private Button btnInicio;
        private Button btnCerrar;
        private LinkLabel linkCambiar;
        private Label etqPass;
        private Label etqPlataforma;
        private Button btnRegistrarse;
        private PictureBox pictureBox1;
        private Button btnCambiar;
        private Button btnVolver;
    }
}