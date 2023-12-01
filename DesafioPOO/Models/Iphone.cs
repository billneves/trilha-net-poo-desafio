using System;

namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string marca, string modelo, int anoFabricacao)
            : base(numero, marca, modelo, anoFabricacao)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} no iPhone {Modelo}");
        }
    }
}
