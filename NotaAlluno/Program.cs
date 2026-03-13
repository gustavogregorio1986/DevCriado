using System;
using NotaAlluno.Control;
using NotaAlluno.Entidade;

class Program
{
    static void Main(string[] args)
    {
        Aluno marina = new Aluno
        {
            NomeAluno = "Marina",
            EmailAluno = "marina@gmail.com",
            Nota1 = 6.9,
            Nota2 = 7.9
        };

        Aluno luiz = new Aluno
        {
            NomeAluno = "Luiz",
            EmailAluno = "luiz@gmail.com",
            Nota1 = 2.9,
            Nota2 = 3.9,
            Recuperacao = 6.0 // exemplo de nota de recuperação
        };

        Aluno leni = new Aluno
        {
            NomeAluno = "Leni",
            EmailAluno = "leni@gmail.com",
            Nota1 = 2.9,
            Nota2 = 1.6
        };

        ControlarAluno controlar = new ControlarAluno();

        // Marina
        Console.WriteLine($"Nome do Aluno: {marina.NomeAluno}");
        Console.WriteLine($"Email do Aluno: {marina.EmailAluno}");
        Console.WriteLine($"Nota 1: {marina.Nota1}");
        Console.WriteLine($"Nota 2: {marina.Nota2}");
        Console.WriteLine($"Média: {controlar.MediaAluno(marina)}");
        Console.WriteLine($"Situação: {controlar.SituacaoAluno(marina)}");
        Console.WriteLine();

        // Luiz
        Console.WriteLine($"Nome do Aluno: {luiz.NomeAluno}");
        Console.WriteLine($"Email do Aluno: {luiz.EmailAluno}");
        Console.WriteLine($"Nota 1: {luiz.Nota1}");
        Console.WriteLine($"Nota 2: {luiz.Nota2}");
        Console.WriteLine($"Média: {controlar.MediaAluno(luiz)}");
        Console.WriteLine($"Situação: {controlar.SituacaoAluno(luiz)}");
        Console.WriteLine();

        // Luiz
        Console.WriteLine($"Nome do Aluno: {leni.NomeAluno}");
        Console.WriteLine($"Email do Aluno: {leni.EmailAluno}");
        Console.WriteLine($"Nota 1: {leni.Nota1}");
        Console.WriteLine($"Nota 2: {leni.Nota2}");
        Console.WriteLine($"Média: {controlar.MediaAluno(leni)}");
        Console.WriteLine($"Situação: {controlar.SituacaoAluno(leni)}");

        Console.ReadLine();
    }
}