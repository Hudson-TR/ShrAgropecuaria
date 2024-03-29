﻿using ShrAgropecuaria.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShrAgropecuaria.Repositorios.Interfaces
{
    public interface IPedidoNutricaoRepository
    {
        IEnumerable<PedidoNutricao> GetByPedido(int idCli, int idFaz, bool entregue);
        void AlterarDataEntrega(PedidoNutricao pedNutri);
        IEnumerable<PedidoNutricao> GetAll();
        IEnumerable<PedidoNutricao> GetByNomeCliente(string Nome);
        IEnumerable<PedidoNutricao> GetByCod(string cod);
        IEnumerable<ProdutoPedidoNutricao> GetByProduto(string cod);
        void GravarProdutoPedido(ProdutoPedidoNutricao prodPedNutri);
        void GravarPedido(PedidoNutricao pedNutri);
        void Excluir(int id);
        void DeletaProdutosPedido(int id);
    }
}
