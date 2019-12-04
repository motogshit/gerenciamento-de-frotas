namespace sistemasfrotas.Views.Cadastros
{
    partial class reciboForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txFun = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btSalvar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbEmpresa = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txValor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txDesc = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(12, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 1);
            this.panel1.TabIndex = 8;
            // 
            // txFun
            // 
            this.txFun.BackColor = System.Drawing.Color.MidnightBlue;
            this.txFun.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txFun.ForeColor = System.Drawing.Color.White;
            this.txFun.Location = new System.Drawing.Point(12, 32);
            this.txFun.MaxLength = 11;
            this.txFun.Name = "txFun";
            this.txFun.Size = new System.Drawing.Size(200, 22);
            this.txFun.TabIndex = 7;
            this.txFun.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txFun_KeyPress);
            this.txFun.Leave += new System.EventHandler(this.txFun_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Código do funcionario :";
            // 
            // btSalvar
            // 
            this.btSalvar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btSalvar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btSalvar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalvar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvar.ForeColor = System.Drawing.Color.White;
            this.btSalvar.Location = new System.Drawing.Point(368, 238);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(101, 37);
            this.btSalvar.TabIndex = 33;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = false;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 21);
            this.label2.TabIndex = 34;
            this.label2.Text = "Nome :";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.ForeColor = System.Drawing.Color.White;
            this.lbNome.Location = new System.Drawing.Point(12, 147);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(158, 21);
            this.lbNome.TabIndex = 35;
            this.lbNome.Text = "Nome do funcionario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 21);
            this.label4.TabIndex = 36;
            this.label4.Text = "Razão da empresa:";
            // 
            // lbEmpresa
            // 
            this.lbEmpresa.AutoSize = true;
            this.lbEmpresa.ForeColor = System.Drawing.Color.White;
            this.lbEmpresa.Location = new System.Drawing.Point(12, 203);
            this.lbEmpresa.Name = "lbEmpresa";
            this.lbEmpresa.Size = new System.Drawing.Size(138, 21);
            this.lbEmpresa.TabIndex = 37;
            this.lbEmpresa.Text = "Nome da empresa";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(12, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 1);
            this.panel2.TabIndex = 40;
            // 
            // txValor
            // 
            this.txValor.BackColor = System.Drawing.Color.MidnightBlue;
            this.txValor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txValor.ForeColor = System.Drawing.Color.White;
            this.txValor.Location = new System.Drawing.Point(12, 89);
            this.txValor.MaxLength = 150;
            this.txValor.Name = "txValor";
            this.txValor.Size = new System.Drawing.Size(200, 22);
            this.txValor.TabIndex = 39;
            this.txValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txValor_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(8, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 21);
            this.label6.TabIndex = 38;
            this.label6.Text = "Valor :";
            // 
            // txDesc
            // 
            this.txDesc.Location = new System.Drawing.Point(242, 32);
            this.txDesc.Name = "txDesc";
            this.txDesc.Size = new System.Drawing.Size(227, 180);
            this.txDesc.TabIndex = 41;
            this.txDesc.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 21);
            this.label3.TabIndex = 42;
            this.label3.Text = "Descrição :";
            // 
            // reciboForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(488, 287);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txDesc);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txValor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbEmpresa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txFun);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "reciboForm";
            this.Text = "reciboForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txFun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbEmpresa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txValor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox txDesc;
        private System.Windows.Forms.Label label3;
    }
}