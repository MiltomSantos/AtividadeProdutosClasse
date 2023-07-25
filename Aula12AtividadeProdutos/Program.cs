using Aula12AtividadeProdutos;

Console.WriteLine("");

Produtos darkSouls1 = new Produtos();
darkSouls1.nome = "Dark Souls 1";
darkSouls1.descricao = "Um jogo dificil pra caramba";
darkSouls1.quantidade = 4;
darkSouls1.preco = 119.50;
darkSouls1.status = true;

darkSouls1.mostra();

darkSouls1.desativa();
darkSouls1.quantidadeDesativada();


Produtos darkSouls2 = new Produtos();
darkSouls2.nome = "Dark Souls 2";
darkSouls2.descricao = "Um jogo ruim pra caramba";
darkSouls2.quantidade = 40;
darkSouls2.preco = 50;
darkSouls2.status = true;

darkSouls2.mostra();
darkSouls2.desativa();
darkSouls2.quantidadeDesativada();

Produtos darkSouls3 = new Produtos();
darkSouls3.nome = "Dark Souls 3";
darkSouls3.descricao = "Um jogo dificil pra caramba!!!!!!";
darkSouls3.quantidade = 2;
darkSouls3.preco = 127.50;
darkSouls3.status = true;

darkSouls3.mostra();
darkSouls3.desativa();
darkSouls3.quantidadeDesativada();

darkSouls1.mostra();
darkSouls2.mostra();
darkSouls3.mostra();
