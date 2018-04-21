using System;
using System.Collections.Generic;
using System.Text;
using CajuBio.Model;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace CajuBio.Requester
{
    public class UsuarioRequester : Requester<Usuario> 
    {
        public override bool create(Usuario model)
        {
            throw new NotImplementedException();
        }

        public override bool delete(Usuario model)
        {
            throw new NotImplementedException();
        }

        protected override Usuario Fill(dynamic json)
        {
            Usuario usuario = new Usuario();
            usuario.id = json.id;
            usuario.nome = json.nome;
            usuario.email = json.email;
            usuario.tipo = json.tipo.id;
            usuario.setor = json.setor.id;
            usuario.senha = json.senha;
            usuario.vinculo = json.vinculo.id;
            return usuario;
        }

        public Usuario read(string email, string senha)
        {
            string url_base = "http://" + server + ":8080/webapi/webapi/usuario/login?email={0}&senha={1}";
            string url = string.Format(url_base, email, senha);
            dynamic usuarioJSON = this.request(url);
            Usuario usuario = null;
            if (!(usuarioJSON is null))
                usuario = this.Fill(usuarioJSON);
            return usuario;
        }

        public override Usuario read(int id)
        {
            string url_base = "http://" + server + ":8080/webapi/webapi/usuario?id={0}";
            string url = string.Format(url_base, id);
            dynamic usuarioJSON = this.request(url);
            Usuario usuario = null;
            if (!(usuarioJSON is null))
                usuario = this.Fill(usuarioJSON);
            return usuario;
        }

        public override List<Usuario> readAll()
        {
            string url_base = "http://" + server + ":8080/webapi/webapi/usuario/all";
            string url = string.Format(url_base);
            dynamic usuarioJSON = this.request(url);
            List<Usuario> result = new List<Usuario>();
            if (!(usuarioJSON is null))
            {
                foreach (dynamic user in usuarioJSON)
                {
                    result.Add(this.Fill(user));
                }
            }
            return result;
        }

        public List<ExperienciaUsuario> readAllExperiencia()
        {
            string url_base = "http://" + server + ":8080/webapi/webapi/usuario/experiencia/all";
            string url = string.Format(url_base);
            dynamic experienciaJSON = this.request(url);
            List<ExperienciaUsuario> result = new List<ExperienciaUsuario>();
            if (!(experienciaJSON is null))
            {
                foreach (dynamic experiencia in experienciaJSON)
                {
                    ExperienciaUsuario exp = new ExperienciaUsuario();
                    exp.id = experiencia.id;
                    exp.descricao = experiencia.descricao;
                    result.Add(exp);
                }
            }
            return result;
        }

        public List<VinculoUsuario> readAllVinculo()
        {
            string url_base = "http://" + server + ":8080/webapi/webapi/usuario/vinculo/all";
            string url = string.Format(url_base);
            dynamic vinculoJSON = this.request(url);
            List<VinculoUsuario> result = new List<VinculoUsuario>();
            if (!(vinculoJSON is null))
            {
                foreach (dynamic vinculo in vinculoJSON)
                {
                    VinculoUsuario vin = new VinculoUsuario();
                    vin.id = vinculo.id;
                    vin.descricao = vinculo.descricao;
                    result.Add(vin);
                }
            }
            return result;
        }

        public List<TipoUsuario> readAllTipo()
        {
            string url_base = "http://" + server + ":8080/webapi/webapi/usuario/tipo/all";
            string url = string.Format(url_base);
            dynamic tipoJSON = this.request(url);
            List<TipoUsuario> result = new List<TipoUsuario>();
            if (!(tipoJSON is null))
            {
                foreach (dynamic tipo in tipoJSON)
                {
                    TipoUsuario tip = new TipoUsuario();
                    tip.id = tipo.id;
                    tip.descricao = tipo.descricao;
                    result.Add(tip);
                }
            }
            return result;
        }

        public List<FormacaoUsuario> readAllFormacao()
        {
            string url_base = "http://" + server + ":8080/webapi/webapi/usuario/formacao/all";
            string url = string.Format(url_base);
            dynamic formacaoJSON = this.request(url);
            List<FormacaoUsuario> result = new List<FormacaoUsuario>();
            if (!(formacaoJSON is null))
            {
                foreach (dynamic formacao in formacaoJSON)
                {
                    FormacaoUsuario form = new FormacaoUsuario();
                    form.id = formacao.id;
                    form.descricao = formacao.descricao;
                    result.Add(form);
                }
            }
            return result;
        }

        public List<SetorUsuario> readAllSetor()
        {
            string url_base = "http://" + server + ":8080/webapi/webapi/usuario/setor/all";
            string url = string.Format(url_base);
            dynamic setorJSON = this.request(url);
            List<SetorUsuario> result = new List<SetorUsuario>();
            if (!(setorJSON is null))
            {
                foreach (dynamic setor in setorJSON)
                {
                    SetorUsuario set = new SetorUsuario();
                    set.id = setor.id;
                    set.descricao = setor.descricao;
                    result.Add(setor);
                }
            }
            return result;
        }

        protected override dynamic Serialize(Usuario model)
        {
            throw new NotImplementedException();
        }

        public override bool update(Usuario model)
        {
            throw new NotImplementedException();
        }
    }
}
