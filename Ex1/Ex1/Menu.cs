﻿using Ex1.Models;
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
                    Console.WriteLine(" 1 - Cadastro de Produto \n 2 - Cadastro de Categoria \n 3 - Imprimir Produtos \n 4 - Imprimir Categorias \n 0 - Sair ");
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
                            imprimiProduto();
                            break;
                        case 4:
                            imprimiCategoria();
                            break;

                    }
                }
            }
        }

        //public void Cadastro(BaseModel model) 
        //{
        //    if (model.GetType() == typeof(Produto))
        //    {

        //    }
        //    else if (model.GetType() == typeof(Categoria)) 
        //    {

        //    }

        //}

        public void CadastroProd()
        {
            Console.Write("Digite o nome do produto: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o valor do produto: ");
            decimal valor = Convert.ToDecimal(Console.ReadLine());
           
            Categoria categoria = ProcuraCategoria();

            Produto produto = new Produto(contadorProd, nome, valor, categoria);
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
        public void imprimiProduto()
        {
            foreach (Produto prod in produtos)
            {
                Console.WriteLine(prod);
            }

            
        }

        public void imprimiCategoria() 
        {
            foreach (Categoria categ in categorias)
            {
                Console.WriteLine(categ);
            }
        }

        public Categoria ProcuraCategoria() 
        {
            do
            {
                Console.WriteLine("Escolhas uma das categorias abaixo, pelo Id");
                imprimiCategoria();
                int id = Convert.ToInt32(Console.ReadLine());
                foreach (Categoria categ in categorias)
                {
                    if (id == categ.Id)
                    {
                        return categ;
                    }
                }
                Console.WriteLine("Categoria não encontrada!!");
                Console.WriteLine("Deseja cadastrar uma nova Categoria?[S/N]");
                string sn = Console.ReadLine().ToLower().Trim();
                if (sn.Equals("s"))
                {
                    CadastroCateg();
                }
            } while (true);
        }

       
    }
}
