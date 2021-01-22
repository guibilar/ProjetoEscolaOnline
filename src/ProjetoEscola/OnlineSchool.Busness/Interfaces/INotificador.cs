using OnlineSchool.Busness.Notificacoes;
using System.Collections.Generic;

namespace OnlineSchool.Busness.Interfaces
{
    public interface INotificador
    {
        bool TemNotificacao();
        List<Notificacao> ObterNotificacoes();
        void Handle(Notificacao notificacao);
    }
}
