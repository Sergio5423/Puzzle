using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Partida
    {
        public Partida() { }
        public Partida(string text1,
                       string text2,
                       string text3,
                       string text4,
                       string text5,
                       string text6,
                       string text7,
                       string text8,
                       string text9,
                       string text10,
                       string text11,
                       string text12,
                       string text13,
                       string text14,
                       string text15,
                       string text16,
                       string click,
                       string segundos,
                       string minutos,
                       string horas) 
        {
            Text1 = text1;
            Text2 = text2;
            Text3 = text3;
            Text4 = text4;
            Text5 = text5;
            Text6 = text6;
            Text7 = text7;
            Text8 = text8;
            Text9 = text9;
            Text10 = text10;
            Text11 = text11;
            Text12 = text12;
            Text13 = text13;
            Text14 = text14;
            Text15 = text15;
            Text16 = text16;
            Click = click;
            Segundos = segundos;
            Minutos = minutos;
            Horas = horas;
        }

        public string Text1 { get; set; }
        public string Text2 { get; set; }
        public string Text3 { get; set; }
        public string Text4 { get; set; }
        public string Text5 { get; set; }
        public string Text6 { get; set; }
        public string Text7 { get; set; }
        public string Text8 { get; set; }
        public string Text9 { get; set; }
        public string Text10 { get; set; }
        public string Text11 { get; set; }
        public string Text12 { get; set; }
        public string Text13 { get; set; }
        public string Text14 { get; set; }
        public string Text15 { get; set; }
        public string Text16 { get; set; }
        public string Click { get; set; }
        public string Segundos { get; set; }
        public string Minutos { get; set;}
        public string Horas { get; set; }
        public override string ToString()
        {
            return $"{Text1};{Text2};{Text3};{Text4};{Text5};{Text6};{Text7};{Text8};{Text9};{Text10};{Text11};{Text12};{Text13};{Text14};{Text15};{Text16};{Click};{Segundos};{Minutos};{Horas}";
        }
    }    
}
