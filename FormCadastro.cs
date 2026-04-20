using GestaoAtivosTI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GestaoAtivosTI
{
    public partial class FormCadastro : Form
    {
        private readonly AtivosRepository _repositorio;
        public FormCadastro(AtivosRepository repositorio)
        {
            InitializeComponent();
            _repositorio = repositorio;
            ConfigurarFormulario();
        }

        public void ConfigurarFormulario()
        {
            cmbTipoEquipamento.SelectedIndex = 0;
            cmbTipoEquipamento.SelectedIndexChanged += cmbTipoEquipamento_SelectedIndexChanged;
        }

        private void cmbTipoEquipamento_SelectedIndexChanged(object? sender, EventArgs e)
        {
            lblEspecifico.Text = cmbTipoEquipamento.SelectedItem?.ToString() == "Notebook" ? "Tamanho da tela(\"):" : "Armazenamento (TB):";

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string numeroSerie = txtNumSerie.Text;
                string marca = txtMarca.Text;
                decimal valorAquisicao = decimal.Parse(txtVlrAquisicao.Text);

                Equipamento novoEquipamento;

                if (cmbTipoEquipamento.SelectedItem?.ToString() == "Notebook")
                {
                    double tela = double.Parse(txtEspecifico.Text);
                    novoEquipamento = new Notebook(numeroSerie, marca, valorAquisicao, tela);
                }
                else
                {
                    int storage = int.Parse(txtEspecifico.Text);
                    novoEquipamento = new Servidor(numeroSerie, marca, valorAquisicao, storage);
                }
                _repositorio.Adicionar(novoEquipamento);

                MessageBox.Show($"Cadastrado com sucesso!\nDepreciação projetada(3 anos):{novoEquipamento.CalcularDepreciacao(3):C}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var confirmacao = MessageBox.Show("Tem certeza que deseja sair da tela de cadastro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmacao == DialogResult.Yes) this.Close();

        }
    }
}
