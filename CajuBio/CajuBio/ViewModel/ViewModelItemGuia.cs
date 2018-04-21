using System;
using System.Collections.Generic;
using System.Text;
using CajuBio.Model;
using CajuBio.Requester;

namespace CajuBio.ViewModel
{
    class ViewModelItemGuia
    {
        public ItemGuia itemGuia { get; set; }
        public string titulo { get; set; }
        public string conteudo { get; set; }

        public ViewModelItemGuia()
        {
            titulo = "Teste";
            conteudo = "Teste teste teste";
        }

        public ViewModelItemGuia(int idpai)
        {
            itemGuia = FacadeRequester.Instance.readItemGuia(idpai);
            if (!(itemGuia is null))
            {
                titulo = itemGuia.titulo;
                conteudo = itemGuia.conteudo;
            }
        }
    }
}
