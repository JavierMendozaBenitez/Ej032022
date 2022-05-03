using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ej_I02_Registrate;

namespace FormRegistro
{
    public partial class Form1 : Form
    {
        public string generoElegido;
        public string paisElegido;
        public string[] cursoElegido = new string[3];
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {           

            lbPaises.Items.Add("Argentina");
            lbPaises.Items.Add("Chile");
            lbPaises.Items.Add("Uruguay");
        }
        
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //cursoEle[0] = "HOLA";

            this.paisElegido = (string)lbPaises.SelectedItem;
            Ingresante ingresante = new Ingresante(tbNombre.Text, tbDireccion.Text, this.generoElegido, this.paisElegido, this.cursoElegido, ((int)nudEdad.Value));

            MessageBox.Show(ingresante.Mostrar(), "",MessageBoxButtons.OK);

            /*for(int i = 0; i < cursoEle.Length; i++)
            {
                MessageBox.Show(cursoEle[i], "", MessageBoxButtons.OK);
            }*/

        }

        private void rbMasculino_CheckedChanged(object sender, EventArgs e)
        {
            this.generoElegido = "Masculino";
        }

        private void rbFemenino_CheckedChanged(object sender, EventArgs e)
        {
            this.generoElegido = "Femenino";
        }

        private void rbNoBinario_CheckedChanged(object sender, EventArgs e)
        {
            this.generoElegido = "No binario";
        }

        private void cbCSharp_CheckedChanged(object sender, EventArgs e)
        {
            this.cursoElegido[0] = "C#";
        }

        private void cbCMasMas_CheckedChanged(object sender, EventArgs e)
        {
            this.cursoElegido[1] = "C++";
        }

        private void cbJavaScript_CheckedChanged(object sender, EventArgs e)
        {
            this.cursoElegido[2] = "JavaScript";
        }

        
    }
}
