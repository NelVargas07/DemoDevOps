using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BC.Modelos;

namespace BW.Interfaces.BW
{
    public  interface IGestionarUsuarioBW
    {
        Task<bool> registreUsuario(Usuario usuario);
        Task<bool> obtenerUsuario(string correo, string password);
    }
}
