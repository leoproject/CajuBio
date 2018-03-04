using System;
using System.Collections.Generic;
using System.Text;

namespace CajuBio.Model
{
    class Acesso
    {
        public int id { get; set; }
        public DateTime momento { get; set; }
        public int usuario { get; set; }
        public int guia { get; set; }
    }
}
