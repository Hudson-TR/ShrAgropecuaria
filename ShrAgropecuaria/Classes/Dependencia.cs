﻿using ShrAgropecuaria.Repositorios.Interfaces;
using ShrAgropecuaria.Repositorios.MySqlRepository;
using ShrAgropecuaria.Views;
using SimpleInjector;
using SimpleInjector.Lifestyles;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using ShrAgropecuaria.Views.Pesquisas;

namespace ShrAgropecuaria.Classes
{
    class Dependencia
    {
        public static SimpleInjector.Container Container { get; set; } = new SimpleInjector.Container();

        static Dependencia()
        {
            Dependencia.Container.Options.DefaultLifestyle = Lifestyle.Transient;
            Dependencia.Container.Options.DefaultScopedLifestyle = new ThreadScopedLifestyle();
        }

        public static void Configurar()
        {
            Container.Register<IDbConnection>(Connection.GetConnection, Lifestyle.Scoped);
            Container.Register<ICidadeRepository, MySqlCidadeRepository>(Lifestyle.Scoped);
            Container.Register<IFornecedorRepository, MySqlFornecedorRepository>(Lifestyle.Scoped);
            Container.Register<IClienteRepository, MySqlClienteRepository>(Lifestyle.Scoped);
            Container.Register<IUsuarioRepository, MySqlUsuarioRepository>(Lifestyle.Scoped);
            Container.Register<ICategoriaProdutoPETRepository, MySqlCategoriaProdutoPET>(Lifestyle.Scoped);
            Container.Register<IProdutoPETRepository, MySqlProdutoPET>(Lifestyle.Scoped);
            Container.Register<IProdutoNutricao, MySqlProdutoNutricaoRepository>(Lifestyle.Scoped);
            Container.Register<IParametrizacaoRepository, MySqlParametrizacaoRepository>(Lifestyle.Scoped);
            Container.Register<IFiadoRepository, MySqlFiadoRepository>(Lifestyle.Scoped);
            Container.Register<IContasAPagarRepository, MySqlContasAPagarRepository>(Lifestyle.Scoped);
            Container.Register<IDespesaRepository, MySqlDespesaRepository>(Lifestyle.Scoped);
            Container.Register<IPedidoNutricaoRepository, MySqlPedidoNutricaoRepository>(Lifestyle.Scoped);
            Container.Register<IFazendaRepository, MySqlFazendaRepository>(Lifestyle.Scoped);
            Container.Register<ISaldoProdutoNutricao, MySqlSaldoProdutoNutricaoRepository>(Lifestyle.Scoped);
            Container.Register<IVendaPETRepository, MySqlVendaPETRepository>(Lifestyle.Scoped);

            Container.Register<PesquisaLancarDespesa>();
            Container.Register<PesquisaCategoria>();
            Container.Register<view_LancarDespesa>();
            Container.Register<PesquisaProdutoPET>();
            Container.Register<view_QuitarContasAPagar>();
            Container.Register<view_Fornecedor>();
            Container.Register<view_ProdutoPET>();
            Container.Register<View_Cliente>();
            Container.Register<PesquisaCidade>();
            Container.Register<PesquisaFornecedor>();
            Container.Register<view_Login>();
            Container.Register<view_Usuario>();
            Container.Register<view_ProdutoNutrição>();
            Container.Register<view_Parametrização>();
            Container.Register<view_Fiado>();
            Container.Register<view_ControlarEntregaPedidoNutrição>();
            Container.Register<PesquisaFiado>();
            Container.Register<PesquisaPedidoNutrição>();
            Container.Register<view_PedidoNutrição>();
            Container.Register<SaldoProdutoNutricao>();
            Container.Register<PesquisaSaldoClienteLoja>();
            Container.Register<view_VendaPET>();
            Container.Register<PesquisaVendaPET>();
        }
    }
}
