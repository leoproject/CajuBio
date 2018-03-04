using System;
using System.Collections.Generic;
using System.Text;
using CajuBio;

namespace CajuBio.Requester
{
    public abstract class Requester<IModel >
    {
        public Boolean create(IModel model)
        {
            return false;
        }

        public Boolean update(IModel model)
        {
            return false;
        }

        public Boolean delete(IModel model)
        {
            return false;
        }

        public IModel read(int id)
        {
            return default(IModel);
        }

        public List<IModel> readAll()
        {
            return null;
        }


    }
}
