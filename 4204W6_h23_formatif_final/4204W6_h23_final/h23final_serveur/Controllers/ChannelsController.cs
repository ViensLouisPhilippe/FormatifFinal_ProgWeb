using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using h23final_serveur.Data;
using h23final_serveur.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace h23final_serveur.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ChannelsController : ControllerBase
    {
        private readonly h23final_serveurContext _context;

        public ChannelsController(h23final_serveurContext context)
        {
            _context = context;
        }

        // GET: api/Channels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Channel>>> GetChannel()
        {
            if (_context.Channel == null)
            {
                return NotFound();
            }
            return await _context.Channel.ToListAsync();
        }

        // ███ Ajoutez une action ici ███
        [HttpPost]
        [Authorize(Roles="moderator")]
        public async Task<ActionResult> PostChannel(string name)
        {
            User? user = await _context.Users.FindAsync(User.FindFirstValue(ClaimTypes.NameIdentifier));

            _context.Channel.Add(new Channel { Name = name });
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
