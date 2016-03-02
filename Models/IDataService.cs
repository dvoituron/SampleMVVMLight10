using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SampleMvvmLight.Models
{
    public interface IDataService
    {
        Task<IEnumerable<Friend>> GetFriends();
    }
}
