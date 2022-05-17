using Blazor2.Models.City;
using Entities.Entities;

namespace Blazor2.ViewOperation.Interfaces
{
    public interface ICityViewService
    {
        List<CityViewModel> OnlyCity();
        List<CityViewModel> District(int id);
        List<CityViewModel> District();
        City TEntity(CityViewModel entity);
        List<CityViewModel> UpperCity();
    }
}
