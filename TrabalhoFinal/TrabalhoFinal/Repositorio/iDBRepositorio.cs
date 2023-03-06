using TrabalhoFinal.Models;

namespace TrabalhoFinal.Repositorio
{
    public interface iDBRepositorio
    {
        RegistoModel GetId(int id);

        List<RegistoModel> GetAll();

        RegistoModel Adicionar(RegistoModel registo);

        RegistoModel Alterar(RegistoModel registo);

        bool Apagar(int id);
    }
}
