using System;

namespace CrescimentoExponencial.Models
{
    public class Treino
    {
        public Treino( string name, int repeticoes)
        {
           
            Name = name;
            Repeticoes = repeticoes;
          
        }

        public Guid Id { get; set; } = Guid.NewGuid();


        public string Name { get; set; }
        public int Repeticoes { get; set; }
        public DateTime DataDeCadastro { get; set; } = DateTime.Now;


    }
}
