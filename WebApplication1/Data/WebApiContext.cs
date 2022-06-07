using Microsoft.EntityFrameworkCore;
using WebApplication1.Entidades;

namespace WebApplication1.Data
{
    public class WebApiContext : DbContext
    {
        public WebApiContext(DbContextOptions<WebApiContext > options) : base(options)
        {
                
        }
        public DbSet <Produto> Produtos { get; set; }
    }
}
