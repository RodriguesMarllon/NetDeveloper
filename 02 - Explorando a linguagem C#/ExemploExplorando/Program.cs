using ExemploExplorando.Models;
using System.Globalization;

DateTime data = DateTime.Now;

Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));











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