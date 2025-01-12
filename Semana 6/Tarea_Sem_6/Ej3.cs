[ApiController]
[Route("api/[controller]")]
public class UsuariosController : ControllerBase
{
    private static List<Usuario> usuarios = new List<Usuario>
    {
        new Usuario { Id = 1, Nombre = "Ana" },
        new Usuario { Id = 2, Nombre = "Carlos" },
        new Usuario { Id = 3, Nombre = "Luis" },
        new Usuario { Id = 4, Nombre = "Marta" },
        new Usuario { Id = 5, Nombre = "Sofía" },
        new Usuario { Id = 6, Nombre = "Miguel" },
    };

    [HttpGet]
    public IActionResult GetUsuarios([FromQuery] int page = 1, [FromQuery] int pageSize = 2)
    {
        if (page <= 0 || pageSize <= 0)
        {
            return BadRequest("La página y el tamaño deben ser mayores a 0.");
        }

        var paginados = usuarios.Skip((page - 1) * pageSize).Take(pageSize).ToList();
        return Ok(paginados);
    }
}

public class Usuario
{
    public int Id { get; set; }
    public string Nombre { get; set; }
}
