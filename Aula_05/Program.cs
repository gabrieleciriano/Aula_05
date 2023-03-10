using Aula_05;

Produto p1 = new Produto(1, 10.90M, "Cerveja");

Console.WriteLine(p1.getId()+" "+p1.getDescricao());

p1.setValor(11.85M);
p1.setDescricao("Cerveja Skol 1 litrão");

Console.WriteLine(p1.getId() + " " + p1.getDescricao());