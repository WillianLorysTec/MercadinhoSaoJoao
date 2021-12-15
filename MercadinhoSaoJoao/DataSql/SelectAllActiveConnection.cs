using System.Data.SqlClient;
using Dapper;
using MercadinhoSaoJoao.DataContext;

namespace MercadinhoSaoJoao.DataSql
{
    public class SelectAllActiveConnection
    { 
       
        public void SelectAllActive()
        {

            const string stringconnection = "Server=localhost;Database=MercadinhoSJ;Trusted_Connection=True;";
            var SqlSelectAllActive = @"SELECT * FROM [Cliente] WHERE [Active] = 1";

            using (SqlConnection connection = new SqlConnection(stringconnection))
            {
                connection.Open();

                var reader = connection.Query<Cliente>(SqlSelectAllActive);

                foreach (var item in reader)
                {
                    Console.WriteLine($"{item.Id}, {item.Name}, {item.Telephone}, {item.RG}, {item.CPF}, {item.Active}");
                }

            };
            
        }
    }
}
