using System;
using System.Collections.Generic;
namespace CourseAtividadeList1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> lista = new List<Funcionario>();

            Boolean inicio = true;
            while (inicio == true)
            {
                Console.WriteLine();
                Console.Write("1. Cadastro, 2.Aumentar Salário, 3.Sair: ");
                int opc = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (opc == 1)
                {
                    Console.Write("Digite o nome:");
                    string nome = Console.ReadLine();
                    Console.Write("Digite o ID: ");
                    int ID = int.Parse(Console.ReadLine());
                    Console.Write("Digite o salário:");
                    double salario = double.Parse(Console.ReadLine());
                    lista.Add(new Funcionario(ID, nome, salario));
                    Console.WriteLine("--------------------Funcionário cadastrado!!!----------------------");
                    Console.WriteLine();

                }
                else if (opc == 2)
                {
                    Console.WriteLine();
                    Console.WriteLine("-----------------Localizando o Funcionário para aumento------------------");
                    Console.Write("Digite o ID do funcionario: ");
                    int ID = int.Parse(Console.ReadLine());
                    Funcionario fun = lista.Find(x => x.IDFuncionario == ID);
                    Console.WriteLine(fun);

                    if (fun != null)
                    {
                        Console.WriteLine("------------------Funcionário encontrado!----------------");
                        Console.WriteLine();
                        Console.Write("Digite a porcentagem de aumento: ");
                        double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        fun.AumentarSalarioFuncionario(porcent);
                        Console.WriteLine(fun);
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Funcionário não encontrado!");
                        Console.WriteLine();

                    }
                }
                else if (opc == 3)
                {
                    Console.WriteLine();

                    Console.WriteLine("Fim do programa!!!");
                    inicio = false;
                    Console.WriteLine();
                }


                foreach (var item in lista)
                {
                    Console.WriteLine(item);
                }





            }

        }

    }
    }
}
