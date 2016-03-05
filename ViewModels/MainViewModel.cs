using GalaSoft.MvvmLight.Command;
using SampleMvvmLight.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace SampleMvvmLight.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            this.DisplayDetailCommand = new RelayCommand<Friend>(DisplayDetailExecute, CanDisplayDetailExecute);
        }

        public async override void Initialize()
        {
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


        private Friend _selectedFriend = null;
        public Friend SelectedFriend
        {
            get
            {
                return _selectedFriend;
            }
            set
            {
                Set(() => SelectedFriend, ref _selectedFriend, value);
            }
        }

        public RelayCommand<Friend> DisplayDetailCommand { get; private set; }

        public void DisplayDetailExecute(Friend parameter)
        {
            this.NavigationService.NavigateTo<int>(ViewModelLocator.DETAIL_PAGE, this.SelectedFriend.ID);
        }

        public bool CanDisplayDetailExecute(Friend parameter)
        {
            return this.SelectedFriend != null;
        }
    }
}
