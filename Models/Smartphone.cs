namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
       
        public string Modelo { get; set; }

        public string Imei { get; set; }

        public int Memoria { get; set; }
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Memoria = memoria;
            Imei = imei;
            Modelo = modelo;
            Numero = numero;
            return;
            
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);

      

    }
}