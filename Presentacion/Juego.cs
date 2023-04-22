using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Logica;


namespace Presentacion
{
    public partial class Juego : Form
    {
        Operaciones operaciones = new Operaciones();        
        int Segundos = 00;
        int minutos = 00;
        int horas = 00;
        public int click = 0;

        public Juego()
        {
            InitializeComponent();
        }
        private void Reiniciar()
        {
            int f = 0;
            int[] numeros = operaciones.Random();
            foreach (Button ficha in groupBox1.Controls)
            {
                if (numeros[f] == 16)
                {
                    ficha.Text = string.Empty;
                }
                else
                {
                    ficha.Text = numeros[f].ToString();
                }
                f++;
            }

            //if (numeros[0] == 16)
            //{
            //    button1.Text = string.Empty;                
            //}
            //else
            //{
            //    button1.Text = numeros[0].ToString();                
            //}

            //if (numeros[1] == 16)
            //{
            //    button2.Text = string.Empty;
            //}
            //else
            //{
            //    button2.Text = numeros[1].ToString();
            //}

            //if (numeros[2] == 16)
            //{
            //    button3.Text = string.Empty;
            //}
            //else
            //{
            //    button3.Text = numeros[2].ToString();
            //}

            //if (numeros[3] == 16)
            //{
            //    button4.Text = string.Empty;
            //}
            //else
            //{
            //    button4.Text = numeros[3].ToString();
            //}

            //if (numeros[4] == 16)
            //{
            //    button5.Text = string.Empty;
            //}
            //else
            //{
            //    button5.Text = numeros[4].ToString();
            //}

            //if (numeros[5] == 16)
            //{
            //    button6.Text = string.Empty;
            //}
            //else
            //{
            //    button6.Text = numeros[5].ToString();
            //}

            //if (numeros[6] == 16)
            //{
            //    button7.Text = string.Empty;
            //}
            //else
            //{
            //    button7.Text = numeros[6].ToString();
            //}

            //if (numeros[7] == 16)
            //{
            //    button8.Text = string.Empty;
            //}
            //else
            //{
            //    button8.Text = numeros[7].ToString();
            //}

            //if (numeros[8] == 16)
            //{
            //    button9.Text = string.Empty;
            //}
            //else
            //{
            //    button9.Text = numeros[8].ToString();
            //}

            //if (numeros[9] == 16)
            //{
            //    button10.Text = string.Empty;
            //}
            //else
            //{
            //    button10.Text = numeros[9].ToString();
            //}

            //if (numeros[10] == 16)
            //{
            //    button11.Text = string.Empty;
            //}
            //else
            //{
            //    button11.Text = numeros[10].ToString();
            //}

            //if (numeros[11] == 16)
            //{
            //    button12.Text = string.Empty;
            //}
            //else
            //{
            //    button12.Text = numeros[11].ToString();
            //}

            //if (numeros[12] == 16)
            //{
            //    button13.Text = string.Empty;
            //}
            //else
            //{
            //    button13.Text = numeros[12].ToString();
            //}

            //if (numeros[13] == 16)
            //{
            //    button14.Text = string.Empty;
            //}
            //else
            //{
            //    button14.Text = numeros[13].ToString();
            //}

            //if (numeros[14] == 16)
            //{
            //    button15.Text = string.Empty;
            //}
            //else
            //{
            //    button15.Text = numeros[14].ToString();
            //}

            //if (numeros[15] == 16)
            //{
            //    button16.Text = string.Empty;
            //}
            //else
            //{
            //    button16.Text = numeros[15].ToString();
            //}
        }
        public void Verificar()
        {
            int f = 1;
            int conf = 0;
            foreach (Button ficha in groupBox1.Controls)
            {
                if (ficha.Text.Equals(f.ToString()))
                {
                    conf++;                    
                }                
                f++;
            }
            if (conf == 15)
            {
                MessageBox.Show("Ganaste");
            }

            //if ((button1.Text).Equals("1"))
            //{
            //    if ((button2.Text).Equals("2"))
            //    {
            //        if ((button3.Text).Equals("3"))
            //        {
            //            if ((button4.Text).Equals("4"))
            //            {
            //                if ((button5.Text).Equals("5"))
            //                {
            //                    if ((button6.Text).Equals("6"))
            //                    {
            //                        if ((button7.Text).Equals("7"))
            //                        {
            //                            if ((button8.Text).Equals("8"))
            //                            {
            //                                if ((button9.Text).Equals("9"))
            //                                {
            //                                    if ((button10.Text).Equals("10"))
            //                                    {
            //                                        if ((button11.Text).Equals("11"))
            //                                        {
            //                                            if ((button12.Text).Equals("12"))
            //                                            {
            //                                                if ((button13.Text).Equals("13"))
            //                                                {
            //                                                    if ((button14.Text).Equals("14"))
            //                                                    {
            //                                                        if ((button15.Text).Equals("15"))
            //                                                        {
            //                                                            if ((button16.Text).Equals(string.Empty))
            //                                                            {
            //                                                                MessageBox.Show("Ganaste");
            //                                                            }
            //                                                        }
            //                                                    }
            //                                                }
            //                                            }
            //                                        }
            //                                    }
            //                                }
            //                            }
            //                        }
            //                    }
            //                }
            //            }
            //        }
            //    }
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            click++;
            lbClicks.Text = click.ToString();
            if (button1.Text != string.Empty)
            {
                if (button2.Text == string.Empty)
                {
                    button2.Text = button1.Text;
                    button1.Text = string.Empty;
                }
                if (button5.Text == string.Empty)
                {
                    button5.Text = button1.Text;
                    button1.Text = string.Empty;
                }
            }
            Verificar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            click++;
            lbClicks.Text = click.ToString();
            if (button2.Text != string.Empty)
            {
                if (button1.Text == string.Empty)
                {
                    button1.Text = button2.Text;
                    button2.Text = string.Empty;
                }
                if (button3.Text == string.Empty)
                {
                    button3.Text = button2.Text;
                    button2.Text = string.Empty;
                }
                if (button6.Text == string.Empty)
                {
                    button6.Text = button2.Text;
                    button2.Text = string.Empty;
                }
            }
            Verificar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Start();
            click++;
            lbClicks.Text = click.ToString();
            if (button3.Text != string.Empty)
            {
                if (button2.Text == string.Empty)
                {
                    button2.Text = button3.Text;
                    button3.Text = string.Empty;
                }
                if (button4.Text == string.Empty)
                {
                    button4.Text = button3.Text;
                    button3.Text = string.Empty;
                }
                if (button7.Text == string.Empty)
                {
                    button7.Text = button3.Text;
                    button3.Text = string.Empty;
                }
            }
            Verificar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Start();
            click++;
            lbClicks.Text = click.ToString();
            if (button4.Text != string.Empty)
            {
                if (button3.Text == string.Empty)
                {
                    button3.Text = button4.Text;
                    button4.Text = string.Empty;
                }
                if (button8.Text == string.Empty)
                {
                    button8.Text = button4.Text;
                    button4.Text = string.Empty;
                }
            }
            Verificar();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Start();
            click++;
            lbClicks.Text = click.ToString();
            if (button5.Text != string.Empty)
            {
                if (button1.Text == string.Empty)
                {
                    button1.Text = button5.Text;
                    button5.Text = string.Empty;
                }
                if (button6.Text == string.Empty)
                {
                    button6.Text = button5.Text;
                    button5.Text = string.Empty;
                }
                if (button9.Text == string.Empty)
                {
                    button9.Text = button5.Text;
                    button5.Text = string.Empty;
                }
            }
            Verificar();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer1.Start();
            click++;
            lbClicks.Text = click.ToString();
            if (button6.Text != string.Empty)
            {
                if (button2.Text == string.Empty)
                {
                    button2.Text = button6.Text;
                    button6.Text = string.Empty;
                }
                if (button7.Text == string.Empty)
                {
                    button7.Text = button6.Text;
                    button6.Text = string.Empty;
                }
                if (button10.Text == string.Empty)
                {
                    button10.Text = button6.Text;
                    button6.Text = string.Empty;
                }
                if (button5.Text == string.Empty)
                {
                    button5.Text = button6.Text;
                    button6.Text = string.Empty;
                }
            }
            Verificar();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            timer1.Start();
            click++;
            lbClicks.Text = click.ToString();
            if (button7.Text != string.Empty)
            {
                if (button3.Text == string.Empty)
                {
                    button3.Text = button7.Text;
                    button7.Text = string.Empty;

                }
                if (button8.Text == string.Empty)
                {
                    button8.Text = button7.Text;
                    button7.Text = string.Empty;
                }
                if (button11.Text == string.Empty)
                {
                    button11.Text = button7.Text;
                    button7.Text = string.Empty;
                }
                if (button6.Text == string.Empty)
                {
                    button6.Text = button7.Text;
                    button7.Text = string.Empty;
                }
            }
            Verificar();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            timer1.Start();
            click++;
            lbClicks.Text = click.ToString();
            if (button8.Text != string.Empty)
            {
                if (button4.Text == string.Empty)
                {
                    button4.Text = button8.Text;
                    button8.Text = string.Empty;
                }
                if (button12.Text == string.Empty)
                {
                    button12.Text = button8.Text;
                    button8.Text = string.Empty;
                }
                if (button7.Text == string.Empty)
                {
                    button7.Text = button8.Text;
                    button8.Text = string.Empty;
                }
            }
            Verificar();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            timer1.Start();
            click++;
            lbClicks.Text = click.ToString();
            if (button9.Text != string.Empty)
            {
                if (button5.Text == string.Empty)
                {
                    button5.Text = button9.Text;
                    button9.Text = string.Empty;
                }
                if (button10.Text == string.Empty)
                {
                    button10.Text = button9.Text;
                    button9.Text = string.Empty;
                }
                if (button13.Text == string.Empty)
                {
                    button13.Text = button9.Text;
                    button9.Text = string.Empty;
                }
            }
            Verificar();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            timer1.Start();
            click++;
            lbClicks.Text = click.ToString();
            if (button10.Text != string.Empty)
            {
                if (button6.Text == string.Empty)
                {
                    button6.Text = button10.Text;
                    button10.Text = string.Empty;
                }
                if (button11.Text == string.Empty)
                {
                    button11.Text = button10.Text;
                    button10.Text = string.Empty;
                }
                if (button14.Text == string.Empty)
                {
                    button14.Text = button10.Text;
                    button10.Text = string.Empty;
                }
                if (button9.Text == string.Empty)
                {
                    button9.Text = button10.Text;
                    button10.Text = string.Empty;
                }
            }
            Verificar();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            timer1.Start();
            click++;
            lbClicks.Text = click.ToString();
            if (button11.Text != string.Empty)
            {
                if (button7.Text == string.Empty)
                {
                    button7.Text = button11.Text;
                    button11.Text = string.Empty;
                }
                if (button12.Text == string.Empty)
                {
                    button12.Text = button11.Text;
                    button11.Text = string.Empty;
                }
                if (button15.Text == string.Empty)
                {
                    button15.Text = button11.Text;
                    button11.Text = string.Empty;
                }
                if (button10.Text == string.Empty)
                {
                    button10.Text = button11.Text;
                    button11.Text = string.Empty;
                }
            }
            Verificar();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            timer1.Start();
            click++;
            lbClicks.Text = click.ToString();
            if (button12.Text != string.Empty)
            {
                if (button8.Text == string.Empty)
                {
                    button8.Text = button12.Text;
                    button12.Text = string.Empty;
                }
                if (button16.Text == string.Empty)
                {
                    button16.Text = button12.Text;
                    button12.Text = string.Empty;
                }
                if (button11.Text == string.Empty)
                {
                    button11.Text = button12.Text;
                    button12.Text = string.Empty;
                }
            }
            Verificar();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            timer1.Start();
            click++;
            lbClicks.Text = click.ToString();
            if (button13.Text != string.Empty)
            {
                if (button9.Text == string.Empty)
                {
                    button9.Text = button13.Text;
                    button13.Text = string.Empty;
                }
                if (button14.Text == string.Empty)
                {
                    button14.Text = button13.Text;
                    button13.Text = string.Empty;
                }
            }
            Verificar();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            timer1.Start();
            click++;
            lbClicks.Text = click.ToString();
            if (button14.Text != string.Empty)
            {
                if (button10.Text == string.Empty)
                {
                    button10.Text = button14.Text;
                    button14.Text = string.Empty;
                }
                if (button15.Text == string.Empty)
                {
                    button15.Text = button14.Text;
                    button14.Text = string.Empty;
                }
                if (button13.Text == string.Empty)
                {
                    button13.Text = button14.Text;
                    button14.Text = string.Empty;
                }
            }
            Verificar();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            timer1.Start();
            click++;
            lbClicks.Text = click.ToString();
            if (button15.Text != string.Empty)
            {
                if (button11.Text == string.Empty)
                {
                    button11.Text = button15.Text;
                    button15.Text = string.Empty;
                }
                if (button16.Text == string.Empty)
                {
                    button16.Text = button15.Text;
                    button15.Text = string.Empty;
                }
                if (button14.Text == string.Empty)
                {
                    button14.Text = button15.Text;
                    button15.Text = string.Empty;
                }
            }
            Verificar();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            timer1.Start();
            click++;
            lbClicks.Text = click.ToString();
            if (button16.Text != string.Empty)
            {
                if (button12.Text == string.Empty)
                {
                    button12.Text = button16.Text;
                    button16.Text = string.Empty;
                }
                if (button15.Text == string.Empty)
                {
                    button15.Text = button16.Text;
                    button16.Text = string.Empty;
                }
            }
            Verificar();
        }
        private void buttonReiniciar_Click(object sender, EventArgs e)
        {
            Reiniciar();
            lbClicks.Text = "0";
            timer1.Stop();
            Segundos = 0;
            minutos = 0;
            horas = 0;
            lbSegundos.Text = "00";
            lbMinutos.Text = "00";
            lbHoras.Text = "00";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Segundos++;
            lbSegundos.Text = Segundos.ToString();
            lbMinutos.Text = minutos.ToString();
            lbHoras.Text = horas.ToString();
            if (Segundos == 59)
            {
                Segundos = 0;
                minutos++;
            }
            if (minutos == 59)
            {
                minutos = 0;
                horas++;
            }
        }

        private void buttonIniciar_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
         
        private void btnPausa_Click(object sender, EventArgs e)
        {
            timer1.Stop();            
        }
        
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            var lista = new List<string>();
            foreach (Button item in groupBox1.Controls)
            {                
                if (item.Text == String.Empty)
                {
                    lista.Add("16");
                }
                else
                {
                    lista.Add(item.Text);
                }
            }
            lista.Add(click.ToString());
            lista.Add(Segundos.ToString());
            lista.Add(minutos.ToString());
            lista.Add(horas.ToString());
            string msgG = operaciones.GuardarPartida(lista);
            MessageBox.Show(msgG);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
