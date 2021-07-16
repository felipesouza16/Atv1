using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1.Models
{

    public class Produto : BaseModel
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public Categoria  Categoria{ get; set; }
        public Produto(int Id, string Nome, decimal Valor, Categoria Categoria)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.Valor = Valor;
            this.Categoria = Categoria;
        }
        public override string ToString()
        {
            return $" |ID: {Id}\n |Nome : {Nome}\n |Valor: R${Valor.ToString("F2").Replace(',','.')}\n |Nome da Categoria: {Categoria.Nome} |Descrição da Categoria: {Categoria.Descricao} \n\n";
        }

    }
}
