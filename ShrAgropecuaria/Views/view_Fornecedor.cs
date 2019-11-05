﻿using ShrAgropecuaria.Classes;
using ShrAgropecuaria.Repositorios.Interfaces;
using ShrAgropecuaria.Views.Pesquisas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShrAgropecuaria.Views
{
    public partial class view_Fornecedor : Form
    {
        Fornecedor forn = new Fornecedor();

        public ICidadeRepository CidadeRepository { get; }
        public IFornecedorRepository FornecedorRepository { get; }


        public view_Fornecedor(ICidadeRepository cidadeRepository, IFornecedorRepository fornecedorRepository)
        {
            InitializeComponent();
            CidadeRepository = cidadeRepository;
            FornecedorRepository = fornecedorRepository;
            txtID.Enabled = false;
            txtEstado.Enabled = false;
        }
        
        void LimparTela()
        {
            txtBairro.Text = "";
            txtCEP.Text = "";
            txtCNPJ.Text = "";
            txtComplemento.Text = "";
            txtDescricao.Text = "";
            txtEndereco.Text = "";
            txtID.Text = "";
            txtNome.Text = "";
            txtNumero.Text = "";
            txtTelefone.Text = "";
            txtCidade.Text = "";
        }

        


        private void btnGravar_Click(object sender, EventArgs e)
        {
            if(txtBairro.Text != "")
            {
                forn.Forn_bairro = txtBairro.Text;
                if(txtCEP.Text != "")
                {
                    
                    forn.Forn_cep = txtCEP.Text.Replace("-", "");
                    if (txtCidade.Text != "")
                    {
                        forn.Cidade = (Cidade)CidadeRepository.PegaId(txtCidade.Text);
                        if(txtCNPJ.Text != "")
                        {
                            
                            
                            forn.Forn_cnpj = txtCNPJ.Text.Replace(",", "").Replace("/", "").Replace("-", "");
                            if(txtComplemento.Text != "")
                            {
                                forn.Forn_complemento = txtComplemento.Text;
                                if(txtDescricao.Text != "")
                                {
                                    forn.Forn_descricao = txtDescricao.Text;
                                    if(txtEndereco.Text != "")
                                    {
                                        forn.Forn_endereco = txtEndereco.Text;
                                        if(txtNome.Text != "")
                                        {
                                            forn.Forn_nome = txtNome.Text;
                                            if(txtNumero.Text != "")
                                            {
                                                forn.Forn_numero = Convert.ToInt32(txtNumero.Text);
                                                if(txtTelefone.Text != "")
                                                {
                                                    
                                                    forn.Forn_telefone = txtTelefone.Text.Replace(")","").Replace("(","").Replace("-","");
                                                    
                                                    if(forn != null)
                                                    {
                                                        if (txtID.Text != "")
                                                        {
                                                            forn.Forn_cod = Convert.ToInt32(txtID.Text);
                                                            FornecedorRepository.Gravar(forn);
                                                        }
                                                        else
                                                            FornecedorRepository.Gravar(forn);

                                                        MessageBox.Show("Gravou!");
                                                        LimparTela();
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }



        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparTela();
            txtNome.Focus();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            var a = new PesquisaFornecedor(FornecedorRepository);
            
            if(a.ShowDialog() == DialogResult.OK)
            {
                
                txtID.Text = a.forn.Forn_cod.ToString();
                txtBairro.Text = a.forn.Forn_bairro;
                txtCEP.Text = a.forn.Forn_cep;
                txtCidade.Text = a.forn.Cidade.Cid_nome;
                txtEstado.Text = a.forn.Cidade.EstadoUf;
                txtCNPJ.Text = a.forn.Forn_cnpj.ToString();
                txtComplemento.Text = a.forn.Forn_complemento;
                txtDescricao.Text = a.forn.Forn_descricao;
                txtEndereco.Text = a.forn.Forn_endereco;
                txtNome.Text = a.forn.Forn_nome;
                txtNumero.Text = a.forn.Forn_numero.ToString();
                txtTelefone.Text = a.forn.Forn_telefone;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int cod;
            int.TryParse(txtID.Text, out cod);
            forn = FornecedorRepository.Get(cod);
            if(forn != null)
            {
                FornecedorRepository.Excluir(forn);
            }
            else
            {
                MessageBox.Show("Não foi possível Excluir esse fornecedor");
            }
        }

        private void btnPesquisarCid_Click(object sender, EventArgs e)
        {
            var a = new PesquisaCidade(CidadeRepository);
            if(a.ShowDialog() == DialogResult.OK)
            {
                txtCidade.Text = a.Cidades.Cid_nome;
                txtEstado.Text = a.Cidades.Estado.Est_uf;
            }
        }
    }
}
