using Api.Entity;
using Api.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Manager
{
    public class DistrictManager : IDistrictService
    {
        private HttpClient _httpClient;

        public DistrictManager(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<District>> GetIlceListesi(int id)
        {
            return _httpClient.GetJsonAsync<List<District>>("");
        }
    }
}
