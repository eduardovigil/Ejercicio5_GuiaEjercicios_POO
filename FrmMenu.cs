using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5_GuiaEjercicios_POO
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form ejercicio = new Form1();
            ejercicio.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form ejercicio2 = new FrmProductos();
            ejercicio2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
