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
using Proyecto;

namespace Proyecto
{

    public partial class Form2 : MetroFramework.Forms.MetroForm
    {

        //instancia de mi clase y la cracion de una lista
         List<registro> MiRegistros = new List<registro>();
        Form3 Consulta;
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
            //Envio la Lista al Form de consulta
            Form3 Cons = new Form3(MiRegistros);
            Cons.ShowDialog();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Se agregan los registros a la lista
            MiRegistros.Add(new registro
            {
                Ticket = txtpedido.Text,
                Nombre = txtnombre.Text,
                Producto = combopedido.Text,
                Fecha = txtfecha.Text
            });
           
            
            MessageBox.Show("Se guardo registro correctamente");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtpedido.Clear();
            txtnombre.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Creado por:" +"\n" + "David Ernesto Alemán Posada - AP101318" + "\n" + "Tito Antonio Arévalo Rivas - AR101921" + "\n" + "Diego Antonio Arias Navarrete - AN100518");



        }
    }

}