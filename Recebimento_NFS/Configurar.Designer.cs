
namespace Recebimento_NFS
{
    partial class Configurar
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
            this.tb_servidor = new System.Windows.Forms.TextBox();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.lb_servidor = new System.Windows.Forms.Label();
            this.tb_banco = new System.Windows.Forms.TextBox();
            this.lb_banco = new System.Windows.Forms.Label();
            this.tb_usuario = new System.Windows.Forms.TextBox();
            this.lb_usuario = new System.Windows.Forms.Label();
            this.tb_senha = new System.Windows.Forms.TextBox();
            this.lb_senha = new System.Windows.Forms.Label();
            this.btn_checar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.tb_resultados = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_servidor
            // 
            this.tb_servidor.Location = new System.Drawing.Point(35, 45);
            this.tb_servidor.Name = "tb_servidor";
            this.tb_servidor.Size = new System.Drawing.Size(301, 20);
            this.tb_servidor.TabIndex = 0;
            // 
            // lb_titulo
            // 
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titulo.Location = new System.Drawing.Point(94, 9);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(171, 16);
            this.lb_titulo.TabIndex = 7;
            this.lb_titulo.Text = "Configurar banco de dados";
            // 
            // lb_servidor
            // 
            this.lb_servidor.AutoSize = true;
            this.lb_servidor.Location = new System.Drawing.Point(32, 29);
            this.lb_servidor.Name = "lb_servidor";
            this.lb_servidor.Size = new System.Drawing.Size(46, 13);
            this.lb_servidor.TabIndex = 8;
            this.lb_servidor.Text = "Servidor";
            // 
            // tb_banco
            // 
            this.tb_banco.Location = new System.Drawing.Point(35, 84);
            this.tb_banco.Name = "tb_banco";
            this.tb_banco.Size = new System.Drawing.Size(301, 20);
            this.tb_banco.TabIndex = 1;
            // 
            // lb_banco
            // 
            this.lb_banco.AutoSize = true;
            this.lb_banco.Location = new System.Drawing.Point(32, 68);
            this.lb_banco.Name = "lb_banco";
            this.lb_banco.Size = new System.Drawing.Size(38, 13);
            this.lb_banco.TabIndex = 9;
            this.lb_banco.Text = "Banco";
            // 
            // tb_usuario
            // 
            this.tb_usuario.Location = new System.Drawing.Point(35, 123);
            this.tb_usuario.Name = "tb_usuario";
            this.tb_usuario.Size = new System.Drawing.Size(301, 20);
            this.tb_usuario.TabIndex = 2;
            // 
            // lb_usuario
            // 
            this.lb_usuario.AutoSize = true;
            this.lb_usuario.Location = new System.Drawing.Point(32, 107);
            this.lb_usuario.Name = "lb_usuario";
            this.lb_usuario.Size = new System.Drawing.Size(43, 13);
            this.lb_usuario.TabIndex = 10;
            this.lb_usuario.Text = "Usuário";
            // 
            // tb_senha
            // 
            this.tb_senha.Location = new System.Drawing.Point(35, 162);
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.PasswordChar = '*';
            this.tb_senha.Size = new System.Drawing.Size(301, 20);
            this.tb_senha.TabIndex = 3;
            // 
            // lb_senha
            // 
            this.lb_senha.AutoSize = true;
            this.lb_senha.Location = new System.Drawing.Point(32, 146);
            this.lb_senha.Name = "lb_senha";
            this.lb_senha.Size = new System.Drawing.Size(38, 13);
            this.lb_senha.TabIndex = 11;
            this.lb_senha.Text = "Senha";
            // 
            // btn_checar
            // 
            this.btn_checar.Location = new System.Drawing.Point(49, 188);
            this.btn_checar.Name = "btn_checar";
            this.btn_checar.Size = new System.Drawing.Size(126, 30);
            this.btn_checar.TabIndex = 4;
            this.btn_checar.Text = "Checar conexão";
            this.btn_checar.UseVisualStyleBackColor = true;
            this.btn_checar.Click += new System.EventHandler(this.btn_checar_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(194, 188);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(126, 30);
            this.btn_salvar.TabIndex = 5;
            this.btn_salvar.Text = "Salvar Informações";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // tb_resultados
            // 
            this.tb_resultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_resultados.Location = new System.Drawing.Point(35, 229);
            this.tb_resultados.Multiline = true;
            this.tb_resultados.Name = "tb_resultados";
            this.tb_resultados.Size = new System.Drawing.Size(301, 57);
            this.tb_resultados.TabIndex = 6;
            // 
            // Configurar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(369, 301);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.btn_checar);
            this.Controls.Add(this.lb_senha);
            this.Controls.Add(this.lb_usuario);
            this.Controls.Add(this.lb_banco);
            this.Controls.Add(this.lb_servidor);
            this.Controls.Add(this.lb_titulo);
            this.Controls.Add(this.tb_resultados);
            this.Controls.Add(this.tb_senha);
            this.Controls.Add(this.tb_usuario);
            this.Controls.Add(this.tb_banco);
            this.Controls.Add(this.tb_servidor);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Configurar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_servidor;
        private System.Windows.Forms.Label lb_titulo;
        private System.Windows.Forms.Label lb_servidor;
        private System.Windows.Forms.TextBox tb_banco;
        private System.Windows.Forms.Label lb_banco;
        private System.Windows.Forms.TextBox tb_usuario;
        private System.Windows.Forms.Label lb_usuario;
        private System.Windows.Forms.TextBox tb_senha;
        private System.Windows.Forms.Label lb_senha;
        private System.Windows.Forms.Button btn_checar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.TextBox tb_resultados;
    }
}