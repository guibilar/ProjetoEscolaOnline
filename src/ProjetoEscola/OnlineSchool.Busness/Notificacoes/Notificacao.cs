﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineSchool.Busness.Notificacoes
{
    public class Notificacao
    {
        public Notificacao(string mensagem)
        {
            Mensagem = mensagem;
        }

        public string Mensagem { get; }
    }
}
