namespace AplicacaoMVCLinq.Models
{
    public class Clientes
    {
        public int ClientesId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateOnly DataNasc { get; set; }

        public Clientes(int id, string nome, string email, string telefone, DateOnly dateNasc)
        {
            this.ClientesId = id;
            this.Nome = nome;
            this.Email = email;
            this.Telefone = telefone;
            this.DataNasc = dateNasc;
        }
    }
}
