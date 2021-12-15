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
    public class UpdateConnection
    {
        const string stringconnection = "Server=localhost;Database=MercadinhoSJ;Trusted_Connection=True;";
        const string SqlUpdate = @"UPDATE [Cliente] SET Name = @Name, [Telephone] = @Telephone,
            [RG] = @RG, [CPF] = @CPF, [ACTIVE] = @ACTIVE
            WHERE Id = @Id";

        public void Update()
        {

            Cliente clientes = new Cliente();
            clientes.Name = "Joao Pedro";
            clientes.Telephone = "439999652217";
            clientes.RG = "1245667522";
            clientes.CPF = "4265478852";
            clientes.Active = false;

            Console.WriteLine("Digite o ID do cliente: ");
            int id = int.Parse(Console.ReadLine());
            clientes.Id = id;

            using (SqlConnection connection = new SqlConnection(stringconnection))
            {
                connection.Open();

               var rows = connection.Execute(SqlUpdate, new
                {
                    clientes.Name,
                    clientes.Telephone,
                    clientes.RG,
                    clientes.CPF,
                    clientes.Active,
                    clientes.Id

                });

                Console.WriteLine($"{rows} linhas afetadas");
            }
        }

    }
}
