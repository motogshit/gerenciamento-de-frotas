namespace sistemasfrotas.Views.Cadastros
{
    partial class manutencaoForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txCusto = new System.Windows.Forms.TextBox();
            this.txDesc = new System.Windows.Forms.RichTextBox();
            this.btSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Custo aproximado da manutenção";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descrição do problema";
            // 
            // txCusto
            // 
            this.txCusto.Location = new System.Drawing.Point(29, 25);
            this.txCusto.MaxLength = 150;
            this.txCusto.Name = "txCusto";
            this.txCusto.Size = new System.Drawing.Size(211, 20);
            this.txCusto.TabIndex = 2;
            this.txCusto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txCusto_KeyPress);
            // 
            // txDesc
            // 
            this.txDesc.Location = new System.Drawing.Point(29, 78);
            this.txDesc.Name = "txDesc";
            this.txDesc.Size = new System.Drawing.Size(211, 96);
            this.txDesc.TabIndex = 3;
            this.txDesc.Text = "";
            // 
            // btSave
            // 
            this.btSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btSave.Location = new System.Drawing.Point(282, 151);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 4;
            this.btSave.Text = "Salvar";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // manutencaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 181);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.txDesc);
            this.Controls.Add(this.txCusto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(385, 220);
            this.MinimumSize = new System.Drawing.Size(385, 220);
            this.Name = "manutencaoForm";
            this.Text = "manutencaoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txCusto;
        private System.Windows.Forms.RichTextBox txDesc;
        private System.Windows.Forms.Button btSave;
    }
}