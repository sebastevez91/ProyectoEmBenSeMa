namespace SchoolMusic.Proyecto
{
    partial class FormCursada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCursada));
            groupBox1 = new GroupBox();
            txtInfo = new RichTextBox();
            btnStudent = new Button();
            listViewStudent = new ListView();
            IdUser = new ColumnHeader();
            NameStudent = new ColumnHeader();
            Mail = new ColumnHeader();
            btnEnviar = new Button();
            button3 = new Button();
            groupBoxMensaje = new GroupBox();
            comboBoxStudent = new ComboBox();
            btnSend = new Button();
            rtxtBody = new RichTextBox();
            txtSubjet = new TextBox();
            etqBody = new Label();
            etqSubjet = new Label();
            etqFrom = new Label();
            groupBox1.SuspendLayout();
            groupBoxMensaje.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtInfo);
            groupBox1.Location = new Point(12, 18);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(339, 266);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informacón de cursada";
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(15, 22);
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(305, 193);
            txtInfo.TabIndex = 0;
            txtInfo.Text = "";
            // 
            // btnStudent
            // 
            btnStudent.BackgroundImage = (Image)resources.GetObject("btnStudent.BackgroundImage");
            btnStudent.FlatStyle = FlatStyle.Flat;
            btnStudent.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnStudent.ForeColor = Color.White;
            btnStudent.ImageAlign = ContentAlignment.MiddleLeft;
            btnStudent.Location = new Point(400, 27);
            btnStudent.Name = "btnStudent";
            btnStudent.Size = new Size(180, 45);
            btnStudent.TabIndex = 28;
            btnStudent.Text = "Mostrar alumnos";
            btnStudent.UseVisualStyleBackColor = true;
            btnStudent.Click += btnStudent_Click;
            // 
            // listViewStudent
            // 
            listViewStudent.Columns.AddRange(new ColumnHeader[] { IdUser, NameStudent, Mail });
            listViewStudent.Location = new Point(372, 96);
            listViewStudent.Name = "listViewStudent";
            listViewStudent.Size = new Size(428, 137);
            listViewStudent.TabIndex = 29;
            listViewStudent.UseCompatibleStateImageBehavior = false;
            listViewStudent.View = View.Details;
            // 
            // IdUser
            // 
            IdUser.Text = "N°";
            IdUser.Width = 40;
            // 
            // NameStudent
            // 
            NameStudent.Text = "Nombre Completo";
            NameStudent.Width = 160;
            // 
            // Mail
            // 
            Mail.Text = "Email";
            Mail.Width = 120;
            // 
            // btnEnviar
            // 
            btnEnviar.BackgroundImage = (Image)resources.GetObject("btnEnviar.BackgroundImage");
            btnEnviar.Enabled = false;
            btnEnviar.FlatStyle = FlatStyle.Flat;
            btnEnviar.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEnviar.ForeColor = Color.White;
            btnEnviar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEnviar.Location = new Point(372, 239);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(180, 45);
            btnEnviar.TabIndex = 30;
            btnEnviar.Text = "Enviar mensaje";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(601, 27);
            button3.Name = "button3";
            button3.Size = new Size(180, 45);
            button3.TabIndex = 31;
            button3.Text = "Tablon";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // groupBoxMensaje
            // 
            groupBoxMensaje.Controls.Add(comboBoxStudent);
            groupBoxMensaje.Controls.Add(btnSend);
            groupBoxMensaje.Controls.Add(rtxtBody);
            groupBoxMensaje.Controls.Add(txtSubjet);
            groupBoxMensaje.Controls.Add(etqBody);
            groupBoxMensaje.Controls.Add(etqSubjet);
            groupBoxMensaje.Controls.Add(etqFrom);
            groupBoxMensaje.Location = new Point(100, 290);
            groupBoxMensaje.Name = "groupBoxMensaje";
            groupBoxMensaje.Size = new Size(627, 188);
            groupBoxMensaje.TabIndex = 32;
            groupBoxMensaje.TabStop = false;
            groupBoxMensaje.Text = "Mensaje";
            groupBoxMensaje.Visible = false;
            // 
            // comboBoxStudent
            // 
            comboBoxStudent.FormattingEnabled = true;
            comboBoxStudent.Location = new Point(76, 27);
            comboBoxStudent.Name = "comboBoxStudent";
            comboBoxStudent.Size = new Size(262, 23);
            comboBoxStudent.TabIndex = 6;
            comboBoxStudent.Text = "Selecciona un estudiante";
            // 
            // btnSend
            // 
            btnSend.Location = new Point(533, 90);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(75, 23);
            btnSend.TabIndex = 5;
            btnSend.Text = "Enviar";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // rtxtBody
            // 
            rtxtBody.Location = new Point(76, 90);
            rtxtBody.Name = "rtxtBody";
            rtxtBody.Size = new Size(410, 92);
            rtxtBody.TabIndex = 4;
            rtxtBody.Text = "";
            // 
            // txtSubjet
            // 
            txtSubjet.Location = new Point(76, 58);
            txtSubjet.Name = "txtSubjet";
            txtSubjet.Size = new Size(410, 23);
            txtSubjet.TabIndex = 3;
            // 
            // etqBody
            // 
            etqBody.AutoSize = true;
            etqBody.Location = new Point(16, 90);
            etqBody.Name = "etqBody";
            etqBody.Size = new Size(54, 15);
            etqBody.TabIndex = 2;
            etqBody.Text = "Mensaje:";
            // 
            // etqSubjet
            // 
            etqSubjet.AutoSize = true;
            etqSubjet.Location = new Point(16, 59);
            etqSubjet.Name = "etqSubjet";
            etqSubjet.Size = new Size(48, 15);
            etqSubjet.TabIndex = 1;
            etqSubjet.Text = "Asunto:";
            // 
            // etqFrom
            // 
            etqFrom.AutoSize = true;
            etqFrom.Location = new Point(16, 30);
            etqFrom.Name = "etqFrom";
            etqFrom.Size = new Size(33, 15);
            etqFrom.TabIndex = 0;
            etqFrom.Text = "Para:";
            // 
            // FormCursada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(807, 490);
            Controls.Add(groupBoxMensaje);
            Controls.Add(button3);
            Controls.Add(btnEnviar);
            Controls.Add(listViewStudent);
            Controls.Add(btnStudent);
            Controls.Add(groupBox1);
            Name = "FormCursada";
            Text = "FormCursada";
            groupBox1.ResumeLayout(false);
            groupBoxMensaje.ResumeLayout(false);
            groupBoxMensaje.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private RichTextBox txtInfo;
        private Button btnStudent;
        private ListView listViewStudent;
        private ColumnHeader NameStudent;
        private ColumnHeader Mail;
        private Button btnEnviar;
        private Button button3;
        private GroupBox groupBoxMensaje;
        private TextBox txtSubjet;
        private Label etqBody;
        private Label etqSubjet;
        private Label etqFrom;
        private RichTextBox rtxtBody;
        private Button btnSend;
        private ColumnHeader IdUser;
        private ComboBox comboBoxStudent;
    }
}