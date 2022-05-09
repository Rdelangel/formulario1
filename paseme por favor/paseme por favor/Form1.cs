using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paseme_por_favor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics papel;
            papel = pictureBox1.CreateGraphics();
            SolidBrush red = new SolidBrush(Color.Blue);
            papel.FillRectangle(red, 50, 30, 150, 180);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = (MessageBox.Show("Desea salir", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk));
            if (respuesta == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
