﻿using Microsoft.EntityFrameworkCore;
using Movie.Web.Models.Domain;

namespace Movie.Web.Data.Services
{
    public class ActorsService : IActorsService
    {
        private readonly ApplicationDbContext _context;

        public ActorsService(ApplicationDbContext context)
        {
            _context = context; 
        }

        public void Add(Actor actor)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Actor>> GetAll()
        {
            var result =await _context.Actors.ToListAsync();  
            return result;  
        }

        public Actor GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Actor Update(int id, Actor newActor)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Actor>> IActorsService.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
