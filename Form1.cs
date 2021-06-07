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
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }
        public  int validarForm(string Usu, string contraseña)
        {
            if (String.IsNullOrEmpty(Usu) || String.IsNullOrEmpty(contraseña))
            {
                string message = "Llena todo los campos";
                string caption = "Error detectado";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Muestra el mensaje
                result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Warning);
                return 0;
            }
            else {
                return 1;
            }

        }
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string Usuaario = txtUsuario.Text;
            string Contraseña = txtContraseña.Text;
            if (validarForm(Usuaario, Contraseña) == 0)
            {}
            else
            {
                if (Usuaario == "Usuario123" && Contraseña == "123456")
                {
                    MessageBox.Show("Ingreso correcto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form2 principal = new Form2();
                    principal.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ingrese los datos correctos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
