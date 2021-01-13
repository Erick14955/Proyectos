using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class RegistroUsuario : Form
    {
        public RegistroUsuario()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            TextoID.Clear();
            TextoAlias.Clear();
            TextoNombres.Clear();
            TextoClave.Clear();
            TextoClave2.Clear();
            TextoEmail.Clear();
            TextoCosto.Clear();
            MessageBox.Show("Se han eliminados todos los datos correctamente");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TextoID.Clear();
            TextoAlias.Clear();
            TextoNombres.Clear();
            TextoClave.Clear();
            TextoClave2.Clear();
            TextoEmail.Clear();
            TextoCosto.Clear();
            MessageBox.Show("Datos guardados correctamente");
        }

        private void TextoClave_TextChanged(object sender, EventArgs e)
        {
            TextoClave.PasswordChar = '*';
        }

        private void TextoClave2_TextChanged(object sender, EventArgs e)
        {
            TextoClave2.PasswordChar = '*';
        }
    }
}
