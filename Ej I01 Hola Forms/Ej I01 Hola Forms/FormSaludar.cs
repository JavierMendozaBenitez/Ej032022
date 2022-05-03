using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej_I01_Hola_Forms
{
    public partial class FormSaludar : Form
    {
        public FormSaludar()
        {
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            string titulo = "¡Hola, Windows Forms!";
            string mensaje = $"Soy {txtNombre.Text} {txtApellido.Text} y mi materia favorita es {cmbMateria.SelectedItem}.";

            if (Validar())
            {
                FormMensaje frmMensaje = new FormMensaje(titulo, mensaje);
                frmMensaje.ShowDialog();
            }
        }

        private void FormSaludar_Load(object sender, EventArgs e)
        {
            cmbMateria.Items.Add("Programación I");
            cmbMateria.Items.Add("Laboratorio de Computación I");
            cmbMateria.Items.Add("Sistema de procesamiento de datos");
            cmbMateria.Items.Add("Inglés I");
            cmbMateria.Items.Add("Matemática");
            cmbMateria.Items.Add("Programación II");
            cmbMateria.Items.Add("Laboratorio de Computación II");
            cmbMateria.Items.Add("Inglés II");
            cmbMateria.Items.Add("Metodología de la investigación");
            cmbMateria.Items.Add("Arquitectura y sistemas operativos");
            cmbMateria.Items.Add("Estadística");
            cmbMateria.SelectedIndex = 0;//Muestra Programación I
        }

        private bool Validar()
        {
            bool esValido = true;
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Se deben completar los siguientes campos:");

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                esValido = false;
                sb.AppendLine("Nombre");
            }

            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                esValido = false;
                sb.AppendLine("Apellido");
            }

            if (!esValido)
            {
                MessageBox.Show(sb.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return esValido;
        }
    }
}
