using AdmTarea.Api.DTOs;
using AdmTarea.BC.Modelos;

namespace AdmTarea.Api.Utilitarios
{
    public class FotoDTOMapper
    {
        public static FotoDTO ConvertirFotoADTO(Foto foto)
        {
            return new FotoDTO()
            {
                Descripcion = foto.Descripcion,
                Eliminada = foto.Eliminada,
                Etiquetas = foto.Etiquetas,
                FechaCreacion = foto.FechaCreacion, 
                Id = foto.Id,
                Imagen = foto.Imagen,
                Latitud = foto.Latitud,
                Longitud = foto.Longitud
            };
        }

        public static Foto ConvertirDTOAFoto(FotoDTO fotoDTO)
        {

            return new Foto()
            {
                Descripcion = fotoDTO.Descripcion,
                Longitud = fotoDTO.Longitud,
                Latitud = fotoDTO.Latitud,
                Imagen = fotoDTO.Imagen,
                Id = fotoDTO.Id,
                FechaCreacion = fotoDTO.FechaCreacion,
                Etiquetas= fotoDTO.Etiquetas,  
                Eliminada= fotoDTO.Eliminada
            };
        }

        public static IEnumerable<FotoDTO> ConvertirListaDeFotosADTO(IEnumerable<Foto> fotos)
        {

            IEnumerable<FotoDTO> fotosDTO = fotos.Select(t => new FotoDTO()
            {
                Eliminada = t.Eliminada,
                Etiquetas = t.Etiquetas,   
                FechaCreacion=t.FechaCreacion,
                Id = t.Id,
                Imagen=t.Imagen,
                Latitud=t.Latitud,
                Descripcion=t.Descripcion,
                Longitud = t.Longitud
            }
            );
            return fotosDTO;
        }
    }
}
