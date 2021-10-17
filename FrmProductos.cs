using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Ejercicio5_GuiaEjercicios_POO
{
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            InitializeComponent();
        }
        //prepara objeto para generar cuadro de dialogo de seleccion de archivo
        OpenFileDialog cuadroseleccion = new OpenFileDialog();

        /*listado que permite tener varios elementos de la clase Persona*/
        private List<Producto> Productos = new List<Producto>();
        private int edit_indice = -1;
        //el índice para editar comienza en -1, esto significa que no hay ninguno seleccionado, esto servirá para el DataGridView.
        private void actualizarGrid()
        {
            dgvlistado.DataSource = null;
            dgvlistado.DataSource = Productos; /*los nombres de columna que veremos son los de las propiedades*/

        }
        private void reseteo()
        {
            txtnombre.Clear();
            txtdescripcion.Clear();
            txtprecio.Clear();
            txtstock.Clear();
            
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            cmbmarca.Items.Add("LG");
            cmbmarca.Items.Add("Frigidaire");
            cmbmarca.Items.Add("Maytag");
            cmbmarca.Items.Add("Gibson");
            cmbmarca.Items.Add("Philips");
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            Regex exp = new Regex(@"[0-9]{1,9}(\.[0-9]{0,2})?$");
            Regex exp2 = new Regex(@"^[a-zA-Z ]*$");
            if (exp.IsMatch(txtprecio.Text) && exp.IsMatch(txtstock.Text) && exp2.IsMatch(txtnombre.Text) && exp2.IsMatch(txtdescripcion.Text))
            {
                //creo un objeto de la clase persona y guardo a través de las propiedades
                Producto product = new Producto();
                product.Nombre = txtnombre.Text;
                product.Descripcion = txtdescripcion.Text;
                product.Marca = cmbmarca.Text;
                product.Precio = float.Parse(txtprecio.Text);
                product.Stock = int.Parse(txtstock.Text);
                if (edit_indice > -1) //verifica si hay un índice seleccionado
                {
                    Productos[edit_indice] = product;
                    edit_indice = -1;
                }
                else
                {

                    Productos.Add(product); /*al arreglo de Productos le agrego el objeto creado con todos los datos que recolecté*/

                }
                actualizarGrid();//llamamos al procedimiento que guarda en datagrid
                reseteo(); //llamamos al método que resetea
            }
            else
            {
                MessageBox.Show("Datos Incorrecto..");
                MessageBox.Show("Ingrese los datos de nuevo");
                
                reseteo(); //llamamos al método que resetea
            }
            
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (edit_indice > -1) //verifica si hay un índice seleccionado
            {
                Productos.RemoveAt(edit_indice);
                edit_indice = -1; //resetea variable a -1
                reseteo();
                actualizarGrid();
            }
            else
            {
                MessageBox.Show("Dar doble click sobre elemento para seleccionar y borrar ");
            }
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtprecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtstock_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtdescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form Menu = new FrmMenu();
            Menu.Show();
            this.Hide();

        }
    }
}
