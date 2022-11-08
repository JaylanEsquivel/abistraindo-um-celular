namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero,string modelo, string imei, string memoria) : base(numero){
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }
        public override void InstalarAplicativo(string nomeApp) {

            Console.WriteLine($"Instalando aplicativo Windows Phone {nomeApp} ...");

        }
    }
}