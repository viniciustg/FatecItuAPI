using System.Collections.Generic;
using FatecItuApi.Business.Notificacoes;

namespace FatecItuApi.Business.Intefaces
{
    public interface INotificador
    {
        bool TemNotificacao();
        List<Notificacao> ObterNotificacoes();
        void Handle(Notificacao notificacao);
    }
}