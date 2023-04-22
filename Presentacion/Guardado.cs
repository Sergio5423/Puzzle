using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Logica;

namespace Presentacion
{
    public partial class Guardado : Form
    {
        Operaciones operaciones = new Operaciones();
        Juego juego;

        public Guardado()
        {
            InitializeComponent();
        }

        private void Guardado_Load(object sender, EventArgs e)
        {
            juego = new Juego();
            lstPartidas.Items.Clear();
            foreach (var partida in operaciones.ConsultarPartidas())
            {
                lstPartidas.Items.Add(partida);
            }            
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            Close();
            var partida = lstPartidas.SelectedItem;
            CargarPartida(partida);                              
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void CargarPartida(dynamic partida)
        {
            juego.click = int.Parse(partida.Click);            
            juego.ShowDialog();
        }
    }
}