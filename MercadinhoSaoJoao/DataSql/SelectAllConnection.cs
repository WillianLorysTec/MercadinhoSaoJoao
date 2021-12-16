using Dapper;
using MercadinhoSaoJoao.DataContext;
using System.Data.SqlClient;

namespace MercadinhoSaoJoao.DataSql
{
    public class SelectAllConnection
    {
        const string SqlSelectAll = @"SELECT * FROM [Cliente]";
        const string stringconnection = "Server=localhost;Database=MercadinhoSJ;Trusted_Connection=True;";

        public void SelectAll()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(stringconnection))
                {
                    connection.Open();
                    var reader = connection.Query<Cliente>(SqlSelectAll);

                    foreach (var item in reader)
                    {
                        Console.WriteLine($"{item.Id}, {item.Name}, {item.Telephone}, {item.RG}, {item.CPF}, {item.Active}");
                    }
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
        
    }
}
