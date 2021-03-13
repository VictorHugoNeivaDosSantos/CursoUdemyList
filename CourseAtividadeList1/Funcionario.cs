using System;
using System.Collections.Generic;
using System.Text;

namespace CourseAtividadeList1
{
    class Funcionario { 


        public string Nome { get; set; }
    public int IDFuncionario { get; set; }
    public double SalarioFuncionario { get; set; }


    public Funcionario(int idFun, string nomeFun, double salarioFun)
    {

        Nome = nomeFun;
        IDFuncionario = idFun;
        SalarioFuncionario = salarioFun;

    }


    public void AumentarSalarioFuncionario(double aumentoPorcentagem)
    {

        SalarioFuncionario = SalarioFuncionario * ((100 + aumentoPorcentagem) / 100);

    }


    public override string ToString()
    {
        return "#" + IDFuncionario + ", " + Nome + ", tem o salário de R$" + SalarioFuncionario;
    }





}
    }
}
