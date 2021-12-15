using MercadinhoSaoJoao.DataSql;

namespace MercadinhoSaoJoao
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("1 = Selecionar todos os registros com estado ACTIVE\n2 = Selecionar todos os registros\n3 = Inserir dados\n4 = Update por ID");
            Console.Write("DIGITE A OPÇÃO DESEJADA: ");
            int opcao = int.Parse(Console.ReadLine());
            Console.Clear();

            do
            {
                switch (opcao)
                {
                    case 1:
                        var selectallconnectionactive = new SelectAllActiveConnection();
                        selectallconnectionactive.SelectAllActive();
                        break;
                    case 2:
                        var selectallconnection = new SelectAllConnection();
                        selectallconnection.SelectAll();
                        break;
                    case 3:
                        var insertconnection = new InsertConnection();
                        insertconnection.Insert();
                        break;
                    case 4:
                        var updateById = new UpdateConnection();
                        updateById.Update();
                        break;
                    case 5:
                        var deleteById = new DeleteConnection();
                        deleteById.Delete();
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        Main();
                        break;

                }
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
            
        }


    }
}
