using System;
using System.Collections.Generic;
using System.Text;
using CajuBio;
using System.Net.Http;
using Newtonsoft.Json;

namespace CajuBio.Requester
{
    public abstract class Requester<IModel >
    {
        protected static string server = "192.168.0.12";

        protected dynamic request(string uri)
        {
            System.Net.Http.HttpClient http = new HttpClient();
            string json = http.GetStringAsync(uri).GetAwaiter().GetResult();
            return JsonConvert.DeserializeObject<dynamic>(json);
        }

        public abstract Boolean create(IModel model);

        public abstract Boolean update(IModel model);

        public abstract Boolean delete(IModel model);

        public abstract IModel read(int id);

        public abstract List<IModel> readAll();

        protected abstract IModel Fill(dynamic json);

        protected abstract dynamic Serialize(IModel model);
    }
}
