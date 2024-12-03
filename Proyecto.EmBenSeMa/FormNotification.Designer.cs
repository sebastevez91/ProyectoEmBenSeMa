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
            listMensaje = new ListBox();
            etqRegistro = new Label();
            btnSalir = new Button();
            btnRecpcion = new Button();
            btnEnviados = new Button();
            TypeMjs = new Label();
            grBoxDetalles = new GroupBox();
            txtMensaje = new RichTextBox();
            txtSubjet = new TextBox();
            Mensaje = new Label();
            Subjet = new Label();
            grBoxDetalles.SuspendLayout();
            SuspendLayout();
            // 
            // listMensaje
            // 
            listMensaje.FormattingEnabled = true;
            listMensaje.ItemHeight = 15;
            listMensaje.Location = new Point(78, 141);
            listMensaje.Name = "listMensaje";
            listMensaje.Size = new Size(199, 244);
            listMensaje.TabIndex = 0;
            listMensaje.SelectedIndexChanged += listMensaje_SelectedIndexChanged;
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
            // btnSalir
            // 
            btnSalir.BackgroundImage = (Image)resources.GetObject("btnSalir.BackgroundImage");
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.Transparent;
            btnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalir.Location = new Point(676, 373);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(137, 41);
            btnSalir.TabIndex = 40;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
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
            // grBoxDetalles
            // 
            grBoxDetalles.BackColor = Color.Transparent;
            grBoxDetalles.Controls.Add(txtMensaje);
            grBoxDetalles.Controls.Add(txtSubjet);
            grBoxDetalles.Controls.Add(Mensaje);
            grBoxDetalles.Controls.Add(Subjet);
            grBoxDetalles.Location = new Point(306, 123);
            grBoxDetalles.Name = "grBoxDetalles";
            grBoxDetalles.Size = new Size(500, 244);
            grBoxDetalles.TabIndex = 50;
            grBoxDetalles.TabStop = false;
            grBoxDetalles.Visible = false;
            // 
            // txtMensaje
            // 
            txtMensaje.Enabled = false;
            txtMensaje.Location = new Point(82, 79);
            txtMensaje.Name = "txtMensaje";
            txtMensaje.Size = new Size(388, 146);
            txtMensaje.TabIndex = 3;
            txtMensaje.Text = "";
            // 
            // txtSubjet
            // 
            txtSubjet.Enabled = false;
            txtSubjet.Location = new Point(73, 27);
            txtSubjet.Name = "txtSubjet";
            txtSubjet.Size = new Size(397, 23);
            txtSubjet.TabIndex = 2;
            // 
            // Mensaje
            // 
            Mensaje.AutoSize = true;
            Mensaje.Location = new Point(16, 75);
            Mensaje.Name = "Mensaje";
            Mensaje.Size = new Size(60, 15);
            Mensaje.TabIndex = 1;
            Mensaje.Text = "Mensaje : ";
            // 
            // Subjet
            // 
            Subjet.AutoSize = true;
            Subjet.Location = new Point(16, 30);
            Subjet.Name = "Subjet";
            Subjet.Size = new Size(51, 15);
            Subjet.TabIndex = 0;
            Subjet.Text = "Asunto :";
            // 
            // FormNotification
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(872, 450);
            Controls.Add(grBoxDetalles);
            Controls.Add(TypeMjs);
            Controls.Add(btnEnviados);
            Controls.Add(btnRecpcion);
            Controls.Add(btnSalir);
            Controls.Add(etqRegistro);
            Controls.Add(listMensaje);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormNotification";
            Text = "Notificaciones";
            grBoxDetalles.ResumeLayout(false);
            grBoxDetalles.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listMensaje;
        private Label etqRegistro;
        private Button btnSalir;
        private Button btnRecpcion;
        private Button btnEnviados;
        private Label TypeMjs;
        private GroupBox grBoxDetalles;
        private Label Subjet;
        private RichTextBox txtMensaje;
        private TextBox txtSubjet;
        private Label Mensaje;
    }
}