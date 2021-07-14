using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Menu
    {
        List<Produto> produtos = new List<Produto>();
        List<Categoria> categorias = new List<Categoria>();
        public void Cabecalho()
        {
            Console.WriteLine("--------------");
        }

        public void Opcoes()
        {
            Console.WriteLine("------------- Menu de opções -------------");
            Console.WriteLine("1 - Cadastro de Produto \n 2 - Cadastro de Categoria \n 3 - 0 - Sair ");
        }
        public void Escolhas()
        {
            string resposta = "y";

            {
                Opcoes();
                byte escolha = Convert.ToByte(Console.ReadLine());
                switch (escolha)
                {
                    case 0:
                        return;

                    case 1:

                        byte Id = 1;
                        do CadastroProd()

                        

                        //case 1

                }
            }
        }
        public void Rodape()
        {
            Console.WriteLine("-------------");
        }
        public void CadastroProd()
        {
            byte id = 0;
            Console.WriteLine("Nome do Produto");
            string nome = Console.ReadLine();
            Console.WriteLine("Descricao do produto");
            decimal valor = Convert.ToDecimal(Console.ReadLine());
            Produto produto = new Produto(id, nome, valor);

        }
    }
}
