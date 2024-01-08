using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;


namespace PokemonApp
{
    public partial class frmPokemon : Form
    {
        private List<Pokemon> listapokemons;
        public frmPokemon()
        {
            InitializeComponent();
        }

        private void frmPokemon_Load(object sender, EventArgs e)
        {
            cargar();
            comboBoxCampo.Items.Add("Numero");
            comboBoxCampo.Items.Add("Nombre");
            comboBoxCampo.Items.Add("Descripción");



        }

        private void dgvPokemons_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvPokemons.CurrentRow != null)
            {
                Pokemon seleccionado = (Pokemon)dgvPokemons.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.UrlImagen);
            }
            
        }

        private void cargar()
        {
            PokemonNegocio negocio = new PokemonNegocio();
            try
            {
                listapokemons = negocio.listar();
                dgvPokemons.DataSource = listapokemons;
                ocultarColumnas();
                cargarImagen(listapokemons[0].UrlImagen);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void ocultarColumnas()
        {
            dgvPokemons.Columns["UrlImagen"].Visible = false;
           
            dgvPokemons.Columns["Id"].Visible = false;
        }

        private void cargarImagen(string imagen) 
        {
            try
            {
                pictureBoxPokemon.Load(imagen);
            }
            catch (Exception ex)
            {

                pictureBoxPokemon.Load("https://developers.elementor.com/docs/assets/img/elementor-placeholder-image.png");
            }
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            FrmAltaPokemon alta = new FrmAltaPokemon();
            alta.ShowDialog();
            cargar();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            if(dgvPokemons.CurrentRow != null)
            {
                Pokemon seleccionado;
                seleccionado = (Pokemon)dgvPokemons.CurrentRow.DataBoundItem;

                FrmAltaPokemon modificar = new FrmAltaPokemon(seleccionado);
                modificar.ShowDialog();
                cargar();
            }
            else
            {
                MessageBox.Show("Debes seleccionar un pokemon para poder modificarlo","ATENCIÓN",MessageBoxButtons.OK,MessageBoxIcon.Error);
                cargar();
            }
          
        }

        private void buttonEliminarFisico_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void buttonEliminarLogico_Click(object sender, EventArgs e)
        {
            eliminar(true);
        }

        private void eliminar(bool logico = false)
        {
            PokemonNegocio negocio = new PokemonNegocio();
            Pokemon seleccionado;

            try
            {
                if(dgvPokemons.CurrentRow != null)
                {
                    DialogResult respuesta = MessageBox.Show("¿Seguro que desea eliminar el Pokemon?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.Yes)
                    {
                        seleccionado = (Pokemon)dgvPokemons.CurrentRow.DataBoundItem;
                        if (logico)
                            negocio.eliminarLogico(seleccionado.Id);
                        else
                            negocio.eliminar(seleccionado.Id);
                        cargar();
                    }
                }
                else
                {
                    MessageBox.Show("Debes seleccionar un Pokemon para poder eliminarlo..","ATENCIÓN",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    cargar();
                }
               

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private bool validarFiltro()
        {
            if(comboBoxCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione un campo por favor");
                return true;
            }
            

            if(comboBoxCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione el criterio,por favor");
                return true;
            }
            

            if(comboBoxCampo.SelectedItem.ToString() == "Numero")
            {
                if (string.IsNullOrEmpty(textBoxFiltroAvanzado.Text))
                {
                    MessageBox.Show("La caja de texto no puede estar vacia..");
                    return true;
                }

                if (!soloNumeros(textBoxFiltroAvanzado.Text))
                {
                    MessageBox.Show("Solo números por favor,por campo numerico seleccionado..");
                    return true;
                }
                  
            }
            return false;

        }
        private bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                
                    return false;
                
            }
            return true;
        }

        private void buttonFiltro_Click(object sender, EventArgs e)
        {
            PokemonNegocio negocio = new PokemonNegocio();
            try
            {
                if (validarFiltro())
                    return;

                string campo = comboBoxCampo.SelectedItem.ToString();
                string criterio = comboBoxCriterio.SelectedItem.ToString();
                string filtro = textBoxFiltroAvanzado.Text;
                dgvPokemons.DataSource = negocio.filtrar(campo, criterio, filtro);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
           
        }

        private void textBoxFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Pokemon> listaFiltrada;

            string filtro = textBoxFiltro.Text;

            if (filtro != "")
            {
                listaFiltrada = listapokemons.FindAll(x => x.Nombre.ToLower().Contains(filtro.ToLower()) || x.Tipo.Descripcion.ToLower().Contains(filtro.ToLower()));
            }
            else
            {
                listaFiltrada = listapokemons;
            }

            dgvPokemons.DataSource = null;
            dgvPokemons.DataSource = listaFiltrada;
            ocultarColumnas();
        }

        private void comboBoxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = comboBoxCampo.SelectedItem.ToString();
            if(opcion == "Numero")
            {
                comboBoxCriterio.Items.Clear();
                comboBoxCriterio.Items.Add("Mayor a");
                comboBoxCriterio.Items.Add("Menor a");
                comboBoxCriterio.Items.Add("Igual a");
            }
            else
            {
                comboBoxCriterio.Items.Clear();
                comboBoxCriterio.Items.Add("Empieza con");
                comboBoxCriterio.Items.Add("Termina con");
                comboBoxCriterio.Items.Add("Contiene");
            }
        }

       
    }
}
