namespace Proyecto.EmBenSeMa
{
    partial class FormContact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormContact));
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            btnEnviar = new Button();
            btnCancelar = new Button();
            pictureBox1 = new PictureBox();
            txtTel = new TextBox();
            txtMensaje = new TextBox();
            txtCorreo = new TextBox();
            txtNombre = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.Snow;
            label4.Location = new Point(180, 155);
            label4.Name = "label4";
            label4.Size = new Size(78, 22);
            label4.TabIndex = 3;
            label4.Text = "Mensaje:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.Snow;
            label3.Location = new Point(175, 126);
            label3.Name = "label3";
            label3.Size = new Size(82, 22);
            label3.TabIndex = 2;
            label3.Text = "Telefono:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.Snow;
            label2.Location = new Point(190, 99);
            label2.Name = "label2";
            label2.Size = new Size(67, 22);
            label2.TabIndex = 1;
            label2.Text = "Correo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(105, 71);
            label1.Name = "label1";
            label1.Size = new Size(152, 22);
            label1.TabIndex = 0;
            label1.Text = "Nombre Completo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.Snow;
            label5.Location = new Point(33, 26);
            label5.Name = "label5";
            label5.Size = new Size(236, 29);
            label5.TabIndex = 3;
            label5.Text = "Dejanos tu consulta";
            // 
            // btnEnviar
            // 
            btnEnviar.BackColor = Color.Transparent;
            btnEnviar.BackgroundImage = (Image)resources.GetObject("btnEnviar.BackgroundImage");
            btnEnviar.BackgroundImageLayout = ImageLayout.Stretch;
            btnEnviar.FlatStyle = FlatStyle.Flat;
            btnEnviar.Font = new Font("Segoe Print", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEnviar.ForeColor = Color.Transparent;
            btnEnviar.Image = (Image)resources.GetObject("btnEnviar.Image");
            btnEnviar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEnviar.Location = new Point(514, 258);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(157, 59);
            btnEnviar.TabIndex = 6;
            btnEnviar.Text = "Enviar";
            btnEnviar.TextAlign = ContentAlignment.MiddleRight;
            btnEnviar.UseVisualStyleBackColor = false;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.White;
            btnCancelar.BackgroundImage = (Image)resources.GetObject("btnCancelar.BackgroundImage");
            btnCancelar.BackgroundImageLayout = ImageLayout.Stretch;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe Print", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.Transparent;
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(340, 258);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(157, 59);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(63, 191);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(183, 115);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(263, 128);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(219, 23);
            txtTel.TabIndex = 16;
            // 
            // txtMensaje
            // 
            txtMensaje.Location = new Point(264, 157);
            txtMensaje.Multiline = true;
            txtMensaje.Name = "txtMensaje";
            txtMensaje.Size = new Size(407, 94);
            txtMensaje.TabIndex = 15;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(263, 99);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(408, 23);
            txtCorreo.TabIndex = 14;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(263, 70);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(408, 23);
            txtNombre.TabIndex = 13;
            // 
            // FormContact
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(719, 346);
            Controls.Add(txtTel);
            Controls.Add(txtMensaje);
            Controls.Add(txtCorreo);
            Controls.Add(txtNombre);
            Controls.Add(pictureBox1);
            Controls.Add(btnCancelar);
            Controls.Add(btnEnviar);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            ForeColor = SystemColors.Window;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormContact";
            Text = "Contacto";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private Button btnEnviar;
        private Button btnCancelar;
        private PictureBox pictureBox1;
        private TextBox txtTel;
        private TextBox txtMensaje;
        private TextBox txtCorreo;
        private TextBox txtNombre;
    }
}