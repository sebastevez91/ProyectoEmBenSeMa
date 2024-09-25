namespace SchoolMusic.Proyecto
{
    partial class FormPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPayment));
            etqPlataforma = new Label();
            pictureBox1 = new PictureBox();
            comboMesPagar = new ComboBox();
            groupCuota = new GroupBox();
            etqMetodo = new Label();
            comboMetodo = new ComboBox();
            btnPagar = new Button();
            btnVerPagar = new Button();
            eqtEstado = new Label();
            etqDni = new Label();
            btnSalir = new Button();
            label2 = new Label();
            comboCurso = new ComboBox();
            label3 = new Label();
            btnMostrar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupCuota.SuspendLayout();
            SuspendLayout();
            // 
            // etqPlataforma
            // 
            etqPlataforma.AutoSize = true;
            etqPlataforma.BackColor = Color.Transparent;
            etqPlataforma.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            etqPlataforma.ForeColor = Color.Snow;
            etqPlataforma.Location = new Point(49, 37);
            etqPlataforma.Name = "etqPlataforma";
            etqPlataforma.Size = new Size(220, 29);
            etqPlataforma.TabIndex = 10;
            etqPlataforma.Text = "Billetera de pagos";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(411, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(110, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // comboMesPagar
            // 
            comboMesPagar.FormattingEnabled = true;
            comboMesPagar.Location = new Point(61, 19);
            comboMesPagar.Name = "comboMesPagar";
            comboMesPagar.Size = new Size(203, 23);
            comboMesPagar.TabIndex = 13;
            // 
            // groupCuota
            // 
            groupCuota.BackColor = Color.Transparent;
            groupCuota.Controls.Add(etqMetodo);
            groupCuota.Controls.Add(comboMetodo);
            groupCuota.Controls.Add(btnPagar);
            groupCuota.Controls.Add(btnVerPagar);
            groupCuota.Controls.Add(eqtEstado);
            groupCuota.Controls.Add(etqDni);
            groupCuota.Controls.Add(comboMesPagar);
            groupCuota.Location = new Point(55, 104);
            groupCuota.Name = "groupCuota";
            groupCuota.Size = new Size(480, 187);
            groupCuota.TabIndex = 14;
            groupCuota.TabStop = false;
            groupCuota.Text = "Coutas";
            groupCuota.Visible = false;
            // 
            // etqMetodo
            // 
            etqMetodo.AutoSize = true;
            etqMetodo.BackColor = Color.Transparent;
            etqMetodo.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            etqMetodo.ForeColor = Color.Snow;
            etqMetodo.Location = new Point(6, 139);
            etqMetodo.Name = "etqMetodo";
            etqMetodo.Size = new Size(133, 22);
            etqMetodo.TabIndex = 21;
            etqMetodo.Text = "Método de pago";
            etqMetodo.Visible = false;
            // 
            // comboMetodo
            // 
            comboMetodo.FormattingEnabled = true;
            comboMetodo.Items.AddRange(new object[] { "Transferencia", "Tarjeta Débito", "Tarjeta de Credito", "Efectivo" });
            comboMetodo.Location = new Point(145, 141);
            comboMetodo.Name = "comboMetodo";
            comboMetodo.Size = new Size(241, 23);
            comboMetodo.TabIndex = 20;
            comboMetodo.Text = "Seleccione un método de pago";
            comboMetodo.Visible = false;
            // 
            // btnPagar
            // 
            btnPagar.BackColor = Color.Transparent;
            btnPagar.BackgroundImage = (Image)resources.GetObject("btnPagar.BackgroundImage");
            btnPagar.BackgroundImageLayout = ImageLayout.Stretch;
            btnPagar.FlatStyle = FlatStyle.Flat;
            btnPagar.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnPagar.ForeColor = Color.Transparent;
            btnPagar.ImageAlign = ContentAlignment.MiddleLeft;
            btnPagar.Location = new Point(392, 141);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(74, 30);
            btnPagar.TabIndex = 19;
            btnPagar.Text = "Pagar";
            btnPagar.UseVisualStyleBackColor = false;
            btnPagar.Visible = false;
            btnPagar.Click += btnPagar_Click;
            // 
            // btnVerPagar
            // 
            btnVerPagar.BackColor = Color.Transparent;
            btnVerPagar.BackgroundImage = (Image)resources.GetObject("btnVerPagar.BackgroundImage");
            btnVerPagar.BackgroundImageLayout = ImageLayout.Stretch;
            btnVerPagar.FlatStyle = FlatStyle.Flat;
            btnVerPagar.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnVerPagar.ForeColor = Color.Transparent;
            btnVerPagar.ImageAlign = ContentAlignment.MiddleLeft;
            btnVerPagar.Location = new Point(270, 17);
            btnVerPagar.Name = "btnVerPagar";
            btnVerPagar.Size = new Size(74, 30);
            btnVerPagar.TabIndex = 18;
            btnVerPagar.Text = "Ver";
            btnVerPagar.UseVisualStyleBackColor = false;
            btnVerPagar.Click += btnVerPagar_Click;
            // 
            // eqtEstado
            // 
            eqtEstado.AutoSize = true;
            eqtEstado.BackColor = Color.Transparent;
            eqtEstado.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            eqtEstado.ForeColor = Color.Black;
            eqtEstado.Location = new Point(15, 54);
            eqtEstado.Name = "eqtEstado";
            eqtEstado.RightToLeft = RightToLeft.No;
            eqtEstado.Size = new Size(117, 22);
            eqtEstado.TabIndex = 17;
            eqtEstado.Text = "Muestra cuota";
            eqtEstado.Visible = false;
            // 
            // etqDni
            // 
            etqDni.AutoSize = true;
            etqDni.BackColor = Color.Transparent;
            etqDni.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            etqDni.ForeColor = Color.Snow;
            etqDni.Location = new Point(15, 20);
            etqDni.Name = "etqDni";
            etqDni.Size = new Size(45, 22);
            etqDni.TabIndex = 15;
            etqDni.Text = "Mes:";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Transparent;
            btnSalir.BackgroundImage = (Image)resources.GetObject("btnSalir.BackgroundImage");
            btnSalir.BackgroundImageLayout = ImageLayout.Stretch;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe Print", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.Transparent;
            btnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalir.Location = new Point(393, 297);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(128, 45);
            btnSalir.TabIndex = 17;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.Snow;
            label2.Location = new Point(55, 79);
            label2.Name = "label2";
            label2.Size = new Size(52, 22);
            label2.TabIndex = 23;
            label2.Text = "Curso";
            label2.Visible = false;
            // 
            // comboCurso
            // 
            comboCurso.FormattingEnabled = true;
            comboCurso.Location = new Point(95, 79);
            comboCurso.Name = "comboCurso";
            comboCurso.Size = new Size(141, 23);
            comboCurso.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.Snow;
            label3.Location = new Point(279, 43);
            label3.Name = "label3";
            label3.Size = new Size(71, 22);
            label3.TabIndex = 24;
            label3.Text = "Alumno:";
            label3.Visible = false;
            // 
            // btnMostrar
            // 
            btnMostrar.BackColor = Color.Transparent;
            btnMostrar.BackgroundImage = (Image)resources.GetObject("btnMostrar.BackgroundImage");
            btnMostrar.BackgroundImageLayout = ImageLayout.Stretch;
            btnMostrar.FlatStyle = FlatStyle.Flat;
            btnMostrar.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnMostrar.ForeColor = Color.Transparent;
            btnMostrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnMostrar.Location = new Point(242, 69);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(69, 33);
            btnMostrar.TabIndex = 25;
            btnMostrar.Text = "Mostrar";
            btnMostrar.TextAlign = ContentAlignment.TopLeft;
            btnMostrar.UseVisualStyleBackColor = false;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // FormPayment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(595, 388);
            Controls.Add(btnMostrar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboCurso);
            Controls.Add(btnSalir);
            Controls.Add(groupCuota);
            Controls.Add(pictureBox1);
            Controls.Add(etqPlataforma);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormPayment";
            Text = "Pagos";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupCuota.ResumeLayout(false);
            groupCuota.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label etqPlataforma;
        private PictureBox pictureBox1;
        private ComboBox comboMesPagar;
        private GroupBox groupCuota;
        private Label eqtEstado;
        private Label etqDni;
        private Button btnVerPagar;
        private Button btnSalir;
        private Button btnPagar;
        private Label etqMetodo;
        private ComboBox comboMetodo;
        private Label label2;
        private ComboBox comboCurso;
        private Label label3;
        private Button btnMostrar;
    }
}