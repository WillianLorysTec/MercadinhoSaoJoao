using MercadinhoSaoJoao.DataSql;

namespace MercadinhoSaoJoao
{
    public class Program
    {
        static void Main()
        {
            // dentro de cada método criar o retorno para o MAIN()
            Console.WriteLine("0 = Sair\n1 = Selecionar todos os registros com estado ACTIVE\n2 = Selecionar todos os registros\n3 = Inserir dados\n4 = Update por ID\n5 = Delete por ID\n6 = Alterar State para INATIVO");
            Console.Write("DIGITE A OPÇÃO DESEJADA: ");
            int opcao = int.Parse(Console.ReadLine());
            Console.Clear();
            
                switch (opcao)
                {
                    case 0:
                        System.Environment.Exit(0);
                        break;
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
                    case 6:
                        var deleteState = new DeleteState();
                        deleteState.DeleteSetState();
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        Main();
                        break;

                
            }
            
            
        }


    }
}
