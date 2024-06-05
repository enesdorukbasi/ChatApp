namespace ChatAppServer.WebAPI.DTOs
{
    public sealed record SendMessageDTO(Guid PushedUserId, Guid ToUserId, string Message);
}
