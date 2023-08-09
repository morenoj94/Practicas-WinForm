using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeraVentana
{
    public partial class VentanaPrincipal : Form
    {
        int numeroAleatorio, numeroUsuario;
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            LbIntrucciones.Text = "Introduce un numero del 1 al 100, veamos si tienes suerte";
            numeroAleatorio = random.Next(1, 101);
        }

        private void BtnVerificar_Click(object sender, EventArgs e)
        {
            numeroUsuario = int.Parse(txtNumero.Text);
            if (numeroUsuario == numeroAleatorio)
            {
                MessageBox.Show("Acertaste");
                LbFelicitacion.Text = "Felicidades";
            }
            else 
            {
                if (numeroUsuario > numeroAleatorio)
                {
                    MessageBox.Show("Intenta otra vez, el numero que usaste es mayor");
                    txtNumero.Text = "";
                }
                else
                {
                    MessageBox.Show("Intenta otra vez, el numero que usaste es menor");
                    txtNumero.Text = "";
                }
            }
        }
    }
}
