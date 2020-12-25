using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace IdeaAppBlazor.Models
{
    public class IdeaRepository : IIdeaRepository
    {
        private readonly ApplicationDbContext _context;

        public IdeaRepository(ApplicationDbContext context)
        {
            this._context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<Idea> AddIdea(Idea idea)
        {
            _context.Add(idea);

            await _context.SaveChangesAsync();

            return idea;
        }

        public async Task<List<Idea>> GetAll()
        {
            return await _context.Ideas.ToListAsync();
        }
    }
}
