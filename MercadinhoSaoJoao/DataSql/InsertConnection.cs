using Dapper;
using MercadinhoSaoJoao.DataContext;
using System.Data.SqlClient;

namespace MercadinhoSaoJoao.DataSql
{
    public class InsertConnection
    {
       

        const string stringconnection = "Server=localhost;Database=MercadinhoSJ;Trusted_Connection=True;";
        const string SqlInsert = @"INSERT INTO [Cliente] VALUES (
            @Name,
            @Telephone,
            @RG,
            @CPF,
            @Active);";

        public void Insert()
        {

            Cliente clientes = new Cliente();
            clientes.Name = "Joao";
            clientes.Telephone = "4398752241";
            clientes.RG = "145267894";
            clientes.CPF = "2167555755";
            clientes.Active = true;

            try
            {
                using (SqlConnection connection = new SqlConnection(stringconnection))
                {
                    connection.Open();

                    var rows = connection.Execute(SqlInsert, new
                    {
                        clientes.Name,
                        clientes.Telephone,
                        clientes.RG,
                        clientes.CPF,
                        clientes.Active

                    });
                    Console.WriteLine($"{rows} registros afetados");
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            
        }

        


      
    }
}
