using System;
namespace _06Encapsulamento
{
    public class Aluno
    {
        private double nota1,nota2;
        private double media()
        {
            return (nota1+nota2)/2;
        }
    }
    public void mensagem()
    {
        Console.WriteLine("Informe a primeira nota");
        nota1=Convert.ToInt32(Console.ReadLine());
    }
}