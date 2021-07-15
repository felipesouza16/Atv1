using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    public class Menu
    {
        List<Produto> produtos = new List<Produto>();
        //List<Categoria> categorias = new List<Categoria>();
        int contadorProd = 0;
        
        public void Cabecalho()
        {
            Console.WriteLine("--------------");
        }

        public void Opcoes()
        {
        }
        public void Escolhas()
        {
            {
                while (true)
                {
                    Console.WriteLine("------------- Menu de opções -------------");
                    Console.WriteLine(" 1 - Cadastro de Produto \n 2 - Cadastro de Categoria \n 3 - Exibir Resultados \n 0 - Sair ");
                    byte escolha = Convert.ToByte(Console.ReadLine());
                    switch (escolha)
                    {
                        case 0:
                            return;

                        case 1:
                            CadastroProd();
                            break;

                        case 3:
                            ExibirDados();
                            break;

                        
                    }
                }
            }
        }
        public void Rodape()
        {
            Console.WriteLine("-------------");
        }
        public void CadastroProd()
        {
            Console.Write("Digite o nome do produto: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o valor do produto: ");
            decimal valor = Convert.ToDecimal(Console.ReadLine());

            Produto produto = new Produto(contadorProd, nome, valor);
            contadorProd++;

            produtos.Add(produto);
            Console.WriteLine(produtos);
        }
        public void ExibirDados()
        {
            foreach (Produto prod in produtos)
            {
                Console.WriteLine($" ID : {prod.Id}\n Nome : {prod.Nome}\n Valor{prod.Valor}");
            }
        }
    }
}
