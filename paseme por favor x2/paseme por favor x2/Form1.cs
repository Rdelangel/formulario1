using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paseme_por_favor_x2
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int saludo;
            saludo = comboBox1.SelectedIndex;
            switch (saludo)
            {
                case 0:
                    MessageBox.Show("Hi", "Ingles", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case 1:
                    MessageBox.Show("Caio", "Italiano", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case 2:
                    MessageBox.Show("Bonjour", "Frances", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case 3:
                    MessageBox.Show("Konichiwa", "Japones", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case 4:
                    MessageBox.Show("Aloha", "Hawaiiano", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
             
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = (MessageBox.Show("¿Desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk));
            if (respuesta == DialogResult.Yes)
            {
                this.Close();
            }
        }

        public struct datos
        {

            public string nombre;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            datos informacion;
            informacion.nombre = textBox1.Text;
            final obj = new final(informacion);
            obj.ShowDialog();
        }
    }
}
