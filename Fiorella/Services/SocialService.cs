using System;
using Fiorella.Models;
using Fiorella.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Fiorella.Services
{
	public class SocialService:ISocialService
	{
        private readonly AppDbContext _context;
		public SocialService(AppDbContext context)
		{
            _context = context;
		}

        public async Task<IEnumerable<Social>> GetAllAsync()
        {
            return await _context.Socials.ToListAsync();
        }
    }
}

