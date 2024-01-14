﻿﻿using DesafioPOO.Models;


//Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "134620", modelo: "Modelo 1", imei: "123456789", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");
nokia.ReceberLigacao();

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone");
Smartphone iphone = new Iphone(numero: "201813", modelo: "Modelo 2", imei: "987654321", memoria: 256);
iphone.Ligar();
iphone.InstalarAplicativo("Whatsapp");
iphone.ReceberLigacao();