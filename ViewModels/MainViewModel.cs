using GalaSoft.MvvmLight.Command;
using SampleMvvmLight.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace SampleMvvmLight.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            this.DisplayDetailCommand = new RelayCommand<Friend>(DisplayDetailExecute, CanDisplayDetailExecute);
        }

        protected async override Task OnLoadedAsync()
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

        private RelayCommand _displayHelpCommand;

        /// <summary>
        /// Gets the DisplayHelpCommand.
        /// </summary>
        public RelayCommand DisplayHelpCommand
        {
            get
            {
                return _displayHelpCommand ?? (_displayHelpCommand = new RelayCommand(
                    ExecuteDisplayHelpCommand,
                    CanExecuteDisplayHelpCommand));
            }
        }

        private void ExecuteDisplayHelpCommand()
        {
            this.DialogService.ShowMessage("Select a person and click on the Detail button.", "Information");
        }

        private bool CanExecuteDisplayHelpCommand()
        {
            return true;
        }
    }
}
