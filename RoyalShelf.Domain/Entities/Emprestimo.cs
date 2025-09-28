namespace RoyalShelf.Domain.Entities
{
    public class Emprestimo
    {
        public int Id { get; private set; }
        public int UsuarioId { get; private set; }
        public int LivroId { get; private set; }
        public DateTime DtEmprestimo { get; private set; }
        public DateTime? DtDevolucao { get; private set; }


        public void RegistrarDevolucao(DateTime data)
        {
            DtDevolucao = data;
        }
    }
}
