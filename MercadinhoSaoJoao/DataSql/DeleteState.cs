using Dapper;
using MercadinhoSaoJoao.DataContext;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadinhoSaoJoao.DataSql
{
    public class DeleteState
    {
        public void DeleteSetState()
        {
            const string stringconnection = "Server=localhost;Database=MercadinhoSJ;Trusted_Connection=True;";
            var SqlDeleteState = @"UPDATE [Cliente] SET [Active] = 0 WHERE Id = @Id";

            Cliente clientes = new Cliente();
            Console.Write("Digite o ID a ser alterado o STATE: ");
            clientes.Id = int.Parse(Console.ReadLine());


            using (SqlConnection connection = new SqlConnection(stringconnection))
            {
                connection.Open();

                var rows = connection.Execute(SqlDeleteState, new
                {
                    clientes.Id

                });
                Console.WriteLine($"{rows} registros afetados");

            }


        }
        
    }
}
