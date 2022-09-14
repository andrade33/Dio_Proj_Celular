using DesafioPOO.Models;


Console.WriteLine("===========================================");
Console.WriteLine("USando o Nokia...");
Smartphone nokia = new Nokia(numero: "9999999", modelo: "DIO NO-PRO 001", imei: "123456789", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("whatsapp");
nokia.ReceberLigacao();
Console.WriteLine("===========================================");

Console.WriteLine("===========================================");
Console.WriteLine("USando o Iphone...");
Smartphone iphone = new Iphone(numero: "6666666", modelo: "DIO NO-PRO 002", imei: "987654321", memoria: 64);
iphone.InstalarAplicativo("telegram");
iphone.ReceberLigacao();
Console.WriteLine("===========================================");

// TODO: Realizar os testes com as classes Nokia e Iphone