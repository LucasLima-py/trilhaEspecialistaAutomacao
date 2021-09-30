using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade_final___Trilha_especialista
{
    class Class1
    {
        class Funcionario // Classe mãe
        {
            public string Nome { get; set; }
            public int Carga_horaria { get; set; }
            public double Valor_hora { get; set; }
            public double Salario { get; set; }
            public int Tipo_funcionario { get; set; }
        }
        class Funcionario_terceiro : Funcionario  // Classe filha
        {

            public string Empresa_origem { get; set; }
            public double Taxa_servico { get; private set; }

            public Funcionario_terceiro(string Nome_t, int Carga_horaria_t, double Valor_hora_t, double Salario_t)
            {
                Empresa_origem = Empresa_origem;
                Taxa_servico = Taxa_servico;
                Nome_t = Nome;
                Carga_horaria_t = Carga_horaria;
                Valor_hora_t = Valor_hora;
                Salario_t = Salario;
            }
            public void CalculaSalario()   // method
            {
                if (Tipo_funcionario == 0)
                {
                    Console.WriteLine("Funcionario Interno!");
                    Salario = Carga_horaria * Valor_hora;
                }
                else
                {
                    Console.WriteLine("Funcionario Terceiro!");
                    Salario = (Carga_horaria * Valor_hora) + Taxa_servico;
                }

            }
            public void ImprimeDados()   // method
            {
                Console.WriteLine("O nome do funcionário é: " + Nome);
                Console.WriteLine("O salário do funcionário + " + Nome + "é: " + Salario);
            }
        }
    }
}
