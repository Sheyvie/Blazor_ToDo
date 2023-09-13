namespace ToDo.Models
{
    public class TaskDto
    {

        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } =string.Empty;
        public string Description { get; set; }= string.Empty;

        public string Importance { get; set; }=string.Empty;

    }
}
