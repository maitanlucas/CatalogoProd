using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatalogoProd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.CurrentRow != null)
            {
                var produto = (Produto)dgvProdutos.CurrentRow.DataBoundItem;

                try
                {
                    Banco.InserirFavorito(produto);
                    MessageBox.Show("Produto salvo como favorito!");
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627) // Erro de chave primária duplicada
                    {
                        MessageBox.Show("Este produto já está na lista de favoritos.");
                    }
                    else
                    {
                        MessageBox.Show("Erro ao salvar: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um produto para adicionar aos favoritos.");
            }
        }


        private async void btnCarregar_Click(object sender, EventArgs e)
        {
            var controller = new ProdutoController();
            var produtos = await controller.ObterProdutosAsync();
            dgvProdutos.DataSource = produtos;

            var categorias = produtos
                .Select(p => p.category)
                .Distinct()
                .OrderBy(c => c)
                .ToList();
            cmbCategoria.DataSource = categorias;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            decimal precoMin = 0, precoMax = decimal.MaxValue;
            var lista = (List<Produto>)dgvProdutos.DataSource;
            string categoria = cmbCategoria.Text;

            decimal.TryParse(txtPrecoMin.Text, out precoMin);
            decimal.TryParse(txtPrecoMax.Text, out precoMax);

            var filtrados = lista
                .Where(p => p.category == categoria && p.price >= precoMin && p.price <= precoMax)
                .ToList();
            dgvProdutos.DataSource = filtrados;
        }

        private void btnFavoritos_Click(object sender, EventArgs e)
        {
            dgvProdutos.DataSource = Banco.ListarFavoritos();
        }
    }
}
