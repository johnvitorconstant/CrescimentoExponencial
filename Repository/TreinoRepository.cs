using CrescimentoExponencial.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CrescimentoExponencial.Repository
{
    public class TreinoRepository
    {
        static Treino treino1 = new Treino("Biceps", 15);
        static Treino treino2 = new Treino("Triceps", 20);
        private List<Treino> Treinos = new List<Treino>() { treino1, treino2 };

        public List<Treino> ObterTodos()
        {
            return Treinos;
        }

        public async Task InserirTreino(Treino treino)
        {
            Treinos.Add(treino);

        }


    }
}
