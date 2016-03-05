using SampleMvvmLight.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace SampleMvvmLight.Design
{
    public class DesignDataService : Models.Interfaces.IDataService
    {
        public async Task<Friend[]> GetFriendsAsync()
        {
            return await Task.Run(() =>
            {
                List<Friend> friends = new List<Friend>();

                friends.Add(new Friend()
                {
                    ID = 1,
                    FirstName = "Denis",
                    LastName = "Voituron",
                    Picture = "http://samplemvvmlight.azurewebsites.net:80/People/1.jpg"
                });

                friends.Add(new Friend()
                {
                    ID = 2,
                    FirstName = "Anne",
                    LastName = "Dubois",
                    Picture = "http://samplemvvmlight.azurewebsites.net:80/People/3.jpg"
                });

                friends.Add(new Friend()
                {
                    ID = 2,
                    FirstName = "Christophe",
                    LastName = "Peugnet",
                    Picture = "http://samplemvvmlight.azurewebsites.net:80/People/8.jpg"
                });

                return friends.ToArray();
            });
        }

        public async Task<Friend> GetFriendAsync(int friendID)
        {
            return await Task.Run(() =>
            {
                return new Friend()
                {
                    ID = 1,
                    FirstName = "Denis",
                    LastName = "Voituron",
                    Picture = "http://samplemvvmlight.azurewebsites.net:80/People/1.jpg"
                };
            });
        }
    }
}
