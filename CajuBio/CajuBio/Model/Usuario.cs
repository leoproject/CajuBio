using System;
using System.Collections.Generic;
using System.Text;

namespace CajuBio.Model
{
    public class Usuario
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public int setor { get; set; }
        public int formacao { get; set; }
        public int tipo { get; set; }
        public int vinculo { get; set; }

        

    }
}
