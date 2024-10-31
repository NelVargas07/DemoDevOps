using System.Threading;
using BC.Modelos;
using BW.Interfaces.BW;
using Microsoft.AspNetCore.Mvc;
using VargasCalderonNelson_C18195_Examen_I_IF4101.DTOs;
using VargasCalderonNelson_C18195_Examen_I_IF4101.Utilitarios;

namespace VargasCalderonNelson_C18195_Examen_I_IF4101.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IGestionarUsuarioBW gestionarUsuarioBW;

        public UsuarioController(IGestionarUsuarioBW gestionarUsuarioBW)
        {
            this.gestionarUsuarioBW = gestionarUsuarioBW;
        }

        [HttpPost]

        public async Task<ActionResult<bool>> RegistrarUsuario(UsuarioDTO usuarioDTO)
        {

            Usuario usuario = UsuarioDTOMapper.ConvertirDTOAUsuario(usuarioDTO);

            var respuesta = await gestionarUsuarioBW.registreUsuario(usuario);

            return respuesta;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<bool>> ObtenerTarea(string correo, string password)
        {
            return await gestionarUsuarioBW.obtenerUsuario(correo,password);
        }
    }
}
