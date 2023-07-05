namespace TodoTopado.Domain.Entities
{
    public class Todo : BasicEntity
    {
        public Todo(string title, string description, DateTime deadLine)
        {
            Title = title;
            Description = description;
            Status = 1;
            IsActive = true;
            DeadLine = deadLine;
            AddCreationDate();
        }

        public int UserId { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public int Status { get; private set; }
        public bool IsActive { get; private set; }
        public DateTime DeadLine { get; private set; }

        public void UpdateTitle(string newTitle)
        {
            Title = newTitle;
        }

        public void UpdateDescription(string newDescription)
        {
            Description = newDescription;
        }

        public void UpdateStatusToDo()
        {
            Status = 1;
        }

        public void UpdateStatusToInProgress()
        {
            Status = 2;
        }

        public void UpdateStatusToDone()
        {
            Status = 3;
        }

        public void Disable()
        {
            IsActive = false;
        }

        public void UpdateDeadLine(DateTime newDeadLine)
        {
            DeadLine = newDeadLine;
        }
    }
}