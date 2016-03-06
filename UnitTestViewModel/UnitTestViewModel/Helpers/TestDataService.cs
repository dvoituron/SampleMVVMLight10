using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleMvvmLight.Models;

namespace UnitTestViewModel.Helpers
{
    public class TestDataService : SampleMvvmLight.Models.Interfaces.IDataService
    {
        public Task<Friend> GetFriendAsync(int friendID)
        {
            return new SampleMvvmLight.Design.DesignDataService().GetFriendAsync(friendID);
        }

        public Task<Friend[]> GetFriendsAsync()
        {
            return new SampleMvvmLight.Design.DesignDataService().GetFriendsAsync();
        }
    }
}
