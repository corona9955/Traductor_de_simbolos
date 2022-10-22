using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Traductor_de_simbolos;
using Traductor_de_simbolos.Simbolos;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;

namespace Traductor_de_simbolos
{
    public partial class Traductor : Form
    {
        // Creación de objeto de la clase TraductorSimbolos.
        TraductorSimbolos sim = new TraductorSimbolos();
        public Traductor()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        // Botón de traducir
        private void btnTraducir_Click(object sender, EventArgs e)
        {
            // Llama a la Entrada y le asigna el texto de txtEntrada.
            sim.Entrada = txtEntrada.Text;
            // Válida si es que hay texto en txtEntrada.
            if (txtEntrada.Text == "")
            {
                MessageBox.Show("Ingrese un símbolo por favor.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            // En el caso que si haya texto, asigna  al txtSalida el valor que retorna el método TraducirSimbolo
            else
            {
                if (Regex.IsMatch(txtEntrada.Text, @"([\w][\w]+)") == true)
                {
                    MessageBox.Show("No se pueden dejar caracteres juntos.","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }
                MessageBox.Show("Símbolos traducidos correctamente...","Muy bien",MessageBoxButtons.OK,MessageBoxIcon.Question);
                txtSalida.Text = sim.TraducirSimbolo();
            }
                
        }
        // Limpia las cajas de texto
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtEntrada.Text = string.Empty;
            txtSalida.Text = string.Empty;
        }

        private void pbxInfo_Click_1(object sender, EventArgs e)
        {
            pbxInfo2.Visible = true;
            pbxInfo2.Visible = false;
            AccionInformación();
            
        }
        private void pbxInfo2_Click(object sender, EventArgs e)
        {
            AccionInformación();
        }

        private void pbx1_MouseHover(object sender, EventArgs e)
        {
            pbxInfo2.Visible = true;
        }

        private void pbxInfo2_MouseLeave(object sender, EventArgs e)
        {
            pbxInfo2.Visible = false;
        }

        public void AccionInformación()
        {
            MessageBox.Show("Gracias por usar el programa...\n" +
               "Desarrolladores:\n" +
               "Corona García Daniel Alejandro - 19211618 \ndaniel.corona193@tectijuana.edu.mx\n\n" +
               "Ramirez Flores Abril - 19211715 \nabril.ramirez193@tectijuana.edu.mx", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pbxSalida1_MouseHover(object sender, EventArgs e)
        {
            pbxSalida2.Visible = true;
        }

        private void pbxSalida2_MouseLeave(object sender, EventArgs e)
        {
            pbxSalida2.Visible = false;
        }

        private void pbxSalida2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que deseas salir de la aplicación?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
