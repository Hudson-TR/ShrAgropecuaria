﻿using ShrAgropecuaria.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShrAgropecuaria.Repositorios.Interfaces
{
    public interface IParametrizacaoRepository
    {
        Parametrizacao Get();
        void Gravar(Parametrizacao p, Boolean f);

    }
}
