
namespace Crud
{
    partial class Form1
    {
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnAtualizar = new System.Windows.Forms.Button();
            this.BtnDeletar = new System.Windows.Forms.Button();
            this.dgvCrud = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LanePreferida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LaneOdiada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.combox_lanepref = new System.Windows.Forms.ComboBox();
            this.combox_laneodiada = new System.Windows.Forms.ComboBox();
            this.num_nota = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCrud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_nota)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(302, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "CRUD";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnNovo
            // 
            this.BtnNovo.BackColor = System.Drawing.Color.Lime;
            this.BtnNovo.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNovo.Location = new System.Drawing.Point(614, 67);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(157, 71);
            this.BtnNovo.TabIndex = 1;
            this.BtnNovo.Text = "Novo";
            this.BtnNovo.UseVisualStyleBackColor = false;
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.BackColor = System.Drawing.Color.Cyan;
            this.BtnSalvar.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalvar.Location = new System.Drawing.Point(614, 155);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(157, 71);
            this.BtnSalvar.TabIndex = 2;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = false;
            // 
            // BtnAtualizar
            // 
            this.BtnAtualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnAtualizar.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtualizar.Location = new System.Drawing.Point(614, 245);
            this.BtnAtualizar.Name = "BtnAtualizar";
            this.BtnAtualizar.Size = new System.Drawing.Size(157, 71);
            this.BtnAtualizar.TabIndex = 3;
            this.BtnAtualizar.Text = "Atualizar";
            this.BtnAtualizar.UseVisualStyleBackColor = false;
            // 
            // BtnDeletar
            // 
            this.BtnDeletar.BackColor = System.Drawing.Color.White;
            this.BtnDeletar.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeletar.Location = new System.Drawing.Point(614, 335);
            this.BtnDeletar.Name = "BtnDeletar";
            this.BtnDeletar.Size = new System.Drawing.Size(157, 71);
            this.BtnDeletar.TabIndex = 4;
            this.BtnDeletar.Text = "Deletar";
            this.BtnDeletar.UseVisualStyleBackColor = false;
            // 
            // dgvCrud
            // 
            this.dgvCrud.AllowUserToOrderColumns = true;
            this.dgvCrud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCrud.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.LanePreferida,
            this.LaneOdiada,
            this.Nota});
            this.dgvCrud.Location = new System.Drawing.Point(12, 246);
            this.dgvCrud.Name = "dgvCrud";
            this.dgvCrud.RowHeadersWidth = 51;
            this.dgvCrud.RowTemplate.Height = 24;
            this.dgvCrud.Size = new System.Drawing.Size(579, 160);
            this.dgvCrud.TabIndex = 5;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.MinimumWidth = 6;
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 230;
            // 
            // LanePreferida
            // 
            this.LanePreferida.HeaderText = "Lane Preferida";
            this.LanePreferida.MinimumWidth = 6;
            this.LanePreferida.Name = "LanePreferida";
            this.LanePreferida.ReadOnly = true;
            this.LanePreferida.Width = 113;
            // 
            // LaneOdiada
            // 
            this.LaneOdiada.HeaderText = "Lane Odiada";
            this.LaneOdiada.MinimumWidth = 6;
            this.LaneOdiada.Name = "LaneOdiada";
            this.LaneOdiada.ReadOnly = true;
            this.LaneOdiada.Width = 113;
            // 
            // Nota
            // 
            this.Nota.HeaderText = "Nota";
            this.Nota.MinimumWidth = 6;
            this.Nota.Name = "Nota";
            this.Nota.ReadOnly = true;
            this.Nota.Width = 70;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(128, 67);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(463, 22);
            this.txtNome.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(9, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nome do Usuário";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(9, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Lane Preferida";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(9, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Lane Odiada";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(9, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Nota do Usuário";
            // 
            // combox_lanepref
            // 
            this.combox_lanepref.FormattingEnabled = true;
            this.combox_lanepref.Items.AddRange(new object[] {
            "Top",
            "Jungle",
            "Mid",
            "Adc",
            "Suporte"});
            this.combox_lanepref.Location = new System.Drawing.Point(128, 116);
            this.combox_lanepref.Name = "combox_lanepref";
            this.combox_lanepref.Size = new System.Drawing.Size(127, 24);
            this.combox_lanepref.TabIndex = 14;
            // 
            // combox_laneodiada
            // 
            this.combox_laneodiada.FormattingEnabled = true;
            this.combox_laneodiada.Items.AddRange(new object[] {
            "Top",
            "Jungle",
            "Mid",
            "Adc",
            "Suporte"});
            this.combox_laneodiada.Location = new System.Drawing.Point(128, 155);
            this.combox_laneodiada.Name = "combox_laneodiada";
            this.combox_laneodiada.Size = new System.Drawing.Size(127, 24);
            this.combox_laneodiada.TabIndex = 15;
            // 
            // num_nota
            // 
            this.num_nota.Location = new System.Drawing.Point(128, 201);
            this.num_nota.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.num_nota.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.num_nota.Name = "num_nota";
            this.num_nota.Size = new System.Drawing.Size(126, 22);
            this.num_nota.TabIndex = 16;
            this.num_nota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_nota.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.num_nota);
            this.Controls.Add(this.combox_laneodiada);
            this.Controls.Add(this.combox_lanepref);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.dgvCrud);
            this.Controls.Add(this.BtnDeletar);
            this.Controls.Add(this.BtnAtualizar);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCrud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_nota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnAtualizar;
        private System.Windows.Forms.Button BtnDeletar;
        private System.Windows.Forms.DataGridView dgvCrud;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn LanePreferida;
        private System.Windows.Forms.DataGridViewTextBoxColumn LaneOdiada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox combox_lanepref;
        private System.Windows.Forms.ComboBox combox_laneodiada;
        private System.Windows.Forms.NumericUpDown num_nota;
    }
}

