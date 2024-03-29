﻿using ShrAgropecuaria.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShrAgropecuaria.Repositorios.Interfaces
{
    public interface ISaldoProdutoNutricao
    {
        IEnumerable<SaldoClientePedidoLoja> BuscaPorFazenda(string fazenda);

        void Grava(SaldoClientePedidoLoja saldo);
    }
}
