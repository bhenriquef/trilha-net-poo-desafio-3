using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "123456", modelo: "1", imei: "111111", memoria: 2);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero: "23456", modelo: "2", imei: "22222", memoria: 2);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");