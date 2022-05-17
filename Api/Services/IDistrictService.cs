using Api.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Services
{
    public interface IDistrictService
    {
        Task<List<District>> GetIlceListesi(int id);

    }
}
