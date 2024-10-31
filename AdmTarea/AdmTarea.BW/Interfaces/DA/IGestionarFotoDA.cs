using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdmTarea.BC.Modelos;

namespace AdmTarea.BW.Interfaces.DA
{
    public interface IGestionarFotoDA
    {
        Task<bool> registrarFoto(Foto foto);
        Task<bool> actualiceFoto(long id, string descripcion, string etiquetas);
        Task<bool> elimineFoto(long id);
        Task<IEnumerable<Foto>> obtengaTodasLasFotos();
    }
}
