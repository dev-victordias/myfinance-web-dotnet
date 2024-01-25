using Microsoft.EntityFrameworkCore;
using myfinance_web_dotnet_domain;
using myfinance_web_dotnet_infra.interfaces;

namespace myfinance_web_dotnet_infra.repositories
{
    public class PlanoContaRepository : Repository<PlanoConta>, IPlanoContaRepository
    {
        public PlanoContaRepository(MyFinanceDbContext dbContext) : base(dbContext)
        {

        }
    }
}