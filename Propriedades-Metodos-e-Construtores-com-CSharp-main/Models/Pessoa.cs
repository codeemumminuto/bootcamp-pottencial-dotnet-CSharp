using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Propriedades_Metodos_e_Construtores_com_CSharp_main.Models
{   
    public class Pessoa
    {
        public Pessoa(){

        }

        public Pessoa(string nome, string sobrenome){
            Nome = nome;
            Sobrenome = sobrenome;
        }

        private string _nome;
        private int _idade;
        public string Nome {
            get => _nome.ToUpper();
            
            set{
                if(value == ""){
                    throw new ArgumentException("O nome não pode estar vazio");
                }

                _nome = value;
            } 
        }
        public int Idade {
            get => _idade;
            
            set{
                if(value < 0){
                    throw new ArgumentException("A idade não pode ser menor que 0");
                }

                _idade = value;
            } 
        }
        
        public string Sobrenome { get ; set;}
        public string NomeCompleto => $"{Nome} {Sobrenome}";


        public void Apresentar(){
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        }
    }
}