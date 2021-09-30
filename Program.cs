using System;

namespace Atividade_final___Trilha_especialista
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Teste");
            Console.WriteLine("Por favor, digite 1 se o funcionario for terceirizado, ou 0 se for interno");
            int tipo_func = Console.ReadLine();
            Funcionario_terceiro func1 = new Funcionario_terceiro("Lucas", 40, 8, 4350);
            func1.CalculaSalario();
            func1.ImprimeDados(); 
        }
    }
}
