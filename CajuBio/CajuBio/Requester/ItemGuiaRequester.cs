using System;
using System.Collections.Generic;
using System.Text;
using CajuBio.Model; 

namespace CajuBio.Requester
{
    class ItemGuiaRequester : Requester<ItemGuia>
    {
        public override bool create(ItemGuia model)
        {
            throw new NotImplementedException();
        }

        public override bool delete(ItemGuia model)
        {
            throw new NotImplementedException();
        }

        public override ItemGuia read(int id)
        {
            string url_base = "http://" + server + ":8080/webapi/webapi/item_guia?id={0}";
            string url = string.Format(url_base, id);
            dynamic itemGuiaJSON = this.request(url);
            ItemGuia itemGuia = null;
            if (!(itemGuiaJSON is null))
                itemGuia = this.Fill(itemGuiaJSON);
            return itemGuia;
        }

        public ItemGuia readItemFromPai(int idpai)
        {
            string url_base = "http://" + server + ":8080/webapi/webapi/item_guia/childsOf?idpai={0}";
            string url = string.Format(url_base, idpai);
            dynamic itemGuiaJSON = this.request(url);
            ItemGuia itemGuia = null;
            if (!(itemGuiaJSON is null))
                itemGuia = this.Fill(itemGuiaJSON);
            return itemGuia;
        }


        public override List<ItemGuia> readAll()
        {
            string url_base = "http://" + server + ":8080/webapi/webapi/itemguia/all";
            string url = string.Format(url_base);
            dynamic itemGuiaJSON = this.request(url);
            List<ItemGuia> result = new List<ItemGuia>();
            if (!(itemGuiaJSON is null))
            {
                foreach (dynamic itemGuia in itemGuiaJSON)
                {
                    result.Add(this.Fill(itemGuia));
                }
            }
            return result;
        }

        public override bool update(ItemGuia model)
        {
            throw new NotImplementedException();
        }

        protected override ItemGuia Fill(dynamic json)
        {
            ItemGuia itemGuia = new ItemGuia();
            itemGuia.conteudo = json.content;
            itemGuia.id = json.id;
            itemGuia.idPai = json.idPai;
            itemGuia.titulo = json.title;
            return itemGuia;        
        }

        protected override dynamic Serialize(ItemGuia model)
        {
            throw new NotImplementedException();
        }
    }
}
