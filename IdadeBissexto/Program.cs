using IdadeBissexto;

Pessoa pessoa = new Pessoa();

pessoa.Nome = pessoa.definirNome();
pessoa.Idade = pessoa.definirIdade();
pessoa.Profissao = pessoa.definirProfissao();


Console.WriteLine("DADOS PESSOAIS");
pessoa.Imprimir();
pessoa.IdadeBissexto();






