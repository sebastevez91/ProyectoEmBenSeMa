namespace SchoolMusic.Proyecto
{
    partial class RecoverPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecoverPassword));
            btnEnviar = new Button();
            txtEmail = new TextBox();
            groupBox1 = new GroupBox();
            etqResultado = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            radioButtonStudent = new RadioButton();
            radioButtonTeacher = new RadioButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnEnviar
            // 
            btnEnviar.BackColor = Color.Transparent;
            btnEnviar.BackgroundImage = (Image)resources.GetObject("btnEnviar.BackgroundImage");
            btnEnviar.BackgroundImageLayout = ImageLayout.Stretch;
            btnEnviar.FlatStyle = FlatStyle.Flat;
            btnEnviar.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEnviar.ForeColor = Color.Transparent;
            btnEnviar.Image = (Image)resources.GetObject("btnEnviar.Image");
            btnEnviar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEnviar.Location = new Point(321, 95);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(102, 31);
            btnEnviar.TabIndex = 14;
            btnEnviar.Text = "Enviar";
            btnEnviar.TextAlign = ContentAlignment.MiddleRight;
            btnEnviar.UseVisualStyleBackColor = false;
            btnEnviar.Click += btnCambiar_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(86, 54);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Ingresa tu email";
            txtEmail.Size = new Size(337, 23);
            txtEmail.TabIndex = 15;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(etqResultado);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(btnEnviar);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(455, 178);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Recuperar contraseña";
            // 
            // etqResultado
            // 
            etqResultado.AutoSize = true;
            etqResultado.Location = new Point(17, 142);
            etqResultado.Name = "etqResultado";
            etqResultado.Size = new Size(99, 15);
            etqResultado.TabIndex = 18;
            etqResultado.Text = "Mensaje de envio";
            etqResultado.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 57);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 17;
            label1.Text = "Email";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButtonTeacher);
            groupBox2.Controls.Add(radioButtonStudent);
            groupBox2.Location = new Point(86, 83);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(212, 46);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tipo de usuario";
            // 
            // radioButtonStudent
            // 
            radioButtonStudent.AutoSize = true;
            radioButtonStudent.Location = new Point(16, 21);
            radioButtonStudent.Name = "radioButtonStudent";
            radioButtonStudent.Size = new Size(68, 19);
            radioButtonStudent.TabIndex = 0;
            radioButtonStudent.TabStop = true;
            radioButtonStudent.Text = "Alumno";
            radioButtonStudent.UseVisualStyleBackColor = true;
            // 
            // radioButtonTeacher
            // 
            radioButtonTeacher.AutoSize = true;
            radioButtonTeacher.Location = new Point(114, 21);
            radioButtonTeacher.Name = "radioButtonTeacher";
            radioButtonTeacher.Size = new Size(69, 19);
            radioButtonTeacher.TabIndex = 1;
            radioButtonTeacher.TabStop = true;
            radioButtonTeacher.Text = "Profesor";
            radioButtonTeacher.UseVisualStyleBackColor = true;
            // 
            // RecoverPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 202);
            Controls.Add(groupBox1);
            Name = "RecoverPassword";
            Text = "RecoverPassword";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnEnviar;
        private TextBox txtEmail;
        private GroupBox groupBox1;
        private Label label1;
        private Label etqResultado;
        private GroupBox groupBox2;
        private RadioButton radioButtonTeacher;
        private RadioButton radioButtonStudent;
    }
}