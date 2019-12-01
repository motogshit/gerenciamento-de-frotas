namespace sistemasfrotas.Views
{
    partial class VeiculosView
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbEmpresas = new System.Windows.Forms.ComboBox();
            this.btAluga = new System.Windows.Forms.Button();
            this.btCadastra = new System.Windows.Forms.Button();
            this.btDevolve = new System.Windows.Forms.Button();
            this.btAlugados = new System.Windows.Forms.Button();
            this.btVeiculos = new System.Windows.Forms.Button();
            this.btManu = new System.Windows.Forms.Button();
            this.btManutencao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.Color.Aqua;
            this.btSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btSave.FlatAppearance.BorderSize = 0;
            this.btSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSave.ForeColor = System.Drawing.Color.Black;
            this.btSave.Location = new System.Drawing.Point(94, 963);
            this.btSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(168, 60);
            this.btSave.TabIndex = 46;
            this.btSave.Text = "Salvar";
            this.btSave.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aqua;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(272, 963);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 60);
            this.button1.TabIndex = 47;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Aqua;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(448, 963);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 60);
            this.button2.TabIndex = 48;
            this.button2.Text = "Salvar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(20, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 21);
            this.label1.TabIndex = 52;
            this.label1.Text = "Listar por Empresas";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.Crimson;
            this.checkBox1.Location = new System.Drawing.Point(317, 50);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(197, 25);
            this.checkBox1.TabIndex = 57;
            this.checkBox1.Text = "Listar todos os veiculos?";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGridView1.Location = new System.Drawing.Point(21, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 50;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowTemplate.Height = 34;
            this.dataGridView1.Size = new System.Drawing.Size(1135, 497);
            this.dataGridView1.TabIndex = 58;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cbEmpresas
            // 
            this.cbEmpresas.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cbEmpresas.FormattingEnabled = true;
            this.cbEmpresas.Location = new System.Drawing.Point(24, 46);
            this.cbEmpresas.Name = "cbEmpresas";
            this.cbEmpresas.Size = new System.Drawing.Size(287, 29);
            this.cbEmpresas.TabIndex = 60;
            this.cbEmpresas.SelectedIndexChanged += new System.EventHandler(this.setter);
            // 
            // btAluga
            // 
            this.btAluga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btAluga.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btAluga.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btAluga.FlatAppearance.BorderSize = 0;
            this.btAluga.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btAluga.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btAluga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAluga.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAluga.ForeColor = System.Drawing.Color.White;
            this.btAluga.Location = new System.Drawing.Point(163, 624);
            this.btAluga.Name = "btAluga";
            this.btAluga.Size = new System.Drawing.Size(134, 37);
            this.btAluga.TabIndex = 62;
            this.btAluga.Text = "Alugar Veiculo";
            this.btAluga.UseVisualStyleBackColor = false;
            this.btAluga.Click += new System.EventHandler(this.btAluga_Click);
            // 
            // btCadastra
            // 
            this.btCadastra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btCadastra.BackColor = System.Drawing.SystemColors.Highlight;
            this.btCadastra.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btCadastra.FlatAppearance.BorderSize = 0;
            this.btCadastra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btCadastra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btCadastra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastra.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastra.ForeColor = System.Drawing.Color.White;
            this.btCadastra.Location = new System.Drawing.Point(21, 624);
            this.btCadastra.Name = "btCadastra";
            this.btCadastra.Size = new System.Drawing.Size(136, 37);
            this.btCadastra.TabIndex = 61;
            this.btCadastra.Text = "Adicionar";
            this.btCadastra.UseVisualStyleBackColor = false;
            this.btCadastra.Click += new System.EventHandler(this.btCadastra_Click);
            // 
            // btDevolve
            // 
            this.btDevolve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btDevolve.BackColor = System.Drawing.Color.Navy;
            this.btDevolve.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btDevolve.FlatAppearance.BorderSize = 0;
            this.btDevolve.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btDevolve.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btDevolve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDevolve.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDevolve.ForeColor = System.Drawing.Color.White;
            this.btDevolve.Location = new System.Drawing.Point(303, 624);
            this.btDevolve.Name = "btDevolve";
            this.btDevolve.Size = new System.Drawing.Size(134, 37);
            this.btDevolve.TabIndex = 63;
            this.btDevolve.Text = "Devolver Veiculo";
            this.btDevolve.UseVisualStyleBackColor = false;
            this.btDevolve.Click += new System.EventHandler(this.btDevolve_Click);
            // 
            // btAlugados
            // 
            this.btAlugados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btAlugados.BackColor = System.Drawing.Color.Navy;
            this.btAlugados.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btAlugados.FlatAppearance.BorderSize = 0;
            this.btAlugados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btAlugados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btAlugados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAlugados.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAlugados.ForeColor = System.Drawing.Color.White;
            this.btAlugados.Location = new System.Drawing.Point(843, 22);
            this.btAlugados.Name = "btAlugados";
            this.btAlugados.Size = new System.Drawing.Size(160, 58);
            this.btAlugados.TabIndex = 64;
            this.btAlugados.Text = "Relatório de veiculos alugados";
            this.btAlugados.UseVisualStyleBackColor = false;
            this.btAlugados.Click += new System.EventHandler(this.btAlugados_Click);
            // 
            // btVeiculos
            // 
            this.btVeiculos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btVeiculos.BackColor = System.Drawing.Color.Navy;
            this.btVeiculos.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btVeiculos.FlatAppearance.BorderSize = 0;
            this.btVeiculos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btVeiculos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btVeiculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVeiculos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVeiculos.ForeColor = System.Drawing.Color.White;
            this.btVeiculos.Location = new System.Drawing.Point(1022, 22);
            this.btVeiculos.Name = "btVeiculos";
            this.btVeiculos.Size = new System.Drawing.Size(134, 53);
            this.btVeiculos.TabIndex = 65;
            this.btVeiculos.Text = "Relatório Geral";
            this.btVeiculos.UseVisualStyleBackColor = false;
            this.btVeiculos.Click += new System.EventHandler(this.btVeiculos_Click);
            // 
            // btManu
            // 
            this.btManu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btManu.BackColor = System.Drawing.Color.Navy;
            this.btManu.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btManu.FlatAppearance.BorderSize = 0;
            this.btManu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btManu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btManu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btManu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btManu.ForeColor = System.Drawing.Color.White;
            this.btManu.Location = new System.Drawing.Point(443, 624);
            this.btManu.Name = "btManu";
            this.btManu.Size = new System.Drawing.Size(175, 37);
            this.btManu.TabIndex = 67;
            this.btManu.Text = "Designar a manutenção";
            this.btManu.UseVisualStyleBackColor = false;
            this.btManu.Click += new System.EventHandler(this.btManu_Click);
            // 
            // btManutencao
            // 
            this.btManutencao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btManutencao.BackColor = System.Drawing.Color.Navy;
            this.btManutencao.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btManutencao.FlatAppearance.BorderSize = 0;
            this.btManutencao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btManutencao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btManutencao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btManutencao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btManutencao.ForeColor = System.Drawing.Color.White;
            this.btManutencao.Location = new System.Drawing.Point(659, 22);
            this.btManutencao.Name = "btManutencao";
            this.btManutencao.Size = new System.Drawing.Size(160, 58);
            this.btManutencao.TabIndex = 68;
            this.btManutencao.Text = "Relatorio Manutenção";
            this.btManutencao.UseVisualStyleBackColor = false;
            this.btManutencao.Click += new System.EventHandler(this.btManutencao_Click);
            // 
            // VeiculosView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.Controls.Add(this.btManutencao);
            this.Controls.Add(this.btManu);
            this.Controls.Add(this.btVeiculos);
            this.Controls.Add(this.btAlugados);
            this.Controls.Add(this.btDevolve);
            this.Controls.Add(this.btAluga);
            this.Controls.Add(this.btCadastra);
            this.Controls.Add(this.cbEmpresas);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btSave);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "VeiculosView";
            this.Size = new System.Drawing.Size(1176, 673);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbEmpresas;
        private System.Windows.Forms.Button btAluga;
        private System.Windows.Forms.Button btCadastra;
        private System.Windows.Forms.Button btDevolve;
        private System.Windows.Forms.Button btAlugados;
        private System.Windows.Forms.Button btVeiculos;
        private System.Windows.Forms.Button btManu;
        private System.Windows.Forms.Button btManutencao;
    }
}
