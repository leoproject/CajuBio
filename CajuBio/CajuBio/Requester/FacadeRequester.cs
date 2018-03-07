using System;
using System.Collections.Generic;
using System.Text;
using CajuBio.Model;

namespace CajuBio.Requester
{
    public class FacadeRequester
    {
        private static FacadeRequester instance;
        private FacadeRequester() { }
        public static FacadeRequester Instance
        {
            get
            {
                if (FacadeRequester.instance is null)
                {
                    FacadeRequester.instance = new FacadeRequester();
                }
                return FacadeRequester.instance;
            }
        }

        public Usuario readUsuario(string email, string senha)
        {
            UsuarioRequester requester = new UsuarioRequester();
            return requester.read(email, senha);
        }

        public Usuario readUsuario(int id)
        {
            UsuarioRequester requester = new UsuarioRequester();
            return requester.read(id);
        }

        public List<Usuario> readAllUsuario()
        {
            UsuarioRequester requester = new UsuarioRequester();
            return requester.readAll();
        }
    }
}
