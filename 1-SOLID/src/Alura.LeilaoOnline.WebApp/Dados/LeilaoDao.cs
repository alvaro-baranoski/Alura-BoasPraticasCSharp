using Alura.LeilaoOnline.WebApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace Alura.LeilaoOnline.WebApp.Dados
{
    public class LeilaoDao
    {
        private AppDbContext _context;

        public LeilaoDao()
        {
            _context = new AppDbContext();
        }

        public List<Categoria> getCategorias() 
        {
            return _context.Categorias.ToList();
        }

        public void AddLeilao(Leilao leilao) 
        {
            _context.Leiloes.Add(leilao);
            _context.SaveChanges();
        }

        public Leilao GetLeilao(int id)
        {
            return _context.Leiloes.Find(id);
        }

        public void UpdateLeilao(Leilao leilao)
        {
            _context.Leiloes.Update(leilao);
            _context.SaveChanges();
        }

        public void DeleteLeilao(Leilao leilao)
        {
            _context.Leiloes.Remove(leilao);
            _context.SaveChanges();
        }
    }
}