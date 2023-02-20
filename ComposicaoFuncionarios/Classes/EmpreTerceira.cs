using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposicaoFuncionarios.Classes
{
     class EmpreTerceira
    {
        public string NomeEmpresa;
        public  int codigo;
        public int telefone;

        public EmpreTerceira(string nomeEmpresa, int codigo, int telefone)
        {
            NomeEmpresa = nomeEmpresa;
            this.codigo = codigo;
            this.telefone = telefone;
        }
    }
}
