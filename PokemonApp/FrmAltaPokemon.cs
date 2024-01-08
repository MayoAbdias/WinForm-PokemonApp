using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;
using System.Configuration;

namespace PokemonApp
{
    public partial class FrmAltaPokemon : Form
    {
        private Pokemon pokemon = null;
        private OpenFileDialog archivo = null;
        public FrmAltaPokemon()
        {
            InitializeComponent();
        }

        public FrmAltaPokemon(Pokemon pokemon)
        {
            InitializeComponent();
            this.pokemon = pokemon;
            Text = "Modificar pokemon";
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            
            PokemonNegocio negocio = new PokemonNegocio();
            try
            {
                
                if (pokemon == null)
                    pokemon = new Pokemon();
                pokemon.Numero = int.Parse(textBoxNumero.Text);
                pokemon.Nombre = textBoxNombre.Text;
                pokemon.Descripcion = textBoxDescripcion.Text;
                pokemon.UrlImagen = textBoxUrlImagen.Text;
                pokemon.Tipo = (Elemento)comboBoxTipo.SelectedItem;
                pokemon.Debilidad = (Elemento)comboBoxDebilidad.SelectedItem;

                if(pokemon.Id != 0)
                {
                    negocio.modificar(pokemon);
                    MessageBox.Show("Modificado exitosamente");
                }
                else
                {
                    negocio.agregar(pokemon);
                    MessageBox.Show("Agregado exitosamente");
                }
                //guardo la imagen si la levanto localmente:
                if (archivo != null && !(textBoxUrlImagen.Text.ToUpper().Contains("HTTP")))
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName);


                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Revisar campos vacios", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }

        private void FrmAltaPokemon_Load(object sender, EventArgs e)
        {
            ElementoNegocio elementoNegocio = new ElementoNegocio();
            try
            {
                comboBoxTipo.DataSource = elementoNegocio.listar();
                comboBoxTipo.ValueMember = "Id";
                comboBoxTipo.DisplayMember = "Descripcion";
                comboBoxDebilidad.DataSource = elementoNegocio.listar();
                comboBoxDebilidad.ValueMember = "Id";
                comboBoxDebilidad.DisplayMember = "Descripcion";

                if(pokemon != null)
                {
                    textBoxNumero.Text = pokemon.Numero.ToString();
                    textBoxNombre.Text = pokemon.Nombre;
                    textBoxDescripcion.Text = pokemon.Descripcion;
                    textBoxUrlImagen.Text = pokemon.UrlImagen;
                    cargarImagen(pokemon.UrlImagen);
                    comboBoxTipo.SelectedValue = pokemon.Tipo.Id;
                    comboBoxDebilidad.SelectedValue = pokemon.Debilidad.Id;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
           ;
        }

        private void textBoxUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(textBoxUrlImagen.Text);
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

        private void buttonAgregarImagen_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg |* jpg";
            if(archivo.ShowDialog() == DialogResult.OK)
            {
                textBoxUrlImagen.Text = archivo.FileName;
                cargarImagen(archivo.FileName);
                //guardo la imagen
               
            }
        }
        ErrorProvider error = new ErrorProvider();

        private void textBoxNombre_Leave(object sender, EventArgs e)
        {
            if (Validaciones.txtVacios(textBoxNombre))
            {
                error.SetError(textBoxNombre, "Este campo no puede quedar vacio");
            }
            else
            {
                error.Clear();
            }
        }

        private void textBoxNumero_Leave(object sender, EventArgs e)
        {
            if (Validaciones.txtVacios(textBoxNumero))
            {
                error.SetError(textBoxNumero, "Este campo no puede quedar vacio");
            }
            else
            {
                error.Clear();
            }
        }

        private void textBoxNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = Validaciones.soloNumeros(e);

            if (!valida)
            {
                error.SetError(textBoxNumero, "Solo números por favor");
            }
            else
            {
                error.Clear();
            }

            
        }
    }
}
