namespace Store.Service;

public class ProductService
{
    public IEnumerable<object> GetProducts()
    {
        return new[]
        {
            new { Id = 1, Nombre = "Oliver Carranza", Email = "ocarranza@novasoft.com" },
            new { Id = 2, Nombre = "David Ripalda", Email = "dripalda@novasoft.com" },
            new { Id = 3, Nombre = "Juan Pesoa", Email = "jpesoa@novasoft.com" },
            new { Id = 4, Nombre = "Cesar Mamani", Email = "cmamani@novasoft.com" },
            new { Id = 5, Nombre = "Jose Gonzales", Email = "jgonzales@novasoft.com" }
        };
    }
}
