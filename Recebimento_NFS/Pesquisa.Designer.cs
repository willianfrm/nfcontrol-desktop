
namespace Recebimento_NFS
{
    partial class Pesquisa
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
            this.lv_lista_notas = new System.Windows.Forms.ListView();
            this.numero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.serie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nome_forn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cnpj_forn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hora = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.valor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chave = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lb_num_nota = new System.Windows.Forms.Label();
            this.tb_num_nota = new System.Windows.Forms.TextBox();
            this.lb_cnpj_forn = new System.Windows.Forms.Label();
            this.tb_cnpj_forn = new System.Windows.Forms.TextBox();
            this.lb_valor = new System.Windows.Forms.Label();
            this.tb_valor = new System.Windows.Forms.TextBox();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lv_lista_notas
            // 
            this.lv_lista_notas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.numero,
            this.serie,
            this.nome_forn,
            this.cnpj_forn,
            this.data,
            this.hora,
            this.valor,
            this.status,
            this.chave});
            this.lv_lista_notas.HideSelection = false;
            this.lv_lista_notas.Location = new System.Drawing.Point(12, 81);
            this.lv_lista_notas.Name = "lv_lista_notas";
            this.lv_lista_notas.Size = new System.Drawing.Size(960, 418);
            this.lv_lista_notas.TabIndex = 0;
            this.lv_lista_notas.UseCompatibleStateImageBehavior = false;
            this.lv_lista_notas.View = System.Windows.Forms.View.Details;
            // 
            // numero
            // 
            this.numero.Text = "Número";
            this.numero.Width = 90;
            // 
            // serie
            // 
            this.serie.Text = "Serie";
            this.serie.Width = 36;
            // 
            // nome_forn
            // 
            this.nome_forn.Text = "Fornecedor";
            this.nome_forn.Width = 184;
            // 
            // cnpj_forn
            // 
            this.cnpj_forn.Text = "CNPJ Fornecedor";
            this.cnpj_forn.Width = 117;
            // 
            // data
            // 
            this.data.Text = "Data";
            this.data.Width = 85;
            // 
            // hora
            // 
            this.hora.Text = "Horário";
            this.hora.Width = 81;
            // 
            // valor
            // 
            this.valor.Text = "Valor";
            this.valor.Width = 74;
            // 
            // status
            // 
            this.status.Text = "Satatus";
            this.status.Width = 83;
            // 
            // chave
            // 
            this.chave.Text = "Chave";
            this.chave.Width = 204;
            // 
            // lb_num_nota
            // 
            this.lb_num_nota.AutoSize = true;
            this.lb_num_nota.Location = new System.Drawing.Point(147, 21);
            this.lb_num_nota.Name = "lb_num_nota";
            this.lb_num_nota.Size = new System.Drawing.Size(85, 13);
            this.lb_num_nota.TabIndex = 1;
            this.lb_num_nota.Text = "Número da Nota";
            // 
            // tb_num_nota
            // 
            this.tb_num_nota.Location = new System.Drawing.Point(150, 38);
            this.tb_num_nota.Name = "tb_num_nota";
            this.tb_num_nota.Size = new System.Drawing.Size(115, 20);
            this.tb_num_nota.TabIndex = 2;
            // 
            // lb_cnpj_forn
            // 
            this.lb_cnpj_forn.AutoSize = true;
            this.lb_cnpj_forn.Location = new System.Drawing.Point(268, 21);
            this.lb_cnpj_forn.Name = "lb_cnpj_forn";
            this.lb_cnpj_forn.Size = new System.Drawing.Size(91, 13);
            this.lb_cnpj_forn.TabIndex = 1;
            this.lb_cnpj_forn.Text = "CNPJ Fornecedor";
            // 
            // tb_cnpj_forn
            // 
            this.tb_cnpj_forn.Location = new System.Drawing.Point(271, 38);
            this.tb_cnpj_forn.Name = "tb_cnpj_forn";
            this.tb_cnpj_forn.Size = new System.Drawing.Size(219, 20);
            this.tb_cnpj_forn.TabIndex = 2;
            // 
            // lb_valor
            // 
            this.lb_valor.AutoSize = true;
            this.lb_valor.Location = new System.Drawing.Point(493, 21);
            this.lb_valor.Name = "lb_valor";
            this.lb_valor.Size = new System.Drawing.Size(31, 13);
            this.lb_valor.TabIndex = 1;
            this.lb_valor.Text = "Valor";
            // 
            // tb_valor
            // 
            this.tb_valor.Location = new System.Drawing.Point(496, 38);
            this.tb_valor.Name = "tb_valor";
            this.tb_valor.Size = new System.Drawing.Size(100, 20);
            this.tb_valor.TabIndex = 2;
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Location = new System.Drawing.Point(709, 29);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(92, 37);
            this.btn_pesquisar.TabIndex = 3;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(807, 29);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(92, 37);
            this.btn_sair.TabIndex = 3;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // Pesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(984, 511);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.tb_valor);
            this.Controls.Add(this.lb_valor);
            this.Controls.Add(this.tb_cnpj_forn);
            this.Controls.Add(this.lb_cnpj_forn);
            this.Controls.Add(this.tb_num_nota);
            this.Controls.Add(this.lb_num_nota);
            this.Controls.Add(this.lv_lista_notas);
            this.MaximizeBox = false;
            this.Name = "Pesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_lista_notas;
        private System.Windows.Forms.Label lb_num_nota;
        private System.Windows.Forms.TextBox tb_num_nota;
        private System.Windows.Forms.Label lb_cnpj_forn;
        private System.Windows.Forms.TextBox tb_cnpj_forn;
        private System.Windows.Forms.Label lb_valor;
        private System.Windows.Forms.TextBox tb_valor;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.ColumnHeader numero;
        private System.Windows.Forms.ColumnHeader serie;
        private System.Windows.Forms.ColumnHeader nome_forn;
        private System.Windows.Forms.ColumnHeader cnpj_forn;
        private System.Windows.Forms.ColumnHeader data;
        private System.Windows.Forms.ColumnHeader hora;
        private System.Windows.Forms.ColumnHeader valor;
        private System.Windows.Forms.ColumnHeader status;
        private System.Windows.Forms.ColumnHeader chave;
    }
}