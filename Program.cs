using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia("68745", "Modelo 1", "99999", 32);
nokia.Ligar();
nokia.InstalarAplicativo("YouTube");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone("84563", "Modelo 2", "77777", 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");
