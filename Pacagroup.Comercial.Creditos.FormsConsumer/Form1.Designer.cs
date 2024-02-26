namespace Pacagroup.Comercial.Creditos.FormsConsumer {
    partial class frmListadoCreditos {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.gridCreditos = new System.Windows.Forms.DataGridView();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnListarSoap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridCreditos)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCreditos
            // 
            this.gridCreditos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCreditos.Location = new System.Drawing.Point(12, 172);
            this.gridCreditos.Name = "gridCreditos";
            this.gridCreditos.RowHeadersWidth = 51;
            this.gridCreditos.RowTemplate.Height = 24;
            this.gridCreditos.Size = new System.Drawing.Size(975, 291);
            this.gridCreditos.TabIndex = 0;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(877, 49);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(110, 39);
            this.btnListar.TabIndex = 1;
            this.btnListar.Text = "Listar Rest";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnListarSoap
            // 
            this.btnListarSoap.Location = new System.Drawing.Point(877, 112);
            this.btnListarSoap.Name = "btnListarSoap";
            this.btnListarSoap.Size = new System.Drawing.Size(110, 39);
            this.btnListarSoap.TabIndex = 2;
            this.btnListarSoap.Text = "Listar Soap";
            this.btnListarSoap.UseVisualStyleBackColor = true;
            this.btnListarSoap.Click += new System.EventHandler(this.btnListarSoap_Click);
            // 
            // frmListadoCreditos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 475);
            this.Controls.Add(this.btnListarSoap);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.gridCreditos);
            this.Name = "frmListadoCreditos";
            this.Text = "Listado de Créditos";
            ((System.ComponentModel.ISupportInitialize)(this.gridCreditos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridCreditos;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnListarSoap;
    }
}

