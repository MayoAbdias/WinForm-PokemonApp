namespace PokemonApp
{
    partial class frmPokemon
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
            this.dgvPokemons = new System.Windows.Forms.DataGridView();
            this.pictureBoxPokemon = new System.Windows.Forms.PictureBox();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonEliminarFisico = new System.Windows.Forms.Button();
            this.buttonEliminarLogico = new System.Windows.Forms.Button();
            this.labelFiltro = new System.Windows.Forms.Label();
            this.textBoxFiltro = new System.Windows.Forms.TextBox();
            this.buttonFiltro = new System.Windows.Forms.Button();
            this.labelCampo = new System.Windows.Forms.Label();
            this.labelCriterio = new System.Windows.Forms.Label();
            this.labelFiltroAvanzado = new System.Windows.Forms.Label();
            this.comboBoxCampo = new System.Windows.Forms.ComboBox();
            this.comboBoxCriterio = new System.Windows.Forms.ComboBox();
            this.textBoxFiltroAvanzado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPokemons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPokemons
            // 
            this.dgvPokemons.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPokemons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPokemons.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPokemons.Location = new System.Drawing.Point(9, 45);
            this.dgvPokemons.MultiSelect = false;
            this.dgvPokemons.Name = "dgvPokemons";
            this.dgvPokemons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPokemons.Size = new System.Drawing.Size(547, 193);
            this.dgvPokemons.TabIndex = 0;
            this.dgvPokemons.SelectionChanged += new System.EventHandler(this.dgvPokemons_SelectionChanged);
            // 
            // pictureBoxPokemon
            // 
            this.pictureBoxPokemon.Location = new System.Drawing.Point(575, 45);
            this.pictureBoxPokemon.Name = "pictureBoxPokemon";
            this.pictureBoxPokemon.Size = new System.Drawing.Size(205, 193);
            this.pictureBoxPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPokemon.TabIndex = 1;
            this.pictureBoxPokemon.TabStop = false;
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgregar.Location = new System.Drawing.Point(9, 244);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(94, 23);
            this.buttonAgregar.TabIndex = 2;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModificar.Location = new System.Drawing.Point(109, 244);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(75, 23);
            this.buttonModificar.TabIndex = 3;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // buttonEliminarFisico
            // 
            this.buttonEliminarFisico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminarFisico.Location = new System.Drawing.Point(190, 244);
            this.buttonEliminarFisico.Name = "buttonEliminarFisico";
            this.buttonEliminarFisico.Size = new System.Drawing.Size(82, 23);
            this.buttonEliminarFisico.TabIndex = 4;
            this.buttonEliminarFisico.Text = "Eliminar fisico";
            this.buttonEliminarFisico.UseVisualStyleBackColor = true;
            this.buttonEliminarFisico.Click += new System.EventHandler(this.buttonEliminarFisico_Click);
            // 
            // buttonEliminarLogico
            // 
            this.buttonEliminarLogico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminarLogico.Location = new System.Drawing.Point(278, 244);
            this.buttonEliminarLogico.Name = "buttonEliminarLogico";
            this.buttonEliminarLogico.Size = new System.Drawing.Size(85, 23);
            this.buttonEliminarLogico.TabIndex = 5;
            this.buttonEliminarLogico.Text = "Eliminar logico";
            this.buttonEliminarLogico.UseVisualStyleBackColor = true;
            this.buttonEliminarLogico.Click += new System.EventHandler(this.buttonEliminarLogico_Click);
            // 
            // labelFiltro
            // 
            this.labelFiltro.AutoSize = true;
            this.labelFiltro.Location = new System.Drawing.Point(13, 22);
            this.labelFiltro.Name = "labelFiltro";
            this.labelFiltro.Size = new System.Drawing.Size(61, 13);
            this.labelFiltro.TabIndex = 6;
            this.labelFiltro.Text = "Filtro rapido";
            // 
            // textBoxFiltro
            // 
            this.textBoxFiltro.Location = new System.Drawing.Point(80, 19);
            this.textBoxFiltro.Name = "textBoxFiltro";
            this.textBoxFiltro.Size = new System.Drawing.Size(158, 20);
            this.textBoxFiltro.TabIndex = 7;
            this.textBoxFiltro.TextChanged += new System.EventHandler(this.textBoxFiltro_TextChanged);
            
            // 
            // buttonFiltro
            // 
            this.buttonFiltro.Location = new System.Drawing.Point(587, 296);
            this.buttonFiltro.Name = "buttonFiltro";
            this.buttonFiltro.Size = new System.Drawing.Size(75, 23);
            this.buttonFiltro.TabIndex = 8;
            this.buttonFiltro.Text = "Buscar";
            this.buttonFiltro.UseVisualStyleBackColor = true;
            this.buttonFiltro.Click += new System.EventHandler(this.buttonFiltro_Click);
            // 
            // labelCampo
            // 
            this.labelCampo.AutoSize = true;
            this.labelCampo.Location = new System.Drawing.Point(7, 302);
            this.labelCampo.Name = "labelCampo";
            this.labelCampo.Size = new System.Drawing.Size(40, 13);
            this.labelCampo.TabIndex = 9;
            this.labelCampo.Text = "Campo";
            // 
            // labelCriterio
            // 
            this.labelCriterio.AutoSize = true;
            this.labelCriterio.Location = new System.Drawing.Point(192, 302);
            this.labelCriterio.Name = "labelCriterio";
            this.labelCriterio.Size = new System.Drawing.Size(39, 13);
            this.labelCriterio.TabIndex = 10;
            this.labelCriterio.Text = "Criterio";
            // 
            // labelFiltroAvanzado
            // 
            this.labelFiltroAvanzado.AutoSize = true;
            this.labelFiltroAvanzado.Location = new System.Drawing.Point(372, 302);
            this.labelFiltroAvanzado.Name = "labelFiltroAvanzado";
            this.labelFiltroAvanzado.Size = new System.Drawing.Size(29, 13);
            this.labelFiltroAvanzado.TabIndex = 11;
            this.labelFiltroAvanzado.Text = "Filtro";
            // 
            // comboBoxCampo
            // 
            this.comboBoxCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCampo.FormattingEnabled = true;
            this.comboBoxCampo.Location = new System.Drawing.Point(59, 298);
            this.comboBoxCampo.Name = "comboBoxCampo";
            this.comboBoxCampo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCampo.TabIndex = 12;
            this.comboBoxCampo.SelectedIndexChanged += new System.EventHandler(this.comboBoxCampo_SelectedIndexChanged);
            // 
            // comboBoxCriterio
            // 
            this.comboBoxCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCriterio.FormattingEnabled = true;
            this.comboBoxCriterio.Location = new System.Drawing.Point(239, 298);
            this.comboBoxCriterio.Name = "comboBoxCriterio";
            this.comboBoxCriterio.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCriterio.TabIndex = 13;
            
            // 
            // textBoxFiltroAvanzado
            // 
            this.textBoxFiltroAvanzado.Location = new System.Drawing.Point(419, 298);
            this.textBoxFiltroAvanzado.Name = "textBoxFiltroAvanzado";
            this.textBoxFiltroAvanzado.Size = new System.Drawing.Size(100, 20);
            this.textBoxFiltroAvanzado.TabIndex = 14;
            // 
            // frmPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 355);
            this.Controls.Add(this.textBoxFiltroAvanzado);
            this.Controls.Add(this.comboBoxCriterio);
            this.Controls.Add(this.comboBoxCampo);
            this.Controls.Add(this.labelFiltroAvanzado);
            this.Controls.Add(this.labelCriterio);
            this.Controls.Add(this.labelCampo);
            this.Controls.Add(this.buttonFiltro);
            this.Controls.Add(this.textBoxFiltro);
            this.Controls.Add(this.labelFiltro);
            this.Controls.Add(this.buttonEliminarLogico);
            this.Controls.Add(this.buttonEliminarFisico);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.pictureBoxPokemon);
            this.Controls.Add(this.dgvPokemons);
            this.Name = "frmPokemon";
            this.Text = "Pokemon";
            this.Load += new System.EventHandler(this.frmPokemon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPokemons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPokemon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPokemons;
        private System.Windows.Forms.PictureBox pictureBoxPokemon;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonEliminarFisico;
        private System.Windows.Forms.Button buttonEliminarLogico;
        private System.Windows.Forms.Label labelFiltro;
        private System.Windows.Forms.TextBox textBoxFiltro;
        private System.Windows.Forms.Button buttonFiltro;
        private System.Windows.Forms.Label labelCampo;
        private System.Windows.Forms.Label labelCriterio;
        private System.Windows.Forms.Label labelFiltroAvanzado;
        private System.Windows.Forms.ComboBox comboBoxCampo;
        private System.Windows.Forms.ComboBox comboBoxCriterio;
        private System.Windows.Forms.TextBox textBoxFiltroAvanzado;
    }
}

