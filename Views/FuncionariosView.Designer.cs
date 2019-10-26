namespace sistemasfrotas.Views
{
    partial class FuncionariosView
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btRemover = new System.Windows.Forms.Button();
            this.btAdicionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 121);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1142, 478);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btRemover
            // 
            this.btRemover.BackColor = System.Drawing.Color.BlueViolet;
            this.btRemover.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btRemover.FlatAppearance.BorderSize = 0;
            this.btRemover.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btRemover.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            this.btRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRemover.ForeColor = System.Drawing.Color.Black;
            this.btRemover.Location = new System.Drawing.Point(136, 613);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(112, 37);
            this.btRemover.TabIndex = 48;
            this.btRemover.Text = "Remover";
            this.btRemover.UseVisualStyleBackColor = false;
            this.btRemover.Click += new System.EventHandler(this.btRemover_Click);
            // 
            // btAdicionar
            // 
            this.btAdicionar.BackColor = System.Drawing.Color.Aqua;
            this.btAdicionar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btAdicionar.FlatAppearance.BorderSize = 0;
            this.btAdicionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btAdicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            this.btAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdicionar.ForeColor = System.Drawing.Color.Black;
            this.btAdicionar.Location = new System.Drawing.Point(18, 613);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(112, 37);
            this.btAdicionar.TabIndex = 49;
            this.btAdicionar.Text = "Adicionar";
            this.btAdicionar.UseVisualStyleBackColor = false;
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // FuncionariosView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.Controls.Add(this.btAdicionar);
            this.Controls.Add(this.btRemover);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FuncionariosView";
            this.Size = new System.Drawing.Size(1176, 673);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btRemover;
        private System.Windows.Forms.Button btAdicionar;
    }
}
