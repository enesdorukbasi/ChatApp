namespace ChatAppServer.WebAPI.Models
{
    public class Chat
    {
        public Chat()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public Guid PushedUserId { get; set; }
        public Guid ToUserId { get; set; }
        public string Message { get; set; } = string.Empty;
        public DateTime PushedDate { get; set; }
    }
}
