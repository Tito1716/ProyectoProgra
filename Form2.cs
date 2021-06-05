using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace Proyecto
{
    public partial class Form2 : MetroFramework.Forms.MetroForm
    {
        registro MyRegistro = new registro(); //instancia de mi clase


        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 nuevo = new Form3();
            this.Hide();
            nuevo.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyRegistro.Ticket = txtpedido.Text;
            MyRegistro.Nombre = txtnombre.Text;
            MyRegistro.Producto = txtpedido.Text;
            MyRegistro.Fecha = txtfecha.Text;

            MessageBox.Show("Se guardo registro correctamente");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtpedido.Clear();
            txtnombre.Clear();
            
            
        }
    }

}