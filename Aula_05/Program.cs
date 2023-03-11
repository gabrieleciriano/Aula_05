using Aula_05;

Produto p1 = new Produto(1, 10.90M, "Cerveja");

Console.WriteLine(p1.getId()+" "+p1.getDescricao());

p1.setValor(11.85M);
p1.setDescricao("Cerveja Skol 1 litrão");

Console.WriteLine(p1.getId() + " " + p1.getDescricao());

Endereco endereco = new Endereco("Rua Mario Miziara", "91", "Sobral", "15906304", "Taquaritinga", "SP");

Cliente c1 = new Cliente(1, "Gabriele", "999758483", endereco);
Cliente c2 = new Cliente(1, "Gabriela", "999758483", endereco);


Console.WriteLine(c2.getEndereco().getRua() + " "+c2.getEndereco().getNumero());
