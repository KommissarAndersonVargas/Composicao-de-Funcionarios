using System;
using ComposicaoFuncionarios.Classes;
class Progran
{
    static void Main()
    {
        List<Funcionario> lista = new List<Funcionario>(); 
       
        int i;
        int y;
        int w;

        try
        {
            Console.Write("Digite o numero de funcionarios: ");
            int numer = int.Parse(Console.ReadLine());
            for (w = 1; w <= numer; w++)
            {



                Console.Write("Digite o nome do funcionario: ");
                string name = Console.ReadLine();
                Console.Write("Digite o salario do funcionario: ");
                double sal = double.Parse(Console.ReadLine());

                Console.Write("Digite o nome da empresa: ");
                string nomeEmpresa = Console.ReadLine();
                Console.Write("Digite o codigo da empresa: ");
                int codigo1 = int.Parse(Console.ReadLine());
                Console.Write("Digite o telefone: ");
                int telefo = int.Parse(Console.ReadLine());

                EmpreTerceira empreTerceira1 = new EmpreTerceira(nomeEmpresa, codigo1, telefo);

                Funcionario funcionario = new Funcionario
                {
                    nome = name,
                    salario = sal,
                    empreTerceira = empreTerceira1,


                };



                Console.Write("Digite o numero de contratos que ele tem: ");
                int num = int.Parse(Console.ReadLine());


                for (y = 0; y <= num; y++)
                {
                    Console.Write("Digite o tipo de contarto: ");
                    string contr = Console.ReadLine();
                    Console.Write("Digite a duracao: ");
                    double timeofctct = double.Parse(Console.ReadLine());



                    Contrato contrato = new Contrato(contr, timeofctct);
                    funcionario.AdContrato(contrato);





                }
                lista.Add(funcionario);




                Console.WriteLine("---infromacoes do Colaborador----");
                Console.WriteLine("Empresa Systens.Industrys");
                Console.WriteLine($"Nome: {funcionario.nome}");
                Console.WriteLine($"Salario: {funcionario.salario}");
                Console.WriteLine("Empresa terceirizada: ");
                Console.WriteLine($"Nome: {funcionario.empreTerceira.NomeEmpresa}");
                Console.WriteLine($"Codigo: {funcionario.empreTerceira.codigo}");
                Console.WriteLine($"Telefone Empresarial: {funcionario.empreTerceira.telefone}");

                Console.WriteLine($"TIPOS DE CONTRATO");


                foreach (Contrato a in funcionario.lista)
                {
                    Console.WriteLine($"Contrato: {a.TipoContarto} ");

                }


            }

            Console.WriteLine($"\n\n Nomes dos funcionarios \n");
            foreach (Funcionario a in lista)
            {
                Console.WriteLine($"Nome: {a.nome} ");

            }
        }

        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }


    }
}
       
