using POOcelularCsharp.Models;

Smartphone smartphone1 = new Nokia("98888-9420", "NokiaV1", "111111111", 32 );
Smartphone smartphone2 = new Iphone("98888-9420", "IphoneX", "22222222", 64);

smartphone1.Apresentar();
smartphone1.Ligar();
smartphone1.ReceberLigacao();
smartphone1.InstalarAplicativo("WhatsApp");

Console.WriteLine();

smartphone2.Apresentar();
smartphone2.Ligar();
smartphone2.ReceberLigacao();
smartphone2.InstalarAplicativo("Instagram");
