using Frontend.Models;

namespace Frontend.Services;

public interface IPizzaService
{
    Task<IEnumerable<PizzaInfo>> GetPizzasAsync();
}