namespace GeneradorDePdfs
{
    partial class ProyectoAdmin
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
            BtnIngresar = new Button();
            lblNombre = new Label();
            lblContraseña = new Label();
            txtNombre = new TextBox();
            txtContrasena = new TextBox();
            BtnRegresar = new Button();
            GruopDeLogib = new GroupBox();
            panel1 = new Panel();
            GruopDeLogib.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // BtnIngresar
            // 
            BtnIngresar.Location = new Point(210, 209);
            BtnIngresar.Name = "BtnIngresar";
            BtnIngresar.Size = new Size(75, 23);
            BtnIngresar.TabIndex = 0;
            BtnIngresar.Text = "Ingresar";
            BtnIngresar.UseVisualStyleBackColor = true;
            BtnIngresar.Click += BtnIngresar_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.ForeColor = Color.WhiteSmoke;
            lblNombre.Location = new Point(43, 8);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.ForeColor = Color.WhiteSmoke;
            lblContraseña.Location = new Point(43, 90);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(67, 15);
            lblContraseña.TabIndex = 2;
            lblContraseña.Text = "Contraseña";
            lblContraseña.Click += lblContraseña_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(43, 35);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(242, 23);
            txtNombre.TabIndex = 3;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(43, 122);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(242, 23);
            txtContrasena.TabIndex = 4;
            // 
            // BtnRegresar
            // 
            BtnRegresar.Location = new Point(43, 209);
            BtnRegresar.Name = "BtnRegresar";
            BtnRegresar.Size = new Size(75, 23);
            BtnRegresar.TabIndex = 5;
            BtnRegresar.Text = "Regresar";
            BtnRegresar.UseVisualStyleBackColor = true;
            // 
            // GruopDeLogib
            // 
            GruopDeLogib.Controls.Add(BtnRegresar);
            GruopDeLogib.Controls.Add(txtContrasena);
            GruopDeLogib.Controls.Add(txtNombre);
            GruopDeLogib.Controls.Add(lblContraseña);
            GruopDeLogib.Controls.Add(lblNombre);
            GruopDeLogib.Controls.Add(BtnIngresar);
            GruopDeLogib.Location = new Point(95, 65);
            GruopDeLogib.Name = "GruopDeLogib";
            GruopDeLogib.Size = new Size(338, 249);
            GruopDeLogib.TabIndex = 6;
            GruopDeLogib.TabStop = false;
            GruopDeLogib.Text = "groupBox1";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(GruopDeLogib);
            panel1.Location = new Point(134, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(539, 390);
            panel1.TabIndex = 7;
            // 
            // ProyectoAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "ProyectoAdmin";
            Text = "ProyectoAdmin";
            GruopDeLogib.ResumeLayout(false);
            GruopDeLogib.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button BtnIngresar;
        private Label lblNombre;
        private Label lblContraseña;
        private TextBox txtNombre;
        private TextBox txtContrasena;
        private Button BtnRegresar;
        private GroupBox GruopDeLogib;
        private Panel panel1;
    }
}