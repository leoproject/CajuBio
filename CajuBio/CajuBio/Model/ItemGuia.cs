using System;
using System.Collections.Generic;
using System.Text;

namespace CajuBio.Model
{
    public class ItemGuia
    {
        public int id { get; set; }
        public string titulo { get; set; }
        public string conteudo { get; set; }
        public int idPai { get; set; }
    }
}
