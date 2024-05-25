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

        private void button1_Click(object sender, EventArgs e)
        {
            if (personaje.Provarconeccion())
            {
                MessageBox.Show("si se pudo");
            }else
            {
                MessageBox.Show("nel paste");
            }
        }

        private void cargar_Click(object sender, EventArgs e)
        {
            dataGridViewPersonajes.DataSource = personaje.LeerPersonajes();
        }

        private void buttoninsertar_Click(object sender, EventArgs e)
        {
            string Nombre = textBoxNombre.Text;
            //string Raza = comboBoxRaza.Text;
            string Raza = textBoxRaza.Text;
            int Niveldepoder = (int)numericUpDownNiveldepoder.Value;
            int Respuesta = personaje.CrearPersonaje(Nombre, Raza, Niveldepoder);
            if (Respuesta > 0 )
            {
                MessageBox.Show("Se creo correctamente");
                dataGridViewPersonajes.DataSource = personaje.LeerPersonajes();
            } else
            {
                MessageBox.Show("Hubo un error al crearlo");
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
                int nivelPoder = int.Parse(personajeEncontrado.Rows[0]["nivel_poder"].ToString());
                textBoxNombre.Text = nombre;
                textBoxRaza.Text = raza;
                comboBoxRaza.Text = raza;
                numericUpDownNiveldepoder.Value = nivelPoder;
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
                textBoxid.Focus(); // Devolver el foco al TextBox
            }
            else
            {
                buscarPorId();
            }
        }
    }
}
