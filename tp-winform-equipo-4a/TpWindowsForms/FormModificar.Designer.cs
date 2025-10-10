namespace TpWindowsForms
{
    partial class FormModificar
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
            this.lblArticulo = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cboImagenes = new System.Windows.Forms.ComboBox();
            this.txtImagen = new System.Windows.Forms.TextBox();
            this.lblImagene = new System.Windows.Forms.Label();
            this.btnAgregarImagen = new System.Windows.Forms.Button();
            this.btnEliminarImagen = new System.Windows.Forms.Button();
            this.lblErrorCodigo = new System.Windows.Forms.Label();
            this.lblErrorNombre = new System.Windows.Forms.Label();
            this.lblCamposObligatorios = new System.Windows.Forms.Label();
            this.lblErrorPrecio = new System.Windows.Forms.Label();
            this.lblErrorMarca = new System.Windows.Forms.Label();
            this.lblErrorCategoria = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblArticulo
            // 
            this.lblArticulo.AutoSize = true;
            this.lblArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArticulo.Location = new System.Drawing.Point(37, 38);
            this.lblArticulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblArticulo.Name = "lblArticulo";
            this.lblArticulo.Size = new System.Drawing.Size(77, 25);
            this.lblArticulo.TabIndex = 0;
            this.lblArticulo.Text = "Artículo";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(39, 87);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Código";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(39, 111);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(39, 135);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(39, 215);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 4;
            this.lblMarca.Text = "Marca";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(40, 240);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(54, 13);
            this.lblCategoria.TabIndex = 5;
            this.lblCategoria.Text = "Categoría";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(40, 265);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 6;
            this.lblPrecio.Text = "Precio";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(146, 84);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCodigo.MaxLength = 50;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(116, 20);
            this.txtCodigo.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(146, 108);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(152, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(146, 132);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDescripcion.MaxLength = 150;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(152, 76);
            this.txtDescripcion.TabIndex = 2;
            // 
            // cboCategoria
            // 
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(146, 237);
            this.cboCategoria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(152, 21);
            this.cboCategoria.TabIndex = 4;
            // 
            // cboMarca
            // 
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(146, 212);
            this.cboMarca.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(152, 21);
            this.cboMarca.TabIndex = 3;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(146, 262);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrecio.MaxLength = 8;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(116, 20);
            this.txtPrecio.TabIndex = 5;
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.Location = new System.Drawing.Point(377, 84);
            this.pbxArticulo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(190, 190);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulo.TabIndex = 14;
            this.pbxArticulo.TabStop = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(149, 378);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(74, 26);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(227, 379);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(69, 25);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cboImagenes
            // 
            this.cboImagenes.FormattingEnabled = true;
            this.cboImagenes.Location = new System.Drawing.Point(146, 291);
            this.cboImagenes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboImagenes.Name = "cboImagenes";
            this.cboImagenes.Size = new System.Drawing.Size(152, 21);
            this.cboImagenes.TabIndex = 6;
            this.cboImagenes.SelectedIndexChanged += new System.EventHandler(this.cboImagenes_SelectedIndexChanged);
            // 
            // txtImagen
            // 
            this.txtImagen.Location = new System.Drawing.Point(146, 316);
            this.txtImagen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtImagen.MaxLength = 1000;
            this.txtImagen.Name = "txtImagen";
            this.txtImagen.Size = new System.Drawing.Size(152, 20);
            this.txtImagen.TabIndex = 8;
            // 
            // lblImagene
            // 
            this.lblImagene.AutoSize = true;
            this.lblImagene.Location = new System.Drawing.Point(40, 294);
            this.lblImagene.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblImagene.Name = "lblImagene";
            this.lblImagene.Size = new System.Drawing.Size(53, 13);
            this.lblImagene.TabIndex = 19;
            this.lblImagene.Text = "Imágenes";
            // 
            // btnAgregarImagen
            // 
            this.btnAgregarImagen.Location = new System.Drawing.Point(315, 315);
            this.btnAgregarImagen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregarImagen.Name = "btnAgregarImagen";
            this.btnAgregarImagen.Size = new System.Drawing.Size(55, 21);
            this.btnAgregarImagen.TabIndex = 9;
            this.btnAgregarImagen.Text = "Agregar";
            this.btnAgregarImagen.UseVisualStyleBackColor = true;
            this.btnAgregarImagen.Click += new System.EventHandler(this.btnAgregarImagen_Click);
            // 
            // btnEliminarImagen
            // 
            this.btnEliminarImagen.ForeColor = System.Drawing.Color.IndianRed;
            this.btnEliminarImagen.Location = new System.Drawing.Point(315, 288);
            this.btnEliminarImagen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminarImagen.Name = "btnEliminarImagen";
            this.btnEliminarImagen.Size = new System.Drawing.Size(56, 24);
            this.btnEliminarImagen.TabIndex = 7;
            this.btnEliminarImagen.Text = "Eliminar";
            this.btnEliminarImagen.UseVisualStyleBackColor = true;
            this.btnEliminarImagen.Click += new System.EventHandler(this.btnEliminarImagen_Click);
            // 
            // lblErrorCodigo
            // 
            this.lblErrorCodigo.AutoSize = true;
            this.lblErrorCodigo.ForeColor = System.Drawing.Color.IndianRed;
            this.lblErrorCodigo.Location = new System.Drawing.Point(302, 86);
            this.lblErrorCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErrorCodigo.Name = "lblErrorCodigo";
            this.lblErrorCodigo.Size = new System.Drawing.Size(17, 13);
            this.lblErrorCodigo.TabIndex = 20;
            this.lblErrorCodigo.Text = "(*)";
            // 
            // lblErrorNombre
            // 
            this.lblErrorNombre.AutoSize = true;
            this.lblErrorNombre.ForeColor = System.Drawing.Color.IndianRed;
            this.lblErrorNombre.Location = new System.Drawing.Point(302, 115);
            this.lblErrorNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErrorNombre.Name = "lblErrorNombre";
            this.lblErrorNombre.Size = new System.Drawing.Size(17, 13);
            this.lblErrorNombre.TabIndex = 21;
            this.lblErrorNombre.Text = "(*)";
            // 
            // lblCamposObligatorios
            // 
            this.lblCamposObligatorios.AutoSize = true;
            this.lblCamposObligatorios.ForeColor = System.Drawing.Color.IndianRed;
            this.lblCamposObligatorios.Location = new System.Drawing.Point(146, 358);
            this.lblCamposObligatorios.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCamposObligatorios.Name = "lblCamposObligatorios";
            this.lblCamposObligatorios.Size = new System.Drawing.Size(116, 13);
            this.lblCamposObligatorios.TabIndex = 22;
            this.lblCamposObligatorios.Text = "(*) Campos Obligatorios";
            // 
            // lblErrorPrecio
            // 
            this.lblErrorPrecio.AutoSize = true;
            this.lblErrorPrecio.ForeColor = System.Drawing.Color.IndianRed;
            this.lblErrorPrecio.Location = new System.Drawing.Point(266, 266);
            this.lblErrorPrecio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErrorPrecio.Name = "lblErrorPrecio";
            this.lblErrorPrecio.Size = new System.Drawing.Size(80, 13);
            this.lblErrorPrecio.TabIndex = 23;
            this.lblErrorPrecio.Text = "Campo Invalido";
            this.lblErrorPrecio.Visible = false;
            // 
            // lblErrorMarca
            // 
            this.lblErrorMarca.AutoSize = true;
            this.lblErrorMarca.ForeColor = System.Drawing.Color.IndianRed;
            this.lblErrorMarca.Location = new System.Drawing.Point(302, 215);
            this.lblErrorMarca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErrorMarca.Name = "lblErrorMarca";
            this.lblErrorMarca.Size = new System.Drawing.Size(17, 13);
            this.lblErrorMarca.TabIndex = 24;
            this.lblErrorMarca.Text = "(*)";
            // 
            // lblErrorCategoria
            // 
            this.lblErrorCategoria.AutoSize = true;
            this.lblErrorCategoria.ForeColor = System.Drawing.Color.IndianRed;
            this.lblErrorCategoria.Location = new System.Drawing.Point(302, 240);
            this.lblErrorCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErrorCategoria.Name = "lblErrorCategoria";
            this.lblErrorCategoria.Size = new System.Drawing.Size(17, 13);
            this.lblErrorCategoria.TabIndex = 25;
            this.lblErrorCategoria.Text = "(*)";
            // 
            // FormModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 437);
            this.Controls.Add(this.lblErrorCategoria);
            this.Controls.Add(this.lblErrorMarca);
            this.Controls.Add(this.lblErrorPrecio);
            this.Controls.Add(this.lblCamposObligatorios);
            this.Controls.Add(this.lblErrorNombre);
            this.Controls.Add(this.lblErrorCodigo);
            this.Controls.Add(this.btnEliminarImagen);
            this.Controls.Add(this.btnAgregarImagen);
            this.Controls.Add(this.lblImagene);
            this.Controls.Add(this.txtImagen);
            this.Controls.Add(this.cboImagenes);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.pbxArticulo);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.cboMarca);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblArticulo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(618, 476);
            this.MinimumSize = new System.Drawing.Size(618, 476);
            this.Name = "FormModificar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar artículo";
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArticulo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.PictureBox pbxArticulo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cboImagenes;
        private System.Windows.Forms.TextBox txtImagen;
        private System.Windows.Forms.Label lblImagene;
        private System.Windows.Forms.Button btnAgregarImagen;
        private System.Windows.Forms.Button btnEliminarImagen;
        private System.Windows.Forms.Label lblErrorCodigo;
        private System.Windows.Forms.Label lblErrorNombre;
        private System.Windows.Forms.Label lblCamposObligatorios;
        private System.Windows.Forms.Label lblErrorPrecio;
        private System.Windows.Forms.Label lblErrorMarca;
        private System.Windows.Forms.Label lblErrorCategoria;
    }
}