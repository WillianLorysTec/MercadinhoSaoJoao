namespace MercadinhoSaoJoao.DataContext
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Telephone { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public bool Active { get; set; }
    }
}
