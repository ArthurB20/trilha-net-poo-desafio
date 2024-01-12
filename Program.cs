using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new Nokia("123456", "Nokia 1", "8", 46);
nokia.InstalarAplicativo("Shazam");
nokia.Ligar();
// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone IPhone:");
Iphone iphone = new Iphone("78910", "IPhone 7", "3", 58);
iphone.InstalarAplicativo("Reddit");
iphone.ReceberLigacao();