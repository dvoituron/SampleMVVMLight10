using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace SampleMvvmLight.Models
{
    public class DataService : IDataService
    {
        private const string UrlBase = "http://samplemvvmlight.azurewebsites.net/friends.aspx";

        public async Task<Friend[]> GetFriendsAsync()
        {
            var client = new HttpClient();
            string json = await client.GetStringAsync(new Uri(UrlBase));

            var result = JsonConvert.DeserializeObject<ListOfFriends>(json);
            return result.Data.ToArray();
        }

    }
}
