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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //prepara objeto para generar cuadro de dialogo de seleccion de archivo
        OpenFileDialog cuadroseleccion = new OpenFileDialog();

        /*listado que permite tener varios elementos de la clase Persona*/
        private List<Cliente> Clientes = new List<Cliente>();
        private int edit_indice = -1;
        //el índice para editar comienza en -1, esto significa que no hay ninguno seleccionado, esto servirá para el DataGridView.
        private void actualizarGrid()
        {
            dgvinfo.DataSource = null;
            dgvinfo.DataSource = Clientes; /*los nombres de columna que veremos son los de las propiedades*/

        }
        private void reseteo()
        {
            txtnombre.Clear();
            txttelefono.Clear();
            txtedad.Clear();
            txtdireccion.Clear();
            txtcorreo.Clear();
            

        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            //creo un objeto de la clase persona y guardo a través de las propiedades
            
            Regex exp = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Regex exp3 = new Regex(@"[0-9]{1,9}(\-[0-9]{0,2})?$");
            Regex exp2 = new Regex(@"^[a-zA-Z ]*$");
            if (exp.IsMatch(txtcorreo.Text) && exp2.IsMatch(txtnombre.Text) && exp3.IsMatch(txtedad.Text) && exp3.IsMatch(txttelefono.Text))
            {
                if (int.Parse(txtedad.Text) > 0 && int.Parse(txtedad.Text) < 18)
                {
                    comboBox1.Text = "Metodo Contado";
                    Cliente cliente = new Cliente();
                    cliente.Nombre = txtnombre.Text;
                    cliente.Edad = int.Parse(txtedad.Text);
                    cliente.direccion = txtdireccion.Text;
                    cliente.Telefono = txttelefono.Text;
                    cliente.metodo = comboBox1.Text;
                    cliente.correo = txtcorreo.Text;
                    if (edit_indice > -1) //verifica si hay un índice seleccionado
                    {
                        Clientes[edit_indice] = cliente;
                        edit_indice = -1;
                    }
                    else
                    {

                        Clientes.Add(cliente); /*al arreglo de Productos le agrego el objeto creado con todos los datos que recolecté*/

                    }
                    actualizarGrid();//llamamos al procedimiento que guarda en datagrid
                    reseteo(); //llamamos al método que resetea
                }
                else if (int.Parse(txtedad.Text) >= 18 )
                { 
                    Cliente cliente = new Cliente();
                    cliente.Nombre = txtnombre.Text;
                    cliente.Edad = int.Parse(txtedad.Text);
                    cliente.direccion = txtdireccion.Text;
                    cliente.Telefono = txttelefono.Text;
                    cliente.metodo = comboBox1.Text;
                    cliente.correo = txtcorreo.Text;
                    if (edit_indice > -1) //verifica si hay un índice seleccionado
                    {
                        Clientes[edit_indice] = cliente;
                        edit_indice = -1;
                    }
                    else
                    {

                        Clientes.Add(cliente); /*al arreglo de Productos le agrego el objeto creado con todos los datos que recolecté*/

                    }
                    actualizarGrid();//llamamos al procedimiento que guarda en datagrid
                    reseteo(); //llamamos al método que resetea
                }
            }
            else
            {
                MessageBox.Show("Datos Incorrecto..");
                MessageBox.Show("Ingrese los datos de nuevo");
                txtcorreo.Clear();
                reseteo(); //llamamos al método que resetea
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Metodo Contado");
            comboBox1.Items.Add("Metodo Credito");
        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
            Form Menu = new FrmMenu();
            Menu.Show();
            this.Hide();
        }
    }
}
