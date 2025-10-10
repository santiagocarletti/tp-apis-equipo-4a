namespace TpWindowsForms
{
    partial class Form1
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
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.pbxArticulos = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.cboImagenes = new System.Windows.Forms.ComboBox();
            this.txtFiltroRapido = new System.Windows.Forms.TextBox();
            this.lblFiltroRapido = new System.Windows.Forms.Label();
            this.txtBusquedaAvanzada = new System.Windows.Forms.TextBox();
            this.cboCampo = new System.Windows.Forms.ComboBox();
            this.cboCriterio = new System.Windows.Forms.ComboBox();
            this.lblCampo = new System.Windows.Forms.Label();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.btnBusquedaAvanzada = new System.Windows.Forms.Button();
            this.gbxBusquedaAvanzada = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnDetalles = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulos)).BeginInit();
            this.gbxBusquedaAvanzada.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvArticulos.ColumnHeadersHeight = 29;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.Location = new System.Drawing.Point(24, 86);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersWidth = 51;
            this.dgvArticulos.RowTemplate.Height = 24;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(919, 209);
            this.dgvArticulos.TabIndex = 0;
            this.dgvArticulos.TabStop = false;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // pbxArticulos
            // 
            this.pbxArticulos.Location = new System.Drawing.Point(972, 86);
            this.pbxArticulos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbxArticulos.Name = "pbxArticulos";
            this.pbxArticulos.Size = new System.Drawing.Size(240, 209);
            this.pbxArticulos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulos.TabIndex = 1;
            this.pbxArticulos.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(24, 310);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 28);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(16, 10);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(148, 39);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Artículos";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(145, 310);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(100, 28);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(267, 310);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(100, 28);
            this.btnBorrar.TabIndex = 3;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // cboImagenes
            // 
            this.cboImagenes.FormattingEnabled = true;
            this.cboImagenes.Location = new System.Drawing.Point(971, 311);
            this.cboImagenes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboImagenes.Name = "cboImagenes";
            this.cboImagenes.Size = new System.Drawing.Size(240, 24);
            this.cboImagenes.TabIndex = 4;
            this.cboImagenes.SelectedIndexChanged += new System.EventHandler(this.cboImagenes_SelectedIndexChanged);
            // 
            // txtFiltroRapido
            // 
            this.txtFiltroRapido.Location = new System.Drawing.Point(156, 53);
            this.txtFiltroRapido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFiltroRapido.Name = "txtFiltroRapido";
            this.txtFiltroRapido.Size = new System.Drawing.Size(207, 22);
            this.txtFiltroRapido.TabIndex = 0;
            this.txtFiltroRapido.TextChanged += new System.EventHandler(this.txtFiltroRapido_TextChanged);
            // 
            // lblFiltroRapido
            // 
            this.lblFiltroRapido.AutoSize = true;
            this.lblFiltroRapido.Location = new System.Drawing.Point(20, 55);
            this.lblFiltroRapido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltroRapido.Name = "lblFiltroRapido";
            this.lblFiltroRapido.Size = new System.Drawing.Size(117, 16);
            this.lblFiltroRapido.TabIndex = 8;
            this.lblFiltroRapido.Text = "Búsqueda Rápida";
            // 
            // txtBusquedaAvanzada
            // 
            this.txtBusquedaAvanzada.Location = new System.Drawing.Point(585, 32);
            this.txtBusquedaAvanzada.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBusquedaAvanzada.Name = "txtBusquedaAvanzada";
            this.txtBusquedaAvanzada.Size = new System.Drawing.Size(332, 22);
            this.txtBusquedaAvanzada.TabIndex = 2;
            // 
            // cboCampo
            // 
            this.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Location = new System.Drawing.Point(91, 32);
            this.cboCampo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(160, 24);
            this.cboCampo.TabIndex = 0;
            this.cboCampo.SelectedIndexChanged += new System.EventHandler(this.cboCampo_SelectedIndexChanged);
            // 
            // cboCriterio
            // 
            this.cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterio.FormattingEnabled = true;
            this.cboCriterio.Location = new System.Drawing.Point(344, 32);
            this.cboCriterio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboCriterio.Name = "cboCriterio";
            this.cboCriterio.Size = new System.Drawing.Size(160, 24);
            this.cboCriterio.TabIndex = 1;
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(29, 37);
            this.lblCampo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(51, 16);
            this.lblCampo.TabIndex = 13;
            this.lblCampo.Text = "Campo";
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(284, 37);
            this.lblCriterio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(49, 16);
            this.lblCriterio.TabIndex = 14;
            this.lblCriterio.Text = "Criterio";
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(536, 37);
            this.lblFiltro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(36, 16);
            this.lblFiltro.TabIndex = 15;
            this.lblFiltro.Text = "Filtro";
            // 
            // btnBusquedaAvanzada
            // 
            this.btnBusquedaAvanzada.Location = new System.Drawing.Point(947, 31);
            this.btnBusquedaAvanzada.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBusquedaAvanzada.Name = "btnBusquedaAvanzada";
            this.btnBusquedaAvanzada.Size = new System.Drawing.Size(108, 28);
            this.btnBusquedaAvanzada.TabIndex = 3;
            this.btnBusquedaAvanzada.Text = "Buscar";
            this.btnBusquedaAvanzada.UseVisualStyleBackColor = true;
            this.btnBusquedaAvanzada.Click += new System.EventHandler(this.btnBusquedaAvanzada_Click);
            // 
            // gbxBusquedaAvanzada
            // 
            this.gbxBusquedaAvanzada.Controls.Add(this.btnLimpiar);
            this.gbxBusquedaAvanzada.Controls.Add(this.cboCampo);
            this.gbxBusquedaAvanzada.Controls.Add(this.btnBusquedaAvanzada);
            this.gbxBusquedaAvanzada.Controls.Add(this.lblCampo);
            this.gbxBusquedaAvanzada.Controls.Add(this.lblFiltro);
            this.gbxBusquedaAvanzada.Controls.Add(this.cboCriterio);
            this.gbxBusquedaAvanzada.Controls.Add(this.txtBusquedaAvanzada);
            this.gbxBusquedaAvanzada.Controls.Add(this.lblCriterio);
            this.gbxBusquedaAvanzada.Location = new System.Drawing.Point(24, 353);
            this.gbxBusquedaAvanzada.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxBusquedaAvanzada.Name = "gbxBusquedaAvanzada";
            this.gbxBusquedaAvanzada.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxBusquedaAvanzada.Size = new System.Drawing.Size(1219, 78);
            this.gbxBusquedaAvanzada.TabIndex = 17;
            this.gbxBusquedaAvanzada.TabStop = false;
            this.gbxBusquedaAvanzada.Text = "Búsqueda Avanzada";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(1080, 31);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(108, 28);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnDetalles
            // 
            this.btnDetalles.Location = new System.Drawing.Point(385, 310);
            this.btnDetalles.Name = "btnDetalles";
            this.btnDetalles.Size = new System.Drawing.Size(100, 28);
            this.btnDetalles.TabIndex = 18;
            this.btnDetalles.Text = "Detalles";
            this.btnDetalles.UseVisualStyleBackColor = true;
            this.btnDetalles.Click += new System.EventHandler(this.btnDetalles_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 434);
            this.Controls.Add(this.btnDetalles);
            this.Controls.Add(this.gbxBusquedaAvanzada);
            this.Controls.Add(this.lblFiltroRapido);
            this.Controls.Add(this.txtFiltroRapido);
            this.Controls.Add(this.cboImagenes);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pbxArticulos);
            this.Controls.Add(this.dgvArticulos);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1274, 481);
            this.MinimumSize = new System.Drawing.Size(1274, 481);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor de artículos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulos)).EndInit();
            this.gbxBusquedaAvanzada.ResumeLayout(false);
            this.gbxBusquedaAvanzada.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.PictureBox pbxArticulos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.ComboBox cboImagenes;
        private System.Windows.Forms.TextBox txtFiltroRapido;
        private System.Windows.Forms.Label lblFiltroRapido;
        private System.Windows.Forms.TextBox txtBusquedaAvanzada;
        private System.Windows.Forms.ComboBox cboCampo;
        private System.Windows.Forms.ComboBox cboCriterio;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.Button btnBusquedaAvanzada;
        private System.Windows.Forms.GroupBox gbxBusquedaAvanzada;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnDetalles;
    }
}

