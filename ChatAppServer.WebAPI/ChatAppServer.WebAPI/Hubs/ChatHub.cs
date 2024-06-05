using ChatAppServer.WebAPI.Context;
using ChatAppServer.WebAPI.Models;
using Microsoft.AspNetCore.SignalR;

namespace ChatAppServer.WebAPI.Hubs
{
    public sealed class ChatHub(SqlDbContext context) : Hub
    {
        public static Dictionary<string, Guid> Users = new Dictionary<string, Guid>();

        public async Task Connect(Guid appUserId)
        {
            Users.Add(Context.ConnectionId, appUserId);
            AppUser? user = await context.Users.FindAsync(appUserId);
            if (user is not null)
            {
                user.Status = "Online";
                await context.SaveChangesAsync();
                await Clients.All.SendAsync("Users", user);
            }
        }

        public override async Task OnDisconnectedAsync(Exception? exception)
        {
            Users.TryGetValue(Context.ConnectionId, out Guid appUserId);
            Users.Remove(Context.ConnectionId);
            AppUser? user = await context.Users.FindAsync(appUserId);
            if (user is not null)
            {
                user.Status = "Offline";
                await context.SaveChangesAsync();
                await Clients.All.SendAsync("Users", user);
            }
        }
    }
}
