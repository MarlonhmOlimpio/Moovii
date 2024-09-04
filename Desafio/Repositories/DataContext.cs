using Desafio.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

namespace Desafio.Repositories;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options){}

    public DbSet<Livro> Livro { get; set;}

    internal void Add(Livro livro1, Livro livro2)
    {
        throw new NotImplementedException();
    }
}


