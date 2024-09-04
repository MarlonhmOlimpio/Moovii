using Desafio.Models;
using Microsoft.EntityFrameworkCore;

namespace Desafio.Repositories;

public interface ILivroRepository
{
    List<Livro> Read();

    void Create(Livro livro);
    void Delete(Guid Id);
    void Update(Livro livro);

}

public class LivroRepository : ILivroRepository
{

    private DataContext _context;

    public LivroRepository(DataContext context)
    {
        _context = context;
    }
    public void Create(Livro livro)
    {
        _context.Add(livro, livro);
        _context.SaveChanges();
    }

    public void Delete(Guid Id)
    {
        _context.Livro.ExecuteDelete<Livro>();
        _context.SaveChanges();
    }

    public List<Livro> Read()
    {
        return _context.Livro.ToList();
    }

    public void Update(Livro livro)
    {
        _context.Update(livro);
        _context.SaveChanges();
    }
}