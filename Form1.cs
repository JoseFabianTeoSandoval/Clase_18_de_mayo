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
    }
}
