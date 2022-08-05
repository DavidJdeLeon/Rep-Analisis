using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValidarEntradas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            Entradas.numero(e);
        }

        private void txtNumeroDecimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            Entradas.numeroDecimal(e);
        }

        private void txtLetra_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Entradas.letras(e);
        }
    }
}
