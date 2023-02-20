using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposicaoFuncionarios.Classes
{
     class Funcionario
    {
        public string nome { get; set; }
        public double salario { get; set; }

        public EmpreTerceira empreTerceira { get; set; }

        public List<Contrato> lista = new List<Contrato>();



        
        public Funcionario()
        {

        }

        public Funcionario(string nome, double salario, EmpreTerceira empreTerceira)
        {
            this.nome = nome;
            this.salario = salario;
            this.empreTerceira = empreTerceira;
        }
        public void AdContrato(Contrato contr)
        {
            lista.Add(contr);
        }
        public void RemoveContrato(Contrato contr)
        {
            lista.Remove(contr);
        }
    }
}
