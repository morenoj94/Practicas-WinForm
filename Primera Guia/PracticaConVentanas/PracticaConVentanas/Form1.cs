using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaConVentanas
{
    public partial class frmClasePersona : Form
    {
        public frmClasePersona()
        {
            InitializeComponent();
        }

        private void FrmFormulario_Load(object sender, EventArgs e)
        {
            cbDocumento.Items.Add("Sin documento");
        }
        Persona persona = new Persona();
        private void btnCargarInfo_Click(object sender, EventArgs e)
        {
            
            persona.Nombre = txtNombre.Text;
            persona.AnioNacimiento = dtpAnioNacimiento.Value;
            persona.Chocolate = cbChocolate.Checked == true? "Le gusta el chocolate" : "No le gusta el chocolate";
            if (rbExtrangero.Checked) persona.Estatus = "extrangero";
            else if (rbNacional.Checked) persona.Estatus = "nacional";
            else persona.Estatus = "turista";
            persona.TipoDocumento = cbDocumento.SelectedItem.ToString();
            persona.NumeroDocumento = txtNumeroDocumento.Text;
            persona.TiempoEnElPais = nudAniosEnElPais.Text;
            tsStatuslbNombre1.Text = persona.Nombre;
            

        }

        private void btnMostrarPersona_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show($"{persona.Nombre}\nAnio de nacimiento: {persona.AnioNacimiento}\n{persona.Chocolate}\nSu estatus es: {persona.Estatus}\nTipo de documento: {persona.TipoDocumento}\nNumero de documento: {persona.NumeroDocumento}\nAnios en el pais: {persona.TiempoEnElPais}");
                       
        }
    }
}
