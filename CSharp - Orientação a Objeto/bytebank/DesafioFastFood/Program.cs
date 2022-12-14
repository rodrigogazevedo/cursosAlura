using DesafioFastFood.Conta;
using DesafioFastFood.ItensOrdem;
using DesafioFastFood.Moradia;
using DesafioFastFood.Ordem;
using DesafioFastFood.ProdutosOrdem;

ItemPedido itemPedido1 = new ItemPedido();
itemPedido1.quantidade = 1;
itemPedido1.numero_Pedido = 100;
itemPedido1.produto1 = new Produto();
itemPedido1.produto1.codigo_Produto = 02;
itemPedido1.produto1.Descricao = "Pizza";
itemPedido1.produto1.valor_Unitario = 32.0;
itemPedido1.produto1.quantidade = 1;
itemPedido1.produto2 = new Produto();
itemPedido1.produto2.codigo_Produto = 02;
itemPedido1.produto2.Descricao = "Pizza";
itemPedido1.produto2.valor_Unitario = 35.0;
itemPedido1.produto2.quantidade = 1;
itemPedido1.produto3 = new Produto();
itemPedido1.produto3.codigo_Produto = 02;
itemPedido1.produto3.Descricao = "Pizza";
itemPedido1.produto3.valor_Unitario = 44.0;
itemPedido1.produto3.quantidade = 1;

Cliente cliente1 = new Cliente();
cliente1.endereco = new Endereco();
cliente1.nome = "José da Silva";
cliente1.cpf = "533.853.970-57";
cliente1.email = "josesilva@email.com";
cliente1.endereco.rua = "Rua 1º de março";
cliente1.endereco.bairro = "Copacabana";
cliente1.endereco.cidade = "Rio de Janeiro";
cliente1.endereco.cep = "31115-780";
cliente1.endereco.numero = 150;

Pedido pedido1 = new Pedido();
pedido1.cliente = cliente1;
pedido1.item = itemPedido1;
pedido1.numero_Pedido = 1000;
pedido1.total_Pedido = 111.0F;

Console.WriteLine(cliente1.endereco.rua);
Console.WriteLine(pedido1.cliente.nome);
