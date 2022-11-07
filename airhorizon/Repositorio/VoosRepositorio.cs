
using airhorizon.db;
using airhorizon.Model;
using airhorizon.Repositorio.interfaces;
using Microsoft.EntityFrameworkCore;

namespace airhorizon.Repositorio
{
    public class VoosRepositorio : iVoosRepositorio
    {
        private readonly VoosDBConext _dbContext;
        public VoosRepositorio(VoosDBConext voosDBConext)
        {
            _dbContext = voosDBConext;
        }
        public async Task<Voos> AddVoo(Voos voo)
        {
            await _dbContext.Voo.AddAsync(voo);
            await _dbContext.SaveChangesAsync();

            return voo;
        }

        public async Task<Voos> AttVoo(Voos voo, int IdVoos)
        {
            Voos voosID = await BuscarId(IdVoos);

            if (voosID == null)
            {
                throw new Exception($"Voo com Id: {IdVoos} não cadastrado");
            }

            voosID.localVoos = voo.localVoos;
            voosID.emailCliVoos = voo.emailCliVoos;
            voosID.cliVoos = voo.cliVoos;

            _dbContext.Voo.Add(voosID);
            await _dbContext.SaveChangesAsync();

            return voosID;
        }

        public async Task<Voos> BuscarId(int IdVoos)
        {
            return await _dbContext.Voo.FirstOrDefaultAsync(x => x.IdVoos == IdVoos);
        }

        public async Task<List<Voos>> BuscarVoos()
        {
            return await _dbContext.Voo.ToListAsync();
        }

        public async Task<bool> DeletarVoo(int IdVoos)
        {
            Voos voosID = await BuscarId(IdVoos);

            if (voosID == null)
            {
                throw new Exception($"Voo com Id: {IdVoos} não cadastrado");
            }

            _dbContext.Voo.Remove(voosID);
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }
}