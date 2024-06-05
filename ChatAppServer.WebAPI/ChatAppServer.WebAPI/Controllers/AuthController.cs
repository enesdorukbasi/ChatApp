using ChatAppServer.WebAPI.Context;
using ChatAppServer.WebAPI.DTOs;
using ChatAppServer.WebAPI.Models;
using GenericFileService.Files;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ChatAppServer.WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public sealed class AuthController(SqlDbContext context) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Register([FromForm] RegisterDTO request, CancellationToken cancellationToken)
        {
            bool isNameExists = await context.Users.AnyAsync(x => x.Name == request.Name, cancellationToken);
            if (isNameExists)
            {
                return BadRequest(new { Message = "Bu kullanıcı adı daha önce kullanılmış." });
            }
            string avatarUrl = FileService.FileSaveToServer(request.AvatarFile, "wwwroot/avatar/");
            AppUser user = new()
            {
                Name = request.Name,
                Avatar = avatarUrl
            };
            await context.Users.AddAsync(user, cancellationToken);
            await context.SaveChangesAsync(cancellationToken);
            return Ok(user);
        }

        [HttpGet]
        public async Task<IActionResult> Login(string name, CancellationToken cancellationToken)
        {
            AppUser? user = await context.Users.FirstOrDefaultAsync(x => x.Name == name, cancellationToken);
            if (user is null)
            {
                return BadRequest(new { Message = "Kullanıcı bulunamadı." });
            }
            user.Status = "Online";
            await context.SaveChangesAsync(cancellationToken);
            return Ok(user);
        }
    }
}
