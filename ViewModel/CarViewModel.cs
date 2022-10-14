using CarAPIClient.Model;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CarAPIClient.ViewModel
{
    class CarViewModel
    {
        private static readonly RestClient client = new RestClient();
        List<Cars> carList = new List<Cars>();

        private async void GetCars()
        {
            var request = new RestRequest("Cars", Method.Get);
            var response = await client.ExecuteAsync<List<Cars>>(request);

            response.Data.ForEach(car => carList.Add(car));
        }
        private async void AddCar()
        {
            var request = new RestRequest("Cars", Method.Post);
            
        }
    }
}
