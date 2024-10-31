using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using BC.Modelos;
using BW.Interfaces.BW;
using BW.Interfaces.DA;

namespace BW.CU
{
    public class GestionarUsuarioBW : IGestionarUsuarioBW
    {
        private readonly IGestionarUsuarioDA gestionarUsuarioDA;

        public GestionarUsuarioBW(IGestionarUsuarioDA gestionarUsuarioDA)
        {
            this.gestionarUsuarioDA = gestionarUsuarioDA;
        }

        public async Task<bool> registreUsuario(Usuario usuario)
        {
            return await gestionarUsuarioDA.registreUsuario(usuario);
        }

        public async Task<bool> obtenerUsuario(string correo, string password)
        {
            return await gestionarUsuarioDA.obtenerUsuario(correo, password);
        }
    }
}
