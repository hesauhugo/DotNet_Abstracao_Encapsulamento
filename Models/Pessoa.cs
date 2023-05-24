using System;
using System.Threading.Tasks;

namespace DotNet_Introducao_Abstracao_Encapsulamento.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Pessoa
    {
        public string Nome {get; set;}
        public int Idade {get; set;}

        public void Apresentar(){
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos!");
        }

    }
}
