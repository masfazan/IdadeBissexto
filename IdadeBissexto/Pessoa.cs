
using System.Data;

namespace IdadeBissexto
{
    internal class Pessoa
    {
        
            public string Nome;
            public int Idade;
            public string Profissao;
        public Pessoa()
        {

        }


        public string definirNome()
            {
                Console.WriteLine("Informe o nome: ");
                return Console.ReadLine();
            }
           
            public int definirIdade()
            {
                Console.WriteLine("Informe a idade: ");
                return int.Parse(Console.ReadLine());
            }
            public string definirProfissao() 
            {
            Console.WriteLine("Informe a profissão: ");
            return Console.ReadLine();
            }
            public void Imprimir()
            {
                Console.WriteLine($"Nome:{Nome}", this.Nome);
                Console.WriteLine($"Idade:{Idade}", this.Idade);
                Console.WriteLine($"Profissão:{Profissao}", this.Profissao);
            }

        public int IdadeBissexto()
        {
            int idbissexto=0;
            int anoNasc = DateTime.Now.Year - Idade;
            int anoAtual = DateTime.Now.Year;
            for (int i = anoNasc; i <= anoAtual; i++)//ano de nasc até o ano atual
            {
                if (DateTime.IsLeapYear(i))
                {
                    idbissexto++;
                }

            }
            Console.WriteLine("Número de anos bissextos durante a vida da pessoa: " + idbissexto);
            return idbissexto;
        }
        
    }
}
