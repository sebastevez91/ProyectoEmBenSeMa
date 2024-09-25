namespace Proyecto.EmBenSeMa
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            btnAlumnos = new Button();
            btnProfe = new Button();
            btnContacto = new Button();
            btnCursos = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAlumnos
            // 
            btnAlumnos.Anchor = AnchorStyles.Left;
            btnAlumnos.BackColor = Color.Transparent;
            btnAlumnos.BackgroundImage = (Image)resources.GetObject("btnAlumnos.BackgroundImage");
            btnAlumnos.BackgroundImageLayout = ImageLayout.Stretch;
            btnAlumnos.FlatStyle = FlatStyle.Flat;
            btnAlumnos.Font = new Font("Segoe Print", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAlumnos.ForeColor = Color.White;
            btnAlumnos.Image = (Image)resources.GetObject("btnAlumnos.Image");
            btnAlumnos.ImageAlign = ContentAlignment.MiddleLeft;
            btnAlumnos.Location = new Point(12, 38);
            btnAlumnos.Name = "btnAlumnos";
            btnAlumnos.Size = new Size(242, 56);
            btnAlumnos.TabIndex = 0;
            btnAlumnos.Text = "Alumnos";
            btnAlumnos.TextAlign = ContentAlignment.BottomRight;
            btnAlumnos.UseVisualStyleBackColor = false;
            btnAlumnos.Click += btnAlumnos_Click;
            // 
            // btnProfe
            // 
            btnProfe.Anchor = AnchorStyles.Left;
            btnProfe.BackColor = Color.Transparent;
            btnProfe.BackgroundImage = (Image)resources.GetObject("btnProfe.BackgroundImage");
            btnProfe.BackgroundImageLayout = ImageLayout.Stretch;
            btnProfe.FlatStyle = FlatStyle.Flat;
            btnProfe.Font = new Font("Segoe Print", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnProfe.ForeColor = Color.White;
            btnProfe.Image = (Image)resources.GetObject("btnProfe.Image");
            btnProfe.ImageAlign = ContentAlignment.MiddleLeft;
            btnProfe.Location = new Point(12, 100);
            btnProfe.Name = "btnProfe";
            btnProfe.Size = new Size(242, 56);
            btnProfe.TabIndex = 1;
            btnProfe.Text = "Profesores";
            btnProfe.TextAlign = ContentAlignment.BottomRight;
            btnProfe.UseVisualStyleBackColor = false;
            btnProfe.Click += btnProfe_Click;
            // 
            // btnContacto
            // 
            btnContacto.Anchor = AnchorStyles.Left;
            btnContacto.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnContacto.BackColor = Color.Transparent;
            btnContacto.BackgroundImage = (Image)resources.GetObject("btnContacto.BackgroundImage");
            btnContacto.FlatStyle = FlatStyle.Flat;
            btnContacto.Font = new Font("Segoe Print", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnContacto.ForeColor = Color.White;
            btnContacto.Image = (Image)resources.GetObject("btnContacto.Image");
            btnContacto.ImageAlign = ContentAlignment.MiddleLeft;
            btnContacto.Location = new Point(12, 224);
            btnContacto.Name = "btnContacto";
            btnContacto.Size = new Size(242, 56);
            btnContacto.TabIndex = 4;
            btnContacto.Text = "Contacto";
            btnContacto.TextAlign = ContentAlignment.BottomRight;
            btnContacto.UseVisualStyleBackColor = false;
            btnContacto.Click += btnContacto_Click;
            // 
            // btnCursos
            // 
            btnCursos.Anchor = AnchorStyles.Left;
            btnCursos.BackColor = Color.Transparent;
            btnCursos.BackgroundImage = (Image)resources.GetObject("btnCursos.BackgroundImage");
            btnCursos.BackgroundImageLayout = ImageLayout.Stretch;
            btnCursos.FlatStyle = FlatStyle.Flat;
            btnCursos.Font = new Font("Segoe Print", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCursos.ForeColor = Color.White;
            btnCursos.Image = (Image)resources.GetObject("btnCursos.Image");
            btnCursos.ImageAlign = ContentAlignment.MiddleLeft;
            btnCursos.Location = new Point(12, 162);
            btnCursos.Name = "btnCursos";
            btnCursos.Size = new Size(242, 56);
            btnCursos.TabIndex = 5;
            btnCursos.Text = "Cursos";
            btnCursos.TextAlign = ContentAlignment.BottomRight;
            btnCursos.UseVisualStyleBackColor = false;
            btnCursos.Click += btnCursos_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(260, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(382, 183);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ActiveBorder;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(702, 374);
            Controls.Add(pictureBox1);
            Controls.Add(btnCursos);
            Controls.Add(btnContacto);
            Controls.Add(btnProfe);
            Controls.Add(btnAlumnos);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMain";
            Text = "School EmBenSeMa";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAlumnos;
        private Button btnProfe;
        private Button btnContacto;
        private Button btnCursos;
        private PictureBox pictureBox1;
    }
}
