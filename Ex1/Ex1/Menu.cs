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
        List<Categoria> categorias = new List<Categoria>();
        int contadorProd = 0;
        int contadorCateg = 0;
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

                        case 2:
                            CadastroCateg();
                            break;

                        case 3:
                            Dados();
                            break;

                        
                    }
                }
            }
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
        }

        public void CadastroCateg()
        {
            Console.Write("Digite o nome da categoria: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o descricao da categoria: ");
            string descricao = Console.ReadLine();

            Categoria categoria = new Categoria(contadorCateg, nome, descricao);
            contadorCateg++;

            categorias.Add(categoria);
        }
        public void Dados()
        {
            foreach (Produto prod in produtos)
            {
                Console.WriteLine($" ID : {prod.Id}\n Nome : {prod.Nome}\n Valor{prod.Valor}");
            }

            foreach (Categoria categ in categorias)
            {
                Console.WriteLine($"ID : {categ.Id}\n Nome: {categ.Nome}\n Descricao {categ.Descricao}");
            }
        }
    }
}
