using GalaSoft.MvvmLight.Command;
using SampleMvvmLight.Models;
using System;
using System.Threading.Tasks;

namespace SampleMvvmLight.ViewModels
{
    public class DetailViewModel : ViewModelBase
    {
        public DetailViewModel()
        {
            this.BackCommand = new RelayCommand(() => this.NavigationService.GoBack());
            this.NavigationRegistering<int>();
        }

        protected async override Task OnNavigationFrom(object parameter)
        {
            this.Friend = await this.DataService.GetFriendAsync((int)parameter);
        }

        protected async override Task OnLoadedAsync()
        {
            if (this.IsInDesignMode)
            {
                this.Friend = await this.DataService.GetFriendAsync(1);
            }

        }
        
        public RelayCommand BackCommand { get; set; }

        private Friend _friend = null;
        public Friend Friend
        {
            get
            {
                return _friend;
            }
            set
            {
                Set(() => Friend, ref _friend, value);
            }
        }
    }
}
