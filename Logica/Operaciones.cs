using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;
using System.Collections;

namespace Logica
{
    public class Operaciones
    {        
        Repositorio repositorio = new Repositorio();
        List<Partida> partidas = null;
        public string GuardarPartida(List<string> lista)
        {
            var partida = new Partida();
            int i = 0;
            foreach (string item in lista)
            {
                if (item == string.Empty)
                {
                    lista[i] = "16";
                }
                i++;
            }
            partida.Text1 = lista[0];
            partida.Text2 = lista[1];
            partida.Text3 = lista[2];
            partida.Text4 = lista[3];
            partida.Text5 = lista[4];
            partida.Text6 = lista[5];
            partida.Text7 = lista[6];
            partida.Text8 = lista[7];
            partida.Text9 = lista[8];
            partida.Text10 = lista[9];
            partida.Text11 = lista[10];
            partida.Text12 = lista[11];
            partida.Text13 = lista[12];
            partida.Text14 = lista[13];
            partida.Text15 = lista[14];
            partida.Text16 = lista[15];
            partida.Click = lista[16];
            partida.Segundos = lista[17];
            partida.Minutos = lista[18];
            partida.Horas = lista[19];
            string msgG = repositorio.GuardarPartida(partida);
            return msgG;
        }
        public List<Partida> ConsultarPartidas()
        {
            partidas = repositorio.ConsultarPartidas();
            if (repositorio.ConsultarPartidas().Count == 0)
            {
                return null;
            }
            foreach (var partida in partidas)
            {
                if (partida.Text1 == "16")
                {
                    partida.Text1 = string.Empty;
                }
                if (partida.Text2 == "16")
                {
                    partida.Text2 = string.Empty;
                }
                if (partida.Text3 == "16")
                {
                    partida.Text3 = string.Empty;
                }
                if (partida.Text4 == "16")
                {
                    partida.Text4 = string.Empty;
                }
                if (partida.Text5 == "16")
                {
                    partida.Text5 = string.Empty;
                }
                if (partida.Text6 == "16")
                {
                    partida.Text6 = string.Empty;
                }
                if (partida.Text7 == "16")
                {
                    partida.Text7 = string.Empty;
                }
                if (partida.Text8 == "16")
                {
                    partida.Text8 = string.Empty;
                }
                if (partida.Text9 == "16")
                {
                    partida.Text9 = string.Empty;
                }
                if (partida.Text10 == "16")
                {
                    partida.Text10 = string.Empty;
                }
                if (partida.Text11 == "16")
                {
                    partida.Text11 = string.Empty;
                }
                if (partida.Text12 == "16")
                {
                    partida.Text12 = string.Empty;
                }
                if (partida.Text13 == "16")
                {
                    partida.Text13 = string.Empty;
                }
                if (partida.Text14 == "16")
                {
                    partida.Text14 = string.Empty;
                }
                if (partida.Text15 == "16")
                {
                    partida.Text15 = string.Empty;
                }
                if (partida.Text16 == "16")
                {
                    partida.Text16 = string.Empty;
                }
            }
            return partidas;
        }
        public int[] Random()
        {            
            int[] numeros;
            numeros = new int[16];
            int numero;
            int f;

            for (f = 0; f < 16; f++)
            {
                do
                {
                    numero = new Random().Next(1, 17);
                } while (numeros.Contains(numero));
                numeros[f] = numero;
            }                        
            return numeros;
        }
    }
}
