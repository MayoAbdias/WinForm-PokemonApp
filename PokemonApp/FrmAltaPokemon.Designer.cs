namespace PokemonApp
{
    partial class FrmAltaPokemon
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
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelNumero = new System.Windows.Forms.Label();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.labelTipo = new System.Windows.Forms.Label();
            this.labelDebilidad = new System.Windows.Forms.Label();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.comboBoxDebilidad = new System.Windows.Forms.ComboBox();
            this.labelUrlImagen = new System.Windows.Forms.Label();
            this.textBoxUrlImagen = new System.Windows.Forms.TextBox();
            this.pictureBoxPokemon = new System.Windows.Forms.PictureBox();
            this.buttonAgregarImagen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(51, 43);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(50, 13);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre :";
            // 
            // labelNumero
            // 
            this.labelNumero.AutoSize = true;
            this.labelNumero.Location = new System.Drawing.Point(51, 19);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(50, 13);
            this.labelNumero.TabIndex = 1;
            this.labelNumero.Text = "Numero :";
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(32, 69);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(69, 13);
            this.labelDescripcion.TabIndex = 2;
            this.labelDescripcion.Text = "Descripcion :";
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Location = new System.Drawing.Point(107, 19);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(135, 20);
            this.textBoxNumero.TabIndex = 0;
            this.textBoxNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumero_KeyPress);
            this.textBoxNumero.Leave += new System.EventHandler(this.textBoxNumero_Leave);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(107, 43);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(135, 20);
            this.textBoxNombre.TabIndex = 1;
            this.textBoxNombre.Leave += new System.EventHandler(this.textBoxNombre_Leave);
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(107, 69);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(135, 20);
            this.textBoxDescripcion.TabIndex = 2;
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAceptar.Location = new System.Drawing.Point(54, 247);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 6;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Location = new System.Drawing.Point(211, 247);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 7;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Location = new System.Drawing.Point(67, 121);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(34, 13);
            this.labelTipo.TabIndex = 8;
            this.labelTipo.Text = "Tipo :";
            // 
            // labelDebilidad
            // 
            this.labelDebilidad.AutoSize = true;
            this.labelDebilidad.Location = new System.Drawing.Point(44, 148);
            this.labelDebilidad.Name = "labelDebilidad";
            this.labelDebilidad.Size = new System.Drawing.Size(57, 13);
            this.labelDebilidad.TabIndex = 9;
            this.labelDebilidad.Text = "Debilidad :";
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Location = new System.Drawing.Point(107, 121);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(135, 21);
            this.comboBoxTipo.TabIndex = 4;
            // 
            // comboBoxDebilidad
            // 
            this.comboBoxDebilidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDebilidad.FormattingEnabled = true;
            this.comboBoxDebilidad.Location = new System.Drawing.Point(107, 148);
            this.comboBoxDebilidad.Name = "comboBoxDebilidad";
            this.comboBoxDebilidad.Size = new System.Drawing.Size(135, 21);
            this.comboBoxDebilidad.TabIndex = 5;
            // 
            // labelUrlImagen
            // 
            this.labelUrlImagen.AutoSize = true;
            this.labelUrlImagen.Location = new System.Drawing.Point(41, 95);
            this.labelUrlImagen.Name = "labelUrlImagen";
            this.labelUrlImagen.Size = new System.Drawing.Size(60, 13);
            this.labelUrlImagen.TabIndex = 12;
            this.labelUrlImagen.Text = "Urlimagen :";
            // 
            // textBoxUrlImagen
            // 
            this.textBoxUrlImagen.Location = new System.Drawing.Point(107, 95);
            this.textBoxUrlImagen.Name = "textBoxUrlImagen";
            this.textBoxUrlImagen.Size = new System.Drawing.Size(135, 20);
            this.textBoxUrlImagen.TabIndex = 3;
            this.textBoxUrlImagen.Leave += new System.EventHandler(this.textBoxUrlImagen_Leave);
            // 
            // pictureBoxPokemon
            // 
            this.pictureBoxPokemon.Location = new System.Drawing.Point(317, 19);
            this.pictureBoxPokemon.Name = "pictureBoxPokemon";
            this.pictureBoxPokemon.Size = new System.Drawing.Size(209, 178);
            this.pictureBoxPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPokemon.TabIndex = 14;
            this.pictureBoxPokemon.TabStop = false;
            // 
            // buttonAgregarImagen
            // 
            this.buttonAgregarImagen.Location = new System.Drawing.Point(248, 95);
            this.buttonAgregarImagen.Name = "buttonAgregarImagen";
            this.buttonAgregarImagen.Size = new System.Drawing.Size(37, 23);
            this.buttonAgregarImagen.TabIndex = 15;
            this.buttonAgregarImagen.Text = "+";
            this.buttonAgregarImagen.UseVisualStyleBackColor = true;
            this.buttonAgregarImagen.Click += new System.EventHandler(this.buttonAgregarImagen_Click);
            // 
            // FrmAltaPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 301);
            this.Controls.Add(this.buttonAgregarImagen);
            this.Controls.Add(this.pictureBoxPokemon);
            this.Controls.Add(this.textBoxUrlImagen);
            this.Controls.Add(this.labelUrlImagen);
            this.Controls.Add(this.comboBoxDebilidad);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.labelDebilidad);
            this.Controls.Add(this.labelTipo);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxNumero);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.labelNumero);
            this.Controls.Add(this.labelNombre);
            this.Name = "FrmAltaPokemon";
            this.Text = "Nuevo Pokemon";
            this.Load += new System.EventHandler(this.FrmAltaPokemon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPokemon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelNumero;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.Label labelDebilidad;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.ComboBox comboBoxDebilidad;
        private System.Windows.Forms.Label labelUrlImagen;
        private System.Windows.Forms.TextBox textBoxUrlImagen;
        private System.Windows.Forms.PictureBox pictureBoxPokemon;
        private System.Windows.Forms.Button buttonAgregarImagen;
    }
}