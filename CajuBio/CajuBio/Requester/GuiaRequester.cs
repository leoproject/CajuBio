using System;
using System.Collections.Generic;
using System.Text;
using CajuBio.Model;
using CajuBio.Requester;

namespace CajuBio.Requester
{
    class GuiaRequester : Requester<Guia>
    {
        public override bool create(Guia model)
        {
            throw new NotImplementedException();
        }

        public override bool delete(Guia model)
        {
            throw new NotImplementedException();
        }

        protected override Guia Fill(dynamic json)
        {
            Guia guia = new Guia();
            guia.id = json.id;
            guia.titulo = json.title;
            guia.descricao = json.descricao;
            guia.idPai = json.idPai;
            return guia;
        }

        public override Guia read(int id)
        {
            string url_base = "http://" + server + ":8080/webapi/webapi/guia?id={0}";
            string url = string.Format(url_base, id);
            dynamic guiaJSON = this.request(url);
            Guia guia = null;
            if (!(guiaJSON is null))
                guia = this.Fill(guiaJSON);
            return guia;
        }

        public override List<Guia> readAll()
        {
            string url_base = "http://" + server + ":8080/webapi/webapi/guia/all";
            string url = string.Format(url_base);
            dynamic guiaJSON = this.request(url);
            List<Guia> result = new List<Guia>();
            if (!(guiaJSON is null))
            {
                foreach (dynamic guia in guiaJSON)
                {
                    result.Add(this.Fill(guia));
                }
            }
            return result;
        }

        public List<Guia> readChildsOf(int idPai)
        {
            string url_base = "http://" + server + ":8080/webapi/webapi/guia/childsOf?idpai={0}";
            string url = string.Format(url_base, idPai);
            dynamic guiaJSON = this.request(url);
            List<Guia> result = new List<Guia>();
            if (!(guiaJSON is null))
            {
                foreach (dynamic guia in guiaJSON)
                {
                    result.Add(this.Fill(guia));
                }
            }
            return result;
        }

        protected override dynamic Serialize(Guia model)
        {
            throw new NotImplementedException();
        }

        public override bool update(Guia model)
        {
            throw new NotImplementedException();
        }
    }
}
