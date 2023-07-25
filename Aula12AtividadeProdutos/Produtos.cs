using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula12AtividadeProdutos
{
    internal class Produtos
    {
        public string nome;
        public string descricao;
        public int quantidade;
        public double preco;
        public bool status;

        public void mostra()
        {
            Console.WriteLine($"Produto: {nome}, Quantidade: {quantidade}, Preço: {preco}, Status: {status}\nDescrição: {descricao}");
        }

        public void desativa()
        {
            Console.WriteLine("Quer desativar o produto?\n'S' para sim\n'N' para não");
            string resp = Console.ReadLine();
            if (resp=="S")
            {
                status= false;
            }
            else
            {
                status= true;
            }
        }

        public void quantidadeDesativada()
        {
            Console.WriteLine("Quer zerar a quantidade?\n");
            string resp = Console.ReadLine();
            if (resp == "S")
            {
                quantidade=0;
            }
            
        }
    }
}
