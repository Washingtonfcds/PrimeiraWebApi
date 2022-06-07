using Microsoft.EntityFrameworkCore;
using WebApplication1.Entidades;

namespace PrimeiraWebApi.Infra.Data
{
    public class WebApiContext : DbContext
    {
        public WebApiContext(DbContextOptions<WebApiContext > options) : base(options)
        {
                
        }
        public DbSet <Produto> Produtos { get; set; }
    }
}
