[ApiController]
[Route("api/[controller]")]
public class CalculadoraController : ControllerBase
{
    [HttpGet("suma")]
    public IActionResult Sumar([FromQuery] double num1, [FromQuery] double num2)
    {
        return Ok(num1 + num2);
    }

    [HttpGet("resta")]
    public IActionResult Restar([FromQuery] double num1, [FromQuery] double num2)
    {
        return Ok(num1 - num2);
    }

    [HttpGet("multiplicacion")]
    public IActionResult Multiplicar([FromQuery] double num1, [FromQuery] double num2)
    {
        return Ok(num1 * num2);
    }

    [HttpGet("division")]
    public IActionResult Dividir([FromQuery] double num1, [FromQuery] double num2)
    {
        if (num2 == 0)
        {
            return BadRequest("No se puede dividir entre cero.");
        }
        return Ok(num1 / num2);
    }
}
