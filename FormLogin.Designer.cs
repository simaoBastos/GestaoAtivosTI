namespace GestaoAtivosTI
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblUsuario = new Label();
            lblSenha = new Label();
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            btnEntrar = new Button();
            btnHidePass = new Button();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.FlatStyle = FlatStyle.System;
            lblUsuario.Font = new Font("Calibri", 15F, FontStyle.Bold);
            lblUsuario.ForeColor = Color.White;
            lblUsuario.Location = new Point(135, 18);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(81, 27);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuário:";
            lblUsuario.TextAlign = ContentAlignment.MiddleCenter;
            lblUsuario.UseCompatibleTextRendering = true;
            lblUsuario.Click += lblUsuario_Click;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.FlatStyle = FlatStyle.System;
            lblSenha.Font = new Font("Calibri", 15F, FontStyle.Bold);
            lblSenha.ForeColor = Color.White;
            lblSenha.Location = new Point(142, 75);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(67, 27);
            lblSenha.TabIndex = 1;
            lblSenha.Text = "Senha:";
            lblSenha.TextAlign = ContentAlignment.MiddleCenter;
            lblSenha.UseCompatibleTextRendering = true;
            // 
            // txtUsuario
            // 
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Calibri", 10F);
            txtUsuario.Location = new Point(26, 48);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(287, 17);
            txtUsuario.TabIndex = 2;
            // 
            // txtSenha
            // 
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.Font = new Font("Calibri", 10F);
            txtSenha.Location = new Point(26, 105);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(287, 17);
            txtSenha.TabIndex = 3;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = SystemColors.ControlDark;
            btnEntrar.FlatAppearance.BorderSize = 0;
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Calibri", 15F, FontStyle.Bold);
            btnEntrar.ForeColor = Color.White;
            btnEntrar.Location = new Point(72, 140);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(200, 40);
            btnEntrar.TabIndex = 4;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // btnHidePass
            // 
            btnHidePass.BackColor = SystemColors.Window;
            btnHidePass.FlatAppearance.BorderSize = 0;
            btnHidePass.FlatAppearance.MouseDownBackColor = SystemColors.Window;
            btnHidePass.FlatAppearance.MouseOverBackColor = SystemColors.Window;
            btnHidePass.FlatStyle = FlatStyle.Flat;
            btnHidePass.Font = new Font("Segoe UI Symbol", 9F);
            btnHidePass.Location = new Point(287, 105);
            btnHidePass.Name = "btnHidePass";
            btnHidePass.Size = new Size(26, 17);
            btnHidePass.TabIndex = 6;
            btnHidePass.UseCompatibleTextRendering = true;
            btnHidePass.UseVisualStyleBackColor = false;
            btnHidePass.Click += btnHidePass_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(334, 211);
            Controls.Add(btnHidePass);
            Controls.Add(btnEntrar);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            Controls.Add(lblSenha);
            Controls.Add(lblUsuario);
            Font = new Font("Calibri", 15F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login - Sistema de Ativos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private Label lblSenha;
        private TextBox txtUsuario;
        private TextBox txtSenha;
        private Button btnEntrar;
        private Button btnHidePass;
    }
}
