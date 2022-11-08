using DesafioPOO.Models;

// CELULAR NOKI 
Nokia celularNokia = new Nokia("79981940449","A25s","1234568","64GB");

celularNokia.Ligar();
celularNokia.InstalarAplicativo("Whatsapp");
celularNokia.ReceberLigacao();

// CELULAR IPHONE

Iphone celularIphone = new Iphone("79981141618","10","17584","128GB");

celularIphone.Ligar();
celularIphone.InstalarAplicativo("Instagram");
celularIphone.ReceberLigacao();

Console.WriteLine($"Numero do meu celular Nokia: {celularNokia.Numero}");

Console.WriteLine($"Numero do meu celular Iphone: {celularIphone.Numero}");