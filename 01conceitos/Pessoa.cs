class Pessoa {
    // Atributos
    public string? Nome;

    public int Idade;

    //metodo de apresentação

    public void Apresentação() 
    {
        Console.WriteLine($"Olá, meu nome é {Nome}");
    }

    //Metodo para retornar a situação da Idade

    public string VerificarIdade() 
    {
        return Idade >= 18 ? "É maior de idade" : "É menor de idade";
    }
}