using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace ParksMVC.Models
{
    public class Park
    {
        public int ParkId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public int SquareMileage { get; set; }
        public string Terrain { get; set; }
        public string Description { get; set; }

        public static List<Park> GetParks()
        {
            var apiCallTask = ApiHelper.ApiCall(0);
            var result = apiCallTask.Result;
            JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
            List<Park> parksList = JsonConvert.DeserializeObject<List<Park>>(jsonResponse.ToString());
            return parksList;
        }

        public static Park GetPark(int id)
        {
            var apiCallTask = ApiHelper.ApiCall(id);
            var result = apiCallTask.Result;
            JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
            Park park = JsonConvert.DeserializeObject<Park>(jsonResponse.ToString());
            return park;
        }
    }
}