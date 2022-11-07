

using airhorizon.Model;

namespace airhorizon.Repositorio.interfaces
{
    public interface iVoosRepositorio
    {
        Task<List<Voos>> BuscarVoos();
        Task<Voos> BuscarId(int IdVoos );
        Task<Voos> AddVoo(Voos voo);
        Task<Voos> AttVoo(Voos voo, int IdVoos);
        Task<bool> DeletarVoo(int IdVoos);
    }
}