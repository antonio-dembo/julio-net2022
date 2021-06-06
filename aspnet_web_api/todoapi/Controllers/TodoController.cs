using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace todoapi.Controllers
{
    [ApiController]
    [Route("api/TodoItems")] // 1- Definir o roteamento da api para cá.
    public class TodoController : ControllerBase
    {
        private readonly ILogger<TodoController> _logger;
        // Tenho que ter acesso ao meu objeto que implementa o meu repositório.
        private readonly ITodoItemRepository _repository;

        public TodoController(ILogger<TodoController> logger , ITodoItemRepository repository)
        {
            _logger = logger;
            _repository = repository; // Padrão de projeto mais adequado é a Injeção de Dependência.
        }

        // implementar as rotas de acesso.
        [HttpGet] // Esse método já herda a rota que está na classe
        // Get /api/TodoItems
        public IEnumerable<TodoItem> GetAll(){
            return _repository.getAll();
        }
        

    }
}
