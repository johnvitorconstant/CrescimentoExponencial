using System;

namespace CrescimentoExponencial.Models
{
    public class TreinoDto
    {
        public TreinoDto(string name, int repeticoes)
        {

            Name = name;
            Repeticoes = repeticoes;

        }


        /// <example>
        /// Supino reto
        /// </example>
        public string Name { get; set; }


        /// <example>
        /// 15
        /// </example>
        public int Repeticoes { get; set; }



    }
}
