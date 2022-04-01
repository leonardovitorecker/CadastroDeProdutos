using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ControleEstoque1
{
    public partial class FrmProduto : ControleEstoque1.FrmBase
    {
        public FrmProduto()
        {
            InitializeComponent();
            CarregarGrid1();
            BloqueiaCampos1();
           
        }
        private void CarregarGrid1()
        {
            Model get = new Model();
            List<DtoProduto2> lista = get.ListProdutos();
            this.dataGridView2.DataSource = lista;
            this.dataGridView2.Refresh();
        }

        private void bntNovo_Click(object sender, EventArgs e)
        {
           
            txt_CodBarras.Text= string.Empty;
            txt_NomeProduto.Text = string.Empty;
            txt_Fabricante.Text = string.Empty;
            txt_Validade.Text= string.Empty;
            LiberarCampos();
            txt_CodBarras.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Model set = new Model();
                DtoProduto p = new DtoProduto();
                p.codigobarras = txt_CodBarras.Text;
                p.nome = txt_NomeProduto.Text;
                p.fabricante = txt_Fabricante.Text;
                if (txt_CodProd.Text != string.Empty)
                {
                    p.id= int.Parse(txt_CodProd.Text);
                    set.EditProduto(p);
                }
                else
                {
                    set.SetProduto(p);
                }

                BloqueiaCampos1();
                CarregarGrid1();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

      // #region Tratamento Visual
        private void LiberarCampos()
        {
           txt_CodBarras.Enabled = true;
            txt_NomeProduto.Enabled = true;
            txt_Fabricante.Enabled = true;
            txt_Validade.Enabled = true;
            
        }
        private void BloqueiaCampos1()
        {
            txt_CodProd.Enabled = false;
            txt_CodBarras.Enabled = false;
            txt_NomeProduto.Enabled = false;
            txt_Fabricante.Enabled = false;
            txt_Validade.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            LiberarCampos();
            txt_CodBarras.Focus();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txt_CodProd.Text != string.Empty)
            {
                Model del = new Model();
                del.DeletarProduto(int.Parse(txt_CodProd.Text));
                BloqueiaCampos1();
                CarregarGrid1();
            }
        }



       
        

        private void dataGridView2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int id = (Int32)dataGridView2.CurrentRow.Cells[0].Value;

            Model get = new Model();
            DtoProduto2 p = get.GetProdutoId(id);
            txt_CodProd.Text = p.id.ToString();
            txt_CodBarras.Text = p.codigobarras.ToString();

            LiberarCampos();
            txt_NomeProduto.Focus();
        }
    
    }
    
}
