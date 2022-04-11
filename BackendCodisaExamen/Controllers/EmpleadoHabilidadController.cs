using BackendCodisaExamen.BLL;
using BackendCodisaExamen.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendCodisaExamen.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadoHabilidadController : ControllerBase
    {
        BLLEmpleadoHabilidad bllEmpleadoHabilidad = null;

        [HttpGet("{pIdEmpleado}")]
        
        public ActionResult<EmpleoHabilidad> listaHabilidad(int pIdEmpleado)
        {
            bllEmpleadoHabilidad = new BLLEmpleadoHabilidad();

            return Ok(bllEmpleadoHabilidad.listaHabilidades(pIdEmpleado));
        }
    }
}
