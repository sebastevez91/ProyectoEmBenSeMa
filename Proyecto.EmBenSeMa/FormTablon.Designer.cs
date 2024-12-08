namespace SchoolMusic.Proyecto
{
    partial class FormTablon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTablon));
            grBoxAnuncio = new GroupBox();
            txtTitulo = new TextBox();
            button1 = new Button();
            txtAnuncio = new TextBox();
            groupBox2 = new GroupBox();
            etqTitulo = new Label();
            contenidoAnuncio = new RichTextBox();
            grBoxComen = new GroupBox();
            trViewComent = new TreeView();
            button4 = new Button();
            txtComentario = new TextBox();
            listTopic = new ListBox();
            tittle = new Label();
            profesor = new Label();
            grBoxAnuncio.SuspendLayout();
            groupBox2.SuspendLayout();
            grBoxComen.SuspendLayout();
            SuspendLayout();
            // 
            // grBoxAnuncio
            // 
            grBoxAnuncio.BackColor = Color.Transparent;
            grBoxAnuncio.Controls.Add(txtTitulo);
            grBoxAnuncio.Controls.Add(button1);
            grBoxAnuncio.Controls.Add(txtAnuncio);
            grBoxAnuncio.Location = new Point(55, 127);
            grBoxAnuncio.Name = "grBoxAnuncio";
            grBoxAnuncio.Size = new Size(721, 93);
            grBoxAnuncio.TabIndex = 0;
            grBoxAnuncio.TabStop = false;
            grBoxAnuncio.Text = "Nuevo anuncio";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(6, 25);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.PlaceholderText = "Ingrese el titulo del anuncio";
            txtTitulo.Size = new Size(310, 23);
            txtTitulo.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(570, 54);
            button1.Name = "button1";
            button1.Size = new Size(120, 29);
            button1.TabIndex = 1;
            button1.Text = "Publicar anuncio";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtAnuncio
            // 
            txtAnuncio.Location = new Point(6, 54);
            txtAnuncio.Multiline = true;
            txtAnuncio.Name = "txtAnuncio";
            txtAnuncio.PlaceholderText = "Ingresa tu anuncio aqui";
            txtAnuncio.Size = new Size(533, 33);
            txtAnuncio.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(etqTitulo);
            groupBox2.Controls.Add(contenidoAnuncio);
            groupBox2.Controls.Add(grBoxComen);
            groupBox2.Controls.Add(listTopic);
            groupBox2.Location = new Point(55, 226);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(721, 357);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Anuncios de cursada";
            // 
            // etqTitulo
            // 
            etqTitulo.AutoSize = true;
            etqTitulo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            etqTitulo.Location = new Point(193, 17);
            etqTitulo.Name = "etqTitulo";
            etqTitulo.Size = new Size(41, 17);
            etqTitulo.TabIndex = 8;
            etqTitulo.Text = "label1";
            // 
            // contenidoAnuncio
            // 
            contenidoAnuncio.Enabled = false;
            contenidoAnuncio.Location = new Point(189, 44);
            contenidoAnuncio.Name = "contenidoAnuncio";
            contenidoAnuncio.Size = new Size(514, 159);
            contenidoAnuncio.TabIndex = 7;
            contenidoAnuncio.Text = "";
            // 
            // grBoxComen
            // 
            grBoxComen.Controls.Add(trViewComent);
            grBoxComen.Controls.Add(button4);
            grBoxComen.Controls.Add(txtComentario);
            grBoxComen.Location = new Point(189, 210);
            grBoxComen.Name = "grBoxComen";
            grBoxComen.Size = new Size(517, 141);
            grBoxComen.TabIndex = 2;
            grBoxComen.TabStop = false;
            // 
            // trViewComent
            // 
            trViewComent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            trViewComent.HideSelection = false;
            trViewComent.ItemHeight = 20;
            trViewComent.Location = new Point(6, 12);
            trViewComent.Name = "trViewComent";
            trViewComent.Size = new Size(508, 88);
            trViewComent.TabIndex = 3;
            // 
            // button4
            // 
            button4.Location = new Point(347, 105);
            button4.Name = "button4";
            button4.Size = new Size(154, 23);
            button4.TabIndex = 2;
            button4.Text = "Publicar comentario";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // txtComentario
            // 
            txtComentario.Location = new Point(6, 106);
            txtComentario.Name = "txtComentario";
            txtComentario.PlaceholderText = "Ingresa un comentario del anuncio ";
            txtComentario.Size = new Size(324, 23);
            txtComentario.TabIndex = 0;
            // 
            // listTopic
            // 
            listTopic.FormattingEnabled = true;
            listTopic.ItemHeight = 15;
            listTopic.Location = new Point(6, 17);
            listTopic.Name = "listTopic";
            listTopic.Size = new Size(174, 304);
            listTopic.TabIndex = 6;
            listTopic.SelectedIndexChanged += listTopic_SelectedIndexChanged;
            // 
            // tittle
            // 
            tittle.AutoSize = true;
            tittle.BackColor = Color.Transparent;
            tittle.Font = new Font("Segoe Print", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            tittle.Location = new Point(46, 44);
            tittle.Name = "tittle";
            tittle.Size = new Size(105, 51);
            tittle.TabIndex = 9;
            tittle.Text = "Titulo";
            // 
            // profesor
            // 
            profesor.AutoSize = true;
            profesor.BackColor = Color.Transparent;
            profesor.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            profesor.Location = new Point(61, 95);
            profesor.Name = "profesor";
            profesor.Size = new Size(50, 23);
            profesor.TabIndex = 10;
            profesor.Text = "label1";
            // 
            // FormTablon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Olive;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(829, 636);
            Controls.Add(profesor);
            Controls.Add(tittle);
            Controls.Add(groupBox2);
            Controls.Add(grBoxAnuncio);
            Name = "FormTablon";
            Text = "Tablon de Cursada";
            grBoxAnuncio.ResumeLayout(false);
            grBoxAnuncio.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            grBoxComen.ResumeLayout(false);
            grBoxComen.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grBoxAnuncio;
        private TextBox txtAnuncio;
        private Button button1;
        private GroupBox groupBox2;
        private GroupBox grBoxComen;
        private Button button4;
        private TextBox txtComentario;
        private ListBox listTopic;
        private RichTextBox contenidoAnuncio;
        private TreeView trViewComent;
        private TextBox txtTitulo;
        private Label etqTitulo;
        private Label tittle;
        private Label profesor;
    }
}