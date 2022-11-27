using supermercadomenorpreco;

CadastroCliente cadastroCliente = new()
{
    Nome = "Leite Muuu",
    Fabricante = "Delta LTDA",
    CodigoDeBarras = "98566 4578A 75631 123458 00005 111459",
    ValorUnitario = 5.65,
    ValorDeCompra = 3.30,
    QuantidadeEmEstoque = 100
};

Console.WriteLine("Nome produto = "+cadastroCliente.Nome);
Console.WriteLine("Fabricante produto = "+cadastroCliente.Fabricante);
Console.WriteLine("Código de barras do produto = "+cadastroCliente.CodigoDeBarras);
Console.WriteLine("Valor unitário do produto = "+cadastroCliente.ValorUnitario);
Console.WriteLine("Valor de compra do produto = "+cadastroCliente.ValorDeCompra);
Console.WriteLine("Quantidade em estoque do produto = "+cadastroCliente.QuantidadeEmEstoque);
