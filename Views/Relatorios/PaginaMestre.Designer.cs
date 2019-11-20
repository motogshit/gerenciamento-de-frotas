namespace sistemasfrotas.Views.Relatorios
{
    partial class PaginaMestre
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportFuncionarios = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dt1 = new System.Windows.Forms.DateTimePicker();
            this.dt2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportVeiculos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportRecibos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportAlugados = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportManutencao = new Microsoft.Reporting.WinForms.ReportViewer();
            this.manutencaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alugadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recibosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.veiculosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funcionariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manutencaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alugadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recibosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veiculosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportFuncionarios
            // 
            this.reportFuncionarios.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dtFuncionarios";
            reportDataSource1.Value = this.funcionariosBindingSource;
            this.reportFuncionarios.LocalReport.DataSources.Add(reportDataSource1);
            this.reportFuncionarios.LocalReport.ReportEmbeddedResource = "sistemasfrotas.Views.Relatorios.funcionarios.rdlc";
            this.reportFuncionarios.Location = new System.Drawing.Point(0, 0);
            this.reportFuncionarios.Name = "reportFuncionarios";
            this.reportFuncionarios.ServerReport.BearerToken = null;
            this.reportFuncionarios.Size = new System.Drawing.Size(1059, 483);
            this.reportFuncionarios.TabIndex = 0;
            // 
            // dt1
            // 
            this.dt1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dt1.Location = new System.Drawing.Point(23, 49);
            this.dt1.Name = "dt1";
            this.dt1.Size = new System.Drawing.Size(345, 29);
            this.dt1.TabIndex = 1;
            this.dt1.ValueChanged += new System.EventHandler(this.dt1_ValueChanged);
            // 
            // dt2
            // 
            this.dt2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dt2.Location = new System.Drawing.Point(578, 49);
            this.dt2.Name = "dt2";
            this.dt2.Size = new System.Drawing.Size(345, 29);
            this.dt2.TabIndex = 2;
            this.dt2.ValueChanged += new System.EventHandler(this.dt1_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(19, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Intervalo de data Inicial :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(574, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Intervalo de data Final :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dt1);
            this.panel1.Controls.Add(this.dt2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 383);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1059, 100);
            this.panel1.TabIndex = 5;
            // 
            // reportVeiculos
            // 
            this.reportVeiculos.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "dtVeiculos";
            reportDataSource2.Value = this.veiculosBindingSource;
            this.reportVeiculos.LocalReport.DataSources.Add(reportDataSource2);
            this.reportVeiculos.LocalReport.ReportEmbeddedResource = "sistemasfrotas.Views.Relatorios.Veiculos.rdlc";
            this.reportVeiculos.Location = new System.Drawing.Point(0, 0);
            this.reportVeiculos.Name = "reportVeiculos";
            this.reportVeiculos.ServerReport.BearerToken = null;
            this.reportVeiculos.Size = new System.Drawing.Size(1059, 383);
            this.reportVeiculos.TabIndex = 6;
            // 
            // reportRecibos
            // 
            this.reportRecibos.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "dtRecibos";
            reportDataSource3.Value = this.recibosBindingSource;
            this.reportRecibos.LocalReport.DataSources.Add(reportDataSource3);
            this.reportRecibos.LocalReport.ReportEmbeddedResource = "sistemasfrotas.Views.Relatorios.Recibos.rdlc";
            this.reportRecibos.Location = new System.Drawing.Point(0, 0);
            this.reportRecibos.Name = "reportRecibos";
            this.reportRecibos.ServerReport.BearerToken = null;
            this.reportRecibos.Size = new System.Drawing.Size(1059, 383);
            this.reportRecibos.TabIndex = 7;
            // 
            // reportAlugados
            // 
            this.reportAlugados.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource4.Name = "dtAlugados";
            reportDataSource4.Value = this.alugadosBindingSource;
            this.reportAlugados.LocalReport.DataSources.Add(reportDataSource4);
            this.reportAlugados.LocalReport.ReportEmbeddedResource = "sistemasfrotas.Views.Relatorios.Alugados.rdlc";
            this.reportAlugados.Location = new System.Drawing.Point(0, 0);
            this.reportAlugados.Name = "reportAlugados";
            this.reportAlugados.ServerReport.BearerToken = null;
            this.reportAlugados.Size = new System.Drawing.Size(1059, 383);
            this.reportAlugados.TabIndex = 8;
            // 
            // reportManutencao
            // 
            this.reportManutencao.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource5.Name = "dtManutencao";
            reportDataSource5.Value = this.manutencaoBindingSource;
            this.reportManutencao.LocalReport.DataSources.Add(reportDataSource5);
            this.reportManutencao.LocalReport.ReportEmbeddedResource = "sistemasfrotas.Views.Relatorios.Manutencao.rdlc";
            this.reportManutencao.Location = new System.Drawing.Point(0, 0);
            this.reportManutencao.Name = "reportManutencao";
            this.reportManutencao.ServerReport.BearerToken = null;
            this.reportManutencao.Size = new System.Drawing.Size(1059, 383);
            this.reportManutencao.TabIndex = 9;
            // 
            // manutencaoBindingSource
            // 
            this.manutencaoBindingSource.DataSource = typeof(sistemasfrotas.Model.manutencao);
            // 
            // alugadosBindingSource
            // 
            this.alugadosBindingSource.DataSource = typeof(sistemasfrotas.Model.alugados);
            // 
            // recibosBindingSource
            // 
            this.recibosBindingSource.DataSource = typeof(sistemasfrotas.Model.recibos);
            // 
            // veiculosBindingSource
            // 
            this.veiculosBindingSource.DataSource = typeof(sistemasfrotas.Model.veiculos);
            // 
            // funcionariosBindingSource
            // 
            this.funcionariosBindingSource.DataSource = typeof(sistemasfrotas.Model.funcionarios);
            // 
            // PaginaMestre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1059, 483);
            this.Controls.Add(this.reportManutencao);
            this.Controls.Add(this.reportAlugados);
            this.Controls.Add(this.reportRecibos);
            this.Controls.Add(this.reportVeiculos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.reportFuncionarios);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PaginaMestre";
            this.Text = "Relatório";
            this.Load += new System.EventHandler(this.PaginaMestre_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manutencaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alugadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recibosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veiculosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportFuncionarios;
        private System.Windows.Forms.DateTimePicker dt1;
        private System.Windows.Forms.DateTimePicker dt2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource funcionariosBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportVeiculos;
        private System.Windows.Forms.BindingSource veiculosBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportRecibos;
        private System.Windows.Forms.BindingSource recibosBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportAlugados;
        private System.Windows.Forms.BindingSource alugadosBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportManutencao;
        private System.Windows.Forms.BindingSource manutencaoBindingSource;
    }
}