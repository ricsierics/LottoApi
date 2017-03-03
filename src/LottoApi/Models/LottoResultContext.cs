using Microsoft.EntityFrameworkCore;

namespace LottoApi.Models
{
    public class LottoResultContext : DbContext
    {
        public LottoResultContext(DbContextOptions<LottoResultContext> options) : base(options)
        {

        }

        public DbSet<LottoResult> LottoResults { get; set; }
    }
}
