namespace pryVerduBiblioteca
{
    partial class FrmBiblioteca
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvBiblioteca = new System.Windows.Forms.DataGridView();
            this.btnAvanzar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombrelibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigoeditorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigoautor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigodistribuidor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBiblioteca)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBiblioteca
            // 
            this.dgvBiblioteca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBiblioteca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombrelibro,
            this.Codigoeditorial,
            this.Codigoautor,
            this.Codigodistribuidor});
            this.dgvBiblioteca.Location = new System.Drawing.Point(12, 12);
            this.dgvBiblioteca.Name = "dgvBiblioteca";
            this.dgvBiblioteca.Size = new System.Drawing.Size(543, 238);
            this.dgvBiblioteca.TabIndex = 0;
            // 
            // btnAvanzar
            // 
            this.btnAvanzar.Location = new System.Drawing.Point(464, 256);
            this.btnAvanzar.Name = "btnAvanzar";
            this.btnAvanzar.Size = new System.Drawing.Size(91, 23);
            this.btnAvanzar.TabIndex = 1;
            this.btnAvanzar.Text = "Avanzar";
            this.btnAvanzar.UseVisualStyleBackColor = true;
            this.btnAvanzar.Click += new System.EventHandler(this.btnAvanzar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(367, 256);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(91, 23);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            // 
            // Nombrelibro
            // 
            this.Nombrelibro.HeaderText = "Nombre libro";
            this.Nombrelibro.Name = "Nombrelibro";
            // 
            // Codigoeditorial
            // 
            this.Codigoeditorial.HeaderText = "Código editorial";
            this.Codigoeditorial.Name = "Codigoeditorial";
            // 
            // Codigoautor
            // 
            this.Codigoautor.HeaderText = "Código autor";
            this.Codigoautor.Name = "Codigoautor";
            // 
            // Codigodistribuidor
            // 
            this.Codigodistribuidor.HeaderText = "Código distribuidor";
            this.Codigodistribuidor.Name = "Codigodistribuidor";
            // 
            // FrmBiblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 289);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnAvanzar);
            this.Controls.Add(this.dgvBiblioteca);
            this.Name = "FrmBiblioteca";
            this.Text = "Biblioteca";
            this.Load += new System.EventHandler(this.FrmBiblioteca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBiblioteca)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBiblioteca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombrelibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigoeditorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigoautor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigodistribuidor;
        private System.Windows.Forms.Button btnAvanzar;
        private System.Windows.Forms.Button btnVolver;
    }
}

