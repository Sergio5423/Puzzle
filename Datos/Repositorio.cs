using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class Repositorio
    {
        string ruta = "Archivo.txt";
        public string GuardarPartida(Partida partida)
        {            
            //1
            StreamWriter sw = new StreamWriter(ruta, true);            

            //2                        
            sw.WriteLine(partida.ToString());                                                
            
            //3
            sw.Close();            
            return "Datos Almacenados";
        }
        public List<Partida> ConsultarPartidas()
        {
            var lista = new List<Partida>();

            var sr = new StreamReader(ruta);

            while (!sr.EndOfStream)
            {
                lista.Add(Mapeador(sr.ReadLine()));
            }
            sr.Close();
            return lista;
        }
        private Partida Mapeador(string linea)
        {
            var partida = new Partida
            {
                Text1 = linea.Split(';')[0],
                Text2 = linea.Split(';')[1],
                Text3 = linea.Split(';')[2],
                Text4 = linea.Split(';')[3],
                Text5 = linea.Split(';')[4],
                Text6 = linea.Split(';')[5],
                Text7 = linea.Split(';')[6],
                Text8 = linea.Split(';')[7],
                Text9 = linea.Split(';')[8],
                Text10 = linea.Split(';')[9],
                Text11 = linea.Split(';')[10],
                Text12 = linea.Split(';')[11],
                Text13 = linea.Split(';')[12],
                Text14 = linea.Split(';')[13],
                Text15 = linea.Split(';')[14],
                Text16 = linea.Split(';')[15],
                Click = linea.Split(';')[16],
                Segundos = linea.Split(';')[17],
                Minutos = linea.Split(';')[18],
                Horas = linea.Split(';')[19],
            };
            return partida;
        }
    }
}
