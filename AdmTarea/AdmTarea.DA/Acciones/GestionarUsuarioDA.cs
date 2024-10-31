using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BC.Modelos;
using BW.Interfaces.DA;
using DA.Contexto;
using Microsoft.EntityFrameworkCore;

namespace DA.Acciones
{
    public  class GestionarUsuarioDA : IGestionarUsuarioDA
    {
        private readonly UsuarioContext usuarioContext;
        public GestionarUsuarioDA(UsuarioContext _usuarioContext)
        {
            usuarioContext = _usuarioContext;
        }
        public async Task<bool> registreUsuario(Usuario usuario)
        {
            Entidades.UsuarioDA usuarioBD = new()
            {
                ID = usuario.ID,
                NOMBRE = usuario.NOMBRE,
                APELLIDOS = usuario.APELLIDOS,
                CORREO = usuario.CORREO,
                PASSWORD = usuario.PASSWORD
                
            };

            usuarioContext.UsuarioDA.Add(usuarioBD);

            var resultado = await usuarioContext.SaveChangesAsync();

            if (resultado < 0)
                return false;

            return true;

        }

        public async Task<bool> obtenerUsuario(string correo, string password)
        {

            var UsuarioDA = await usuarioContext.UsuarioDA.FirstOrDefaultAsync(t => t.CORREO == correo );

            if (UsuarioDA is null)
                return false;
            if (UsuarioDA.PASSWORD.Equals(password))
                return true;
            return false;
        }
    }
}
