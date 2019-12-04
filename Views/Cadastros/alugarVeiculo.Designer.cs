namespace sistemasfrotas.Views
{
    partial class alugarVeiculo
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.txCodV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txPlaca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnh = new System.Windows.Forms.Panel();
            this.txKmEnt = new System.Windows.Forms.TextBox();
            this.lbEnt = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txKmIni = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbAlugado = new System.Windows.Forms.Label();
            this.lbDevolvido = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txCodF = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txNome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(16, 54);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 1);
            this.panel5.TabIndex = 20;
            // 
            // txCodV
            // 
            this.txCodV.BackColor = System.Drawing.Color.MidnightBlue;
            this.txCodV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txCodV.ForeColor = System.Drawing.Color.White;
            this.txCodV.Location = new System.Drawing.Point(16, 33);
            this.txCodV.MaxLength = 11;
            this.txCodV.Name = "txCodV";
            this.txCodV.Size = new System.Drawing.Size(200, 18);
            this.txCodV.TabIndex = 19;
            this.txCodV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txCodV_KeyPress);
            this.txCodV.Leave += new System.EventHandler(this.txCodV_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Codigo do Veiculo";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(227, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 1);
            this.panel1.TabIndex = 23;
            // 
            // txPlaca
            // 
            this.txPlaca.BackColor = System.Drawing.Color.MidnightBlue;
            this.txPlaca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txPlaca.Enabled = false;
            this.txPlaca.ForeColor = System.Drawing.Color.White;
            this.txPlaca.Location = new System.Drawing.Point(227, 33);
            this.txPlaca.Name = "txPlaca";
            this.txPlaca.Size = new System.Drawing.Size(200, 18);
            this.txPlaca.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(223, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Placa do Veiculo";
            // 
            // pnh
            // 
            this.pnh.BackColor = System.Drawing.Color.White;
            this.pnh.Location = new System.Drawing.Point(16, 177);
            this.pnh.Name = "pnh";
            this.pnh.Size = new System.Drawing.Size(200, 1);
            this.pnh.TabIndex = 26;
            this.pnh.Visible = false;
            // 
            // txKmEnt
            // 
            this.txKmEnt.BackColor = System.Drawing.Color.MidnightBlue;
            this.txKmEnt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txKmEnt.ForeColor = System.Drawing.Color.White;
            this.txKmEnt.Location = new System.Drawing.Point(16, 156);
            this.txKmEnt.Name = "txKmEnt";
            this.txKmEnt.Size = new System.Drawing.Size(200, 18);
            this.txKmEnt.TabIndex = 25;
            this.txKmEnt.Visible = false;
            // 
            // lbEnt
            // 
            this.lbEnt.AutoSize = true;
            this.lbEnt.ForeColor = System.Drawing.Color.White;
            this.lbEnt.Location = new System.Drawing.Point(12, 132);
            this.lbEnt.Name = "lbEnt";
            this.lbEnt.Size = new System.Drawing.Size(83, 17);
            this.lbEnt.TabIndex = 24;
            this.lbEnt.Text = "Km Entregue";
            this.lbEnt.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(436, 54);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 1);
            this.panel3.TabIndex = 29;
            // 
            // txKmIni
            // 
            this.txKmIni.BackColor = System.Drawing.Color.MidnightBlue;
            this.txKmIni.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txKmIni.Enabled = false;
            this.txKmIni.ForeColor = System.Drawing.Color.White;
            this.txKmIni.Location = new System.Drawing.Point(436, 33);
            this.txKmIni.Name = "txKmIni";
            this.txKmIni.ReadOnly = true;
            this.txKmIni.Size = new System.Drawing.Size(200, 18);
            this.txKmIni.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(432, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "KM Atual";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.Location = new System.Drawing.Point(478, 90);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(115, 25);
            this.lbStatus.TabIndex = 30;
            this.lbStatus.Text = "DISPONIVEL";
            // 
            // lbAlugado
            // 
            this.lbAlugado.AutoSize = true;
            this.lbAlugado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAlugado.Location = new System.Drawing.Point(12, 199);
            this.lbAlugado.Name = "lbAlugado";
            this.lbAlugado.Size = new System.Drawing.Size(105, 21);
            this.lbAlugado.TabIndex = 31;
            this.lbAlugado.Text = "Alugado em : ";
            // 
            // lbDevolvido
            // 
            this.lbDevolvido.AutoSize = true;
            this.lbDevolvido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDevolvido.Location = new System.Drawing.Point(12, 245);
            this.lbDevolvido.Name = "lbDevolvido";
            this.lbDevolvido.Size = new System.Drawing.Size(113, 21);
            this.lbDevolvido.TabIndex = 32;
            this.lbDevolvido.Text = "Devolvido em :";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(16, 118);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 1);
            this.panel4.TabIndex = 35;
            // 
            // txCodF
            // 
            this.txCodF.BackColor = System.Drawing.Color.MidnightBlue;
            this.txCodF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txCodF.ForeColor = System.Drawing.Color.White;
            this.txCodF.Location = new System.Drawing.Point(16, 101);
            this.txCodF.MaxLength = 11;
            this.txCodF.Name = "txCodF";
            this.txCodF.Size = new System.Drawing.Size(200, 18);
            this.txCodF.TabIndex = 34;
            this.txCodF.CursorChanged += new System.EventHandler(this.txCodF_TextChanged);
            this.txCodF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txCodV_KeyPress);
            this.txCodF.Leave += new System.EventHandler(this.txCodF_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "Codigo do Funcionario";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(228, 118);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 1);
            this.panel6.TabIndex = 38;
            // 
            // txNome
            // 
            this.txNome.BackColor = System.Drawing.Color.MidnightBlue;
            this.txNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txNome.Enabled = false;
            this.txNome.ForeColor = System.Drawing.Color.White;
            this.txNome.Location = new System.Drawing.Point(228, 97);
            this.txNome.Name = "txNome";
            this.txNome.ReadOnly = true;
            this.txNome.Size = new System.Drawing.Size(200, 18);
            this.txNome.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(224, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 17);
            this.label6.TabIndex = 36;
            this.label6.Text = "Nome do Funcionario";
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
            this.btSave.Location = new System.Drawing.Point(524, 141);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(112, 37);
            this.btSave.TabIndex = 47;
            this.btSave.Text = "Confirmar";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // alugarVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(660, 280);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.txNome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txCodF);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbDevolvido);
            this.Controls.Add(this.lbAlugado);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txKmIni);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnh);
            this.Controls.Add(this.txKmEnt);
            this.Controls.Add(this.lbEnt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txPlaca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.txCodV);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "alugarVeiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alugar Veiculo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txCodV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txPlaca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnh;
        private System.Windows.Forms.TextBox txKmEnt;
        private System.Windows.Forms.Label lbEnt;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txKmIni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label lbAlugado;
        private System.Windows.Forms.Label lbDevolvido;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txCodF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txNome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Timer timer1;
    }
}