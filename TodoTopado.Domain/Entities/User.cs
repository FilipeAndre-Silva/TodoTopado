namespace TodoTopado.Domain.Entities
{
    public class User : BasicEntity
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Rule { get; set; }
        public ICollection<Todo> Todos { get; set; }
    }
}