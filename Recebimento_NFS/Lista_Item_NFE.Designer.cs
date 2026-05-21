
namespace Recebimento_NFS
{
    partial class Lista_Item_NFE
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
            this.lb_numero_chave = new System.Windows.Forms.Label();
            this.tb_chave = new System.Windows.Forms.TextBox();
            this.lb_fornecedor = new System.Windows.Forms.Label();
            this.lb_valor = new System.Windows.Forms.Label();
            this.lb_horario = new System.Windows.Forms.Label();
            this.lb_vencimentos = new System.Windows.Forms.Label();
            this.lbx_vencimentos = new System.Windows.Forms.ListBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_numero_chave
            // 
            this.lb_numero_chave.AutoSize = true;
            this.lb_numero_chave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_numero_chave.Location = new System.Drawing.Point(37, 7);
            this.lb_numero_chave.Name = "lb_numero_chave";
            this.lb_numero_chave.Size = new System.Drawing.Size(177, 25);
            this.lb_numero_chave.TabIndex = 0;
            this.lb_numero_chave.Text = "00000000 - 000";
            // 
            // tb_chave
            // 
            this.tb_chave.Location = new System.Drawing.Point(42, 69);
            this.tb_chave.Name = "tb_chave";
            this.tb_chave.Size = new System.Drawing.Size(284, 20);
            this.tb_chave.TabIndex = 1;
            this.tb_chave.Text = "01234567890123456789012345678901234567890123";
            this.tb_chave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_chave_KeyDown);
            // 
            // lb_fornecedor
            // 
            this.lb_fornecedor.AutoSize = true;
            this.lb_fornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_fornecedor.Location = new System.Drawing.Point(42, 41);
            this.lb_fornecedor.Name = "lb_fornecedor";
            this.lb_fornecedor.Size = new System.Drawing.Size(133, 16);
            this.lb_fornecedor.TabIndex = 2;
            this.lb_fornecedor.Text = "Fornecedor Nome";
            // 
            // lb_valor
            // 
            this.lb_valor.AutoSize = true;
            this.lb_valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_valor.Location = new System.Drawing.Point(394, 14);
            this.lb_valor.Name = "lb_valor";
            this.lb_valor.Size = new System.Drawing.Size(87, 16);
            this.lb_valor.TabIndex = 3;
            this.lb_valor.Text = "R$ 1.000,00";
            // 
            // lb_horario
            // 
            this.lb_horario.AutoSize = true;
            this.lb_horario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_horario.Location = new System.Drawing.Point(394, 39);
            this.lb_horario.Name = "lb_horario";
            this.lb_horario.Size = new System.Drawing.Size(137, 13);
            this.lb_horario.TabIndex = 3;
            this.lb_horario.Text = "00/00/0000   00:00:00";
            // 
            // lb_vencimentos
            // 
            this.lb_vencimentos.AutoSize = true;
            this.lb_vencimentos.Location = new System.Drawing.Point(683, 8);
            this.lb_vencimentos.Name = "lb_vencimentos";
            this.lb_vencimentos.Size = new System.Drawing.Size(68, 13);
            this.lb_vencimentos.TabIndex = 4;
            this.lb_vencimentos.Text = "Vencimentos";
            // 
            // lbx_vencimentos
            // 
            this.lbx_vencimentos.FormattingEnabled = true;
            this.lbx_vencimentos.Location = new System.Drawing.Point(687, 22);
            this.lbx_vencimentos.Name = "lbx_vencimentos";
            this.lbx_vencimentos.Size = new System.Drawing.Size(139, 69);
            this.lbx_vencimentos.TabIndex = 5;
            // 
            // groupBox
            // 
            this.groupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox.Controls.Add(this.btn_excluir);
            this.groupBox.Controls.Add(this.lb_numero_chave);
            this.groupBox.Controls.Add(this.lbx_vencimentos);
            this.groupBox.Controls.Add(this.tb_chave);
            this.groupBox.Controls.Add(this.lb_vencimentos);
            this.groupBox.Controls.Add(this.lb_fornecedor);
            this.groupBox.Controls.Add(this.lb_horario);
            this.groupBox.Controls.Add(this.lb_valor);
            this.groupBox.Location = new System.Drawing.Point(3, -3);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(929, 94);
            this.groupBox.TabIndex = 6;
            this.groupBox.TabStop = false;
            // 
            // btn_excluir
            // 
            this.btn_excluir.BackgroundImage = global::Recebimento_NFS.Properties.Resources.lixeira;
            this.btn_excluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_excluir.Location = new System.Drawing.Point(843, 15);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(75, 69);
            this.btn_excluir.TabIndex = 6;
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // Lista_Item_NFE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Controls.Add(this.groupBox);
            this.Name = "Lista_Item_NFE";
            this.Size = new System.Drawing.Size(935, 93);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_numero_chave;
        private System.Windows.Forms.TextBox tb_chave;
        private System.Windows.Forms.Label lb_fornecedor;
        private System.Windows.Forms.Label lb_valor;
        private System.Windows.Forms.Label lb_horario;
        private System.Windows.Forms.Label lb_vencimentos;
        private System.Windows.Forms.ListBox lbx_vencimentos;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button btn_excluir;
    }
}
