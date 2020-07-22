using System;
using System.Linq;

namespace Classe
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            aluno.Nome = "Camila";
            aluno.Sala = "3ª série";
            aluno.Numero = 6;

            Console.WriteLine("Qual é o bimestre que você deseja saber a nota?");
            int bimestre = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"A nota da aluna {aluno.Nome}, número {aluno.Numero} da sala {aluno.Sala} no {bimestre}º bimestre é {aluno.notes[bimestre - 1]}.");

            Console.WriteLine($"E sua média geral é {aluno.notes.Average()}.");
        }
    }
}
