using SampleMvvmLight.Models;
using System;
using System.Collections.Generic;

namespace SampleMvvmLight.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public async override void Initialize()
        {
            base.Initialize();
            this.Friends = await this.DateService.GetFriendsAsync();
        }

        private Friend[] _friends = null;
        public Friend[] Friends
        {
            get
            {
                return _friends;
            }
            set
            {
                Set(() => Friends, ref _friends, value);
            }
        }
    }
}
