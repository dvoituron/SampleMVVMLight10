using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SampleMvvmLight.Models.Interfaces
{
    public interface IDataService
    {
        Task<Friend[]> GetFriendsAsync();

        Task<Friend> GetFriendAsync(int friendID);
    }
}
