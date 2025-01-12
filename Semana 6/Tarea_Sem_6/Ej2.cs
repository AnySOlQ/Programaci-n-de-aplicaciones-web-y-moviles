[ApiController]
[Route("api/[controller]")]
public class TareasController : ControllerBase
{
    private static List<Tarea> tareas = new List<Tarea>();

    [HttpGet]
    public IActionResult GetTareas()
    {
        return Ok(tareas);
    }

    [HttpPost]
    public IActionResult CrearTarea([FromBody] Tarea nuevaTarea)
    {
        nuevaTarea.Id = tareas.Count + 1;
        tareas.Add(nuevaTarea);
        return CreatedAtAction(nameof(GetTareaPorId), new { id = nuevaTarea.Id }, nuevaTarea);
    }

    [HttpGet("{id}")]
    public IActionResult GetTareaPorId(int id)
    {
        var tarea = tareas.FirstOrDefault(t => t.Id == id);
        if (tarea == null)
        {
            return NotFound();
        }
        return Ok(tarea);
    }

    [HttpPut("{id}")]
    public IActionResult ActualizarTarea(int id, [FromBody] Tarea tareaActualizada)
    {
        var tarea = tareas.FirstOrDefault(t => t.Id == id);
        if (tarea == null)
        {
            return NotFound();
        }
        tarea.Titulo = tareaActualizada.Titulo;
        tarea.Completado = tareaActualizada.Completado;
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult EliminarTarea(int id)
    {
        var tarea = tareas.FirstOrDefault(t => t.Id == id);
        if (tarea == null)
        {
            return NotFound();
        }
        tareas.Remove(tarea);
        return NoContent();
    }
}

public class Tarea
{
    public int Id { get; set; }
    public string Titulo { get; set; }
    public bool Completado { get; set; }
}