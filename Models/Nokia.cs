namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string WhatsAPP){
                Console.WriteLine($"Instalando o app: {WhatsAPP} no Nokia");
        }

         public void Ligar()
        {
            Console.WriteLine("Chamando...");
        }


         public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo uma chama de voz...");
        }

      

    }
}