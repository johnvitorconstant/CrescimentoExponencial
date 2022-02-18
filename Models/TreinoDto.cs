using System;

namespace CrescimentoExponencial.Models
{
    public class TreinoDto
    {
        public TreinoDto( string name, int repeticoes)
        {
           
            Name = name;
            Repeticoes = repeticoes;
          
        }

   
        public string Name { get; set; }
        public int Repeticoes { get; set; }
  


    }
}
