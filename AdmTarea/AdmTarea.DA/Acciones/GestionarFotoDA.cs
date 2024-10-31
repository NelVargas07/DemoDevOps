using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AdmTarea.BC.Modelos;
using AdmTarea.BW.Interfaces.DA;
using AdmTarea.DA.Contexto;
using AdmTarea.DA.Entidades;
using Microsoft.EntityFrameworkCore;

namespace AdmTarea.DA.Acciones
{
    public class GestionarFotoDA : IGestionarFotoDA
    {
        private readonly AdmTareaContext admTareaContext;
        public GestionarFotoDA(AdmTareaContext _admTareaContext)
        {
            admTareaContext = _admTareaContext;
        }
        public async Task<bool> actualiceFoto(long id, string descripcion, string etiquetas)
        {
            var fotoDA = admTareaContext.FotoDA.FirstOrDefault(t => t.Id == id);

            if (fotoDA != null)
            {
                fotoDA.Descripcion = descripcion;
                fotoDA.Etiquetas = etiquetas;

                var resultado = await admTareaContext.SaveChangesAsync();

                return resultado >= 0 ? true : false;
            }
            return false;
        }

        public async Task<bool> elimineFoto(long id)
        {
            var fotoDA = admTareaContext.FotoDA.FirstOrDefault(t => t.Id == id);

            if (fotoDA != null)
            {
                admTareaContext.FotoDA.Remove(fotoDA);
                var resultado = await admTareaContext.SaveChangesAsync();

                if (resultado > 0)
                    return true;
            }
            return false;
        }

        public async Task<IEnumerable<Foto>> obtengaTodasLasFotos()
        {
            return await admTareaContext.FotoDA
                  .Select(FotoDA => new Foto
                  {
                      Id = FotoDA.Id,
                      Etiquetas = FotoDA.Etiquetas,
                      Descripcion = FotoDA.Descripcion,
                      Eliminada = FotoDA.Eliminada,
                      FechaCreacion = FotoDA.FechaCreacion,
                      Imagen = FotoDA.Imagen,
                      Latitud = FotoDA.Latitud,
                      Longitud = FotoDA.Longitud

                  }).ToListAsync();
        }

        public async Task<bool> registrarFoto(Foto foto)
        {
            Entidades.FotoDA fotoBD = new()
            {
                Longitud = foto.Longitud,
                Latitud = foto.Latitud,
                Imagen = foto.Imagen,
                FechaCreacion = foto.FechaCreacion,
                Descripcion= foto.Descripcion,
                Etiquetas = foto.Etiquetas
                
            };

            admTareaContext.FotoDA.Add(fotoBD);

            var resultado = await admTareaContext.SaveChangesAsync();


            //turn resultado > 0;

            if (resultado < 0)
                return false;

            return true;
        }
    }
}
