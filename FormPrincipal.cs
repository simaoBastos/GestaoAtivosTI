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
    public partial class FormPrincipal : Form
    {
        private AtivosRepository _repositorio;
        private BindingSource _bindingSource;
        public FormPrincipal()
        {
            InitializeComponent();
            _repositorio = new AtivosRepository();
            _bindingSource = new BindingSource();

            ConfigurarFormulario();
            CarregarDados();
        }


        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            AjustarColunas();
        }

        public void AjustarColunas()
        {
            dgvEquipamentos.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            foreach (DataGridViewColumn col in dgvEquipamentos.Columns)
            {
                if (col.Name != "Id")
                {
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
        }


        public void ConfigurarFormulario()
        {
            dgvEquipamentos.DataSource = _bindingSource;
        }

        public void CarregarDados()
        {
            var equipamentos = _repositorio.ObterTodos();
            _bindingSource.DataSource = equipamentos.ToList();
            _bindingSource.ResetBindings(false);

        }

        private void btnNovo_Click(object? sender, EventArgs e)
        {
            using (var telaCadastro = new FormCadastro(_repositorio))
            {
                telaCadastro.ShowDialog();
            }
            CarregarDados();
        }

        private void btnRemover_Click(object? sender, EventArgs e)
        {
            if (dgvEquipamentos.CurrentRow?.DataBoundItem is Equipamento equipamentoSelecionado)
            {
                var confirmacao = MessageBox.Show($"Deseja realmente remover {equipamentoSelecionado.NumeroSerie}?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmacao == DialogResult.Yes)
                {
                    _repositorio.Remover(equipamentoSelecionado.Id);
                    CarregarDados();
                }
                else
                {
                    MessageBox.Show("Selecione um equipamento na grade para remover.");
                }
            }
        }

    }
}
