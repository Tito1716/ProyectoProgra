using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{ 
    public partial class Form3 : Form
    {
        //Creo la lista de donde se almacenaran los registros
        List<registro> MiRegistros = new List<registro>();

        public Form3(List<registro> Registros)//Importa la lista del Form2
        {
            MiRegistros = Registros;
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 nuevo = new Form2();
            this.Hide();
            nuevo.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Decalro la variable del ticket
            string numero = textBox1.Text;
            //Creo la varible de tipo registro de la clase y lo igualo a la variable a buscar
            registro Actual = MiRegistros.Find(x => x.Ticket == numero);
            if (Actual.Ticket == numero)//Si son iguales 
            {
                txtpedido.Text = Actual.Ticket;//Sobreescriben el txt
                txtOrden.Text = Actual.Nombre;
                txtCliente.Text = Actual.Producto;
            }
            else
            {
                MessageBox.Show("No se encuentra", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);//Si no se encuentra
            }
            
        }
    }
}
