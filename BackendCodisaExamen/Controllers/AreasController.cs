using BackendCodisaExamen.BLL;
using BackendCodisaExamen.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendCodisaExamen.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AreasController : Controller
    {
        BLLArea objBllArea = null;


        [HttpPost]
        public ActionResult guardaArea(AreaEntity areaEntity)
        {

            objBllArea = new BLLArea();

            objBllArea.upsert(areaEntity, "1");

            return Ok("dd");

        }
    }
}
