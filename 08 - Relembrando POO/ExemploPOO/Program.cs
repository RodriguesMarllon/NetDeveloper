using ExemploPOO.Models;

Aluno a1 = new Aluno
{
    Nome = "Marllon",
    Idade = 19,
    Email = "marllon@gmail.com",
    Nota = 10
};
a1.Apresentar();


Professor p1 = new Professor
{
    Nome = "Eduardo",
    Idade = 30,
    Email = "eduardo@gmail.com",
    Salario = 1000
};
p1.Apresentar();
