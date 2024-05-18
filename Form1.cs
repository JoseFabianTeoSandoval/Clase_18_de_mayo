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

namespace Clase_18_de_mayo
{
    public partial class Form1 : Form
    {
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
    }
}
