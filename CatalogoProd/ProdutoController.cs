using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Json;

namespace CatalogoProd
{
    internal class ProdutoController
    {
        public async Task<List<Produto>> ObterProdutosAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                var resposta = await client.GetAsync("https://fakestoreapi.com/products");
                resposta.EnsureSuccessStatusCode();
                var json = await resposta.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<List<Produto>>(json);
            }
        }
    }
}

