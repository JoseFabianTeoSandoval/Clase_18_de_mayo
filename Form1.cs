using Clase_18_de_mayo.data.dataAcces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Clase_18_de_mayo
{
    public partial class Form1 : Form
    {
        // Lista de razas
        private string[] razasDragonBall = {
            "Android",
            "Bio-Android",
            "Humana",
            "Humano",
            "Majin",
            "Namekuseijin",
            "Saiyajin",
            "Saiyajin/Humano",
            "Saiyajin/Saiyajin"
        };
        private PDB personaje;
        public Form1()
        {
            InitializeComponent();
            personaje = new PDB();
        }
        private void cargar_Click(object sender, EventArgs e)
        {
            dataGridViewPersonajes.DataSource = personaje.LeerPersonajes();
        }

        private void buttoninsertar_Click(object sender, EventArgs e)
        {
            string nombre = textBoxNombre.Text;
            //string Raza = comboBoxRaza.Text;
            string raza = textBoxRaza.Text;
            int niveldepoder = (int)numericUpDownNiveldepoder.Value;
            DateTime fechadecreacion = dateTimePickerFechadecreacion.Value;
            string historia = textBoxHistoria.Text;

            int respuesta = personaje.CrearPersonaje(nombre, raza, niveldepoder, fechadecreacion, historia);
            if (respuesta > 0)
            {
                MessageBox.Show("Personaje creado correctamente");
                dataGridViewPersonajes.DataSource = personaje.LeerPersonajes();
            }
            else
            {
                MessageBox.Show("Error al crear el personaje");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Llenar el ComboBox con las razas
            comboBoxRaza.Items.AddRange(razasDragonBall);
        }

        private void buscarPorId()
        {
            int idPersonajeABuscar = int.Parse(textBoxid.Text);

            DataTable personajeEncontrado = personaje.BuscarPersonajePorId(idPersonajeABuscar);

            if (personajeEncontrado.Rows.Count > 0)
            {
                // El personaje fue encontrado
                string nombre = personajeEncontrado.Rows[0]["nombre"].ToString();
                string raza = personajeEncontrado.Rows[0]["raza"].ToString();
                int niveldepoder = int.Parse(personajeEncontrado.Rows[0]["nivel_poder"].ToString());
                DateTime fechadecreacion = DateTime.Parse(personajeEncontrado.Rows[0]["fecha_creacion"].ToString());
                string historia = personajeEncontrado.Rows[0]["historia"].ToString();

                textBoxNombre.Text = nombre;
                textBoxRaza.Text = raza;
                comboBoxRaza.Text = raza;
                numericUpDownNiveldepoder.Value = niveldepoder;
                dateTimePickerFechadecreacion.Value = fechadecreacion;
                textBoxHistoria.Text = historia;
            }
            else
            {
                // El personaje no fue encontrado
                Console.WriteLine("No se encontró el personaje con ID: " + idPersonajeABuscar);
            }
        }
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            buscarPorId(); 
        }

        private void textBoxid_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxid.Text))
            {
                MessageBox.Show("Por favor, ingresa un valor en el campo de texto.");
                textBoxid.Focus(); 
            }
            else
            {
                buscarPorId();
            }
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            string nombre = textBoxNombre.Text;
            string raza = textBoxRaza.Text;
            string historia = textBoxHistoria.Text;
            int niveldepoder = (int)numericUpDownNiveldepoder .Value;
            if (!string.IsNullOrWhiteSpace(textBoxid.Text))
            {
                int id = int.Parse(textBoxid.Text);
                MessageBox.Show("Actualizo Correctamente");
                personaje.ActualizarPersonaje(id, nombre, raza, niveldepoder, historia);
                dataGridViewPersonajes.DataSource = personaje.LeerPersonajes();
                LimpiarControles();
            }
            else
            {
                MessageBox.Show("Ingrese la ID del personaje");
                textBoxid.Focus(); 
            }
        }
        private void LimpiarControles()
        {
            textBoxid.Clear();
            textBoxHistoria.Clear();
            textBoxNombre.Clear();
            textBoxRaza.Clear();
            numericUpDownNiveldepoder .ResetText();
            comboBoxRaza.ResetText();
            dataGridViewPersonajes.DataSource = null;

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int idPersonajeAEliminar = int.Parse(textBoxid.Text);
                personaje.EliminarPersonaje(idPersonajeAEliminar);
                MessageBox.Show("Personaje eliminado correctamente.");
                LimpiarControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el personaje: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void buttonProvar_Click(object sender, EventArgs e)
        {
            if (personaje.Provarconeccion())
            {
                MessageBox.Show("si se pudo");
            }
            else
            {
                MessageBox.Show("nel paste");
            }
        }
    }
}
