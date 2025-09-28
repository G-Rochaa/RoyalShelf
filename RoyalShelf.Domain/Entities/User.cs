namespace RoyalShelf.Domain.Entities
{
    public class User
    {
        public int Id { get; private set; }
        public string Nome { get; private set; } = string.Empty;
        public string Email { get; private set; } = string.Empty;
    }
}
