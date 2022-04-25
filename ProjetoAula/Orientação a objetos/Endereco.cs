using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula.Orientação_a_objetos
{
    public struct Endereco
    {
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public string Numero { get; set; }
        public TipoRuaEnum TipoRuaEnum { get; set; }
    }
}
