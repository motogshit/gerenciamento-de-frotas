namespace sistemasfrotas
{
    partial class Dashboard
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.btnRelatorios = new System.Windows.Forms.Button();
            this.btnFuncionarios = new System.Windows.Forms.Button();
            this.btnVeiculos = new System.Windows.Forms.Button();
            this.btnPagamentos = new System.Windows.Forms.Button();
            this.btnEmpresa = new System.Windows.Forms.Button();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Container = new System.Windows.Forms.Panel();
            this.HeaderPanel.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeaderPanel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.HeaderPanel.Controls.Add(this.HeaderLabel);
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(1366, 35);
            this.HeaderPanel.TabIndex = 0;
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.Location = new System.Drawing.Point(30, 7);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(212, 21);
            this.HeaderLabel.TabIndex = 0;
            this.HeaderLabel.Text = "Em Fase de Desenvolvimento";
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.MenuPanel.Controls.Add(this.btnRelatorios);
            this.MenuPanel.Controls.Add(this.btnFuncionarios);
            this.MenuPanel.Controls.Add(this.btnVeiculos);
            this.MenuPanel.Controls.Add(this.btnPagamentos);
            this.MenuPanel.Controls.Add(this.btnEmpresa);
            this.MenuPanel.Location = new System.Drawing.Point(0, 36);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(190, 732);
            this.MenuPanel.TabIndex = 1;
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRelatorios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRelatorios.FlatAppearance.BorderSize = 0;
            this.btnRelatorios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnRelatorios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GreenYellow;
            this.btnRelatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorios.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorios.Location = new System.Drawing.Point(8, 248);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Size = new System.Drawing.Size(175, 51);
            this.btnRelatorios.TabIndex = 4;
            this.btnRelatorios.Text = "Relatorios";
            this.btnRelatorios.UseVisualStyleBackColor = true;
            // 
            // btnFuncionarios
            // 
            this.btnFuncionarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFuncionarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFuncionarios.FlatAppearance.BorderSize = 0;
            this.btnFuncionarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnFuncionarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GreenYellow;
            this.btnFuncionarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuncionarios.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncionarios.Location = new System.Drawing.Point(8, 191);
            this.btnFuncionarios.Name = "btnFuncionarios";
            this.btnFuncionarios.Size = new System.Drawing.Size(175, 51);
            this.btnFuncionarios.TabIndex = 3;
            this.btnFuncionarios.Text = "Funcionarios";
            this.btnFuncionarios.UseVisualStyleBackColor = true;
            this.btnFuncionarios.Click += new System.EventHandler(this.btnFuncionarios_Click);
            // 
            // btnVeiculos
            // 
            this.btnVeiculos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVeiculos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVeiculos.FlatAppearance.BorderSize = 0;
            this.btnVeiculos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnVeiculos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GreenYellow;
            this.btnVeiculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVeiculos.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVeiculos.Location = new System.Drawing.Point(8, 77);
            this.btnVeiculos.Name = "btnVeiculos";
            this.btnVeiculos.Size = new System.Drawing.Size(175, 51);
            this.btnVeiculos.TabIndex = 2;
            this.btnVeiculos.Text = "Veiculos";
            this.btnVeiculos.UseVisualStyleBackColor = true;
            this.btnVeiculos.Click += new System.EventHandler(this.btnVeiculos_Click);
            // 
            // btnPagamentos
            // 
            this.btnPagamentos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPagamentos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPagamentos.FlatAppearance.BorderSize = 0;
            this.btnPagamentos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnPagamentos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GreenYellow;
            this.btnPagamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagamentos.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagamentos.Location = new System.Drawing.Point(8, 134);
            this.btnPagamentos.Name = "btnPagamentos";
            this.btnPagamentos.Size = new System.Drawing.Size(175, 51);
            this.btnPagamentos.TabIndex = 1;
            this.btnPagamentos.Text = "Pagamentos";
            this.btnPagamentos.UseVisualStyleBackColor = true;
            // 
            // btnEmpresa
            // 
            this.btnEmpresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEmpresa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpresa.FlatAppearance.BorderSize = 0;
            this.btnEmpresa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnEmpresa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GreenYellow;
            this.btnEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpresa.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpresa.Location = new System.Drawing.Point(8, 20);
            this.btnEmpresa.Name = "btnEmpresa";
            this.btnEmpresa.Size = new System.Drawing.Size(175, 51);
            this.btnEmpresa.TabIndex = 0;
            this.btnEmpresa.Text = "Empresas";
            this.btnEmpresa.UseVisualStyleBackColor = true;
            this.btnEmpresa.Click += new System.EventHandler(this.btnEmpresa_Click);
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TopPanel.Controls.Add(this.label1);
            this.TopPanel.Location = new System.Drawing.Point(190, 36);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1175, 60);
            this.TopPanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario: Administrador";
            // 
            // Container
            // 
            this.Container.Location = new System.Drawing.Point(190, 95);
            this.Container.Name = "Container";
            this.Container.Size = new System.Drawing.Size(1175, 673);
            this.Container.TabIndex = 3;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.Container);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.HeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.MenuPanel.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button btnRelatorios;
        private System.Windows.Forms.Button btnFuncionarios;
        private System.Windows.Forms.Button btnVeiculos;
        private System.Windows.Forms.Button btnPagamentos;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Container;
        private System.Windows.Forms.Button btnEmpresa;
    }
}

