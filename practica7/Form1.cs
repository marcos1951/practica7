using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace practica7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     
        private void button1_Click(object sender, EventArgs e)
        {
            int pts = 0;

            if (this.radiogd.Checked)
                pts++;

            if (this.num.Text == "3")
                pts++;

            if (this.mex.Checked)
                pts++;

            DateTime fecha = this.calendario.SelectionStart;

            string fechaseleccionada = fecha.ToShortDateString();

            if (fechaseleccionada == "16/09/1810")
                pts++;

            MessageBox.Show("LOS PUNTOS OBTENIDOS: " + pts);
            
        }
    }
}
