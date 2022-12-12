using Propriedades_Metodos_e_Construtores_com_CSharp_main.Models;

Pessoa p1 = new Pessoa("Lucas", "Alan");
Pessoa p2 = new Pessoa("Alan", "Lima");

Curso ingles = new Curso();
ingles.Nome = "Inglês";
ingles.Alunos = new List<Pessoa>();

ingles.AdicionarAluno(p1);
ingles.AdicionarAluno(p2);
ingles.ListarAlunos();