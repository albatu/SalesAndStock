using Blazor2.Models.City;
using Blazor2.ViewOperation.Interfaces;
using Business.Interfaces;
using Entities.Entities;

namespace Blazor2.ViewOperation.Managers
{
    public class CityViewManager : ICityViewService
    {
        private ICityService _cityService;

        public CityViewManager(ICityService cityService)
        {
            _cityService = cityService;
        }

        public List<CityViewModel> District(int id)
        {
            List<CityViewModel> list = new List<CityViewModel>();
            foreach (var item in _cityService.District(id))
            {
                list.Add(new CityViewModel { 
                
                    Id = item.Id,
                    CityName = item.Name,
                    ParentId = item.DistrictId
                });
            }
            return list;
        }

        public List<CityViewModel> District()
        {
            List<CityViewModel> list = new List<CityViewModel>();

            foreach (var item in _cityService.District())
            {
                list.Add(new CityViewModel { 
                
                    ParentId = item.DistrictId,
                    DistrictId = item.Id,
                    DistrictName = item.Name
                });
            }
            return list;
        }

       

        public List<CityViewModel> OnlyCity()
        {
            List<CityViewModel> list = new List<CityViewModel>();
            foreach (var item in _cityService.OnlyCity())
            {
                list.Add(new CityViewModel { Id = item.Id, CityName = item.Name,DistrictId = item.DistrictId });
            }

            return list;
        }
        
        public City TEntity(CityViewModel entity)
        {
            return new City{ 
            
                Id = entity.Id,
                DistrictId = entity.ParentId,
                Name = entity.CityName
            };
        }

        public List<CityViewModel> UpperCity()
        {
            List<CityViewModel> list = new List<CityViewModel>();
            foreach (var item in _cityService.OnlyCity())
            {
                list.Add(new CityViewModel { ParentId = item.Id, CityName = item.Name});
            }

            return list;
        }
    }
}
