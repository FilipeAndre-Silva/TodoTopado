namespace TodoTopado.Domain.Entities
{
    public abstract class BasicEntity
    {
        public int Id { get; private set; }
        public DateTime CreationDate { get; private set; }
        public DateTime ChangeDate { get; private set; }

        public void AddCreationDate()
        {
            CreationDate = DateTime.Now;
        }

        public void AddChangeDate()
        {
            ChangeDate = DateTime.Now;
        }
    }
}