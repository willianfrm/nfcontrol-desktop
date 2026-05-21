
namespace Recebimento_NFS
{
    partial class Imprimir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Imprimir));
            this.lv_lista_notas_dia = new System.Windows.Forms.ListView();
            this.numero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.serie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nome_forn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cnpj_forn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hora = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.valor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.lb_impressora = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // lv_lista_notas_dia
            // 
            this.lv_lista_notas_dia.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.numero,
            this.serie,
            this.nome_forn,
            this.cnpj_forn,
            this.data,
            this.hora,
            this.valor});
            this.lv_lista_notas_dia.HideSelection = false;
            this.lv_lista_notas_dia.Location = new System.Drawing.Point(12, 75);
            this.lv_lista_notas_dia.Name = "lv_lista_notas_dia";
            this.lv_lista_notas_dia.Size = new System.Drawing.Size(679, 393);
            this.lv_lista_notas_dia.TabIndex = 1;
            this.lv_lista_notas_dia.UseCompatibleStateImageBehavior = false;
            this.lv_lista_notas_dia.View = System.Windows.Forms.View.Details;
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
            // btn_imprimir
            // 
            this.btn_imprimir.Location = new System.Drawing.Point(34, 12);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(76, 57);
            this.btn_imprimir.TabIndex = 2;
            this.btn_imprimir.Text = "Imprimir";
            this.btn_imprimir.UseVisualStyleBackColor = true;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // lb_impressora
            // 
            this.lb_impressora.AutoSize = true;
            this.lb_impressora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_impressora.Location = new System.Drawing.Point(139, 30);
            this.lb_impressora.Name = "lb_impressora";
            this.lb_impressora.Size = new System.Drawing.Size(82, 16);
            this.lb_impressora.TabIndex = 3;
            this.lb_impressora.Text = "Impressora: ";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Imprimir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 480);
            this.Controls.Add(this.lb_impressora);
            this.Controls.Add(this.btn_imprimir);
            this.Controls.Add(this.lv_lista_notas_dia);
            this.MaximizeBox = false;
            this.Name = "Imprimir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Imprimir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_lista_notas_dia;
        private System.Windows.Forms.ColumnHeader numero;
        private System.Windows.Forms.ColumnHeader serie;
        private System.Windows.Forms.ColumnHeader nome_forn;
        private System.Windows.Forms.ColumnHeader cnpj_forn;
        private System.Windows.Forms.ColumnHeader data;
        private System.Windows.Forms.ColumnHeader hora;
        private System.Windows.Forms.ColumnHeader valor;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Label lb_impressora;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}