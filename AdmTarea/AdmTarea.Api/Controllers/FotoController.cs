using AdmTarea.Api.DTOs;
using AdmTarea.Api.Utilitarios;
using AdmTarea.BC.Modelos;
using AdmTarea.BW.Interfaces.BW;
using Microsoft.AspNetCore.Mvc;

namespace AdmTarea.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FotoController : ControllerBase
    {

        private readonly IGestionarFoto gestionarFoto;

        public FotoController(IGestionarFoto gestionarFoto)
        {
            this.gestionarFoto = gestionarFoto;
        }

        [HttpGet]

        public async Task<ActionResult<IEnumerable<FotoDTO>>> ObtenerTodasLasTareas()
        {
            //revisar bien

            var tareaDTOs = FotoDTOMapper.ConvertirListaDeFotosADTO(await gestionarFoto.obtengaTodasLasFotos());

            return Ok(tareaDTOs);
        }

        [HttpPut("{id}")]

        public async Task<IActionResult> EditarFoto(long id, string descripcion, string etiquetas)
        {


            var respuesta = await gestionarFoto.actualiceFoto(id, descripcion,etiquetas);

            if (!respuesta)
                return BadRequest(respuesta);

            return Ok(respuesta);


        }

        [HttpPost]

        public async Task<ActionResult<bool>> RegistrarFoto(FotoDTO fotoDTO)
        {

            Foto foto = FotoDTOMapper.ConvertirDTOAFoto(fotoDTO);

            var respuesta = await gestionarFoto.registrarFoto(foto);

            return respuesta;
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> EliminarFoto(long id)
        {

            var respuesta = await gestionarFoto.elimineFoto(id);

            if (!respuesta)
                return BadRequest(respuesta);

            return Ok(respuesta);

        }
    }
}
