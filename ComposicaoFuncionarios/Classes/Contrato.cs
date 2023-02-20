using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposicaoFuncionarios.Classes
{
     class Contrato
    {
        public string TipoContarto { get; set; }
        public double Duracao { get; set; }



        public Contrato(string tipoContarto, double duracao)
        {
            TipoContarto = tipoContarto;
            Duracao = duracao;
        }
    }
}
