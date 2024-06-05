using ChatAppServer.WebAPI.Context;
using ChatAppServer.WebAPI.DTOs;
using ChatAppServer.WebAPI.Hubs;
using ChatAppServer.WebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;

namespace ChatAppServer.WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public sealed class ChatController(SqlDbContext context, IHubContext<ChatHub> hubContext) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            List<AppUser> users = await context.Users.OrderBy(x => x.Name).ToListAsync();
            return Ok(users);
        }

        [HttpGet]
        public async Task<IActionResult> GetChats(Guid userId, Guid toUserId, CancellationToken cancellationToken)
        {
            List<Chat> chats = await context.Chats.Where(x => x.PushedUserId == userId && x.ToUserId == toUserId ||
            x.ToUserId == userId && x.PushedUserId == toUserId).OrderBy(x => x.PushedDate).ToListAsync();
            return Ok(chats);
        }

        [HttpPost]
        public async Task<IActionResult> SendMessage(SendMessageDTO request, CancellationToken cancellationToken)
        {
            Chat chat = new()
            {
                PushedUserId = request.PushedUserId,
                ToUserId = request.ToUserId,
                Message = request.Message,
                PushedDate = DateTime.Now,
            };
            await context.Chats.AddAsync(chat, cancellationToken);
            await context.SaveChangesAsync(cancellationToken);
            string connectionId = ChatHub.Users.First(x => x.Value == chat.ToUserId).Key;
            await hubContext.Clients.Client(connectionId).SendAsync("Messages", chat);
            return Ok(chat);
        }
    }
}
