using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Menu : Form
    {
        Juego juego;
        Guardado guardado;

        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            juego = new Juego();
            guardado = new Guardado();
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            juego.ShowDialog();            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardado_Click(object sender, EventArgs e)
        {
            guardado.ShowDialog();
        }
    }
}
