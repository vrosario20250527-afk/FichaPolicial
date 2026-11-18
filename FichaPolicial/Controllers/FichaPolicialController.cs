using Microsoft.AspNetCore.Mvc;

namespace ApiFichasPublicas.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FichasPolicialesController : ControllerBase
    {
        private static readonly List<FichaPolicial> _fichas = new()
        {
            new FichaPolicial
            {
                Id = 1,
                NumeroExpediente = "EXP-2026-001",
                NombreCompleto = "Carlos Mendoza",
                DocumentoIdentidad = "402-1234567-8",
                Edad = 34,
                DelitoImputado = "Robo agravado",
                Peligrosidad = NivelPeligrosidad.Alta,
                Estado = "Detenido",
                FechaRegistro = DateTime.Now.AddDays(-5)
            },
            new FichaPolicial
            {
                Id = 2,
                NumeroExpediente = "EXP-2026-002",
                NombreCompleto = "Elena Rojas",
                DocumentoIdentidad = "001-9876543-2",
                Edad = 28,
                DelitoImputado = "Fraude informático",
                Peligrosidad = NivelPeligrosidad.Baja,
                Estado = "Libre bajo fianza",
                FechaRegistro = DateTime.Now.AddDays(-2)
                },
            new FichaPolicial
            {
                Id = 3,
                NumeroExpediente = "EXP-2026-000012",
                NombreCompleto = "Julio Cabral Lugo",
                DocumentoIdentidad = "402-3816278-4",
                Edad = 28,
                DelitoImputado = "Venta de drogas y asesinato en masa",
                Peligrosidad = NivelPeligrosidad.Alta,
                Estado = "Profugo de la justicia",
                FechaRegistro = DateTime.Now.AddDays(-2)
            },
            new FichaPolicial
            {
                Id = 4,
                NumeroExpediente = "EXP-2026-000013",
                NombreCompleto = "María Fernanda López",
                DocumentoIdentidad = "001-2345678-9",
                Edad = 30,
                DelitoImputado = "Estafa y lavado de dinero",
                Peligrosidad = NivelPeligrosidad.Media,
                Estado = "Detenida",
                FechaRegistro = DateTime.Now.AddDays(-1)
            },
            new FichaPolicial
            {
                Id = 5,
                NumeroExpediente = "EXP-2026-000014",
                NombreCompleto = "Luis Alberto Martínez",
                DocumentoIdentidad = "402-8765432-1",
                Edad = 40,
                DelitoImputado = "Homicidio y tráfico de armas",
                Peligrosidad = NivelPeligrosidad.Alta,
                Estado = "En prisión preventiva",
                FechaRegistro = DateTime.Now.AddDays(-3)
            },
            new FichaPolicial
            {
                Id = 6,
                NumeroExpediente = "EXP-2026-000015",
                NombreCompleto = "Ana Gabriela Torres",
                DocumentoIdentidad = "001-3456789-0",
                Edad = 25,
                DelitoImputado = "Secuestro y extorsión",
                Peligrosidad = NivelPeligrosidad.Alta,
                Estado = "Detenida",
                FechaRegistro = DateTime.Now.AddDays(-4)
            },
            new FichaPolicial
            {
                Id = 7,
                NumeroExpediente = "EXP-2026-000016",
                NombreCompleto = "Jorge Luis Ramírez",
                DocumentoIdentidad = "402-5678901-2",
                Edad = 32,
                DelitoImputado = "Corrupción y malversación de fondos",
                Peligrosidad = NivelPeligrosidad.Media,
                Estado = "Libre bajo fianza",
                FechaRegistro = DateTime.Now.AddDays(-6)
            },
            new FichaPolicial
            {
                Id = 8,
                NumeroExpediente = "EXP-2026-000017",
                NombreCompleto = "Sofía Valdez",
                DocumentoIdentidad = "001-4567890-1",
                Edad = 29,
                DelitoImputado = "Tráfico de drogas y lavado de dinero",
                Peligrosidad = NivelPeligrosidad.Alta,
                Estado = "Detenida",
                FechaRegistro = DateTime.Now.AddDays(-7)
            },
            new FichaPolicial
            {
                Id = 9,
                NumeroExpediente = "EXP-2026-000018",
                NombreCompleto = "Ricardo Fernández",
                DocumentoIdentidad = "402-6789012-3",
                Edad = 38,
                DelitoImputado = "Asalto a mano armada y robo de vehículos",
                Peligrosidad = NivelPeligrosidad.Alta,
                Estado = "En prisión preventiva",
                FechaRegistro = DateTime.Now.AddDays(-8)
            },
            new FichaPolicial
            {
                Id = 10,
                NumeroExpediente = "EXP-2026-000019",
                NombreCompleto = "Valentina Herrera",
                DocumentoIdentidad = "001-5678901-2",
                Edad = 27,
                DelitoImputado = "Estafa y fraude financiero",
                Peligrosidad = NivelPeligrosidad.Media,
                Estado = "Libre bajo fianza",
                FechaRegistro = DateTime.Now.AddDays(-9)
            },
            new FichaPolicial
            {
                Id = 11,
                NumeroExpediente = "EXP-2026-000020",
                NombreCompleto = "Diego Ramírez",
                DocumentoIdentidad = "402-7890123-4",
                Edad = 31,
                DelitoImputado = "Homicidio y tráfico de drogas",
                Peligrosidad = NivelPeligrosidad.Alta,
                Estado = "Detenido",
                FechaRegistro = DateTime.Now.AddDays(-10)
            },
            new FichaPolicial
            {
                Id = 12,
                NumeroExpediente = "EXP-2026-000021",
                NombreCompleto = "Camila Vargas",
                DocumentoIdentidad = "001-6789012-3",
                Edad = 26,
                DelitoImputado = "Secuestro y extorsión",
                Peligrosidad = NivelPeligrosidad.Alta,
                Estado = "En prisión preventiva",
                FechaRegistro = DateTime.Now.AddDays(-11)
            },
            new FichaPolicial
            {
                Id = 13,
                NumeroExpediente = "EXP-2026-000022",
                NombreCompleto = "Andrés Castillo",
                DocumentoIdentidad = "402-8901234-5",
                Edad = 35,
                DelitoImputado = "Corrupción y malversación de fondos",
                Peligrosidad = NivelPeligrosidad.Media,
                Estado = "Libre bajo fianza",
                FechaRegistro = DateTime.Now.AddDays(-12)
            },
            new FichaPolicial
            {
                Id = 14,
                NumeroExpediente = "EXP-2026-000023",
                NombreCompleto = "Isabella Morales",
                DocumentoIdentidad = "001-7890123-4",
                Edad = 30,
                DelitoImputado = "Tráfico de drogas y lavado de dinero",
                Peligrosidad = NivelPeligrosidad.Alta,
                Estado = "Detenida",
                FechaRegistro = DateTime.Now.AddDays(-13)
            },
            new FichaPolicial
            {
                Id = 15,
                NumeroExpediente = "EXP-2026-000024",
                NombreCompleto = "Sebastián Torres",
                DocumentoIdentidad = "402-9012345-6",
                Edad = 33,
                DelitoImputado = "Asalto a mano armada y robo de vehículos",
                Peligrosidad = NivelPeligrosidad.Alta,
                Estado = "En prisión preventiva",
                FechaRegistro = DateTime.Now.AddDays(-14)
            }
        };

        // GET: api/FichasPoliciales
        [HttpGet]
        public ActionResult<IEnumerable<FichaPolicial>> GetTodas()
        {
            return Ok(_fichas);
        }

        // GET: api/FichasPoliciales/1
        [HttpGet("{id}")]
        public ActionResult<FichaPolicial> GetPorId(int id)
        {
            var ficha = _fichas.FirstOrDefault(f => f.Id == id);
            if (ficha == null)
            {
                return NotFound(new { mensaje = $"No se encontró la ficha con ID {id}" });
            }
            return Ok(ficha);
        }

        // POST: api/FichasPoliciales
        [HttpPost]
        public ActionResult<FichaPolicial> CrearFicha([FromBody] FichaPolicial nuevaFicha)
        {
            nuevaFicha.Id = _fichas.Any() ? _fichas.Max(f => f.Id) + 1 : 1;
            nuevaFicha.FechaRegistro = DateTime.Now;

            _fichas.Add(nuevaFicha);

            return CreatedAtAction(nameof(GetPorId), new { id = nuevaFicha.Id }, nuevaFicha);
        }

        // PUT: api/FichasPoliciales/1
        [HttpPut("{id}")]
        public IActionResult ActualizarFicha(int id, [FromBody] FichaPolicial fichaActualizada)
        {
            var fichaExistente = _fichas.FirstOrDefault(f => f.Id == id);
            if (fichaExistente == null)
            {
                return NotFound(new { mensaje = $"No se encontró la ficha con ID {id}" });
            }

            fichaExistente.NumeroExpediente = fichaActualizada.NumeroExpediente;
            fichaExistente.NombreCompleto = fichaActualizada.NombreCompleto;
            fichaExistente.DocumentoIdentidad = fichaActualizada.DocumentoIdentidad;
            fichaExistente.Edad = fichaActualizada.Edad;
            fichaExistente.DelitoImputado = fichaActualizada.DelitoImputado;
            fichaExistente.Peligrosidad = fichaActualizada.Peligrosidad;
            fichaExistente.Estado = fichaActualizada.Estado;

            return NoContent();
        }

        // DELETE: api/FichasPoliciales/1
        [HttpDelete("{id}")]
        public IActionResult EliminarFicha(int id)
        {
            var ficha = _fichas.FirstOrDefault(f => f.Id == id);
            if (ficha == null)
            {
                return NotFound(new { mensaje = $"No se encontró la ficha con ID {id}" });
            }

            _fichas.Remove(ficha);
            return NoContent();
        }
    }
}