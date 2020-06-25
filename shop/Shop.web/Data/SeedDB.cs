

namespace Shop.web.Data
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    

    public class SeedDb
    {
        private readonly DataContext context;
        private readonly Random random;

        public SeedDb(DataContext context)
        {
            this.context = context;
            this.random = new Random();
        }

        public async Task SeedAsync()
        {
            await this.context.Database.EnsureCreatedAsync();

            if (!this.context.Products.Any())
            {
                this.AddProduct("Farmacia");
                this.AddProduct("Transporte");
                this.AddProduct("Tecnologia");
                await this.context.SaveChangesAsync();
            }
        }

        private void AddProduct(string name)
        {
            this.context.Products.Add(new Product
            {
                Name = name,
                Descripcion = this.random.Next(100).ToString(),
                Direccion = this.random.Next(100).ToString(),
                Contacto = this.random.Next(100).ToString(),
                Disponible = this.random.Next(100).ToString()

            });
        }
    }

}
