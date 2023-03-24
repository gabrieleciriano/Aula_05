using Aula_05;
using Aula_05.Heranca;

//Produto p1 = new Produto(1, 10.90M, "Cerveja");

//Console.WriteLine(p1.getId()+" "+p1.getDescricao());

//p1.setValor(11.85M);
//p1.setDescricao("Cerveja Skol 1 litrão");

//Console.WriteLine(p1.getId() + " " + p1.getDescricao());

Endereco endereco = new Endereco("Rua Mario Miziara", "91", "Sobral", "15906304", "Taquaritinga", "SP");

Cliente c1 = new Cliente(1,"Gabriele", "999999999", endereco);
Cliente c2 = new Cliente(2,"Gabriela", "999999999",endereco);
Cliente c3 = new Cliente(3,"Ryan", "999999999", endereco);
Cliente c4 = new Cliente(4,"André", "999999999", endereco);
Cliente c5 = new Cliente(5, "Jhonatan", "999999999", endereco);



//Console.WriteLine(c2.getEndereco().getRua() + " "+c2.getEndereco().getNumero());

//--------------------------------------------------------------------------------------------------------------

//1 - Imprima na tela todos os clientes desse contexto

List<Cliente> listaClientes = new()
{
    c1,
    c2,
    c3,
    c4,
    c5
};


for (int i = 0; i < listaClientes.Count; i++)
{
    Console.WriteLine(listaClientes[i].ImprimirDadosCliente());
    Console.WriteLine("\n----------------------------------------------------------\n");
}

//2 - Crie uma lista com 560 produtos e imprima na tela

List<Produto> listaProdutos = new List<Produto>();
for (int i = 0; i < 560; i++)
{
    Produto produto = new Produto(i + 1, (i * 2) + 3, $"produto Nº {i + 1}");
    listaProdutos.Add(produto);
    Console.WriteLine($"Id: {produto.getId()}, Valor: {produto.getValor()}, Descrição do Produto: {produto.getDescricao()}");
    Console.WriteLine("\n----------------------------------------------------------\n");
}

//3 - Crie uma lista que aceite qualquer tipo de veículo e imprima na tela

Carro jeep = new Carro();
jeep.temMotor = true;
jeep.numeroPortas = 4;
jeep.numeroAssentos = 5;
jeep.fabricante = "Jeep";
jeep.cintoSegurança = true;
jeep.arCondicionado = false;

Carro hb20 = new Carro();
hb20.temMotor = true;
hb20.numeroPortas = 4;
hb20.numeroAssentos = 5;
hb20.fabricante = "Hyundai";
hb20.cintoSegurança = true;
hb20.arCondicionado = false;

Bike bike = new Bike();
bike.temMotor = false;
bike.numeroPortas = 0;
bike.numeroAssentos = 1;

Bike speed = new Bike();
speed.temMotor = false;
speed.numeroPortas = 0;
bike.numeroAssentos = 1;


List<Veiculo> listaVeiculos = new();
{
    listaVeiculos.Add(jeep);
    listaVeiculos.Add(hb20);
    listaVeiculos.Add(bike);
    listaVeiculos.Add(speed);
}


foreach (var item in listaVeiculos)
{
    Console.WriteLine(item.ExibirDados());
    Console.WriteLine("\n----------------------------------------------------------\n");
}