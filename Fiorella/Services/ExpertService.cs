using System;
using Fiorella.Models;
using Fiorella.Services.Interfaces;
using Fiorella.ViewModels.Expert;
using Microsoft.EntityFrameworkCore;

namespace Fiorella.Services
{
    public class ExpertService : IExpertService
    {
        private readonly AppDbContext _context;
        public ExpertService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<ExpertVM>> GetAllAsync()
        {
            IEnumerable<Expert> experts = await _context.Experts.ToListAsync();
            return experts.Select(m => new ExpertVM { FullName = m.FullName, Image = m.Image, Position = m.Position });
        }
    }
}

