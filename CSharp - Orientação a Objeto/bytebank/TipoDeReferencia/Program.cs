using TipoDeReferencia;

Roupa roupa1 = new Roupa();
roupa1.fabricante = "Moda Jeans";
roupa1.valor = 63.0;
Roupa roupa2 = roupa1;
roupa2.valor = roupa2.valor + 1000;
Console.WriteLine(roupa1.valor);
Console.ReadLine();