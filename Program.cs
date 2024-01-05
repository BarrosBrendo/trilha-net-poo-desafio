using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia smartphone1 = new(numero: "65665", modelo: "nokia01", iMEI: "adasd", memoria: 64);
Iphone smartphone2 = new(numero: "66544", modelo: "iphone01", iMEI: "adsa", memoria: 64);

Console.WriteLine("Smartphone Nokia:");
smartphone1.Ligar();
smartphone1.ReceberLigacao();
smartphone1.InstalarAplicativo(nomeApp: "Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphoe Iphone:");
smartphone1.Ligar();
smartphone2.ReceberLigacao();
smartphone2.InstalarAplicativo(nomeApp: "Signal");
