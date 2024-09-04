using Microsoft.AspNetCore.Mvc;

namespace Desafio.Controller;

[Route("Livro")]
[ApiController]
public class LivroController : ControllerBase
{
    public IActionResult Get(){
        return Ok();
    }
}