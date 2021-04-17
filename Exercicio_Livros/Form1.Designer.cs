using System.Diagnostics.Tracing;

namespace Exercicio_Livros
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
            this.TABCONTROL1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lb_codigo = new System.Windows.Forms.Label();
            this.button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_preco = new System.Windows.Forms.TextBox();
            this.tb_estilo = new System.Windows.Forms.TextBox();
            this.tb_autor = new System.Windows.Forms.TextBox();
            this.tb_titulo = new System.Windows.Forms.TextBox();
            this.Grid1 = new System.Windows.Forms.DataGridView();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TITULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AUTOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTILO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PREÇO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rb_estilo = new System.Windows.Forms.RadioButton();
            this.rb_titulo = new System.Windows.Forms.RadioButton();
            this.rb_codigo = new System.Windows.Forms.RadioButton();
            this.tb_pesquisa = new System.Windows.Forms.TextBox();
            this.LB = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Grid2 = new System.Windows.Forms.DataGridView();
            this.CODIGO2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TITULO2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AUTOR2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTILO2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECO2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_media = new System.Windows.Forms.Label();
            this.TABCONTROL1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid2)).BeginInit();
            this.SuspendLayout();
            // 
            // TABCONTROL1
            // 
            this.TABCONTROL1.Controls.Add(this.tabPage1);
            this.TABCONTROL1.Controls.Add(this.tabPage2);
            this.TABCONTROL1.Location = new System.Drawing.Point(3, 1);
            this.TABCONTROL1.Name = "TABCONTROL1";
            this.TABCONTROL1.SelectedIndex = 0;
            this.TABCONTROL1.Size = new System.Drawing.Size(932, 452);
            this.TABCONTROL1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lb_media);
            this.tabPage1.Controls.Add(this.lb_codigo);
            this.tabPage1.Controls.Add(this.button);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tb_preco);
            this.tabPage1.Controls.Add(this.tb_estilo);
            this.tabPage1.Controls.Add(this.tb_autor);
            this.tabPage1.Controls.Add(this.tb_titulo);
            this.tabPage1.Controls.Add(this.Grid1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(924, 426);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "CADATRO";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lb_codigo
            // 
            this.lb_codigo.BackColor = System.Drawing.Color.Black;
            this.lb_codigo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_codigo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lb_codigo.Location = new System.Drawing.Point(66, 48);
            this.lb_codigo.Name = "lb_codigo";
            this.lb_codigo.Size = new System.Drawing.Size(188, 19);
            this.lb_codigo.TabIndex = 12;
            this.lb_codigo.Text = "1";
            this.lb_codigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button
            // 
            this.button.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button.Location = new System.Drawing.Point(470, 150);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(106, 51);
            this.button.TabIndex = 11;
            this.button.Text = "Cadastrar";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(466, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "PREÇO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(466, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "ESTILO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "AUTOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "TITULO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "CODIGO";
            // 
            // tb_preco
            // 
            this.tb_preco.Location = new System.Drawing.Point(470, 105);
            this.tb_preco.Name = "tb_preco";
            this.tb_preco.Size = new System.Drawing.Size(151, 20);
            this.tb_preco.TabIndex = 5;
            // 
            // tb_estilo
            // 
            this.tb_estilo.Location = new System.Drawing.Point(470, 47);
            this.tb_estilo.Name = "tb_estilo";
            this.tb_estilo.Size = new System.Drawing.Size(151, 20);
            this.tb_estilo.TabIndex = 4;
            // 
            // tb_autor
            // 
            this.tb_autor.Location = new System.Drawing.Point(64, 166);
            this.tb_autor.Name = "tb_autor";
            this.tb_autor.Size = new System.Drawing.Size(295, 20);
            this.tb_autor.TabIndex = 3;
            // 
            // tb_titulo
            // 
            this.tb_titulo.Location = new System.Drawing.Point(64, 105);
            this.tb_titulo.Name = "tb_titulo";
            this.tb_titulo.Size = new System.Drawing.Size(295, 20);
            this.tb_titulo.TabIndex = 2;
            // 
            // Grid1
            // 
            this.Grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO,
            this.TITULO,
            this.AUTOR,
            this.ESTILO,
            this.PREÇO});
            this.Grid1.Location = new System.Drawing.Point(35, 238);
            this.Grid1.Name = "Grid1";
            this.Grid1.Size = new System.Drawing.Size(651, 150);
            this.Grid1.TabIndex = 0;
            // 
            // CODIGO
            // 
            this.CODIGO.HeaderText = "CODIGO";
            this.CODIGO.Name = "CODIGO";
            // 
            // TITULO
            // 
            this.TITULO.HeaderText = "TITULO";
            this.TITULO.Name = "TITULO";
            // 
            // AUTOR
            // 
            this.AUTOR.HeaderText = "AUTOR";
            this.AUTOR.Name = "AUTOR";
            // 
            // ESTILO
            // 
            this.ESTILO.HeaderText = "ESTILO";
            this.ESTILO.Name = "ESTILO";
            // 
            // PREÇO
            // 
            this.PREÇO.HeaderText = "PREÇO";
            this.PREÇO.Name = "PREÇO";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.rb_estilo);
            this.tabPage2.Controls.Add(this.rb_titulo);
            this.tabPage2.Controls.Add(this.rb_codigo);
            this.tabPage2.Controls.Add(this.tb_pesquisa);
            this.tabPage2.Controls.Add(this.LB);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.Grid2);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(924, 426);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "PESQUISAR";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rb_estilo
            // 
            this.rb_estilo.AutoSize = true;
            this.rb_estilo.Location = new System.Drawing.Point(259, 142);
            this.rb_estilo.Name = "rb_estilo";
            this.rb_estilo.Size = new System.Drawing.Size(71, 17);
            this.rb_estilo.TabIndex = 10;
            this.rb_estilo.TabStop = true;
            this.rb_estilo.Text = "ESTILO  ";
            this.rb_estilo.UseVisualStyleBackColor = true;
            // 
            // rb_titulo
            // 
            this.rb_titulo.AutoSize = true;
            this.rb_titulo.Location = new System.Drawing.Point(258, 100);
            this.rb_titulo.Name = "rb_titulo";
            this.rb_titulo.Size = new System.Drawing.Size(72, 17);
            this.rb_titulo.TabIndex = 9;
            this.rb_titulo.TabStop = true;
            this.rb_titulo.Text = "TITULO  ";
            this.rb_titulo.UseVisualStyleBackColor = true;
            // 
            // rb_codigo
            // 
            this.rb_codigo.AutoSize = true;
            this.rb_codigo.Location = new System.Drawing.Point(255, 59);
            this.rb_codigo.Name = "rb_codigo";
            this.rb_codigo.Size = new System.Drawing.Size(75, 17);
            this.rb_codigo.TabIndex = 8;
            this.rb_codigo.TabStop = true;
            this.rb_codigo.Text = "CODIGO";
            this.rb_codigo.UseVisualStyleBackColor = true;
            this.rb_codigo.CheckedChanged += new System.EventHandler(this.rb_codigo_CheckedChanged);
            // 
            // tb_pesquisa
            // 
            this.tb_pesquisa.Location = new System.Drawing.Point(52, 97);
            this.tb_pesquisa.Name = "tb_pesquisa";
            this.tb_pesquisa.Size = new System.Drawing.Size(149, 20);
            this.tb_pesquisa.TabIndex = 7;
            // 
            // LB
            // 
            this.LB.AutoSize = true;
            this.LB.Location = new System.Drawing.Point(62, 63);
            this.LB.Name = "LB";
            this.LB.Size = new System.Drawing.Size(94, 13);
            this.LB.TabIndex = 6;
            this.LB.Text = "PESQUISE AQUI";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LawnGreen;
            this.button1.Location = new System.Drawing.Point(451, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 58);
            this.button1.TabIndex = 5;
            this.button1.Text = "PESQUISAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Grid2
            // 
            this.Grid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO2,
            this.TITULO2,
            this.AUTOR2,
            this.ESTILO2,
            this.PRECO2});
            this.Grid2.Location = new System.Drawing.Point(40, 227);
            this.Grid2.Name = "Grid2";
            this.Grid2.Size = new System.Drawing.Size(627, 176);
            this.Grid2.TabIndex = 0;
            // 
            // CODIGO2
            // 
            this.CODIGO2.HeaderText = "CODIGO";
            this.CODIGO2.Name = "CODIGO2";
            // 
            // TITULO2
            // 
            this.TITULO2.HeaderText = "TITULO";
            this.TITULO2.Name = "TITULO2";
            // 
            // AUTOR2
            // 
            this.AUTOR2.HeaderText = "AUTOR";
            this.AUTOR2.Name = "AUTOR2";
            // 
            // ESTILO2
            // 
            this.ESTILO2.HeaderText = "ESTILO";
            this.ESTILO2.Name = "ESTILO2";
            // 
            // PRECO2
            // 
            this.PRECO2.HeaderText = "PREÇO";
            this.PRECO2.Name = "PRECO2";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.DarkOrange;
            this.label6.Location = new System.Drawing.Point(37, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(386, 197);
            this.label6.TabIndex = 11;
            // 
            // lb_media
            // 
            this.lb_media.BackColor = System.Drawing.Color.Black;
            this.lb_media.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_media.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lb_media.Location = new System.Drawing.Point(40, 391);
            this.lb_media.Name = "lb_media";
            this.lb_media.Size = new System.Drawing.Size(146, 19);
            this.lb_media.TabIndex = 13;
            this.lb_media.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(779, 447);
            this.Controls.Add(this.TABCONTROL1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "LOJA DE LIVROS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TABCONTROL1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TABCONTROL1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tb_preco;
        private System.Windows.Forms.TextBox tb_estilo;
        private System.Windows.Forms.TextBox tb_autor;
        private System.Windows.Forms.TextBox tb_titulo;
        private System.Windows.Forms.DataGridView Grid1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TITULO;
        private System.Windows.Forms.DataGridViewTextBoxColumn AUTOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTILO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PREÇO;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label lb_codigo;
        private System.Windows.Forms.DataGridView Grid2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TITULO2;
        private System.Windows.Forms.DataGridViewTextBoxColumn AUTOR2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTILO2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECO2;
        private System.Windows.Forms.TextBox tb_pesquisa;
        private System.Windows.Forms.Label LB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rb_titulo;
        private System.Windows.Forms.RadioButton rb_codigo;
        private System.Windows.Forms.RadioButton rb_estilo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_media;
    }
}

