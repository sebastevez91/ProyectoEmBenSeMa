namespace SchoolMusic.Proyecto
{
    partial class FormNotification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNotification));
            Recpcion = new ListBox();
            etqRegistro = new Label();
            grboxMensaje = new GroupBox();
            etqMensaje = new Label();
            btnResponde = new Button();
            btnSalir = new Button();
            btnMostrar = new Button();
            btnEnviar = new Button();
            txtMensaje = new TextBox();
            txtAsunto = new TextBox();
            etqSubject = new Label();
            label4 = new Label();
            etqTo = new Label();
            groupBoxSend = new GroupBox();
            button1 = new Button();
            btnRecpcion = new Button();
            btnEnviados = new Button();
            Enviados = new ListBox();
            TypeMjs = new Label();
            grboxMensaje.SuspendLayout();
            groupBoxSend.SuspendLayout();
            SuspendLayout();
            // 
            // Recpcion
            // 
            Recpcion.FormattingEnabled = true;
            Recpcion.ItemHeight = 15;
            Recpcion.Location = new Point(82, 144);
            Recpcion.Name = "Recpcion";
            Recpcion.Size = new Size(199, 154);
            Recpcion.TabIndex = 0;
            // 
            // etqRegistro
            // 
            etqRegistro.AutoSize = true;
            etqRegistro.BackColor = Color.Transparent;
            etqRegistro.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            etqRegistro.ForeColor = Color.White;
            etqRegistro.Location = new Point(54, 48);
            etqRegistro.Name = "etqRegistro";
            etqRegistro.Size = new Size(177, 29);
            etqRegistro.TabIndex = 19;
            etqRegistro.Text = "Notificaciones";
            // 
            // grboxMensaje
            // 
            grboxMensaje.Controls.Add(etqMensaje);
            grboxMensaje.Controls.Add(btnResponde);
            grboxMensaje.Location = new Point(313, 99);
            grboxMensaje.Name = "grboxMensaje";
            grboxMensaje.Size = new Size(489, 199);
            grboxMensaje.TabIndex = 20;
            grboxMensaje.TabStop = false;
            grboxMensaje.Text = "Mensaje";
            // 
            // etqMensaje
            // 
            etqMensaje.AutoSize = true;
            etqMensaje.BackColor = Color.Transparent;
            etqMensaje.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            etqMensaje.ForeColor = Color.Black;
            etqMensaje.Location = new Point(13, 29);
            etqMensaje.Name = "etqMensaje";
            etqMensaje.Size = new Size(120, 22);
            etqMensaje.TabIndex = 44;
            etqMensaje.Text = "Notificaciones";
            etqMensaje.Visible = false;
            // 
            // btnResponde
            // 
            btnResponde.BackgroundImage = (Image)resources.GetObject("btnResponde.BackgroundImage");
            btnResponde.FlatStyle = FlatStyle.Flat;
            btnResponde.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnResponde.ForeColor = Color.Transparent;
            btnResponde.ImageAlign = ContentAlignment.MiddleLeft;
            btnResponde.Location = new Point(6, 159);
            btnResponde.Name = "btnResponde";
            btnResponde.Size = new Size(89, 34);
            btnResponde.TabIndex = 44;
            btnResponde.Text = "Responder";
            btnResponde.TextAlign = ContentAlignment.TopLeft;
            btnResponde.UseVisualStyleBackColor = true;
            btnResponde.Visible = false;
            btnResponde.Click += btnResponde_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackgroundImage = (Image)resources.GetObject("btnSalir.BackgroundImage");
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.Transparent;
            btnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalir.Location = new Point(587, 359);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(137, 41);
            btnSalir.TabIndex = 40;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.BackgroundImage = (Image)resources.GetObject("btnMostrar.BackgroundImage");
            btnMostrar.FlatStyle = FlatStyle.Flat;
            btnMostrar.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnMostrar.ForeColor = Color.Transparent;
            btnMostrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnMostrar.Location = new Point(82, 316);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(199, 41);
            btnMostrar.TabIndex = 41;
            btnMostrar.Text = "Mostrar mensaje";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnEnviar
            // 
            btnEnviar.BackgroundImage = (Image)resources.GetObject("btnEnviar.BackgroundImage");
            btnEnviar.FlatStyle = FlatStyle.Flat;
            btnEnviar.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEnviar.ForeColor = Color.Transparent;
            btnEnviar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEnviar.Location = new Point(432, 359);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(137, 41);
            btnEnviar.TabIndex = 42;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Visible = false;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // txtMensaje
            // 
            txtMensaje.Location = new Point(112, 77);
            txtMensaje.Multiline = true;
            txtMensaje.Name = "txtMensaje";
            txtMensaje.Size = new Size(366, 94);
            txtMensaje.TabIndex = 24;
            // 
            // txtAsunto
            // 
            txtAsunto.BackColor = Color.White;
            txtAsunto.Location = new Point(112, 48);
            txtAsunto.Name = "txtAsunto";
            txtAsunto.Size = new Size(366, 23);
            txtAsunto.TabIndex = 23;
            // 
            // etqSubject
            // 
            etqSubject.AutoSize = true;
            etqSubject.BackColor = Color.Transparent;
            etqSubject.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            etqSubject.ForeColor = Color.Snow;
            etqSubject.Location = new Point(38, 48);
            etqSubject.Name = "etqSubject";
            etqSubject.Size = new Size(67, 22);
            etqSubject.TabIndex = 18;
            etqSubject.Text = "Asunto:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.Snow;
            label4.Location = new Point(28, 75);
            label4.Name = "label4";
            label4.Size = new Size(78, 22);
            label4.TabIndex = 20;
            label4.Text = "Mensaje:";
            // 
            // etqTo
            // 
            etqTo.AutoSize = true;
            etqTo.BackColor = Color.Transparent;
            etqTo.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            etqTo.ForeColor = Color.Snow;
            etqTo.Location = new Point(56, 20);
            etqTo.Name = "etqTo";
            etqTo.Size = new Size(50, 22);
            etqTo.TabIndex = 17;
            etqTo.Text = "Para:";
            // 
            // groupBoxSend
            // 
            groupBoxSend.BackColor = Color.Transparent;
            groupBoxSend.Controls.Add(etqSubject);
            groupBoxSend.Controls.Add(etqTo);
            groupBoxSend.Controls.Add(txtMensaje);
            groupBoxSend.Controls.Add(label4);
            groupBoxSend.Controls.Add(txtAsunto);
            groupBoxSend.Location = new Point(313, 99);
            groupBoxSend.Name = "groupBoxSend";
            groupBoxSend.Size = new Size(506, 199);
            groupBoxSend.TabIndex = 43;
            groupBoxSend.TabStop = false;
            groupBoxSend.Text = "Mensaje";
            groupBoxSend.Visible = false;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Transparent;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(82, 363);
            button1.Name = "button1";
            button1.Size = new Size(199, 41);
            button1.TabIndex = 45;
            button1.Text = "Redactar un mensaje";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnRecpcion
            // 
            btnRecpcion.Location = new Point(267, 55);
            btnRecpcion.Name = "btnRecpcion";
            btnRecpcion.Size = new Size(90, 23);
            btnRecpcion.TabIndex = 46;
            btnRecpcion.Text = "Recepción";
            btnRecpcion.UseVisualStyleBackColor = true;
            btnRecpcion.Click += btnRecpcion_Click;
            // 
            // btnEnviados
            // 
            btnEnviados.Location = new Point(369, 55);
            btnEnviados.Name = "btnEnviados";
            btnEnviados.Size = new Size(90, 23);
            btnEnviados.TabIndex = 47;
            btnEnviados.Text = "Enviados";
            btnEnviados.UseVisualStyleBackColor = true;
            btnEnviados.Click += btnEnviados_Click;
            // 
            // Enviados
            // 
            Enviados.FormattingEnabled = true;
            Enviados.ItemHeight = 15;
            Enviados.Location = new Point(82, 144);
            Enviados.Name = "Enviados";
            Enviados.Size = new Size(199, 154);
            Enviados.TabIndex = 48;
            Enviados.Visible = false;
            // 
            // TypeMjs
            // 
            TypeMjs.AutoSize = true;
            TypeMjs.BackColor = Color.Transparent;
            TypeMjs.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            TypeMjs.ForeColor = Color.Snow;
            TypeMjs.Location = new Point(98, 116);
            TypeMjs.Name = "TypeMjs";
            TypeMjs.Size = new Size(157, 22);
            TypeMjs.TabIndex = 49;
            TypeMjs.Text = "Mensajes Recibidos";
            // 
            // FormNotification
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(872, 450);
            Controls.Add(TypeMjs);
            Controls.Add(Enviados);
            Controls.Add(btnEnviados);
            Controls.Add(btnRecpcion);
            Controls.Add(button1);
            Controls.Add(groupBoxSend);
            Controls.Add(btnEnviar);
            Controls.Add(btnMostrar);
            Controls.Add(btnSalir);
            Controls.Add(grboxMensaje);
            Controls.Add(etqRegistro);
            Controls.Add(Recpcion);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormNotification";
            Text = "Notificaciones";
            grboxMensaje.ResumeLayout(false);
            grboxMensaje.PerformLayout();
            groupBoxSend.ResumeLayout(false);
            groupBoxSend.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox Recpcion;
        private Label etqRegistro;
        private GroupBox grboxMensaje;
        private Button btnSalir;
        private Button btnMostrar;
        private Button btnEnviar;
        private TextBox txtMensaje;
        private TextBox txtAsunto;
        private Label etqSubject;
        private Label label4;
        private Label etqTo;
        private GroupBox groupBoxSend;
        private Label etqMensaje;
        private Button btnResponde;
        private Button button1;
        private Button btnRecpcion;
        private Button btnEnviados;
        private ListBox Enviados;
        private Label TypeMjs;
    }
}