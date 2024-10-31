using System.Threading;
using BC.Modelos;
using VargasCalderonNelson_C18195_Examen_I_IF4101.DTOs;

namespace VargasCalderonNelson_C18195_Examen_I_IF4101.Utilitarios
{
    public class UsuarioDTOMapper
    {
        public static UsuarioDTO ConvertirUsuarioADTO(Usuario usuario)
        {
            return new UsuarioDTO()
            {
                 ID = usuario.ID,
                NOMBRE = usuario.NOMBRE,
                APELLIDOS = usuario.APELLIDOS, 
                CORREO = usuario.CORREO,
                PASSWORD = usuario.PASSWORD
            };
        }

        public static Usuario ConvertirDTOAUsuario(UsuarioDTO usuarioDTO)
        {

            return new Usuario()
            {
                ID = usuarioDTO.ID,
                NOMBRE = usuarioDTO.NOMBRE,
                APELLIDOS   =   usuarioDTO.APELLIDOS,
                CORREO= usuarioDTO.CORREO,
                PASSWORD = usuarioDTO.PASSWORD
            };
        }
    }
}
