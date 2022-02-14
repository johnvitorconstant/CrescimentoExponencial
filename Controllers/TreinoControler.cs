using CrescimentoExponencial.Models;
using CrescimentoExponencial.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrescimentoExponencial.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TreinoControler : ControllerBase
    {
      // TreinoRepository _repository = new TreinoRepository();
        private readonly TreinoRepository _repository;

        public TreinoControler(TreinoRepository repository)
        {
           _repository = repository;
        }

        /// <summary>
        /// Obter todos os treinos
        /// </summary>
        /// <returns></returns>

        [HttpGet]
        public async Task<IActionResult> ObterTodosTreinos()
        {
            return Ok(_repository.ObterTodos());
        }

        /// <summary>
        /// Cadastra novo treino
        /// </summary>
        /// <param name="treinoDto"></param>
        /// <returns></returns>

        [HttpPost]
        public async Task<IActionResult> NovoTreino(TreinoDto treinoDto)
        {
            Treino treino = new Treino(treinoDto.Name, treinoDto.Repeticoes);

            await _repository.InserirTreino(treino);
           

            return Ok(treino);

        }
    }
}
