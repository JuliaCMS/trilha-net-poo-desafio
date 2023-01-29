using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "11986547887", modelo: "G21", imei: "75665346853", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "48985637755", modelo: "14 pro", imei: "74683411646", memoria: 256);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");
