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
                    Console.WriteLine(" 1 - Cadastro de Produto \n 2 - Cadastro de Categoria \n 3 - Imprimir Produtos \n 4 - Imprimir Categorias \n 5 - Procura Produto \n 6 - Procura Categoria\n 0 - Sair ");
                    int escolha = Valida.LeituraNumero();
                    switch (escolha)
                    {
                        case 0:
                            return;

                        case 1:
                            Console.Clear();
                            CadastroProd();
                            break;

                        case 2:
                            Console.Clear();
                            CadastroCateg();
                            break;

                        case 3:
                            Console.Clear();
                            imprimiProduto();
                            break;
                        case 4:
                            Console.Clear();
                            imprimiCategoria();
                            break;
                        case 5:
                            Console.Clear();
                            Console.WriteLine("Digite um nome de um produto:");
                            string procuraProd = Valida.ValidaString();
                            procuraProduto(procuraProd);
                            break;
                        case 6:
                            Console.Clear();
                            Console.WriteLine("Digite um nome de uma categoria:");
                            string procuraCat = Valida.ValidaString();
                            procuraCategoria(procuraCat);
                            break;
                        default:
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Opcao invalida, escolha uma das opçoes abaixo");
                            Console.ResetColor();
                            break;

                    }
                }
            }
        }

        public void CadastroProd()
        {
            Console.Write("Digite o nome do produto: ");
            string nome = Valida.ValidaString(); 

            Console.Write("Digite o valor do produto: ");
            decimal valor = Valida.LeituraDecimal();

            if (produtos.Count.Equals(0))
            {
                Console.WriteLine("Nenhuma categoria cadastrada.Primeiro Cadastre uma categoria.");
                CadastroCateg();

            }

            Categoria categoria = categoria = ProcuraCategoria();   
            

            Produto produto = new Produto(contadorProd, nome, valor, categoria);
            contadorProd++;

            produtos.Add(produto);
        }

        public void CadastroCateg()
        {
            Console.Write("Digite o nome da categoria: ");
            string nome = Valida.ValidaString();

            Console.Write("Digite o descricao da categoria: ");
            string descricao = Valida.ValidaString();

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
                int id = Valida.LeituraNumero();
                if (id >= 0) 
                {
                    foreach (Categoria categ in categorias)
                    {
                        if (id == categ.Id)
                        {
                            return categ;
                        }
                    }
                    Console.WriteLine("Categoria não encontrada!!");
                    Console.WriteLine("Deseja cadastrar uma nova Categoria?[S/N]");
                    string sn = Valida.validaSN();
                    if (sn.Equals("s"))
                    {
                        CadastroCateg();
                    }
                }
                
            } while (true);
        }

        public void procuraProduto(string nome)
        {
            if (produtos.Count.Equals(0))
            {
                Console.WriteLine("Sem produtos cadastrados");
            }
            else
            {
                nome = nome.ToLower();
                foreach (var item in produtos)
                {
                    string aux = item.Nome;
                    aux.ToLower();
                    if (aux.Equals(nome))
                    {
                        Console.WriteLine(item);
                        return;
                    }

                }
                Console.WriteLine("Sem produtos cadastrados com esse nome");
            }

        }

        public void procuraCategoria(string nome)
        {
            if (categorias.Count.Equals(0))
            {
                Console.WriteLine("Sem categorias cadastradas");
            }
            else
            {
                nome = nome.ToLower();
                foreach (var item in categorias)
                {
                    string aux = item.Nome;
                    aux.ToLower();
                    if (aux.Equals(nome))
                    {
                        Console.WriteLine(item);
                        return;
                    }
                }
                Console.WriteLine("Sem categorias cadastradas com esse nome");

            }

        }


    }
}
