using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MikeFinalProyect.Formularios
{
    public partial class PersonajeForms : Form
    {
        public PersonajeForms()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool personajeValidado = ValidadPersonaje(out string errorMsg){

            }

        }
        private bool ValidadPersonaje (out string errorMsg)
        {
            errorMsg = string.Empty; 
            if (string.IsNullOrEmpty(tbxID.Text))
            {
                errorMsg += "El Id del personaje no puede estar vacio" + Environment.NewLine;
            }
            if (string.IsNullOrEmpty(tbxNombre.Text))
            {
                errorMsg += "El Id del personaje no puede estar vacio" + Environment.NewLine;
            }
            if (string.IsNullOrEmpty(tbxSerie.Text))
            {
                errorMsg += "El Id del personaje no puede estar vacio" + Environment.NewLine;
            }
            if (string.IsNullOrEmpty(tbxPoder.Text))
            {
                errorMsg += "El Id del personaje no puede estar vacio" + Environment.NewLine;
            }
            if (string.IsNullOrEmpty(tbxVestimenta.Text))
            {
                errorMsg += "El Id del personaje no puede estar vacio" + Environment.NewLine;
            }
            if (string.IsNullOrEmpty(tbxFraseFav.Text))
            {
                errorMsg += "El Id del personaje no puede estar vacio" + Environment.NewLine;
            }
            if (string.IsNullOrEmpty(tbxAltura.Text))
            {
                errorMsg += "El Id del personaje no puede estar vacio" + Environment.NewLine;
            }
            if (string.IsNullOrEmpty(tbxEstado.Text))
            {
                errorMsg += "El Id del personaje no puede estar vacio" + Environment.NewLine;
            }
            if (string.IsNullOrEmpty(tbxSexo.Text))
            {
                errorMsg += "El Id del personaje no puede estar vacio" + Environment.NewLine;
            }
            if (string.IsNullOrEmpty(tbxDireccion.Text))
            {
                errorMsg += "El Id del personaje no puede estar vacio" + Environment.NewLine;
            }
            if (string.IsNullOrEmpty(tbxlatitud.Text))
            {
                errorMsg += "El Id del personaje no puede estar vacio" + Environment.NewLine;
            }
            if (string.IsNullOrEmpty(tbxLongitud.Text))
            {
                errorMsg += "El Id del personaje no puede estar vacio" + Environment.NewLine;
            }
        }
}
