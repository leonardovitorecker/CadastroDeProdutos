namespace ControleEstoque1
{
    partial class FrmProduto
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
            this.txt_CodBarras = new System.Windows.Forms.TextBox();
            this.txt_NomeProduto = new System.Windows.Forms.TextBox();
            this.txt_Validade = new System.Windows.Forms.TextBox();
            this.txt_Fabricante = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Fabricante = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_CodProd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // bntNovo
            // 
            this.bntNovo.FlatAppearance.BorderSize = 0;
            this.bntNovo.Click += new System.EventHandler(this.bntNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txt_CodBarras
            // 
            this.txt_CodBarras.Location = new System.Drawing.Point(37, 178);
            this.txt_CodBarras.Name = "txt_CodBarras";
            this.txt_CodBarras.Size = new System.Drawing.Size(222, 20);
            this.txt_CodBarras.TabIndex = 2;
            // 
            // txt_NomeProduto
            // 
            this.txt_NomeProduto.Location = new System.Drawing.Point(37, 229);
            this.txt_NomeProduto.Name = "txt_NomeProduto";
            this.txt_NomeProduto.Size = new System.Drawing.Size(222, 20);
            this.txt_NomeProduto.TabIndex = 3;
            // 
            // txt_Validade
            // 
            this.txt_Validade.Location = new System.Drawing.Point(37, 337);
            this.txt_Validade.Name = "txt_Validade";
            this.txt_Validade.Size = new System.Drawing.Size(222, 20);
            this.txt_Validade.TabIndex = 4;
            // 
            // txt_Fabricante
            // 
            this.txt_Fabricante.Location = new System.Drawing.Point(37, 277);
            this.txt_Fabricante.Name = "txt_Fabricante";
            this.txt_Fabricante.Size = new System.Drawing.Size(222, 20);
            this.txt_Fabricante.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Codigo de Barras";
            // 
            // Fabricante
            // 
            this.Fabricante.AutoSize = true;
            this.Fabricante.Location = new System.Drawing.Point(34, 261);
            this.Fabricante.Name = "Fabricante";
            this.Fabricante.Size = new System.Drawing.Size(57, 13);
            this.Fabricante.TabIndex = 7;
            this.Fabricante.Text = "Fabricante";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Validade";
            // 
            // txt_CodProd
            // 
            this.txt_CodProd.Location = new System.Drawing.Point(35, 139);
            this.txt_CodProd.Name = "txt_CodProd";
            this.txt_CodProd.Size = new System.Drawing.Size(222, 20);
            this.txt_CodProd.TabIndex = 11;
           
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Codigo do Produto";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(325, 162);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(449, 150);
            this.dataGridView2.TabIndex = 12;
           
            this.dataGridView2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView2_MouseDoubleClick);
            // 
            // FrmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_CodProd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Fabricante);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Fabricante);
            this.Controls.Add(this.txt_Validade);
            this.Controls.Add(this.txt_NomeProduto);
            this.Controls.Add(this.txt_CodBarras);
            this.Name = "FrmProduto";
            this.Controls.SetChildIndex(this.txt_CodBarras, 0);
            this.Controls.SetChildIndex(this.txt_NomeProduto, 0);
            this.Controls.SetChildIndex(this.txt_Validade, 0);
            this.Controls.SetChildIndex(this.txt_Fabricante, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.Fabricante, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txt_CodProd, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.dataGridView2, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_CodBarras;
        private System.Windows.Forms.TextBox txt_NomeProduto;
        private System.Windows.Forms.TextBox txt_Validade;
        private System.Windows.Forms.TextBox txt_Fabricante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Fabricante;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_CodProd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}
