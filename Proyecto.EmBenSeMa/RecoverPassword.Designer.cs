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
            btnCambiar = new Button();
            SuspendLayout();
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
            btnCambiar.Location = new Point(339, 203);
            btnCambiar.Name = "btnCambiar";
            btnCambiar.Size = new Size(123, 45);
            btnCambiar.TabIndex = 14;
            btnCambiar.Text = "Cambiar";
            btnCambiar.TextAlign = ContentAlignment.MiddleRight;
            btnCambiar.UseVisualStyleBackColor = false;
            btnCambiar.Visible = false;
            btnCambiar.Click += btnCambiar_Click;
            // 
            // RecoverPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCambiar);
            Name = "RecoverPassword";
            Text = "RecoverPassword";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCambiar;
    }
}