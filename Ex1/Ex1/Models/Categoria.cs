using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1.Models
{

    public class Categoria : BaseModel
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public Categoria(int id, string nome, string descricao)
        {
            this.Id = id;
            this.Nome = nome;
            this.Descricao = descricao;
        }

        public override string ToString()
        {
            return $" |ID: {Id}\n |Nome: {Nome}\n |Descrição: {Descricao}\n\n";
        }
    }

}
