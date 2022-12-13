using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tupla.Models
{
    public class Pessoa
    {
        public Pessoa()
        {

        }
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }
        public void Deconstruct(out string nome, out string sobrenome)
        {
            nome = Nome;
            sobrenome = Sobrenome;
        }

        public string Nome;
        public string Sobrenome;
    }
}