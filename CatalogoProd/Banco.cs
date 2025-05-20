using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace CatalogoProd
{
    internal class Banco
    {
        //private static string connectionString = "Server=localhost\\SQLEXPRESS;Database=CatalogoProd;" + "Integrated_Security=True;";
        private static string connectionString = "Server=localhost\\SQLEXPRESS;Database=CatalogoProd;" +  "Trusted_Connection=True;";

        public static void InserirFavorito(Produto produto)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Favoritos (IdProdutoAPI, Titulo, Preco, Categoria) VALUES (@Id, @Titulo, @Preco, @Categoria)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", produto.id);
                cmd.Parameters.AddWithValue("@Titulo", produto.title);
                cmd.Parameters.AddWithValue("@Preco", produto.price);
                cmd.Parameters.AddWithValue("@Categoria", produto.category);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public static List<Produto> ListarFavoritos()
        {
            var lista = new List<Produto>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT IdProdutoAPI, Titulo, Preco, Categoria FROM Favoritos";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(new Produto
                    {
                        id = reader.GetInt32(0),
                        title = reader.GetString(1),
                        price = reader.GetDecimal(2),
                        category = reader.GetString(3)
                    });
                }
            }
            return lista;
        }
    }
}
