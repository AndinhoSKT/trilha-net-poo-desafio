namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        
         public override void InstalarAplicativo(string Telegram){
            Console.WriteLine($"Instalando o app: {Telegram} no Iphone'");
        }

        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }




    }
}