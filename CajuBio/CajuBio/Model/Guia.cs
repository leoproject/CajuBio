using System;
using System.Collections.Generic;
using System.Text;

namespace CajuBio.Model
{
    public class Guia
    {
        public int id { get; set; }
        public string titulo { get; set; }
        public string descricao { get; set; }
        public DateTime publicacao { get; set; }
        public int idPai { get; set; }
    }
}
