﻿namespace ShrAgropecuaria.Views.Pesquisas
{
    partial class PesquisaCidade
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.DvgCidade = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnSelecionarCid = new System.Windows.Forms.Button();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DvgCidade)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_id);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.BtnPesquisar);
            this.panel1.Controls.Add(this.txt_nome);
            this.panel1.Controls.Add(this.DvgCidade);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 311);
            this.panel1.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(151, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 65;
            this.label4.Text = "Nome";
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.Location = new System.Drawing.Point(489, 8);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(29, 23);
            this.BtnPesquisar.TabIndex = 64;
            this.BtnPesquisar.Text = "*";
            this.BtnPesquisar.UseVisualStyleBackColor = true;
            this.BtnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // txt_nome
            // 
            this.txt_nome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_nome.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome.Location = new System.Drawing.Point(195, 8);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(288, 23);
            this.txt_nome.TabIndex = 1;
            // 
            // DvgCidade
            // 
            this.DvgCidade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DvgCidade.Location = new System.Drawing.Point(3, 38);
            this.DvgCidade.Name = "DvgCidade";
            this.DvgCidade.Size = new System.Drawing.Size(690, 270);
            this.DvgCidade.TabIndex = 54;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 56;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BtnSelecionarCid
            // 
            this.BtnSelecionarCid.Location = new System.Drawing.Point(630, 338);
            this.BtnSelecionarCid.Name = "BtnSelecionarCid";
            this.BtnSelecionarCid.Size = new System.Drawing.Size(75, 23);
            this.BtnSelecionarCid.TabIndex = 55;
            this.BtnSelecionarCid.Text = "Selecionar";
            this.BtnSelecionarCid.UseVisualStyleBackColor = true;
            this.BtnSelecionarCid.Click += new System.EventHandler(this.BtnSelecionarCid_Click);
            // 
            // txt_id
            // 
            this.txt_id.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_id.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(30, 8);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(75, 23);
            this.txt_id.TabIndex = 67;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 15);
            this.label2.TabIndex = 66;
            this.label2.Text = "ID";
            // 
            // PesquisaCidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 382);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnSelecionarCid);
            this.MaximumSize = new System.Drawing.Size(745, 421);
            this.MinimumSize = new System.Drawing.Size(745, 421);
            this.Name = "PesquisaCidade";
            this.Text = "PesquisaCidade";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DvgCidade)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnPesquisar;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.DataGridView DvgCidade;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnSelecionarCid;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label2;
    }
}