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
    public class SelectById
    {
        public void SelectId()
        {
            const string stringconnection = "Server=localhost;Database=MercadinhoSJ;Trusted_Connection=True;";
            var SqlSelectId = @"SELECT * FROM [Cliente] WHERE [Active] = 1";


            try
            {
                using (SqlConnection connection = new SqlConnection())
                {
                    connection.Open();

                    var reader = connection.Query<Cliente>(SqlSelectId);

                    foreach (var item in reader)
                    {
                        Console.WriteLine($"{item.Id} - {item.Name} - {item.Telephone} - {item.RG} - {item.CPF} {item.Active}");
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
