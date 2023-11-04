using Microsoft.EntityFrameworkCore;
using WebApi_Funcionarios.Models;

namespace WebApi_Funcionarios.DataContext
{//configuração para migration
    public class ApplicationDbContext: DbContext //(DbContext) vem do NuGet EntityFrameworkCore
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<FuncionarioModel> Funcionarios { get; set; }//indicamos qual a model queremos transformar em tabela
    }
}
