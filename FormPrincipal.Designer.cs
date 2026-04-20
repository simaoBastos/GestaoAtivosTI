namespace GestaoAtivosTI
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            dgvEquipamentos = new DataGridView();
            btnNovo = new Button();
            btnRemover = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEquipamentos).BeginInit();
            SuspendLayout();
            // 
            // dgvEquipamentos
            // 
            dgvEquipamentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvEquipamentos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvEquipamentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEquipamentos.Location = new Point(13, 71);
            dgvEquipamentos.Margin = new Padding(4);
            dgvEquipamentos.Name = "dgvEquipamentos";
            dgvEquipamentos.ReadOnly = true;
            dgvEquipamentos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEquipamentos.Size = new Size(758, 377);
            dgvEquipamentos.TabIndex = 0;
            // 
            // btnNovo
            // 
            btnNovo.BackColor = Color.CadetBlue;
            btnNovo.FlatStyle = FlatStyle.Flat;
            btnNovo.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btnNovo.ForeColor = Color.White;
            btnNovo.Location = new Point(160, 13);
            btnNovo.Margin = new Padding(4);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(160, 50);
            btnNovo.TabIndex = 1;
            btnNovo.Text = "Novo Equipamento";
            btnNovo.UseVisualStyleBackColor = false;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnRemover
            // 
            btnRemover.BackColor = Color.LightCoral;
            btnRemover.FlatStyle = FlatStyle.Flat;
            btnRemover.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btnRemover.ForeColor = Color.White;
            btnRemover.Location = new Point(480, 14);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(160, 50);
            btnRemover.TabIndex = 2;
            btnRemover.Text = "Dar Baixa (Remover)";
            btnRemover.UseVisualStyleBackColor = false;
            btnRemover.Click += btnRemover_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(784, 461);
            Controls.Add(btnRemover);
            Controls.Add(btnNovo);
            Controls.Add(dgvEquipamentos);
            Font = new Font("Calibri", 12F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard Principal - Ativos de TI";
            Load += FormPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEquipamentos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvEquipamentos;
        private Button btnNovo;
        private Button btnRemover;
    }
}