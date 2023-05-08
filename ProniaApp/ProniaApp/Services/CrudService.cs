﻿using Microsoft.EntityFrameworkCore;
using ProniaApp.Data;
using ProniaApp.Models;
using ProniaApp.Services.Interfaces;

namespace ProniaApp.Services
{
    public class CrudService<T>:ICrudService<T> where T : BaseEntity
    {
        private readonly AppDbContext _context;
        private DbSet<T> entities;
        public CrudService(AppDbContext context)
        {
            _context = context;
            entities = context.Set<T>();
        }

        public async Task CreateAsync(T entity)
        {
            await entities.AddAsync(entity);
             _context.SaveChanges();
        }

        public void Delete(T entity)
        {
             entities.Remove(entity);
             _context.SaveChanges();
        }

        public void Edit(T entity)
        {
             entities.Update(entity);
            _context.SaveChanges();
        }

        public async Task SaveAsync()
        {
           await _context.SaveChangesAsync();
        }
    }
}
