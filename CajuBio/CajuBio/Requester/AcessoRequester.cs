using System;
using System.Collections.Generic;
using System.Text;
using CajuBio.Model;

namespace CajuBio.Requester
{
    class AcessoRequester : Requester<Acesso>
    {
        public override bool create(Acesso model)
        {
            throw new NotImplementedException();
        }

        public override bool delete(Acesso model)
        {
            throw new NotImplementedException();
        }

        protected override Acesso Fill(dynamic json)
        {
            throw new NotImplementedException();
        }

        public override Acesso read(int id)
        {
            string url_base = "http://" + server + ":8080/webapi/webapi/acesso?id={0}";
            string url = string.Format(url_base, id);
            dynamic acessoJSON = this.request(url);
            Acesso acesso = null;
            if (!(acessoJSON is null))
                acesso = this.Fill(acessoJSON);
            return acesso;
        }

        public override List<Acesso> readAll()
        {
            string url_base = "http://" + server + ":8080/webapi/webapi/itemguia/all";
            string url = string.Format(url_base);
            dynamic acessoJSON = this.request(url);
            List<Acesso> result = new List<Acesso>();
            if (!(acessoJSON is null))
            {
                foreach (dynamic acesso in acessoJSON)
                {
                    result.Add(this.Fill(acesso));
                }
            }
            return result;
        }

        protected override dynamic Serialize(Acesso model)
        {
            throw new NotImplementedException();
        }

        public override bool update(Acesso model)
        {
            throw new NotImplementedException();
        }
    }
}
