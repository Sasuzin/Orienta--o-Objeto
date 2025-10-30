    //Exemplo 1
Pessoa obj1 = new Pessoa();
obj1.Nome = "Luís";
obj1.Apresentação();

// Exemplo 02

Pessoa obj2 = new();
obj2.Nome = "Milena";
obj2.Apresentação();

    //Exemplo 03

Pessoa obj3 = new()
{
    Nome = "Matheus",
    Idade = 20
};

    // Verificar idade dos Objetos.
string retorno = obj3.VerificarIdade();
    Console.WriteLine(retorno);
