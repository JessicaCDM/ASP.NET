using Microsoft.Win32;
using TrabalhoFinal.DataBase;
using TrabalhoFinal.Models;

namespace TrabalhoFinal.Repositorio
{
    public class BaseDadosRepositorio : iDBRepositorio
    {
        private readonly BaseDadosContext _context;

        public BaseDadosRepositorio(BaseDadosContext context)
        {
            _context = context;
        }

        public RegistoModel Adicionar(RegistoModel registo)
        {
            _context.Registos.Add(registo);
            _context.SaveChanges();

            return registo;
        }

        public List<RegistoModel> GetAll()
        {
            return _context.Registos.ToList();
        }

        public RegistoModel GetId(int id)
        {
            return _context.Registos.FirstOrDefault(x => x.Id == id);
        }

        public RegistoModel Alterar(RegistoModel registo)
        {
            RegistoModel registoDB = GetId(registo.Id);
            if (registoDB == null) throw new System.Exception("Houve um erro na atualização");

            registoDB.Nome= registo.Nome;
            registoDB.Email= registo.Email;
            registoDB.Endereco= registo.Endereco;
            registoDB.Distrito= registo.Distrito;
            registoDB.Conselho= registo.Conselho;

            _context.Registos.Update(registoDB);
            _context.SaveChanges();

            return registoDB;
        }

        public bool Apagar(int id)
        {
            RegistoModel registoDB = GetId(id);
            
            if (registoDB == null) throw new System.Exception("Houve um erro na eliminação");
            _context.Registos.Remove(registoDB);
            _context.SaveChanges();

            return true;
        }
    }
}
