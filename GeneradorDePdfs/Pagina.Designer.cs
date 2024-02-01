namespace GeneradorDePdfs
{
    partial class Principal
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
            dgvVista = new DataGridView();
            PicImagen = new PictureBox();
            BtnIngrsar = new Button();
            LblFiltro = new Label();
            txtFiltro = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvVista).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicImagen).BeginInit();
            SuspendLayout();
            // 
            // dgvVista
            // 
            dgvVista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVista.Location = new Point(223, 79);
            dgvVista.Name = "dgvVista";
            dgvVista.Size = new Size(440, 298);
            dgvVista.TabIndex = 0;
            dgvVista.CellContentClick += dgvVista_CellContentClick;
            // 
            // PicImagen
            // 
            PicImagen.Location = new Point(3, 79);
            PicImagen.Name = "PicImagen";
            PicImagen.Size = new Size(197, 298);
            PicImagen.TabIndex = 1;
            PicImagen.TabStop = false;
            // 
            // BtnIngrsar
            // 
            BtnIngrsar.Location = new Point(588, 30);
            BtnIngrsar.Name = "BtnIngrsar";
            BtnIngrsar.Size = new Size(75, 23);
            BtnIngrsar.TabIndex = 2;
            BtnIngrsar.Text = "Ingresar";
            BtnIngrsar.UseVisualStyleBackColor = true;
            BtnIngrsar.Click += BtnIngrsar_Click;
            // 
            // LblFiltro
            // 
            LblFiltro.AutoSize = true;
            LblFiltro.Location = new Point(3, 38);
            LblFiltro.Name = "LblFiltro";
            LblFiltro.Size = new Size(34, 15);
            LblFiltro.TabIndex = 3;
            LblFiltro.Text = "Filtro";
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(54, 30);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(137, 23);
            txtFiltro.TabIndex = 4;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 450);
            Controls.Add(txtFiltro);
            Controls.Add(LblFiltro);
            Controls.Add(BtnIngrsar);
            Controls.Add(PicImagen);
            Controls.Add(dgvVista);
            Name = "Principal";
            Text = "General";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVista).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicImagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvVista;
        private PictureBox PicImagen;
        private Button BtnIngrsar;
        private Label LblFiltro;
        private TextBox txtFiltro;
    }
}
