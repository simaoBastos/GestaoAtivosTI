namespace GestaoAtivosTI
{
    partial class FormCadastro
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
            cmbTipoEquipamento = new ComboBox();
            lblTipoEquipamento = new Label();
            txtNumSerie = new TextBox();
            lblNumeroSerie = new Label();
            lblMarca = new Label();
            txtMarca = new TextBox();
            lblValorAquisicao = new Label();
            txtVlrAquisicao = new TextBox();
            lblEspecifico = new Label();
            txtEspecifico = new TextBox();
            btnSalvar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // cmbTipoEquipamento
            // 
            cmbTipoEquipamento.Font = new Font("Calibri", 12F);
            cmbTipoEquipamento.FormattingEnabled = true;
            cmbTipoEquipamento.Items.AddRange(new object[] { "Notebook", "Servidor" });
            cmbTipoEquipamento.Location = new Point(250, 50);
            cmbTipoEquipamento.Margin = new Padding(4);
            cmbTipoEquipamento.Name = "cmbTipoEquipamento";
            cmbTipoEquipamento.Size = new Size(166, 27);
            cmbTipoEquipamento.TabIndex = 0;
            cmbTipoEquipamento.SelectedIndexChanged += cmbTipoEquipamento_SelectedIndexChanged;
            // 
            // lblTipoEquipamento
            // 
            lblTipoEquipamento.AutoSize = true;
            lblTipoEquipamento.Font = new Font("Calibri", 15F, FontStyle.Bold);
            lblTipoEquipamento.ForeColor = Color.White;
            lblTipoEquipamento.Location = new Point(45, 50);
            lblTipoEquipamento.Margin = new Padding(4, 0, 4, 0);
            lblTipoEquipamento.Name = "lblTipoEquipamento";
            lblTipoEquipamento.Size = new Size(197, 24);
            lblTipoEquipamento.TabIndex = 1;
            lblTipoEquipamento.Text = "Tipo de Equipamento:";
            // 
            // txtNumSerie
            // 
            txtNumSerie.Font = new Font("Calibri", 12F);
            txtNumSerie.Location = new Point(250, 100);
            txtNumSerie.Margin = new Padding(4);
            txtNumSerie.Name = "txtNumSerie";
            txtNumSerie.Size = new Size(166, 27);
            txtNumSerie.TabIndex = 2;
            // 
            // lblNumeroSerie
            // 
            lblNumeroSerie.AutoSize = true;
            lblNumeroSerie.Font = new Font("Calibri", 15F, FontStyle.Bold);
            lblNumeroSerie.ForeColor = Color.White;
            lblNumeroSerie.Location = new Point(45, 100);
            lblNumeroSerie.Margin = new Padding(4, 0, 4, 0);
            lblNumeroSerie.Name = "lblNumeroSerie";
            lblNumeroSerie.Size = new Size(156, 24);
            lblNumeroSerie.TabIndex = 3;
            lblNumeroSerie.Text = "Número de Série:";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Calibri", 15F, FontStyle.Bold);
            lblMarca.ForeColor = Color.White;
            lblMarca.Location = new Point(45, 150);
            lblMarca.Margin = new Padding(4, 0, 4, 0);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(68, 24);
            lblMarca.TabIndex = 5;
            lblMarca.Text = "Marca:";
            // 
            // txtMarca
            // 
            txtMarca.Font = new Font("Calibri", 12F);
            txtMarca.Location = new Point(250, 150);
            txtMarca.Margin = new Padding(4);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(166, 27);
            txtMarca.TabIndex = 4;
            // 
            // lblValorAquisicao
            // 
            lblValorAquisicao.AutoSize = true;
            lblValorAquisicao.Font = new Font("Calibri", 15F, FontStyle.Bold);
            lblValorAquisicao.ForeColor = Color.White;
            lblValorAquisicao.Location = new Point(45, 200);
            lblValorAquisicao.Margin = new Padding(4, 0, 4, 0);
            lblValorAquisicao.Name = "lblValorAquisicao";
            lblValorAquisicao.Size = new Size(177, 24);
            lblValorAquisicao.TabIndex = 7;
            lblValorAquisicao.Text = "Valor  de Aquisição:";
            // 
            // txtVlrAquisicao
            // 
            txtVlrAquisicao.Font = new Font("Calibri", 12F);
            txtVlrAquisicao.Location = new Point(250, 200);
            txtVlrAquisicao.Margin = new Padding(4);
            txtVlrAquisicao.Name = "txtVlrAquisicao";
            txtVlrAquisicao.Size = new Size(166, 27);
            txtVlrAquisicao.TabIndex = 6;
            // 
            // lblEspecifico
            // 
            lblEspecifico.Font = new Font("Calibri", 15F, FontStyle.Bold);
            lblEspecifico.ForeColor = Color.White;
            lblEspecifico.Location = new Point(45, 250);
            lblEspecifico.Margin = new Padding(4, 0, 4, 0);
            lblEspecifico.Name = "lblEspecifico";
            lblEspecifico.Size = new Size(197, 60);
            lblEspecifico.TabIndex = 9;
            lblEspecifico.Text = "textEspecifico";
            // 
            // txtEspecifico
            // 
            txtEspecifico.Font = new Font("Calibri", 12F);
            txtEspecifico.Location = new Point(250, 250);
            txtEspecifico.Margin = new Padding(4);
            txtEspecifico.Name = "txtEspecifico";
            txtEspecifico.Size = new Size(166, 27);
            txtEspecifico.TabIndex = 8;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.CadetBlue;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Calibri", 15F, FontStyle.Bold);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(45, 320);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(160, 40);
            btnSalvar.TabIndex = 10;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.LightCoral;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Calibri", 15F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(256, 320);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(160, 40);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(441, 411);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(lblEspecifico);
            Controls.Add(txtEspecifico);
            Controls.Add(lblValorAquisicao);
            Controls.Add(txtVlrAquisicao);
            Controls.Add(lblMarca);
            Controls.Add(txtMarca);
            Controls.Add(lblNumeroSerie);
            Controls.Add(txtNumSerie);
            Controls.Add(lblTipoEquipamento);
            Controls.Add(cmbTipoEquipamento);
            Font = new Font("Calibri", 15F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Novo Equipamento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbTipoEquipamento;
        private Label lblTipoEquipamento;
        private TextBox txtNumSerie;
        private Label lblNumeroSerie;
        private Label lblMarca;
        private TextBox txtMarca;
        private Label lblValorAquisicao;
        private TextBox txtVlrAquisicao;
        private Label lblEspecifico;
        private TextBox txtEspecifico;
        private Button btnSalvar;
        private Button btnCancelar;
    }
}