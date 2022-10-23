using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Site.Models;
using System.Security.Cryptography;

namespace Site.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EjemploController : ControllerBase
    {
        public EjemploController()
        {

        }

        [HttpPost("Suma")]
        public string Suma(Calculadora suma)
        {
            var Resultado = suma.numero1 + suma.numero2;

            return $"El resultado de la suma es: {Resultado}";
        }

        [HttpPost("Resta")]
        public string Resta(Calculadora resta)
        {
            var Resultado = resta.numero1 - resta.numero2;

            return $"El resultado de la resta es: {Resultado}";
        }

        [HttpPost("Multiplicacion")]
        public string Multiplicacion(Calculadora Multiplicacion)
        {
            var Resultado = Multiplicacion.numero1 * Multiplicacion.numero2;

            return $"El resultado de la Multiplicacion es: {Resultado}";
        }

        [HttpPost("Division")]
        public string Division(Calculadora Division)
        {
            var Resultado = Division.numero1 / Division.numero2;

            return $"El resultado de la Division es: {Resultado}";
        }

    }
}
