
namespace Recebimento_NFS
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtp_Data = new System.Windows.Forms.DateTimePicker();
            this.lb_vencimentos = new System.Windows.Forms.Label();
            this.lbx_vencimentos = new System.Windows.Forms.ListBox();
            this.lb_chegada = new System.Windows.Forms.Label();
            this.lb_valor = new System.Windows.Forms.Label();
            this.lb_forn = new System.Windows.Forms.Label();
            this.lb_num_nfe = new System.Windows.Forms.Label();
            this.lb_chave_boleto = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.tb_chave_boleto = new System.Windows.Forms.TextBox();
            this.painel_lista = new System.Windows.Forms.Panel();
            this.btn_config = new System.Windows.Forms.Button();
            this.btn_relatorio = new System.Windows.Forms.Button();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.btn_config);
            this.panel1.Controls.Add(this.btn_relatorio);
            this.panel1.Controls.Add(this.btn_pesquisar);
            this.panel1.Controls.Add(this.btn_atualizar);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.pb_logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1310, 100);
            this.panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtp_Data);
            this.groupBox1.Controls.Add(this.lb_vencimentos);
            this.groupBox1.Controls.Add(this.lbx_vencimentos);
            this.groupBox1.Controls.Add(this.lb_chegada);
            this.groupBox1.Controls.Add(this.lb_valor);
            this.groupBox1.Controls.Add(this.lb_forn);
            this.groupBox1.Controls.Add(this.lb_num_nfe);
            this.groupBox1.Controls.Add(this.lb_chave_boleto);
            this.groupBox1.Controls.Add(this.btn_cancelar);
            this.groupBox1.Controls.Add(this.tb_chave_boleto);
            this.groupBox1.Location = new System.Drawing.Point(158, -3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(796, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // dtp_Data
            // 
            this.dtp_Data.Location = new System.Drawing.Point(165, 70);
            this.dtp_Data.Name = "dtp_Data";
            this.dtp_Data.Size = new System.Drawing.Size(232, 20);
            this.dtp_Data.TabIndex = 7;
            this.dtp_Data.ValueChanged += new System.EventHandler(this.dtp_Data_ValueChanged);
            // 
            // lb_vencimentos
            // 
            this.lb_vencimentos.AutoSize = true;
            this.lb_vencimentos.Location = new System.Drawing.Point(698, 9);
            this.lb_vencimentos.Name = "lb_vencimentos";
            this.lb_vencimentos.Size = new System.Drawing.Size(68, 13);
            this.lb_vencimentos.TabIndex = 6;
            this.lb_vencimentos.Text = "Vencimentos";
            this.lb_vencimentos.Visible = false;
            // 
            // lbx_vencimentos
            // 
            this.lbx_vencimentos.FormattingEnabled = true;
            this.lbx_vencimentos.Location = new System.Drawing.Point(701, 25);
            this.lbx_vencimentos.Name = "lbx_vencimentos";
            this.lbx_vencimentos.Size = new System.Drawing.Size(89, 69);
            this.lbx_vencimentos.TabIndex = 5;
            this.lbx_vencimentos.Visible = false;
            // 
            // lb_chegada
            // 
            this.lb_chegada.AutoSize = true;
            this.lb_chegada.Location = new System.Drawing.Point(403, 70);
            this.lb_chegada.Name = "lb_chegada";
            this.lb_chegada.Size = new System.Drawing.Size(0, 13);
            this.lb_chegada.TabIndex = 4;
            // 
            // lb_valor
            // 
            this.lb_valor.AutoSize = true;
            this.lb_valor.Location = new System.Drawing.Point(404, 52);
            this.lb_valor.Name = "lb_valor";
            this.lb_valor.Size = new System.Drawing.Size(0, 13);
            this.lb_valor.TabIndex = 4;
            // 
            // lb_forn
            // 
            this.lb_forn.AutoSize = true;
            this.lb_forn.Location = new System.Drawing.Point(404, 34);
            this.lb_forn.Name = "lb_forn";
            this.lb_forn.Size = new System.Drawing.Size(0, 13);
            this.lb_forn.TabIndex = 4;
            // 
            // lb_num_nfe
            // 
            this.lb_num_nfe.AutoSize = true;
            this.lb_num_nfe.Location = new System.Drawing.Point(404, 17);
            this.lb_num_nfe.Name = "lb_num_nfe";
            this.lb_num_nfe.Size = new System.Drawing.Size(0, 13);
            this.lb_num_nfe.TabIndex = 4;
            // 
            // lb_chave_boleto
            // 
            this.lb_chave_boleto.AutoSize = true;
            this.lb_chave_boleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_chave_boleto.Location = new System.Drawing.Point(6, 16);
            this.lb_chave_boleto.Name = "lb_chave_boleto";
            this.lb_chave_boleto.Size = new System.Drawing.Size(185, 16);
            this.lb_chave_boleto.TabIndex = 2;
            this.lb_chave_boleto.Text = "CHAVE DA NOTA FISCAL";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Enabled = false;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Location = new System.Drawing.Point(8, 66);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(72, 26);
            this.btn_cancelar.TabIndex = 3;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // tb_chave_boleto
            // 
            this.tb_chave_boleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_chave_boleto.Location = new System.Drawing.Point(9, 35);
            this.tb_chave_boleto.Name = "tb_chave_boleto";
            this.tb_chave_boleto.Size = new System.Drawing.Size(389, 24);
            this.tb_chave_boleto.TabIndex = 1;
            this.tb_chave_boleto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_chave_boleto_KeyDown);
            // 
            // painel_lista
            // 
            this.painel_lista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.painel_lista.AutoScroll = true;
            this.painel_lista.BackColor = System.Drawing.SystemColors.Control;
            this.painel_lista.Location = new System.Drawing.Point(12, 106);
            this.painel_lista.Name = "painel_lista";
            this.painel_lista.Size = new System.Drawing.Size(1286, 315);
            this.painel_lista.TabIndex = 2;
            // 
            // btn_config
            // 
            this.btn_config.BackColor = System.Drawing.SystemColors.Control;
            this.btn_config.BackgroundImage = global::Recebimento_NFS.Properties.Resources._5;
            this.btn_config.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_config.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_config.Location = new System.Drawing.Point(1219, 15);
            this.btn_config.Name = "btn_config";
            this.btn_config.Size = new System.Drawing.Size(80, 80);
            this.btn_config.TabIndex = 8;
            this.btn_config.UseVisualStyleBackColor = false;
            this.btn_config.Click += new System.EventHandler(this.btn_config_Click);
            // 
            // btn_relatorio
            // 
            this.btn_relatorio.BackColor = System.Drawing.SystemColors.Control;
            this.btn_relatorio.BackgroundImage = global::Recebimento_NFS.Properties.Resources.relatorio;
            this.btn_relatorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_relatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_relatorio.Location = new System.Drawing.Point(1133, 14);
            this.btn_relatorio.Name = "btn_relatorio";
            this.btn_relatorio.Size = new System.Drawing.Size(80, 80);
            this.btn_relatorio.TabIndex = 7;
            this.btn_relatorio.UseVisualStyleBackColor = false;
            this.btn_relatorio.Click += new System.EventHandler(this.btn_relatorio_Click);
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_pesquisar.BackgroundImage = global::Recebimento_NFS.Properties.Resources.Search;
            this.btn_pesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_pesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pesquisar.Location = new System.Drawing.Point(1047, 14);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(80, 80);
            this.btn_pesquisar.TabIndex = 6;
            this.btn_pesquisar.UseVisualStyleBackColor = false;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_atualizar.BackgroundImage = global::Recebimento_NFS.Properties.Resources.atualizar;
            this.btn_atualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_atualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_atualizar.Location = new System.Drawing.Point(961, 14);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(80, 80);
            this.btn_atualizar.TabIndex = 5;
            this.btn_atualizar.UseVisualStyleBackColor = false;
            this.btn_atualizar.Click += new System.EventHandler(this.btn_atualizar_Click);
            // 
            // pb_logo
            // 
            this.pb_logo.BackColor = System.Drawing.SystemColors.Control;
            this.pb_logo.Image = global::Recebimento_NFS.Properties.Resources.logo_baratao_stroke;
            this.pb_logo.Location = new System.Drawing.Point(12, 3);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(140, 94);
            this.pb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_logo.TabIndex = 0;
            this.pb_logo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1310, 433);
            this.Controls.Add(this.painel_lista);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Recebimento NFS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label lb_chave_boleto;
        private System.Windows.Forms.TextBox tb_chave_boleto;
        private System.Windows.Forms.PictureBox pb_logo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_chegada;
        private System.Windows.Forms.Label lb_valor;
        private System.Windows.Forms.Label lb_forn;
        private System.Windows.Forms.Label lb_num_nfe;
        private System.Windows.Forms.Label lb_vencimentos;
        private System.Windows.Forms.ListBox lbx_vencimentos;
        private System.Windows.Forms.Panel painel_lista;
        private System.Windows.Forms.DateTimePicker dtp_Data;
        private System.Windows.Forms.Button btn_config;
        private System.Windows.Forms.Button btn_relatorio;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.Button btn_atualizar;
    }
}

