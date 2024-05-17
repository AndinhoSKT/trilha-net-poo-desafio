using DesafioPOO.Models;


Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "1792145", modelo: "Modelo 1", imei: "12121212", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");




Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "87878787", modelo: "Modelo 2", imei: "4454545", memoria: 124);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");