﻿using ShrAgropecuaria.Classes;
using ShrAgropecuaria.Repositorios.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShrAgropecuaria.Views.Pesquisas
{
    public partial class PesquisaCidade : Form
    {

        public ICidadeRepository CidadeRepository { get; }

        public Cidade Cidades { get; set; }
        
        public PesquisaCidade(ICidadeRepository cidaderepository)
        {

            InitializeComponent();
            CidadeRepository = cidaderepository;
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            if(txt_nome.Text == "" && txt_id.Text == "")
            {
                List<Cidade> cid = CidadeRepository.GetAll().ToList();
                DvgCidade.DataSource = cid;
            }
            else if (txt_nome.Text != "" && txt_id.Text == "")
            {
                List<Cidade> cid = CidadeRepository.GetByNome(txt_nome.Text).ToList();
                DvgCidade.DataSource = cid;
            }
            else
            {
                Cidades = CidadeRepository.Get(Convert.ToInt32(txt_id.Text));
                DvgCidade.DataSource = Cidades;
            }
            
        }

        private void BtnSelecionarCid_Click(object sender, EventArgs e)
        {
            try
            {
                Cidades = DvgCidade.CurrentRow?.DataBoundItem as Cidade;
                if(DvgCidade.CurrentRow!=null)
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnPesquisarNome_Click(object sender, EventArgs e)
        {
            
        }
    }
}
