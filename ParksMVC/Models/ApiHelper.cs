using System.Threading.Tasks;
using RestSharp;

namespace ParksMVC.Models
{
  class ApiHelper
  {
    public static async Task<string> ApiCall(int id)
    {
      RestClient client;
      if (id != 0)
      {
        client = new RestClient($"http://localhost:5000/api/parks/{id}");
      }
      else
      {
        client = new RestClient("http://localhost:5000/api/parks");
      }
      RestRequest request = new RestRequest("/", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

    public static async Task<string> ApiCallEditPark(Park park)
    {
        RestClient client = new RestClient($"http://localhost:5000/api/parks{bagel.BagelId}");
        RestRequest request = new RestRequest("/", Method.PUT);
        request.AddJsonBody(park);
        var response = await client.ExecuteTaskAsync(request);
        return response.Content;
    }

    public static async Task<string> ApiCallCreatePark(Park park)
    {
        RestClient client = new RestClient("http://localhost:5000/api/parks");
        RestRequest request = new RestRequest("/", Method.POST);
        request.AddJsonBody(park);
        var response = await client.ExecuteTaskAsync(request);
        return response.Content;
    }

    public static async Task<string> ApiCallDeletePark(Park park)
    {
        RestClient client = new RestClient($"http://localhost:5000/api/parks/{park.ParkId}");
        RestRequest request = new RestRequest("/", Method.DELETE);
        request.AddJsonBody(park);
        var response = await client.ExecuteTaskAsync(request);
        return response.Content;
    }
  }
}