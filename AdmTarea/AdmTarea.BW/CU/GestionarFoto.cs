using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdmTarea.BC.Modelos;
using AdmTarea.BW.Interfaces.BW;
using AdmTarea.BW.Interfaces.DA;

namespace AdmTarea.BW.CU
{
    public class GestionarFoto : IGestionarFoto
    {
        private readonly IGestionarFotoDA gestionarFotoDA;
        public GestionarFoto(IGestionarFotoDA gestionarFotoDA)
        {
            this.gestionarFotoDA = gestionarFotoDA;
        }
        public async Task<bool> actualiceFoto(long id, string descripcion, string etiquetas)
        {
            return await gestionarFotoDA.actualiceFoto(id, descripcion, etiquetas);
        }

        public async Task<bool> elimineFoto(long id)
        {
            return await gestionarFotoDA.elimineFoto(id);
        }

        public async Task<IEnumerable<Foto>> obtengaTodasLasFotos()
        {
            return await gestionarFotoDA.obtengaTodasLasFotos();
        }

        public async Task<bool> registrarFoto(Foto foto)
        {
            return await gestionarFotoDA.registrarFoto(foto);
        }
    }
}
