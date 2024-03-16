using ExemploExplorando.Models;
using System.Globalization;


string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

foreach (string linha in linhas)
{
    Console.WriteLine(linha);
}








// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-br");

// string dataString = "2022-04-17 18:00";

// bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);

// if (sucesso)
// {
//     Console.WriteLine($"Conversão com sucesso! Data: {data}");
// }
// else
// {
//     Console.WriteLine($"{dataString} não é uma data válida");
// }







// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-br");

// decimal valorMonetario = 1582.40M;

// Console.WriteLine(valorMonetario.ToString("C8"));

// double porcentagem = .3421;

// Console.WriteLine(porcentagem.ToString("P"));

// int numero = 123456;
// Console.WriteLine(numero.ToString("##-##-##"));






// string numero1 = "10";
// int numero2 = 20;

// string resultado = numero1 + numero2;

// Console.WriteLine(resultado);




// Pessoa p1 = new Pessoa(nome: "Leonardo", sobrenome: "Buta");
// Pessoa p2 = new Pessoa(nome: "Eduardo", sobrenome: "Neves Queiroz");

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Ingles";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListaAluno();



// Pessoa p1 = new Pessoa();
// p1.Nome = "Leonardo";
// p1.Sobrenome = "Buta";
// p1.Idade = 20;
// p1.Apresentar();