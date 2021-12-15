using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadinhoSaoJoao.DataSql
{
    public class DeleteConnection
    {
        const string stringconnection = "Server=localhost;Database=MercadinhoSJ;Trusted_Connection=True;";
        const string SqlDelete = "DELETE FROM [Cliente] WHERE Id = @Id";

        
       
        public void Delete()
        {
            Console.Write("Digite o ID para REMOVER: ");
            int id = int.Parse(Console.ReadLine());

            using (SqlConnection connection = new SqlConnection()) 
            {
                connection.Open();

                var rows = connection.Execute(SqlDelete, new
                {
                    @id = id
                });

                Console.WriteLine($"{rows} registros afetados");
            }
        }
    }
}
